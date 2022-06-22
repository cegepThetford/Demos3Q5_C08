using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
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
    /// Logique d'interaction pour Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void TraiterOuverture_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string windowClass = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + "." + btn.Content.ToString();
            Type type = Assembly.GetExecutingAssembly().GetType(windowClass);
            ObjectHandle handle = Activator.CreateInstance(null, windowClass);
            MethodInfo method = type.GetMethod("ShowDialog");
            method.Invoke(handle.Unwrap(), null);
        }
    }
}
