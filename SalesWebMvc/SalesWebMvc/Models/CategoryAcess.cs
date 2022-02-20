using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class CategoryAcess
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [StringLength(1000, ErrorMessage = "máximo de {1} caracteres")]
        public string Desc { get; set; }

        public List<Seller> Sellers { get; set; } = new List<Seller>();

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Campo Obrigátorio")]
        public Access Access { get; set; }

        public CategoryAcess()
        {
        }

        public CategoryAcess(int id, string desc, Access access)
        {
            Id = id;
            Desc = desc;
            Access = access;
        }
    }
}
