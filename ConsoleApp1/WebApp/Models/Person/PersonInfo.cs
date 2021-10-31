using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class PersonInfo
    {
        public int Id { get; set; }
        [Display(Name = "Логин")]
        public string Login { get; set; }
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Name can't be null!!!")]
        public string Name { get; set; }
        [Display(Name = "Почта")]
        public string Email { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime HireDate { get; set; }
    }
}
