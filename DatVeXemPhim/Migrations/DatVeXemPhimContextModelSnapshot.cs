﻿// <auto-generated />
using System;
using DatVeXemPhim.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatVeXemPhim.Migrations
{
    [DbContext(typeof(DatVeXemPhimContext))]
    partial class DatVeXemPhimContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DatVeXemPhim.Models.Ghe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("maPhong")
                        .HasColumnType("int");

                    b.Property<string>("tenGhe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("maPhong");

                    b.ToTable("Ghe");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.KhachHang", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("hoTen")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("matKhau")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("soDienThoai")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("taiKhoan")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.NhanVien", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("diaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("matKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.Property<int>("soDienThoai")
                        .HasColumnType("int");

                    b.Property<string>("taiKhoan")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.Phim", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("daoDien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dienVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("maLoaiPhim")
                        .HasColumnType("int");

                    b.Property<string>("ngonNgu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("posterPhim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenPhim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("thoiGianKhoiChieu")
                        .HasColumnType("datetime2");

                    b.Property<string>("thoiLuong")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("maLoaiPhim");

                    b.ToTable("Phim");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.PhongChieu", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("tenPhong")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("PhongChieu");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.TheLoaiPhim", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("tenLoaiPhim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TheLoaiPhim");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.Ve", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("maGhe")
                        .HasColumnType("int");

                    b.Property<int>("maKhachHang")
                        .HasColumnType("int");

                    b.Property<int>("maNhanVien")
                        .HasColumnType("int");

                    b.Property<int>("maXuatChieu")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayBanVe")
                        .HasColumnType("datetime2");

                    b.Property<int>("tongTien")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("maGhe");

                    b.HasIndex("maKhachHang");

                    b.HasIndex("maNhanVien");

                    b.HasIndex("maXuatChieu");

                    b.ToTable("Ve");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.XuatChieu", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("gioBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("gioKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<int>("maPhim")
                        .HasColumnType("int");

                    b.Property<int>("maPhong")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayChieu")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("maPhim");

                    b.HasIndex("maPhong");

                    b.ToTable("XuatChieu");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.Ghe", b =>
                {
                    b.HasOne("DatVeXemPhim.Models.PhongChieu", "fk_PhongChieu")
                        .WithMany("Ghes")
                        .HasForeignKey("maPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("fk_PhongChieu");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.Phim", b =>
                {
                    b.HasOne("DatVeXemPhim.Models.TheLoaiPhim", "fk_TheLoaiPhim")
                        .WithMany("Phims")
                        .HasForeignKey("maLoaiPhim")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("fk_TheLoaiPhim");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.Ve", b =>
                {
                    b.HasOne("DatVeXemPhim.Models.Ghe", "fk_MaGhe")
                        .WithMany("Ves")
                        .HasForeignKey("maGhe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatVeXemPhim.Models.KhachHang", "fk_KhachHang")
                        .WithMany("Ves")
                        .HasForeignKey("maKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatVeXemPhim.Models.NhanVien", "fk_NhanVien")
                        .WithMany("Ves")
                        .HasForeignKey("maNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatVeXemPhim.Models.XuatChieu", "fk_XuatChieu")
                        .WithMany("Ves")
                        .HasForeignKey("maXuatChieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("fk_KhachHang");

                    b.Navigation("fk_MaGhe");

                    b.Navigation("fk_NhanVien");

                    b.Navigation("fk_XuatChieu");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.XuatChieu", b =>
                {
                    b.HasOne("DatVeXemPhim.Models.Phim", "fk_Phim")
                        .WithMany("XuatChieus")
                        .HasForeignKey("maPhim")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatVeXemPhim.Models.PhongChieu", "fk_PhongChieu")
                        .WithMany("XuatChieus")
                        .HasForeignKey("maPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("fk_Phim");

                    b.Navigation("fk_PhongChieu");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.Ghe", b =>
                {
                    b.Navigation("Ves");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.KhachHang", b =>
                {
                    b.Navigation("Ves");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.NhanVien", b =>
                {
                    b.Navigation("Ves");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.Phim", b =>
                {
                    b.Navigation("XuatChieus");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.PhongChieu", b =>
                {
                    b.Navigation("Ghes");

                    b.Navigation("XuatChieus");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.TheLoaiPhim", b =>
                {
                    b.Navigation("Phims");
                });

            modelBuilder.Entity("DatVeXemPhim.Models.XuatChieu", b =>
                {
                    b.Navigation("Ves");
                });
#pragma warning restore 612, 618
        }
    }
}
