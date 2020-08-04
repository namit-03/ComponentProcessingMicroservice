using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ComponentProcessingMicroservice.Models
{
    public partial class ReturnOrderContext : DbContext
    {
       

        public ReturnOrderContext(DbContextOptions<ReturnOrderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OrderDetails> OrderDetails { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.RequestId);

                entity.Property(e => e.RequestId)
                    .HasColumnName("Request_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
