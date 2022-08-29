using Microsoft.EntityFrameworkCore;
using TarefasMVC.Models;

namespace TarefasMVC.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
