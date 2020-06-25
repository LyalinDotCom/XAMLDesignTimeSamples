using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfdtdSamples.Helpers
{
    public class ListViewdtSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement elemnt = container as FrameworkElement;

            var value = item as string;
            if (value == "Donovan")
            {
                return elemnt.FindResource("ListViewBoldDataTemplate") as DataTemplate;
            } else
            {
                return elemnt.FindResource("ListViewDefaultDataTemplate") as DataTemplate;
            }

            //FrameworkElement elemnt = container as FrameworkElement;
            //User user = item as User;
            //if (user.IsPremiumUser)
            //{
            //    return elemnt.FindResource("PremiumUserDataTemplate") as DataTemplate;
            //}
            //else
            //{
            //    return elemnt.FindResource("NormalUserDataTemplate") as DataTemplate;
            //}
        }
    }
}
