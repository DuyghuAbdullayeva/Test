using MentorProject.Entities.AppdbContextEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MentorProject.Configs
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.Property(x=>x.Name).IsRequired()
                                       .HasMaxLength(100);
            builder.Property(x=>x.Number).IsRequired()
                                         .HasMaxLength(100);

        }
    }
}
