using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using Glossa_App.Data.Repository;

namespace Glossa_App.ViewModels
{
    class SignupViewModel : ObservableObject, IQueryAttributable
    {
        private string _login;
        private string _password;
        private string _resultMsg;
        private string _email;

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

        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                    _email = value;
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

        public SignupViewModel()
        {
            SubmitCommand = new AsyncRelayCommand(Submit);
            //GoToSignupCommand = new AsyncRelayCommand(GoToSignup);
        }

        private async Task Submit()
        {
            AuthenticationRepository authentication =
                AuthenticationRepository.Initialize(new HttpClient());
            string code = await authentication.RegistrationUser(_login, _password, _email);
            switch (code)
            {
                case "200":
                    ResultMsg = "You're succesfully authenticated";
                    break;
                case "406":
                    ResultMsg = "Unable to register user: such nickname or e-mail are already in user";
                    break;
                default:
                    ResultMsg = "Server error. Please, try later";
                    break;
            }
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
