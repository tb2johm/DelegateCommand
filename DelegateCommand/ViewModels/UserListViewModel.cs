using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DelegateCommand.ViewModels
{
    public class UserListViewModel : ViewModelBase
    {
        public ObservableCollection<User> AllUsers { get; set; }

        private User _selectedUser;
        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                if (_selectedUser != value)
                {
                    _selectedUser = value;
                    Notify("SelectedUser");
                }
            }
        }
        
        public UserListViewModel()
        {
            FillListWithTestData();
        }

        private void FillListWithTestData()
        {
            AllUsers = new ObservableCollection<User>();
            AllUsers.Add(new User() { UserName = "Markus", Password = "blablabla" });
            AllUsers.Add(new User() { UserName = "Other", Password = "Guy" });
            AllUsers.Add(new User() { UserName = "Bernt", Password = "sdfa" });
            AllUsers.Add(new User() { UserName = "Markus", Password = "lkajsjk" });
            //AllUsers.Add(new SuperUser() { UserName = "GOd", Password = "kjsd", Level = 999});

        }

    }
}
