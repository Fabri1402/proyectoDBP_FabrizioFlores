using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace proyecto_DBP.Models;

public partial class VentasC : DbContext
{
    public VentasC()
    {
    }

    public VentasC(DbContextOptions<VentasC> options)
        : base(options)
    {
    }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    public virtual DbSet<TbProducto> TbProductos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=SQL5106.site4now.net;Initial Catalog=db_a9ac72_aea;User Id=db_a9ac72_aea_admin;Password=F73243507f");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Horario>(entity =>
        {
            entity.HasKey(e => e.IdHorario).HasName("PK__horarios__DE60F33ABD5C0AF0");

            entity.ToTable("horarios");

            entity.Property(e => e.IdHorario).HasColumnName("idHorario");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.Hora).HasColumnName("hora");
            entity.Property(e => e.Tamaño).HasColumnName("tamaño");
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.IdReserva).HasName("PK__reservas__0E49C69D8133B168");

            entity.ToTable("reservas");

            entity.Property(e => e.ApellidosCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidosCliente");
            entity.Property(e => e.CorreoCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correoCliente");
            entity.Property(e => e.FechaReserva)
                .HasColumnType("date")
                .HasColumnName("fechaReserva");
            entity.Property(e => e.HoraReserva).HasColumnName("horaReserva");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreCliente");
            entity.Property(e => e.TamañoMesa).HasColumnName("tamañoMesa");
            entity.Property(e => e.TelefonoCliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefonoCliente");
        });

        modelBuilder.Entity<TbProducto>(entity =>
        {
            entity.HasKey(e => e.CodPro).HasName("PK__TB_PRODU__28BE23B5D7FBF836");

            entity.ToTable("TB_PRODUCTO");

            entity.Property(e => e.CodPro)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_PRO");
            entity.Property(e => e.DesPro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_PRO");
            entity.Property(e => e.Importado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IMPORTADO");
            entity.Property(e => e.LinPro)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LIN_PRO");
            entity.Property(e => e.PrePro)
                .HasColumnType("money")
                .HasColumnName("PRE_PRO");
            entity.Property(e => e.StkAct).HasColumnName("STK_ACT");
            entity.Property(e => e.StkMin).HasColumnName("STK_MIN");
            entity.Property(e => e.UniMed)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UNI_MED");
            entity.Property(e => e.URL)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__usuario__645723A6B493BEA5");

            entity.ToTable("usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.UsuClave)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("usuClave");
            entity.Property(e => e.UsuNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("usuUsuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
