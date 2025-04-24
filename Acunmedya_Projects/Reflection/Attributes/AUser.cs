using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Reflection.Attributes
{
    public class AUser
    {
        [Required(ErrorMessage = "Ad alanı zorunludur.")]   //Boş geçielemz 
        public string Ad { get; set; }

        [Range(18, 99, ErrorMessage = "Yaş 18 ile 99 arasında olmalıdır.")] // Belirli bir sayı aralığı
        public int Yas { get; set; }

        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")] // E posta formatında olmalı
        public string Email { get; set; }
    }
}
