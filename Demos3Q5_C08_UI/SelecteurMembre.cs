using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Demos3Q5_C08_UI
{
    public class SelecteurMembre : DataTemplateSelector
    {
        // Define a set of properties that represent all the templates 
        // that this selector can return.
        public DataTemplate PremierTemplate { get; set; }
        public DataTemplate SecondTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {

            if (item != null)
            {
                Membre membre = (Membre)item;

                // Return a template based on the object’s properties,
                if (membre.Age < 32)
                    return PremierTemplate;
                else
                    return SecondTemplate;
            }
            return null;
        }
    }
}
