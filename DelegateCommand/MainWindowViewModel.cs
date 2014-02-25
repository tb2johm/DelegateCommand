using System.ComponentModel;
using System.Windows.Input;

namespace DelegateCommand
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    OnPropertyChanged("UserName");
                }
            }
        }

        private string _password;
        public string Password {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged("Password");
                }
            } 
        }

        public ICommand LogonCommand { get; set; }

        public MainWindowViewModel()
        {
            LogonCommand = new RelayCommand(ExecuteLogon, CanExecuteLogon);
        }

        private bool CanExecuteLogon()
        {
            return (!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password));
        }

        private void ExecuteLogon()
        {
            if (UserName == "Markus" && Password == "Yes")
            {
                UserName = "OKIDOKI";
                Password = string.Empty;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}