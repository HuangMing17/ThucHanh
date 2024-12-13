using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab3_03_Database
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=QLSinhVienDB")
        {
        }

        public virtual DbSet<SinhVien> SinhVien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaSo)
                .IsUnicode(false);
        }
    }
}
