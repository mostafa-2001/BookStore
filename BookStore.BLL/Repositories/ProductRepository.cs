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
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly BookSoreContext _context;

        public ProductRepository(BookSoreContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Product>> Search(string search)
        {
            return await _context.Products.Where(p => p.Name.Contains(search)).ToListAsync();
        }
    }
}
