using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DelegateCommand.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected void Notify(String property)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
