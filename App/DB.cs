namespace App
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<area> area { get; set; }
        public virtual DbSet<cargo> cargo { get; set; }
        public virtual DbSet<celula> celula { get; set; }
        public virtual DbSet<niveisEducacionais> niveisEducacionais { get; set; }
        public virtual DbSet<registros> registros { get; set; }
        public virtual DbSet<unidade> unidade { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
