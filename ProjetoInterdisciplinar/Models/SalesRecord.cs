using ProjetoInterdisciplinar.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoInterdisciplinar.Models {
    public class SalesRecord {

        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Quantia { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Vendedor { get; set; }

        public SalesRecord() {
        }

        public SalesRecord(int id, DateTime data, double quantia, SaleStatus status, Seller vendedor) {
            Id = id;
            Data = data;
            Quantia = quantia;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
