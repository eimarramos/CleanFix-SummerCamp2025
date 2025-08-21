using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;
public class ApartmentConfiguration : IEntityTypeConfiguration<Apartment>
{
    public void Configure(EntityTypeBuilder<Apartment> builder)
    {
        builder.Property(a => a.FloorNumber)
            .IsRequired()
            .HasComment("Piso del apartamento");

        builder.Property(a => a.Address)
            .IsRequired()
            .HasMaxLength(100)
            .HasComment("Direcci�n del apartamento");

        builder.Property(a => a.Surface)
            .IsRequired()
            .HasComment("Superficie del apartamento");

        builder.Property(a => a.RoomNumber)
            .IsRequired()
            .HasComment("N�mero de habitaciones");

        builder.Property(a => a.BathroomNumber)
            .IsRequired()
            .HasComment("N�mero de ba�os");
    }
}
