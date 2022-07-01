using Microsoft.EntityFrameworkCore;
using ProjetoHotel.Lib.Models;

namespace ProjetoHotel.Lib.Data
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estadia>().ToTable("ht_estadias");
            modelBuilder.Entity<Estadia>().HasKey(x => x.Id);
            modelBuilder.Entity<Estadia>().HasOne(x => x.Quarto)
                                          .WithMany(x => x.ListaDeEstadia)
                                          .HasForeignKey(x => x.IdQuarto);
            modelBuilder.Entity<Estadia>().HasOne(x => x.Responsavel)
                                          .WithMany(x => x.ListaDeEstadia)
                                          .HasForeignKey(x => x.IdResponsavel);

            modelBuilder.Entity<EstadiaXHospede>().ToTable("ht_estadias_x_hospedes");
            modelBuilder.Entity<EstadiaXHospede>().HasKey(x => x.Id);
            modelBuilder.Entity<EstadiaXHospede>().HasOne(x => x.Hospede)
                                                  .WithMany(x => x.ListaDeEstadiaXHospede)
                                                  .HasForeignKey(x => x.IdHospede);
            modelBuilder.Entity<EstadiaXHospede>().HasOne(x => x.Estadia)
                                                  .WithMany(x => x.ListaDeEstadiaXHospede)
                                                  .HasForeignKey(x => x.IdEstadia);

            modelBuilder.Entity<Hospede>().ToTable("ht_hospedes");
            modelBuilder.Entity<Hospede>().HasKey(x => x.Id);
            modelBuilder.Entity<Hospede>().HasMany(x => x.ListaDeEstadia)
                                          .WithOne(x => x.Responsavel);

            modelBuilder.Entity<Hotel>().ToTable("ht_hoteis");
            modelBuilder.Entity<Hotel>().HasKey(x => x.Id);
            modelBuilder.Entity<Hotel>().HasMany(x => x.ListaDeServicoXHotel)
                                        .WithOne(x => x.Hotel);

            modelBuilder.Entity<Quarto>().ToTable("ht_quartos");
            modelBuilder.Entity<Quarto>().HasKey(x => x.Id);
            modelBuilder.Entity<Quarto>().HasOne(x => x.TipoDeQuarto)
                                         .WithMany(x => x.ListaQuartos);
            modelBuilder.Entity<Quarto>().HasOne(x => x.Hotel)
                                         .WithMany(x => x.ListaDeQuarto)
                                         .HasForeignKey(x => x.IdHotel);

            modelBuilder.Entity<Servico>().ToTable("ht_servicos");
            modelBuilder.Entity<Servico>().HasKey(x => x.Id);
            modelBuilder.Entity<Servico>().HasMany(x => x.ServicoXHotelList)
                                          .WithOne(x => x.Servico);

            modelBuilder.Entity<ServicoXHotel>().ToTable("ht_servicos_x_hoteis");
            modelBuilder.Entity<ServicoXHotel>().HasKey(x => x.Id);
            modelBuilder.Entity<ServicoXHotel>().HasOne(x => x.Servico)
                                                .WithMany(x => x.ServicoXHotelList)
                                                .HasForeignKey(x => x.IdServico);
            modelBuilder.Entity<ServicoXHotel>().HasOne(x => x.Hotel)
                                                .WithMany(x => x.ListaDeServicoXHotel)
                                                .HasForeignKey(x => x.IdHotel);

            modelBuilder.Entity<TipoDeQuarto>().ToTable("ht_tipos_quarto");
            modelBuilder.Entity<TipoDeQuarto>().HasKey(X => X.Id);
            modelBuilder.Entity<TipoDeQuarto>().HasMany(x => x.ListaQuartos)
                                               .WithOne(x => x.TipoDeQuarto)
                                               .HasForeignKey(x => x.IdTipoQuarto);


        }

        public DbSet<Estadia> Estadias { get; set; }
        public DbSet<EstadiaXHospede> EstadiasXHospedes { get; set; }
        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<ServicoXHotel> ServicosXHoteis { get; set; }
        public DbSet<TipoDeQuarto> TiposDeQuarto { get; set; }
    }
}