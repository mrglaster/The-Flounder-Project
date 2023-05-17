using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Web;
using Glossa_App.Models;
using System.ComponentModel;
using Glossa_App.Data.Repository;
using Microsoft.Maui.Controls.PlatformConfiguration;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
//using static Java.Lang.Character;

namespace Glossa_App.ViewModels
{
    [QueryProperty(nameof(DownloadLink), "downloadLink")]
    internal class ModuleViewModel : ObservableObject
    {
        private string downloadLink;

        public string DownloadLink
        {
            get => downloadLink;
            set
            {
                downloadLink = value;
                Initialize();
                Debug.WriteLine(DownloadLink);
            }
        }
        private string title;
        public string Title { 
            get => title;
            private set
            {
                title = value;
                OnPropertyChanged();
            }
        }
        private List<string> words;
        public List<string> Words { get => words;
            set
            {
                words = value;
                OnPropertyChanged();
            }
        }
        private string curWord;

        public string CurWord
        {
            get => curWord;
            private set
            {
                curWord = value;
                OnPropertyChanged();
            }
        }
        public Dictionary<string, List<string>> Translations { get; set; }

        public List<WordModel> WordModels { get; private set; }

        public ICommand NextWordCommand { get; private set; }
        public ICommand PrevWordCommand { get; private set; }

        public ModuleViewModel()
        {
            
        }

        private async void Initialize()
        {
            AuthenticationRepository rep = AuthenticationRepository.Initialize(new HttpClient());
            string xmlText = await rep.GetGSMF(downloadLink);
            //await rep.DownloadFile(downloadLink, appDirectory + "test.gsmf");

            ModuleModel module = ModuleModel.ParseXml(xmlText);
            Title = module.Title;
            Words = module.Words;
            CurWord = Words[0];
            WordModels = new List<WordModel>();
            for (int i = 0; i < Words.Count; i++)
            {
                var word = Words[i];
                var audio = module.Audio[i];
                WordModel wm = new WordModel(word, audio);
                Debug.WriteLine(word);
                WordModels.Add(wm);
            }
            Debug.WriteLine(Title);

            NextWordCommand = new AsyncRelayCommand(NextWord);
            PrevWordCommand = new AsyncRelayCommand(PrevWord);
        }

        private async Task NextWord()
        {
            string new_word = CurWord;
            Debug.WriteLine(1);
            for (int i = 0; i < Words.Count; i++)
            {
                if (Words[i].Equals(CurWord))
                {
                    if (i < Words.Count - 1)
                        CurWord = Words[i + 1];
                    else
                        CurWord = Words[0];
                    Debug.WriteLine(CurWord);
                    break;
                } 
            }
        }

        private async Task PrevWord()
        {
            string new_word = CurWord;
            for (int i = 0; i < Words.Count; i++)
            {
                if (Words[i].Equals(CurWord))
                {
                    if (i - 1 > 0)
                        CurWord = Words[i - 1];
                    else
                        CurWord = Words[Words.Count - 1];
                    break;
                }
            }
        }
    }
}
