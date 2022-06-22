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
    /// Logique d'interaction pour ItemTemplate.xaml
    /// </summary>
    public partial class ItemTemplate : Window
    {
        public ItemTemplate()
        {
            InitializeComponent();
            List<Membre> membres = new List<Membre>();
            membres.Add(new Membre() { Nom = "Adam Bernard", Age = 16 });
            membres.Add(new Membre() { Nom = "Charles Demers", Age = 34 });
            membres.Add(new Membre() { Nom = "Eric Fillion", Age = 20 });

            lstMembres.ItemsSource = membres;
        }
    }
}
