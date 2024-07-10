using Microsoft.EntityFrameworkCore;
using ProjetoInterdisciplinar.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInterdisciplinar.Services {
    public class DepartmentService {

        private readonly ProjetoInterdisciplinarContext _context;
        public DepartmentService(ProjetoInterdisciplinarContext context) {
            _context = context;
        }

        public async Task <List<Department>> FindAllAsync() {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
        //public async Task<List<Department>> FindAllAsync() {
          //  return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        //}
    }
}
