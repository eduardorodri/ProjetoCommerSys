using Microsoft.EntityFrameworkCore;
using ProjetoInterdisciplinar.Models;
using ProjetoInterdisciplinar.Services.Exceptions;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoInterdisciplinar.Services {
    public class SellerService {

        private readonly ProjetoInterdisciplinarContext _context;
        public SellerService(ProjetoInterdisciplinarContext context) {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync() {
            return await _context.Vendedor.ToListAsync();
        }

        public async Task InsertAsync(Seller obj) {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id) {
            return await _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id) {

            try {
                var obj = await _context.Vendedor.FindAsync(id);
                _context.Vendedor.Remove(obj);
                await _context.SaveChangesAsync();
            } catch (DbUpdateException e) {
                throw new IntegrityException("Não é possível deletar este vendedor porque há vendas ativas associadas a ele.");
            }
        }

        public async Task UpdateAsync(Seller obj) {
            bool hasAny = await _context.Vendedor.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny) {
                throw new NotFoundException("ID não encontrado");
            }
            try {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            } catch (DbConcurrencyException e) {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
