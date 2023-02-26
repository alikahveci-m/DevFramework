﻿using DevFramework.Northwind.Entities.Concrete;
using DevFramework.Nortwind.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DevFramework.Nortwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Categories", @"dbo");
            HasKey(x => x.CategoryId);

            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.CategoryName).HasColumnName("CategoryName");
        }
    }
}