using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMS.WebApi.Models;

namespace SMS.WebApi.Configuration;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
       builder.ToTable(nameof(Student)); 
        builder.HasKey(x => x.Id);  
    }
}
