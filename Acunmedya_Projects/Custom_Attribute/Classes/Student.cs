using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Attribute.Attributes
{
    public class Student
    {
        [RequiredField("Öğrenci adı boş bırakılamaz!")]
        public string Name { get; set; }

        [RequiredField("Öğrenci Soyadı boş bırakılamaz!")]
        public string SurName { get; set; }
        [RequiredField("Öğrenci bölümü boş bırakılamaz!")]
        public string Department { get; set; }
       
    }
}
