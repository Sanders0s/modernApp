using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace modernApp.Properties
{
    public class DependencyProperties : DependencyObject
    {
        static DependencyProperties()
        {
            NameAndSurnameProperty = DependencyProperty.Register("NameAndSurname", typeof(string), typeof(DependencyProperties));
        }
        public string NameAndSurname
        {
            get 
            { 
                return (string)GetValue(NameAndSurnameProperty); 
            }
            set 
            { 
                SetValue(NameAndSurnameProperty, value); 
            }
        }

        public static readonly DependencyProperty NameAndSurnameProperty;

        private string auxiliary;
        public string Auxiliary
        {
            get
            {
                return auxiliary;
            }
            set
            {
                auxiliary = value;
            }
        }
    }
}
