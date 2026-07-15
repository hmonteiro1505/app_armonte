using armonte_aplicacao.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace armonte_aplicacao.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Obras> Obras => Set<Obras>();
        public DbSet<Produtos> Produtos => Set<Produtos>();
        public DbSet<Fornecedor> Fornecedores => Set<Fornecedor>();
        public DbSet<Cliente> Clientes => Set<Cliente>();
        public DbSet<FaturaCliente> FaturaCliente => Set<FaturaCliente>();
        public DbSet<ProjetoObraRelacaoCustos> ProjetoObraRelacaoCustos => Set<ProjetoObraRelacaoCustos>();
        public DbSet<FaturaFornecedor> FaturaFornecedores => Set<FaturaFornecedor>();



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost\\SQLEXPRESS;Database=CustosConstrucao;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           /*regras*/
        }
    }
}
