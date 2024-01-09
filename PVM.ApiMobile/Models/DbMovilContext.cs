using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PVM.ApiMobile.Models;

public partial class DbMovilContext : DbContext
{
    public DbMovilContext()
    {
    }

    public DbMovilContext(DbContextOptions<DbMovilContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asistencium> Asistencia { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<TipoPersona> TipoPersonas { get; set; }

    public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=sql5112.site4now.net;database=db_aa3c92_dbmovil;uid=db_aa3c92_dbmovil_admin;pwd=ABCabc123*");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asistencium>(entity =>
        {
            entity.HasKey(e => e.Idasistencia).HasName("PK__Asistenc__D186AE72D4CABBE7");

            entity.Property(e => e.Idasistencia).HasColumnName("idasistencia");
            entity.Property(e => e.Bhabilitado).HasColumnName("bhabilitado");
            entity.Property(e => e.Fechaasistencia)
                .HasColumnType("datetime")
                .HasColumnName("fechaasistencia");
            entity.Property(e => e.Idusuario).HasColumnName("idusuario");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.Asistencia)
                .HasForeignKey(d => d.Idusuario)
                .HasConstraintName("FK__Asistenci__idusu__4222D4EF");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Idpersona).HasName("PK__Persona__5C5C1E285FA9CBCE");

            entity.ToTable("Persona");

            entity.Property(e => e.Idpersona).HasColumnName("idpersona");
            entity.Property(e => e.Apmaterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apmaterno");
            entity.Property(e => e.Appaterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("appaterno");
            entity.Property(e => e.Bhabilitado).HasColumnName("bhabilitado");
            entity.Property(e => e.Btieneusuario).HasColumnName("btieneusuario");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Fechanacimiento).HasColumnName("fechanacimiento");
            entity.Property(e => e.Idtipopersona).HasColumnName("idtipopersona");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdtipopersonaNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.Idtipopersona)
                .HasConstraintName("FK__Persona__idtipop__398D8EEE");
        });

        modelBuilder.Entity<TipoPersona>(entity =>
        {
            entity.HasKey(e => e.Idtipopersona).HasName("PK__TipoPers__515D1B0B60FE145D");

            entity.ToTable("TipoPersona");

            entity.Property(e => e.Idtipopersona).HasColumnName("idtipopersona");
            entity.Property(e => e.Bhabilitado).HasColumnName("bhabilitado");
            entity.Property(e => e.Nombretipopersona)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombretipopersona");
        });

        modelBuilder.Entity<TipoUsuario>(entity =>
        {
            entity.HasKey(e => e.Idtipousuario).HasName("PK__TipoUsua__D607306068D5E4C5");

            entity.ToTable("TipoUsuario");

            entity.Property(e => e.Idtipousuario).HasColumnName("idtipousuario");
            entity.Property(e => e.Bhabilitado).HasColumnName("bhabilitado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Idusuario).HasName("PK__Usuario__080A9743671AC20B");

            entity.ToTable("Usuario");

            entity.Property(e => e.Idusuario).HasColumnName("idusuario");
            entity.Property(e => e.Bhabilitado).HasColumnName("bhabilitado");
            entity.Property(e => e.Contra)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contra");
            entity.Property(e => e.Idpersona).HasColumnName("idpersona");
            entity.Property(e => e.Idtipousuario).HasColumnName("idtipousuario");
            entity.Property(e => e.Nombreusuario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombreusuario");

            entity.HasOne(d => d.IdpersonaNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.Idpersona)
                .HasConstraintName("FK__Usuario__idperso__3F466844");

            entity.HasOne(d => d.IdtipousuarioNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.Idtipousuario)
                .HasConstraintName("FK__Usuario__idtipou__3E52440B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
