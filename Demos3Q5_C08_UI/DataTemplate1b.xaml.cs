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
    public partial class DataTemplate1b : Window
    {
        public Membre Adam { get; set; }
        public Membre Charles { get; set; }
        public DataTemplate1b()
        {
            InitializeComponent();
            Adam = new Membre() { Nom = "Adam Bernard", Age = 18 };
            Charles = new Membre() { Nom = "Charles Demers", Age = 32 };
            panneau.DataContext = this;
        }
    }
}
