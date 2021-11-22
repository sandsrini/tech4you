using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace tech4you.Models
{
    public partial class laptopContext : DbContext
    {
        public laptopContext()
        {
        }

        public laptopContext(DbContextOptions<laptopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customizedlaptop> Customizedlaptops { get; set; }
        public virtual DbSet<Displaytbl> Displaytbls { get; set; }
        public virtual DbSet<Laptoplist> Laptoplists { get; set; }
        public virtual DbSet<Laptoplistmaster> Laptoplistmasters { get; set; }
        public virtual DbSet<Ostbl> Ostbls { get; set; }
        public virtual DbSet<Processortbl> Processortbls { get; set; }
        public virtual DbSet<Storagetypetbl> Storagetypetbls { get; set; }
        public virtual DbSet<Warrantytbl> Warrantytbls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=.;initial catalog=laptop;integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customizedlaptop>(entity =>
            {
                entity.HasKey(e => e.Cuslaptopid)
                    .HasName("PK__customiz__6D7CCEEEF976CBF0");

                entity.ToTable("customizedlaptop");

                entity.Property(e => e.Cuslaptopid).HasColumnName("cuslaptopid");

                entity.Property(e => e.Cusantivirus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("cusantivirus");

                entity.Property(e => e.Cusbrandname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("cusbrandname");

                entity.Property(e => e.Cuslaptopname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("cuslaptopname");

                entity.Property(e => e.Cusprice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("cusprice");

                entity.Property(e => e.Displayid).HasColumnName("displayid");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Grandtotal)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("grandtotal");

                entity.Property(e => e.Invoiceid)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("invoiceid")
                    .HasComputedColumnSql("(concat('T4-',datepart(year,getdate()),'-',right(concat((11),[cuslaptopid]),(3))))", false);

                entity.Property(e => e.Osid).HasColumnName("osid");

                entity.Property(e => e.Processorid).HasColumnName("processorid");

                entity.Property(e => e.Purchasedate)
                    .HasColumnType("datetime")
                    .HasColumnName("purchasedate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((1))");

                entity.Property(e => e.Storagetypeid).HasColumnName("storagetypeid");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Warrantyid).HasColumnName("warrantyid");

                entity.HasOne(d => d.Display)
                    .WithMany(p => p.Customizedlaptops)
                    .HasForeignKey(d => d.Displayid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__customize__displ__18EBB532");

                entity.HasOne(d => d.Os)
                    .WithMany(p => p.Customizedlaptops)
                    .HasForeignKey(d => d.Osid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__customized__osid__19DFD96B");

                entity.HasOne(d => d.Processor)
                    .WithMany(p => p.Customizedlaptops)
                    .HasForeignKey(d => d.Processorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__customize__proce__17F790F9");

                entity.HasOne(d => d.Storagetype)
                    .WithMany(p => p.Customizedlaptops)
                    .HasForeignKey(d => d.Storagetypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__customize__stora__1AD3FDA4");

                entity.HasOne(d => d.Warranty)
                    .WithMany(p => p.Customizedlaptops)
                    .HasForeignKey(d => d.Warrantyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__customize__warra__1BC821DD");
            });

            modelBuilder.Entity<Displaytbl>(entity =>
            {
                entity.HasKey(e => e.Displayid)
                    .HasName("PK__displayt__D56DC80361C4B96E");

                entity.ToTable("displaytbl");

                entity.Property(e => e.Displayid).HasColumnName("displayid");

                entity.Property(e => e.Displaysize)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("displaysize");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price");
            });

            modelBuilder.Entity<Laptoplist>(entity =>
            {
                entity.HasKey(e => e.Laptopid)
                    .HasName("PK__laptopli__5251171630B14813");

                entity.ToTable("laptoplist");

                entity.Property(e => e.Laptopid).HasColumnName("laptopid");

                entity.Property(e => e.Antivirus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("antivirus")
                    .HasDefaultValueSql("('McAfee')");

                entity.Property(e => e.Brandname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brandname");

                entity.Property(e => e.Display)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("display");

                entity.Property(e => e.Graphicscard)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("graphicscard");

                entity.Property(e => e.Laptopname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("laptopname");

                entity.Property(e => e.Memory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("memory");

                entity.Property(e => e.Os)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("os")
                    .HasDefaultValueSql("('windows 10')");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Processor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("processor")
                    .HasDefaultValueSql("('AMD r5')");

                entity.Property(e => e.Productcolor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productcolor")
                    .HasDefaultValueSql("('silver')");

                entity.Property(e => e.Storagetype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("storagetype")
                    .HasDefaultValueSql("('HDD500GB')");

                entity.Property(e => e.Warranty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("warranty")
                    .HasDefaultValueSql("('1 year')");

                entity.Property(e => e.Weight)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<Laptoplistmaster>(entity =>
            {
                entity.HasKey(e => e.Laptopid)
                    .HasName("PK__laptopli__52511716C133D82B");

                entity.ToTable("laptoplistmaster");

                entity.Property(e => e.Laptopid).HasColumnName("laptopid");

                entity.Property(e => e.Antivirus)
                    .HasMaxLength(50)
                    .HasColumnName("antivirus")
                    .HasDefaultValueSql("('McAfee')");

                entity.Property(e => e.Brandname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("brandname");

                entity.Property(e => e.Display)
                    .HasMaxLength(50)
                    .HasColumnName("display")
                    .HasDefaultValueSql("('14inch FHD')");

                entity.Property(e => e.Laptopimage)
                    .IsUnicode(false)
                    .HasColumnName("laptopimage");

                entity.Property(e => e.Laptopname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("laptopname");

                entity.Property(e => e.Memory)
                    .IsUnicode(false)
                    .HasColumnName("memory");

                entity.Property(e => e.Os)
                    .HasMaxLength(50)
                    .HasColumnName("os")
                    .HasDefaultValueSql("('Windows 11 Pro, EN')");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Processor)
                    .HasMaxLength(50)
                    .HasColumnName("processor")
                    .HasDefaultValueSql("('10th Generation Intel')");

                entity.Property(e => e.Productcolor)
                    .HasMaxLength(50)
                    .HasColumnName("productcolor")
                    .HasDefaultValueSql("('silver')");

                entity.Property(e => e.Storagetype)
                    .HasMaxLength(50)
                    .HasColumnName("storagetype")
                    .HasDefaultValueSql("('256GB SSD')");

                entity.Property(e => e.Warranty)
                    .IsUnicode(false)
                    .HasColumnName("warranty");
            });

            modelBuilder.Entity<Ostbl>(entity =>
            {
                entity.HasKey(e => e.Osid)
                    .HasName("PK__ostbl__5242E3498F4FFE91");

                entity.ToTable("ostbl");

                entity.Property(e => e.Osid).HasColumnName("osid");

                entity.Property(e => e.Osname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("osname");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price");
            });

            modelBuilder.Entity<Processortbl>(entity =>
            {
                entity.HasKey(e => e.Processorid)
                    .HasName("PK__processo__E30F8F297294100D");

                entity.ToTable("processortbl");

                entity.Property(e => e.Processorid).HasColumnName("processorid");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Processorname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("processorname");
            });

            modelBuilder.Entity<Storagetypetbl>(entity =>
            {
                entity.HasKey(e => e.Storagetypeid)
                    .HasName("PK__storaget__22F3B0544F5F314B");

                entity.ToTable("storagetypetbl");

                entity.Property(e => e.Storagetypeid).HasColumnName("storagetypeid");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Storagetypename)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("storagetypename");
            });

            modelBuilder.Entity<Warrantytbl>(entity =>
            {
                entity.HasKey(e => e.Warrantyid)
                    .HasName("PK__warranty__05ACB4E9464282F6");

                entity.ToTable("warrantytbl");

                entity.Property(e => e.Warrantyid).HasColumnName("warrantyid");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Warrantyperiod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("warrantyperiod");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
