using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniverseDB.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Имя")]
        public string RealName { get; set; }

        [Required]
        [Display(Name = "Логин")]
        public string UserName { get; set; }

        [Required]
        [UIHint("passowrd")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }


        [Required]
        [Display(Name = "Почта")]
        public string Email { get; set; }

        

    }
}
