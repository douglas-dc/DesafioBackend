using Microsoft.EntityFrameworkCore;

namespace DesafioUseallBackEnd.Models
{
    public class ClienteContext : DbContext
    {
        public DbSet<Cliente> clientes { get; set; }

        public ClienteContext(DbContextOptions<ClienteContext> options) :
            base(options)
        {
        }
    }

}
