using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Attribute.Classes
{
    public class IsEmpty
    {
        public static bool Validate(object model, Control.ControlCollection controls)
        {
            bool isValid = true;
            Type type = model.GetType();

            foreach (Control control in controls)
            {
                if (control is TextBox textBox)
                {
                    PropertyInfo property = type.GetProperty(control.Name);
                    if (property != null)
                    {
                        var attribute = (RequiredFieldAttribute)property.GetCustomAttribute(typeof(RequiredFieldAttribute));
                        if (attribute != null && string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            isValid = false;
                            textBox.BackColor = Color.LightPink;
                            MessageBox.Show(attribute.HataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            textBox.BackColor = SystemColors.Window;
                            property.SetValue(model, textBox.Text.Trim());
                        }
                    }
                }
            }

            return isValid;
        }
    }
}