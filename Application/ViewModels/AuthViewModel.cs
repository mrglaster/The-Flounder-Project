using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

//using Glossa_App.Models;
using Glossa_App.Data.Repository;

namespace Glossa_App.ViewModels
{
    internal class AuthViewModel : ObservableObject, IQueryAttributable
    {
        private string _login;
        private string _password;
        private string _resultMsg;

        public string Login
        {
            get => _login;
            set
            {
                if (_login != value)
                    _login = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                    _password = value;
                OnPropertyChanged();
            }
        }

        public string ResultMsg
        {
            get => _resultMsg;
            private set
            {
                if (_resultMsg != value)
                    _resultMsg = value;
                OnPropertyChanged();
            }
        }

        public ICommand SubmitCommand { get; private set; }
        public ICommand GoToSignupCommand { get; private set; }

        public AuthViewModel()
        {
            SubmitCommand = new AsyncRelayCommand(Submit);
            GoToSignupCommand = new AsyncRelayCommand(GoToSignup);
        }

        private async Task Submit()
        {
            AuthenticationRepository authentication = 
                AuthenticationRepository.Initialize(new HttpClient());
            //string code = await authentication.AuthenticateUser(_login, _password);
            string code = "200";
            switch (code)
            {
                case "200":
                    //ResultMsg = "You're succesfully authenticated";
                    await Shell.Current.GoToAsync("//MainPage", true);
                    break;
                case "406":
                    ResultMsg = "Wrong login or password";
                    break;
                default:
                    ResultMsg = "Server error. Please, try later";
                    break;
            }
        }

        private async Task GoToSignup()
        {
            await Shell.Current.GoToAsync($"SignupPage");
        }

        void IQueryAttributable.ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("load"))
            {
                return;
            }
        }
    }
}
