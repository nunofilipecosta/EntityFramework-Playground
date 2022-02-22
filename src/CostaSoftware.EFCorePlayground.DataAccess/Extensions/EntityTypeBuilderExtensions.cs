using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaSoftware.EFCorePlayground.DataAccess.Extensions
{
    public static class EntityTypeBuilderExtensions
    {
        public static void IsEntity<TEntity, TKey>(this EntityTypeBuilder<TEntity> builder)
            where TEntity : Entity<TKey>
        {
            builder.HasKey(e => e.Id);
        }
    }
}
