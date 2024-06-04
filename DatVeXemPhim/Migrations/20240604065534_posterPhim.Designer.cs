﻿// <auto-generated />
using System;
using DatVeXemPhim.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatVeXemPhim.Migrations
{
    [DbContext(typeof(DatVeXemPhimContext))]
    [Migration("20240604065534_posterPhim")]
    partial class posterPhim
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DatVeXemPhim.Models.Ghe", b =>
                {
                    b.Property<int>("iD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("iD"));

                    b.Property<int>("maPhong")
                        .HasColumnType("int");

                    b.Property<string>("tenGhe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("iD");

                    b.ToTable("Ghe", (string)null);
                });

            modelBuilder.Entity("DatVeXemPhim.Models.KhachHang", b =>
                {
                    b.Property<int>("iD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("iD"));

                    b.Property<string>("eMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("matKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("soDienThoai")
                        .HasColumnType("int");

                    b.Property<string>("taiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("iD");

                    b.ToTable("KhachHang", (string)null);
                });

            modelBuilder.Entity("DatVeXemPhim.Models.NhanVien", b =>
                {
                    b.Property<int>("iD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("iD"));

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hoTen")
                        .IsRequired()
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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("iD");

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("DatVeXemPhim.Models.Phim", b =>
                {
                    b.Property<int>("iD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("iD"));

                    b.Property<string>("daoDien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dienVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ngonNgu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("posterPhim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenPhim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("theLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("thoiGianKhoiChieu")
                        .HasColumnType("datetime2");

                    b.Property<string>("thoiLuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("iD");

                    b.ToTable("Phim", (string)null);
                });

            modelBuilder.Entity("DatVeXemPhim.Models.PhongChieu", b =>
                {
                    b.Property<int>("iD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("iD"));

                    b.Property<string>("tenPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("iD");

                    b.ToTable("PhongChieu", (string)null);
                });

            modelBuilder.Entity("DatVeXemPhim.Models.TheLoaiPhim", b =>
                {
                    b.Property<int>("iD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("iD"));

                    b.Property<string>("tenLoaiPhim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("iD");

                    b.ToTable("TheLoaiPhim", (string)null);
                });

            modelBuilder.Entity("DatVeXemPhim.Models.Ve", b =>
                {
                    b.Property<int>("iD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("iD"));

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

                    b.HasKey("iD");

                    b.ToTable("Ve", (string)null);
                });

            modelBuilder.Entity("DatVeXemPhim.Models.XuatChieu", b =>
                {
                    b.Property<int>("iD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("iD"));

                    b.Property<int>("MaPhim")
                        .HasColumnType("int");

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

                    b.HasKey("iD");

                    b.HasIndex("MaPhim");

                    b.ToTable("XuatChieu", (string)null);
                });

            modelBuilder.Entity("DatVeXemPhim.Models.XuatChieu", b =>
                {
                    b.HasOne("DatVeXemPhim.Models.Phim", "Phim")
                        .WithMany()
                        .HasForeignKey("MaPhim")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Phim");
                });
#pragma warning restore 612, 618
        }
    }
}
