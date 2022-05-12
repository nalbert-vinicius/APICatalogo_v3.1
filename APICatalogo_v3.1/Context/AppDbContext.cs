using APICatalogo_v3._1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo_v3._1.Context
{
    public class AppDbContext : DbContext
    {

        //Config do contexto
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        //Mapeia as entidades
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }


    }
}
