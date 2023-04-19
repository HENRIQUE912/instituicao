using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace instituicao.Models
{
    public class Conexao : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SLQEXPRESS; User id=sa; Password=ntt.123; Database=BdEscola");

        }

        public DbSet<instituicao> Instituicoes { get; set; }
    }
}
