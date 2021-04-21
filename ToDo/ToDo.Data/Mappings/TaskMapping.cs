using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Todo.Domain;

namespace Todo.Data.Mappings
{
    public class TaskMapping : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.Property(p => p.Descricao)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

            builder.HasKey(p => p.Id);

            
        }
    }

}