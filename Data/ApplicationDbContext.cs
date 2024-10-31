using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VendaPesca.Models;

namespace VendaPesca.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<VendaPesca.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<VendaPesca.Models.Fornecedor> Fornecedor { get; set; } = default!;
        public DbSet<VendaPesca.Models.Produto> Produto { get; set; } = default!;
        public DbSet<VendaPesca.Models.Venda> Venda { get; set; } = default!;
    }
}
