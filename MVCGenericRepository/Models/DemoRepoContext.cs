using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGenericRepository.Models
{
    public class DemoRepoContext : DbContext
    {
        public DbSet<Personel> Personels { get; set; }
    }
}
