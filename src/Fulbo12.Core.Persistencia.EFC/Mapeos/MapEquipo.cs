using Fulbo12.Core.Futbol;
namespace Fulbo12.Core.Persistencia.EFC.Mapeos;
public class MapEquipo : IEntityTypeConfiguration<Equipo>
{
    public void Configure(EntityTypeBuilder<Equipo> etb)
    {
        etb.ToTable("Equipo");

        etb.HasKey(e => e.Id)
            .HasName("Pk_Equipo");
        etb.Property(p => p.Id)
            .HasColumnName("idEquipo")
            .ValueGeneratedOnAdd();

        etb.HasOne(e => e.Liga)
            .WithMany(l => l.Equipos)
            .HasForeignKey("idLiga")
            .IsRequired()
            .HasConstraintName("FK_Equipo_Liga");

        etb.Property(e => e.Nombre)
            .HasColumnName("nombre")
            .IsRequired()
            .HasMaxLength(30);
    }
}
