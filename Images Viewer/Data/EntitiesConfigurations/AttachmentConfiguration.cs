using Images_Viewer.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Images_Viewer.Data.EntitiesConfigurations
{
    public class AttachmentConfiguration : EntityTypeConfiguration<Attachment>
    {
        public AttachmentConfiguration()
        {
            Property(x => x.Name).IsRequired().HasMaxLength(50);
            Property(x => x.Description).HasMaxLength(150);
            Property(x => x.Address).HasMaxLength(50);
            Property(x => x.Email).HasMaxLength(30);
        }
    }
}
