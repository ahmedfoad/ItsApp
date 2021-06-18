using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItsApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItsApp.EntityFrameworkCore.Mapping
{
    public class InformationMap : IEntityTypeConfiguration<Information>
    {
        public void Configure(EntityTypeBuilder<Information> builder)
        {
            builder.ToTable("Informations", "Core");
        }
    }
}
