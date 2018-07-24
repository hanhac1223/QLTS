using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace thuctap_QLTS.Models
{
    public partial class QLTSContext : DbContext
    {
        public QLTSContext()
        {
        }

        public QLTSContext(DbContextOptions<QLTSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chucvu> Chucvu { get; set; }
        public virtual DbSet<Donvisuachua> Donvisuachua { get; set; }
        public virtual DbSet<Khauhaotaisan> Khauhaotaisan { get; set; }
        public virtual DbSet<Kho> Kho { get; set; }
        public virtual DbSet<Loaitaisan> Loaitaisan { get; set; }
        public virtual DbSet<Mucdichsudung> Mucdichsudung { get; set; }
        public virtual DbSet<Nhanvien> Nhanvien { get; set; }
        public virtual DbSet<Nhaphanphoi> Nhaphanphoi { get; set; }
        public virtual DbSet<Nhasanxuat> Nhasanxuat { get; set; }
        public virtual DbSet<Phieukiem> Phieukiem { get; set; }
        public virtual DbSet<Phieusua> Phieusua { get; set; }
        public virtual DbSet<Phongban> Phongban { get; set; }
        public virtual DbSet<Taisan> Taisan { get; set; }
        public virtual DbSet<Trangthai> Trangthai { get; set; }
        public virtual DbSet<Trangthaikiem> Trangthaikiem { get; set; }

        // Unable to generate entity type for table 'dbo.TAIKHOAN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PHIEUXUAT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PHIEUNHAP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LICHSUHOATDONG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DIEUCHUYEN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CHUA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CHITIETSUA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CAPPHAT'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=QLTS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chucvu>(entity =>
            {
                entity.HasKey(e => e.MaCv);

                entity.ToTable("CHUCVU");

                entity.Property(e => e.MaCv).HasColumnName("MaCV");

                entity.Property(e => e.MoTa).HasMaxLength(100);

                entity.Property(e => e.TenCv)
                    .HasColumnName("TenCV")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Donvisuachua>(entity =>
            {
                entity.HasKey(e => e.MaDv);

                entity.ToTable("DONVISUACHUA");

                entity.Property(e => e.MaDv).HasColumnName("MaDV");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.TenDv)
                    .HasColumnName("TenDV")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Khauhaotaisan>(entity =>
            {
                entity.HasKey(e => e.MaKhauHao);

                entity.ToTable("KHAUHAOTAISAN");

                entity.Property(e => e.NamKhauHao).HasColumnType("date");

                entity.Property(e => e.TenKhauHao).HasMaxLength(100);
            });

            modelBuilder.Entity<Kho>(entity =>
            {
                entity.HasKey(e => e.MaKho);

                entity.ToTable("KHO");

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.TenKho).HasMaxLength(100);

                entity.Property(e => e.ViTri).HasMaxLength(100);
            });

            modelBuilder.Entity<Loaitaisan>(entity =>
            {
                entity.HasKey(e => e.MaLoai);

                entity.ToTable("LOAITAISAN");

                entity.Property(e => e.MaLoai).ValueGeneratedOnAdd();

                entity.Property(e => e.TenLoai).HasMaxLength(100);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithOne(p => p.Loaitaisan)
                    .HasForeignKey<Loaitaisan>(d => d.MaLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOAITAISAN_TAISAN");
            });

            modelBuilder.Entity<Mucdichsudung>(entity =>
            {
                entity.HasKey(e => e.MaMucDich);

                entity.ToTable("MUCDICHSUDUNG");

                entity.Property(e => e.MoTa).HasMaxLength(200);

                entity.Property(e => e.TenMucDich).HasMaxLength(100);
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.MaNv);

                entity.ToTable("NHANVIEN");

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.GioiTinh).HasMaxLength(20);

                entity.Property(e => e.MaCv).HasColumnName("MaCV");

                entity.Property(e => e.MaPb).HasColumnName("MaPB");

                entity.Property(e => e.TenNv)
                    .HasColumnName("TenNV")
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaCvNavigation)
                    .WithMany(p => p.Nhanvien)
                    .HasForeignKey(d => d.MaCv)
                    .HasConstraintName("FK_NHANVIEN_CHUCVU");

                entity.HasOne(d => d.MaPbNavigation)
                    .WithMany(p => p.Nhanvien)
                    .HasForeignKey(d => d.MaPb)
                    .HasConstraintName("FK_NHANVIEN_PHONGBAN");
            });

            modelBuilder.Entity<Nhaphanphoi>(entity =>
            {
                entity.HasKey(e => e.MaNpp);

                entity.ToTable("NHAPHANPHOI");

                entity.Property(e => e.MaNpp).HasColumnName("MaNPP");

                entity.Property(e => e.MaNsx).HasColumnName("MaNSX");

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.TenNpp)
                    .HasColumnName("TenNPP")
                    .HasMaxLength(100);

                entity.Property(e => e.ViTri).HasMaxLength(100);

                entity.HasOne(d => d.MaNsxNavigation)
                    .WithMany(p => p.Nhaphanphoi)
                    .HasForeignKey(d => d.MaNsx)
                    .HasConstraintName("FK_NHAPHANPHOI_NHASANXUAT");
            });

            modelBuilder.Entity<Nhasanxuat>(entity =>
            {
                entity.HasKey(e => e.MaNsx);

                entity.ToTable("NHASANXUAT");

                entity.Property(e => e.MaNsx).HasColumnName("MaNSX");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.TeNsx)
                    .HasColumnName("TeNSX")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Phieukiem>(entity =>
            {
                entity.HasKey(e => e.MaPk);

                entity.ToTable("PHIEUKIEM");

                entity.Property(e => e.MaPk).HasColumnName("MaPK");

                entity.Property(e => e.MaTtkiem).HasColumnName("MaTTKiem");

                entity.Property(e => e.TenPk)
                    .HasColumnName("TenPK")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Phieusua>(entity =>
            {
                entity.HasKey(e => e.MaPhieu);

                entity.ToTable("PHIEUSUA");

                entity.Property(e => e.MaDv).HasColumnName("MaDV");

                entity.Property(e => e.NgayBdsua)
                    .HasColumnName("NgayBDSua")
                    .HasColumnType("date");

                entity.Property(e => e.NgayKtsua)
                    .HasColumnName("NgayKTSua")
                    .HasColumnType("date");

                entity.Property(e => e.TenPhieu).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(20);

                entity.HasOne(d => d.MaDvNavigation)
                    .WithMany(p => p.Phieusua)
                    .HasForeignKey(d => d.MaDv)
                    .HasConstraintName("FK_PHIEUSUA_DONVISUACHUA");
            });

            modelBuilder.Entity<Phongban>(entity =>
            {
                entity.HasKey(e => e.MaPb);

                entity.ToTable("PHONGBAN");

                entity.Property(e => e.MaPb).HasColumnName("MaPB");

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.TenPb)
                    .HasColumnName("TenPB")
                    .HasMaxLength(100);

                entity.Property(e => e.ViTri).HasMaxLength(100);
            });

            modelBuilder.Entity<Taisan>(entity =>
            {
                entity.HasKey(e => e.MaTs);

                entity.ToTable("TAISAN");

                entity.Property(e => e.MaTs).HasColumnName("MaTS");

                entity.Property(e => e.BanQuyen).HasMaxLength(100);

                entity.Property(e => e.MaNpp).HasColumnName("MaNPP");

                entity.Property(e => e.MaPk).HasColumnName("MaPK");

                entity.Property(e => e.MaTt).HasColumnName("MaTT");

                entity.Property(e => e.MoTa).HasMaxLength(200);

                entity.Property(e => e.NgayMua).HasColumnType("date");

                entity.Property(e => e.TenTs)
                    .HasColumnName("TenTS")
                    .HasMaxLength(100);

                entity.HasOne(d => d.MaKhauHaoNavigation)
                    .WithMany(p => p.Taisan)
                    .HasForeignKey(d => d.MaKhauHao)
                    .HasConstraintName("FK_TAISAN_KHAUHAOTAISAN");

                entity.HasOne(d => d.MaKhauHao1)
                    .WithMany(p => p.Taisan)
                    .HasForeignKey(d => d.MaKhauHao)
                    .HasConstraintName("FK_TAISAN_NHAPHANPHOI");

                entity.HasOne(d => d.MaPkNavigation)
                    .WithMany(p => p.Taisan)
                    .HasForeignKey(d => d.MaPk)
                    .HasConstraintName("FK_TAISAN_PHIEUKIEM");

                entity.HasOne(d => d.MaTtNavigation)
                    .WithMany(p => p.Taisan)
                    .HasForeignKey(d => d.MaTt)
                    .HasConstraintName("FK_TAISAN_TRANGTHAI");

                entity.HasOne(d => d.XoaNavigation)
                    .WithMany(p => p.Taisan)
                    .HasForeignKey(d => d.Xoa)
                    .HasConstraintName("FK_TAISAN_MUCDICHSUDUNG");
            });

            modelBuilder.Entity<Trangthai>(entity =>
            {
                entity.HasKey(e => e.MaTt);

                entity.ToTable("TRANGTHAI");

                entity.Property(e => e.MaTt).HasColumnName("MaTT");

                entity.Property(e => e.MoTa).HasMaxLength(200);

                entity.Property(e => e.TenTt)
                    .HasColumnName("TenTT")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Trangthaikiem>(entity =>
            {
                entity.HasKey(e => e.MaTtkiem);

                entity.ToTable("TRANGTHAIKIEM");

                entity.Property(e => e.MaTtkiem).HasColumnName("MaTTKiem");

                entity.Property(e => e.MoTa).HasMaxLength(200);

                entity.Property(e => e.TenTtkiem)
                    .HasColumnName("TenTTKiem")
                    .HasMaxLength(200);
            });
        }
    }
}
