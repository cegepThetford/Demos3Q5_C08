using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Demos3Q5_C08_UI
{
    /// <summary>
    /// Logique d'interaction pour DeclencheurConvertisseur.xaml
    /// </summary>
    public partial class DeclencheurConvertisseur : Window, INotifyPropertyChanged
    {
        private int _pressionCourante;
        public event PropertyChangedEventHandler PropertyChanged;
        public int PressionCourante {
            get { return _pressionCourante; }
            set {
                _pressionCourante = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("PressionCourante"));
            }
        }
        public DeclencheurConvertisseur()
        {
            PressionCourante = 50;
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
