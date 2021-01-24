using ApiCatalogo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogo.Context
{
    public class AppDbContext : DbContext
    { 
        //Cosntrutor que define o contexto entre o Banco e EF Core para que possamos realizar o CRUD
        public AppDbContext(DbContextOptions<AppDbContext>options)
            : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
