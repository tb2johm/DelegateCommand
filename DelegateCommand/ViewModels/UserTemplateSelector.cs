using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace DelegateCommand.ViewModels
{
    class UserTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item != null && item is SuperUser)
            {
                return System.Windows.Application.Current.Resources["SuperUserTemplate"] as DataTemplate;
            }
            //return (container as FrameworkElement).FindResource("UserTemplate") as DataTemplate;
            return System.Windows.Application.Current.Resources["UserTemplate"] as DataTemplate;

        }
    }
}
