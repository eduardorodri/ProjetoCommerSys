using ProjetoInterdisciplinar.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace ProjetoInterdisciplinar.Services {
    public class SalesRecordService {

        private readonly ProjetoInterdisciplinarContext _context;
        public SalesRecordService(ProjetoInterdisciplinarContext context) {
            _context = context;
        }
        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate) {
            var result = from obj in _context.RecordeVendas select obj;
            if (minDate.HasValue) {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue) {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate) {
            var result = from obj in _context.RecordeVendas select obj;
            if (minDate.HasValue) {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue) {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .GroupBy(x => x.Vendedor.Departamento)
                .ToListAsync();
        }
    }
}
