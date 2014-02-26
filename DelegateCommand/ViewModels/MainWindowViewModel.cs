using System;
using System.ComponentModel;
using System.Windows.Documents;
using System.Windows.Input;
using DelegateCommand.ViewModels;

namespace DelegateCommand
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private User _loginUser;
        public User LoginUser
        {
            get { return _loginUser; }
            set
            {
                if (_loginUser != value)
                {
                    _loginUser = value;
                    OnPropertyChanged("LoginUser");
                }
            }
        }

        public ICommand LogonCommand { get; set; }
        public event EventHandler<EventArgs> LogonOk;

        public MainWindowViewModel()
        {
            LogonCommand = new RelayCommand(ExecuteLogon, CanExecuteLogon);
        }

        private bool CanExecuteLogon()
        {
            return (!string.IsNullOrWhiteSpace(LoginUser.UserName) && !string.IsNullOrWhiteSpace(LoginUser.Password));
        }

        private void ExecuteLogon()
        {
            if (LoginUser.UserName == "Markus" && LoginUser.Password == "Yes")
            {
                LoginUser.UserName = "OKIDOKI";
                LoginUser.Password = string.Empty;

                if (LogonOk != null)
                {
                    LogonOk.Invoke(this, EventArgs.Empty);
                }
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