using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Model;

public partial class VascoContext : DbContext
{
    public VascoContext()
    {
    }

    public VascoContext(DbContextOptions<VascoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ofertum> Oferta { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<ProdutoPedido> ProdutoPedidos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=CT-C-001YG\\SQLEXPRESS;Initial Catalog=Vasco;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ofertum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Oferta__3214EC27F00848A3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

            entity.HasOne(d => d.Produto).WithMany(p => p.Oferta)
                .HasForeignKey(d => d.ProdutoId)
                .HasConstraintName("FK__Oferta__ProdutoI__412EB0B6");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pedido__3214EC273DBE5038");

            entity.ToTable("Pedido");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Hora).HasColumnType("datetime");
            entity.Property(e => e.Nome)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Produto__3214EC27B865C99B");

            entity.ToTable("Produto");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cupom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DescricaoPromocao)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Preco)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProdutoPedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProdutoP__3214EC27FA1479D2");

            entity.ToTable("ProdutoPedido");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PedidoId).HasColumnName("PedidoID");
            entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

            entity.HasOne(d => d.Pedido).WithMany(p => p.ProdutoPedidos)
                .HasForeignKey(d => d.PedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProdutoPe__Pedid__3E52440B");

            entity.HasOne(d => d.Produto).WithMany(p => p.ProdutoPedidos)
                .HasForeignKey(d => d.ProdutoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProdutoPe__Produ__3D5E1FD2");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC279203E7B5");

            entity.ToTable("Usuario");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nome)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Salt)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Senha).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
