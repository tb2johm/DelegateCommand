using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DelegateCommand.ViewModels;

namespace DelegateCommand.Views
{
    /// <summary>
    /// Interaction logic for UserList.xaml
    /// </summary>
    public partial class UserList : Window
    {
        public UserList()
        {
            this.DataContext = new UserListViewModel();

            InitializeComponent();

            /*PropertyGroupDescription desc = new PropertyGroupDescription();
            desc.PropertyName = "UserName";
            ListView1.Group*/
        }
    }
}
