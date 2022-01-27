using ClubTest.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubTest.EntityFrameworkCore
{
    public class TeamConfig : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
           /* builder.ToTable("Equipos");--------*/
            builder.HasKey(x => x.Id);
        }
    }
}