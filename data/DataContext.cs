using Microsoft.EntityFrameworkCore;
using testeNetCore.Models;

namespace testeNetCore.Data{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {

        }
        public DbSet<Cidade> Cidades {get;set;}
    }
}