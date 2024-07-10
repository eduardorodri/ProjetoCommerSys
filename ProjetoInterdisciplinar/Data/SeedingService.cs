using ProjetoInterdisciplinar.Models;
using ProjetoInterdisciplinar.Models.Enums;
using System;
using System.Linq;


namespace ProjetoInterdisciplinar.Data {
    public class SeedingService {
        private ProjetoInterdisciplinarContext _context;

        public SeedingService(ProjetoInterdisciplinarContext context) {
            _context = context;
        }

        public void Seed() {
            if (_context.Department.Any() ||
                _context.Vendedor.Any() ||
                _context.RecordeVendas.Any()) {
                return;
            }
            Department d1 = new Department(1, "Computadores");
            Department d2 = new Department(2, "Eletrônicos");
            Department d3 = new Department(3, "Roupas");
            Department d4 = new Department(4, "Livros");
            Department d5 = new Department(5, "Jogos");

            Seller s1 = new Seller(1, "Ana Souza", "ana.souza@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Bruno Costa", "bruno.costa@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller(3, "Carla Lima", "carla.lima@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(4, "Diego Fernandes", "diego.fernandes@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller(5, "Elisa Oliveira", "elisa.oliveira@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(6, "Marcelo Alves", "marcelo.alves@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);
            Seller s7 = new Seller(7, "Carla Dias", "carla.dias@gmail.com", new DateTime(1997, 3, 4), 3500.0, d5);
            Seller s8 = new Seller(8, "Eduardo Rodrigues", "eduardo.rodrigues@gmail.com", new DateTime(1998, 9, 27), 3500.0, d5);
            Seller s9 = new Seller(9, "Camila Carvalho", "camila.carvalho@gmail.com", new DateTime(1997, 3, 4), 3500.0, d5);


            SalesRecord r1 = new SalesRecord(1, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Faturado, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2020, 09, 4), 7000.0, SaleStatus.Faturado, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 09, 13), 4000.0, SaleStatus.Cancelado, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2023, 09, 1), 8000.0, SaleStatus.Faturado, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2023, 09, 21), 3000.0, SaleStatus.Faturado, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2023, 09, 15), 2000.0, SaleStatus.Faturado, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2022, 09, 28), 13000.0, SaleStatus.Faturado, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 09, 11), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2020, 09, 14), 11000.0, SaleStatus.Pendente, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2021, 09, 7), 9000.0, SaleStatus.Faturado, s6);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2021, 09, 13), 6000.0, SaleStatus.Faturado, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2022, 09, 25), 7000.0, SaleStatus.Pendente, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2023, 09, 29), 10000.0, SaleStatus.Faturado, s4);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2020, 09, 4), 3000.0, SaleStatus.Faturado, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2023, 09, 12), 4000.0, SaleStatus.Faturado, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2022, 10, 5), 2000.0, SaleStatus.Faturado, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2022, 10, 1), 12000.0, SaleStatus.Faturado, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2022, 10, 24), 6000.0, SaleStatus.Faturado, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2022, 10, 22), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2023, 10, 15), 8000.0, SaleStatus.Faturado, s6);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2023, 10, 17), 9000.0, SaleStatus.Faturado, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2021, 10, 24), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2022, 10, 19), 11000.0, SaleStatus.Cancelado, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2021, 12, 12), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2020, 09, 29), 7000.0, SaleStatus.Faturado, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2023, 09, 6), 5000.0, SaleStatus.Faturado, s4);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2023, 10, 13), 9000.0, SaleStatus.Pendente, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2023, 12, 7), 4000.0, SaleStatus.Faturado, s3);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2022, 10, 23), 12000.0, SaleStatus.Faturado, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2020, 11, 12), 4580.0, SaleStatus.Faturado, s5);
            SalesRecord r31 = new SalesRecord(31, new DateTime(2024, 01, 24), 5400.0, SaleStatus.Faturado, s8);
            SalesRecord r32 = new SalesRecord(32, new DateTime(2024, 02, 11), 250.0, SaleStatus.Faturado, s9);
            SalesRecord r33 = new SalesRecord(33, new DateTime(2024, 04, 10), 500.0, SaleStatus.Faturado, s9);
            SalesRecord r34 = new SalesRecord(34, new DateTime(2024, 05, 13), 9000.0, SaleStatus.Faturado, s8);
            SalesRecord r35 = new SalesRecord(35, new DateTime(2024, 05, 23), 6300.0, SaleStatus.Faturado, s9);
            SalesRecord r36 = new SalesRecord(36, new DateTime(2024, 03, 18), 5300.0, SaleStatus.Faturado, s8);
            SalesRecord r37 = new SalesRecord(37, new DateTime(2024, 06, 22), 7000.0, SaleStatus.Faturado, s8);

            _context.Department.AddRange(d1, d2, d3, d4, d5);

            _context.Vendedor.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9);

            _context.RecordeVendas.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30, r31, r32, r33, r34, r35, r36, r37
            );

            _context.SaveChanges();

        }
    }
}


