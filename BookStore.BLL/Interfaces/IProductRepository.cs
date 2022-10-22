using BookStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>  
    {
        Task<IReadOnlyList<Product>> Search(string search);

    }
}
