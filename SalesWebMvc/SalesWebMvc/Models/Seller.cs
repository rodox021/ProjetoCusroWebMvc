using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} Obrigátorio")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} deve ter o tamanho minino de {2} e máximo de {1}")]
        public string Name { get; set; }



        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} Obrigátorio")]
        [EmailAddress(ErrorMessage = "Entre com um e-mail válido")]
        public string Email { get; set; }




        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} Obrigátorio")]
        public DateTime BirthDate { get; set; }



        [Display(Name = "Salário Base")]
        [DataType(DataType.Currency)] // mostra o campo com o valor formatado para sua região que configurado no startuo, R$ 1000,00
        //[DisplayFormat(DataFormatString = "{0:F2}")] // vai mostrar o campo com o valor separado com 2 casa decimais 1000,00
        [Range(100.0, 50000.0, ErrorMessage = "{0} deve ser entre {1} até {2}")]
        [Required(ErrorMessage = "{0} Obrigátorio")]
        public double BaseSalary { get; set; }



        [Display(Name = "Departamento")]
        public Department Department { get; set; }




        [Display(Name = "Departamento")]
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime i, DateTime f)
        {
            return Sales.Where(sr => sr.Date >= i && sr.Date <= f).Sum(sr => sr.Amount);
        }
    }
}
