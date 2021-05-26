using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata;
using EcoTec.Domain.Entities;

namespace Ecotec.Infra.Data.Context
{
    public class EcotecContext : DbContext
    {
        public EcotecContext(IConfiguration configuration)
        {
            Config = configuration;
        }

        public IConfiguration Config { get; }

        public DbSet<LoginModel> Pedido { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            {
                property.AsProperty().Builder.HasMaxLength(150, ConfigurationSource.Convention);
            }

            //modelBuilder.ApplyConfiguration(new PedidoMap());


            base.OnModelCreating(modelBuilder);
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   optionsBuilder.
        //}

        public override int SaveChanges()
        {
            try
            {
                foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataRegistro") != null))
                {
                    if (entry.State == EntityState.Added)
                        entry.Property("DataRegistro").CurrentValue = DateTime.Now;
                    if (entry.State == EntityState.Modified)
                        entry.Property("DataRegistro").IsModified = false;
                }

                return base.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                foreach (var eve in e.Entries)
                {
                    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" tem os seguintes erros de validação:",
                        eve.Entity.GetType().Name, eve.State);
                }
                throw;
            }
            catch (SqlException s)
            {
                Console.WriteLine("- Message: \"{0}\", Data: \"{1}\"",
                    s.Message, s.Data);
                throw;
            }
        }
    }
}