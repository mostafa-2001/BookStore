using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Entities
{
    public enum Rating { bad , good  , verygood ,  Execllent  }
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string UrlImage { get; set; }

        public decimal Price { get; set; }

        public Rating Rating { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int AuthorId { get; set; }

        public virtual  Author Author { get; set; }
    }
}
