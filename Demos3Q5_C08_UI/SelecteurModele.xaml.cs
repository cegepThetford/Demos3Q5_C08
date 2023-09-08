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
    /// Logique d'interaction pour SelecteurModele.xaml
    /// </summary>
    public partial class SelecteurModele : Window
    {
       private Membre _membre1, _membre2, _membre3;
        public Membre Membre1 { get { return _membre1; } set { _membre1 = value; } }
        public Membre Membre2 { get { return _membre2; } set { _membre2 = value; } }
        public Membre Membre3 { get { return _membre3; } set { _membre3 = value; } }
        public SelecteurModele()
        {
            InitializeComponent();
            _membre1 = new Membre() { Nom = "Adam Bernard", Age = 16 };
            _membre2 = new Membre() { Nom = "Charles Demers", Age = 34 };
            _membre3 = new Membre() { Nom = "Eric Fillion", Age = 20 };
            panneau.DataContext = this;
        }
    }
}
