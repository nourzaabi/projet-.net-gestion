using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LocationMVC.Models;

namespace LocationMVC.Services.Repositories
{
    public class AppartementRepository : IRepository<Appartement>
    {
        private readonly ApplicationDbContext _context;

        public AppartementRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Appartement>> GetAllAsync()
        {
            return await _context.Appartements.ToListAsync();
        }

        public async Task<Appartement> GetByIdAsync(int id)
        {
            return await _context.Appartements.FindAsync(id);
        }

        public async Task AddAsync(Appartement entity)
        {
            _context.Appartements.Add(entity);  // Ajout de l'entité
            await _context.SaveChangesAsync();  // Sauvegarde asynchrone des modifications
        }

        public async Task UpdateAsync(Appartement entity)
        {
            _context.Appartements.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Appartement entity)
        {
            _context.Appartements.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

