using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour DataTemplate1.xaml
    /// </summary>
    public partial class DataTemplate1 : Window
    {
        private Membre _membre;
        public Membre Membre { get { return _membre; } set { _membre = value; } }
        public DataTemplate1()
        {
            InitializeComponent();
            _membre = new Membre() { Nom = "Adam Bernard", Age = 18 };
            panneau.DataContext = this;
        }
    }
}
