using System.Windows;

namespace DelegateCommand.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel()
            {
                LoginUser = new User()
                {
                    UserName = "Markus",
                    Password = "Yes"
                }
            };

            (this.DataContext as MainWindowViewModel).LogonOk += new System.EventHandler<System.EventArgs>(MainWindow_LogonOk);
        }

        void MainWindow_LogonOk(object sender, System.EventArgs e)
        {
            this.Hide();
            UserList ul = new UserList();
            ul.Show();
        }
    }
}
