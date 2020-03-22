using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4__EfStudiuDeCaz
{
    public class ModelPhotograph : DbContext
    {
        public ModelPhotograph()
            :base("Data Source=DTPR003271\\SQLEXPRESS;Initial Catalog=TSP;Integrated Security=True")
        {
            
        }
        public virtual DbSet<Photograph> Photographs { get; set; }
        public virtual DbSet<PhotographFullImage> PhotographFullImages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Photograph>()
                .HasRequired(p => p.PhotographFullImage)
                .WithRequiredPrincipal(p => p.Photograph);
            modelBuilder.Entity<Photograph>()
                .ToTable("Photograph", "BazaDeDate");
            modelBuilder.Entity<PhotographFullImage>()
                .ToTable("Photograph", "BazaDeDate");
        }
    }
    public class Photograph
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhotoId { get; set; }
        public string Title { get; set; }
        public byte[] ThumbnailBits { get; set; }
        [ForeignKey("PhotoId")]
        public virtual PhotographFullImage PhotographFullImage { get; set; }
    }

    public class PhotographFullImage
    {
        [Key]
        public int PhotoId { get; set; }
        public byte[] HighResolutionBits { get; set; }
        [ForeignKey("PhotoId")]
        public virtual Photograph Photograph { get; set; }
    }
}
