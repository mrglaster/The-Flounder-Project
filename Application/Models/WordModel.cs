using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
//using static Java.Lang.Character;

namespace Glossa_App.Models
{
    internal class WordModel : ObservableObject
    {
        //private string word;
        private string definition;
        private string audio;

        public string Word { get; private set; }
        public string Audio
        {
            get { return audio; }
            set { audio = value; }
        }

        public ICommand PlayCommand { get; private set; }

        public WordModel(string word, string audio)
        {
            Word = word;
            Audio = audio;
            PlayCommand = new AsyncRelayCommand(Play);
        }

        private async Task Play()
        {
            // Преобразование строки Base64 в массив байт
            byte[] soundBytes = Convert.FromBase64String(Audio);

            // Создание временного файла для сохранения звуковых данных
            string tempFilePath = Path.Combine(Path.GetTempPath(), "temp.wav");
            File.WriteAllBytes(tempFilePath, soundBytes);

            // Воспроизведение звука с использованием SoundPlayer
            using (SoundPlayer player = new SoundPlayer(tempFilePath))
            {
                player.Play();
            }

            // Удаление временного файла после воспроизведения
            File.Delete(tempFilePath);
        }
    }
}
