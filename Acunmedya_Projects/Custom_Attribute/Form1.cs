using System.Reflection;
using Custom_Attribute.Attributes;
using Custom_Attribute.Classes;

namespace Custom_Attribute
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                Name = txtName.Text,
                SurName = txtSurname.Text,
                Department = txtDepartment.Text
            };

            txtName.BackColor = Color.White;
            txtSurname.BackColor = Color.White;
            txtDepartment.BackColor = Color.White;

            var errors = new List<string>();

            var props = typeof(Student).GetProperties();
            foreach (var prop in props)
            {
                var attr = (RequiredFieldAttribute)prop.GetCustomAttribute(typeof(RequiredFieldAttribute));
                if (attr != null)
                {
                    var value = prop.GetValue(student) as string;
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        errors.Add(attr.HataMesaji);

                        if (prop.Name == "Name")
                            txtName.BackColor = Color.LightCoral;
                        else if (prop.Name == "SurName")
                            txtSurname.BackColor = Color.LightCoral;
                        else if (prop.Name == "Department")
                            txtDepartment.BackColor = Color.LightCoral;
                    }
                }
            }

            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            else
            {
                lblOut.Text = $"Ad: {student.Name}\nSoyad: {student.SurName}\nBölüm: {student.Department}";
                
            }

        }
    }
}
