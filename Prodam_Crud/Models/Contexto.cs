using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam_Crud.Models
{
    public class Contexto : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Paciente> Paciente { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}
