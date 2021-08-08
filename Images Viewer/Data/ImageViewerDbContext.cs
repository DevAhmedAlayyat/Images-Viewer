using Images_Viewer.Data.Entities;
using Images_Viewer.Data.EntitiesConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Images_Viewer.Data
{
    class ImageViewerDbContext : DbContext
    {
        public ImageViewerDbContext()
            :base("ImageViewerConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AttachmentConfiguration());
        }

        public DbSet<Attachment> Attachments { get; set; }
    }
}
