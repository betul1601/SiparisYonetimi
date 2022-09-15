using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimi.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public DateTime? CreateDate { get; set; } = DateTime.Now;

        public virtual List <Product> Products { get; set; } //kategori ile product arasında ilişki kurduk.bir kategoriye ait birden fazla product olabileceği için list ile bire çok ilişki kurduk

        public Category() //kısayolu ctor tab tab (constructur kurucu metodun kısaltması)
        {
            Products = new List<Product>(); 
        }
         
    }
}
