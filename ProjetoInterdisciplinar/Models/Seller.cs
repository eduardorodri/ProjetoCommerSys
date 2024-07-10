using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ProjetoInterdisciplinar.Models {
    public class Seller {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} deve conter entre {2} e {1} caracteres válidos")]
        [Display(Name = "Nome do Vendedor")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [EmailAddress(ErrorMessage = "Insira um email válido")]
        [Display(Name = "Endereço de Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Nascimento { get; set; }


        [Required(ErrorMessage = "{0} obrigatório")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} deve ser de {1} até {2}")]
        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double SalarioBase { get; set; }


        public Department Departamento { get; set; }

        [Required(ErrorMessage = "ID do Departamento obrigatório")]
        [Display(Name = "ID do Departamento")]
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Vendas { get; set; } = new List<SalesRecord>();

        public Seller() { }
        
        public Seller(int id, string nome, string email, DateTime nascimento, double salarioBase, Department departamento) {
            Id = id;
            Nome = nome;
            Email = email;
            Nascimento = nascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }
        public void AddSales(SalesRecord sr) {
            Vendas.Add(sr);
        }

        public void RemoveSales (SalesRecord sr) {  
            Vendas.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final) {
            return Vendas.Where(sr => sr.Data >= initial && sr.Data <= final).Sum(sr => sr.Quantia);
        }
    }
}
