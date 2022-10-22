using BookStore.BLL.Interfaces;
using BookStore.DAL.Data;
using BookStore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly BookSoreContext _context;

        public CategoryRepository(BookSoreContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Category>> Search(string search)
        {
            return await _context.Categories.Where(p => p.Name.Contains(search)).ToListAsync();
        }
    }
}
