using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Diagnostics;
using System.Globalization;

namespace Glossa_App.Models
{
    internal class ModulePreview
    {
        private int id;
        private string author;
        private string title;
        private string description;
        private string icon;
        private string lang;
        private string tags;
        private string modulefile;
        private DateTime created;

        public string Author
        {
            get => author;
        }

        public string Title
        {
            get => title;
        }

        public string Description
        {
            get => description;
        }

        public string Icon
        {
            get
            {
                const string path = "C:\\Users\\79246\\Desktop\\Glossa-Project\\Server\\";
                return path + icon;
            }
        }

        public string Tags
        {
            get => tags;
        }

        public string Modulefile
        {
            get => modulefile;
        }

        public string Created
        {
            get => created.ToString("yyyy, MMM, dd", CultureInfo.GetCultureInfo("en-US"));
        }

        public ICommand TappedCommand { get; private set; }

        public ModulePreview(int id, string author, string title, string description, string icon, string lang, string tags, string modulefile, string created)
        {
            this.id = id;
            this.author = author;
            this.title = title;
            this.description = description;
            this.icon = icon;
            this.lang = lang;
            this.tags = String.Join("; ", tags.Split(";"));
            this.modulefile = modulefile;
            this.created = DateTime.Parse(created);

            TappedCommand = new Command(OnTappedCommandExecute);
        }

        private async void OnTappedCommandExecute()
        {
            await Shell.Current.GoToAsync($"//ModulePage?downloadLink={modulefile}");
        }
    }
}
