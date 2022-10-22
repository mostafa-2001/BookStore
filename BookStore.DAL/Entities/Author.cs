using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Entities
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }

        public string Info { get; set; }

        public DateTime BirthOfDate { get; set; }

        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
