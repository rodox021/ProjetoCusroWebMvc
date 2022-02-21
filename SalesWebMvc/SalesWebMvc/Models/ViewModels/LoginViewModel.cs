using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Campo {0} é Obrigatório")]
        [StringLength(70, ErrorMessage = "máximo de {1} caracateres")]
        [EmailAddress(ErrorMessage = "Email Inválido")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Campo {0} é Obrigatório")]
        //[StringLength(70, ErrorMessage = "máximo de {1} caracateres")]
        //[EmailAddress(ErrorMessage = "Email Inválido")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
