using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AKJ738_ZH3.Models;

public partial class tickerContext : DbContext
{
    public tickerContext()
    {
    }

    public tickerContext(DbContextOptions<tickerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BasicCompanyInfo> BasicCompanyInfos { get; set; }

    public virtual DbSet<DailyPrice> DailyPrices { get; set; }

    public virtual DbSet<Ticker> Tickers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=tickerdata.database.windows.net;Initial Catalog=tickerDB;Persist Security Info=True;User ID=AKJ738;Password=Password123;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BasicCompanyInfo>(entity =>
        {
            entity.HasKey(e => e.InfoId).HasName("PK__BasicCom__4DEC9D9A8C5EB851");

            entity.ToTable("BasicCompanyInfo");

            entity.Property(e => e.InfoId).HasColumnName("InfoID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.FoundingDate).HasColumnType("date");
            entity.Property(e => e.Industry).HasMaxLength(100);
            entity.Property(e => e.TickerId).HasColumnName("TickerID");

            entity.HasOne(d => d.Ticker).WithMany(p => p.BasicCompanyInfos)
                .HasForeignKey(d => d.TickerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BasicCompanyInfo_Tickers");
        });

        modelBuilder.Entity<DailyPrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DailyPri__3214EC27C0060AEB");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClosePrice).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.OpenPrice).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TickerId).HasColumnName("TickerID");
            entity.Property(e => e.TradeDate).HasColumnType("date");

            entity.HasOne(d => d.Ticker).WithMany(p => p.DailyPrices)
                .HasForeignKey(d => d.TickerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DailyPrices_Tickers");
        });

        modelBuilder.Entity<Ticker>(entity =>
        {
            entity.HasKey(e => e.TickerId).HasName("PK__Tickers__71A0D295FEEC9769");

            entity.HasIndex(e => e.TickerSymbol, "UQ__Tickers__F144591BC1F48FD4").IsUnique();

            entity.Property(e => e.TickerId).HasColumnName("TickerID");
            entity.Property(e => e.TickerSymbol).HasMaxLength(10);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
