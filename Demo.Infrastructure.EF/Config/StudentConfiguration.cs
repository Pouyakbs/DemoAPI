using Demo.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.EF.Config
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(a => a.StudentId);
            builder.Property(a => a.Name).HasColumnType("nvarchar(60)").IsRequired();
            builder.Property(a => a.Surname).HasColumnType("nvarchar(60)").IsRequired();
            builder.Property(a => a.Age).HasColumnType("int");
        }
    }
}
