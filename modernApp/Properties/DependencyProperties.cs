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
            FullNameDP = DependencyProperty.Register("FullName", typeof(string), typeof(DependencyProperties));
        }
        public string FullName
        {
            get 
            { 
                return (string)GetValue(FullNameDP); 
            }
            set 
            { 
                SetValue(FullNameDP, value); 
            }
        }

        public static readonly DependencyProperty FullNameDP;

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
