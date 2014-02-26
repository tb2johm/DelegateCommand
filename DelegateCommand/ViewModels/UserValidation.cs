using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DelegateCommand.ViewModels
{
    public partial class User : IDataErrorInfo
    {
        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Password")
                {
                    if (this._password.Length < 2)
                    {
                        return "This is a lousy password!";
                    }
                }

                return null;
            }
        }
    }
}
