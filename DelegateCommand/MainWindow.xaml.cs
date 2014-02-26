using System.Windows;

namespace DelegateCommand
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
                    UserName = "Bart",
                    Password = "Nooo"
                }
            };
        }
    }
}
