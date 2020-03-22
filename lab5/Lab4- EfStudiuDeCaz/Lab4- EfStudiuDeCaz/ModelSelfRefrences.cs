using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Lab4__EfStudiuDeCaz
{
    using System.Data.Entity;

    public class ModelSelfRefrences : DbContext
    {
        // Your context has been configured to use a 'ModelSelfRefrences' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Lab4__EfStudiuDeCaz.ModelSelfRefrences' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelSelfRefrences' 
        // connection string in the application configuration file.
        public ModelSelfRefrences()
            : base("Data Source=DTPR003271\\SQLEXPRESS;Initial Catalog=TSP;Integrated Security=True")
        {
        }

        public virtual DbSet<SelfReference> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SelfReference>()
                .HasMany(m => m.References).WithOptional(m => m.ParentSelfReference);
        }

        public class SelfReference
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int SelfReferenceId { get; set; }

            public string Name { get; set; }
            public int? ParentSelfReferenceId { get; set; }

            [ForeignKey("ParentSelfReferenceId")] public SelfReference ParentSelfReference { get; set; }
            public virtual ICollection<SelfReference> References { get; set; }

            public SelfReference()
            {
                References = new HashSet<SelfReference>();

   
            }


        }

        public class SelfReferenceAssertMethods
        {
            public ReadOnlyCollection<SelfReference> GetAll()
            {
                using (var context = new ModelSelfRefrences())
                {
                    return context.MyEntities.ToList().AsReadOnly();
                }
            }

            public void Insert(SelfReference model)
            {
                using (var context = new ModelSelfRefrences())
                {
                    context.MyEntities.Add(model);
                    context.SaveChanges();
                }
            }
        }
    }
}