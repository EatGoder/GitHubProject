using Project.API.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.API.EntityFramework.Mappings
{
    public class UserInfoMapping : EntityTypeConfiguration<UserInfoResponseModel>
    {
        public UserInfoMapping()
        {
            this.HasKey(m => m.UID);

            this.Property(m => m.UID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.UserNO)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(m => m.UserName)
                .IsRequired()
                .HasMaxLength(30);

            this.ToTable("UserInfo");

            this.Property(m => m.UID).HasColumnName("UID");
            this.Property(m => m.UserNO).HasColumnName("UserNO");
            this.Property(m => m.UserName).HasColumnName("UserName");
        }
    }
}
