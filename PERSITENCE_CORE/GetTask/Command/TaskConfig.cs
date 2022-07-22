using DOMAIN_CORE.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PERSITENCE_CORE.GetTask.Command
{
    public class TaskConfig : IEntityTypeConfiguration<Tasks>
    {
        public void Configure(EntityTypeBuilder<Tasks> builder)
        {
            builder.HasKey(e => e.idTask);

            builder.ToTable("tbTask");

        }
    }
}
