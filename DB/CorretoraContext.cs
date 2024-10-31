using Corretora_Consorcio.Model;
using System.Collections.Generic;
using Corretora_Consorcio.Model;
using Microsoft.EntityFrameworkCore;



namespace Corretora_Consorcio.DB
{
 
    public class CorretoraContext:DbContext
    {
        public CorretoraContext(DbContextOptions<CorretoraContext> options) : base(options) { }

        public DbSet<CorretoraCadastro> Corretoras { get; set; }

        public DbSet<Corretor> Corretores { get; set; }

    }
}
