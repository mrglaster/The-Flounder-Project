using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Diagnostics;
using Glossa_App.Data.Repository;
using Glossa_App.Models;
using System.Windows.Input;
//using Android.Webkit;
//using Android.OS;

namespace Glossa_App.ViewModels
{
    class MainViewModel : ObservableObject
    {
        private int cur_page = 1;
        List<ModulePreview> modules;

        public List<ModulePreview> Modules
        {
            get => modules;
            set
            {
                modules = value;
                OnPropertyChanged();
            }
        }
        
        //ModuleRepository moduleRepository = new ModuleRepository(new HttpClient());

        private AuthenticationRepository rep = 
            AuthenticationRepository.Initialize(new HttpClient());

        public MainViewModel()
        {
            LoadModules(1);   
        }

        

        private async void LoadModules(int page)
        {
            JsonNode json_modules = await rep.GetModules(page);

            Modules = json_modules["data"].AsArray().Select(moduleNode =>
            {
                ModulePreview module = new ModulePreview(
                    int.Parse(moduleNode["id"].ToString()),
                    moduleNode["author"].ToString(),
                    moduleNode["title"].ToString(),
                    moduleNode["description"].ToString(),
                    moduleNode["icon"].ToString(),
                    moduleNode["language"].ToString(),
                    moduleNode["tags"].ToString(),
                    moduleNode["module_file"].ToString(),
                    moduleNode["created"].ToString()
                    );
                return module;
            }).ToList();

            System.Diagnostics.Debug.WriteLine(json_modules.ToString());
        }
    }
}
