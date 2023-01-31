﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230117054942_migrationrefactordb22")]
    partial class migrationrefactordb22
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Abstract.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorizedPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorizedPersonPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxAdministration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Entities.Abstract.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cinsiyet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HesKodu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KimlikNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uyruk")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Entities.Abstract.Ilceler", b =>
                {
                    b.Property<int>("ilceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ilceId"), 1L, 1);

                    b.Property<string>("IlceAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SehirAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SehirId")
                        .HasColumnType("int");

                    b.HasKey("ilceId");

                    b.ToTable("Ilceler");
                });

            modelBuilder.Entity("Entities.Abstract.Log", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tarih")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Entities.Abstract.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descreption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MenuCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MenuCategoryId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Entities.Abstract.MenuCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StyleIcon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MenuCategories");
                });

            modelBuilder.Entity("Entities.Abstract.Price", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EndIlId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndIlceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndtSemtMahId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartIlId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartIlceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartSemtMahId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("VehicleCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("VehicleCategoryId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("Entities.Abstract.PriceCarrier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PriceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TotalPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VehicleCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PriceId");

                    b.HasIndex("VehicleCategoryId");

                    b.ToTable("PriceCarriers");
                });

            modelBuilder.Entity("Entities.Abstract.PriceVehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PriceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VehicleCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PriceId");

                    b.HasIndex("VehicleCategoryId");

                    b.ToTable("PriceVehicles");
                });

            modelBuilder.Entity("Entities.Abstract.Rezervation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ArrivalRoute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarrierId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeparturePoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureRoute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonQuantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Personal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalGsm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PriceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PriceVehicleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReferenceEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ReferenceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("VehicleCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PriceId");

                    b.HasIndex("PriceVehicleId");

                    b.HasIndex("ReferenceId");

                    b.HasIndex("VehicleCategoryId");

                    b.ToTable("Rezervation");
                });

            modelBuilder.Entity("Entities.Abstract.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Entities.Abstract.RoleAuthorization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MenuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleAuthorizations");
                });

            modelBuilder.Entity("Entities.Abstract.Sehirler", b =>
                {
                    b.Property<int>("SehirId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SehirId"), 1L, 1);

                    b.Property<byte>("PlakaNo")
                        .HasColumnType("tinyint");

                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.Property<string>("SehirAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TelefonKodu")
                        .HasColumnType("int");

                    b.HasKey("SehirId");

                    b.ToTable("Sehirler");
                });

            modelBuilder.Entity("Entities.Abstract.SemtMah", b =>
                {
                    b.Property<int>("SemtMahId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SemtMahId"), 1L, 1);

                    b.Property<string>("MahalleAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostaKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SemtAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ilceId")
                        .HasColumnType("int");

                    b.HasKey("SemtMahId");

                    b.ToTable("SemtMah");
                });

            modelBuilder.Entity("Entities.Abstract.Ulkeler", b =>
                {
                    b.Property<int>("UlkeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UlkeId"), 1L, 1);

                    b.Property<string>("IkiliKod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelKodu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UcluKod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UlkeAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UlkeId");

                    b.ToTable("Ulkeler");
                });

            modelBuilder.Entity("Entities.Abstract.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Abstract.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Entities.Abstract.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VehicleBrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VehicleCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VehicleChassis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VehicleModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VehiclePlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleStartKm")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("VehicleBrandId");

                    b.HasIndex("VehicleCategoryId");

                    b.HasIndex("VehicleModelId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Entities.Abstract.VehicleBrand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehicleBrands");
                });

            modelBuilder.Entity("Entities.Abstract.VehicleCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehicleCategories");
                });

            modelBuilder.Entity("Entities.Abstract.VehicleModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("VehicleBrandsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VehicleBrandsId");

                    b.ToTable("VehicleModels");
                });

            modelBuilder.Entity("Entities.Abstract.WebSettingsParam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Arrangement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InputValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Page")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WebSettingsParams");
                });

            modelBuilder.Entity("Entities.Abstract.Menu", b =>
                {
                    b.HasOne("Entities.Abstract.MenuCategory", "MenuCategory")
                        .WithMany("Menus")
                        .HasForeignKey("MenuCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuCategory");
                });

            modelBuilder.Entity("Entities.Abstract.Price", b =>
                {
                    b.HasOne("Entities.Abstract.Company", "Company")
                        .WithMany("Prices")
                        .HasForeignKey("CompanyId");

                    b.HasOne("Entities.Abstract.VehicleCategory", "VehicleCategory")
                        .WithMany()
                        .HasForeignKey("VehicleCategoryId");

                    b.Navigation("Company");

                    b.Navigation("VehicleCategory");
                });

            modelBuilder.Entity("Entities.Abstract.PriceCarrier", b =>
                {
                    b.HasOne("Entities.Abstract.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Abstract.Price", "Price")
                        .WithMany()
                        .HasForeignKey("PriceId");

                    b.HasOne("Entities.Abstract.VehicleCategory", "VehicleCategory")
                        .WithMany("PriceCarriers")
                        .HasForeignKey("VehicleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Price");

                    b.Navigation("VehicleCategory");
                });

            modelBuilder.Entity("Entities.Abstract.PriceVehicle", b =>
                {
                    b.HasOne("Entities.Abstract.Price", "Price")
                        .WithMany()
                        .HasForeignKey("PriceId");

                    b.HasOne("Entities.Abstract.VehicleCategory", "VehicleCategory")
                        .WithMany("PriceVehicles")
                        .HasForeignKey("VehicleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Price");

                    b.Navigation("VehicleCategory");
                });

            modelBuilder.Entity("Entities.Abstract.Rezervation", b =>
                {
                    b.HasOne("Entities.Abstract.Company", "Company")
                        .WithMany("Rezervations")
                        .HasForeignKey("CompanyId");

                    b.HasOne("Entities.Abstract.Customer", "Customer")
                        .WithMany("Rezervations")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Entities.Abstract.Price", "Prices")
                        .WithMany("Rezervations")
                        .HasForeignKey("PriceId");

                    b.HasOne("Entities.Abstract.PriceVehicle", null)
                        .WithMany("Rezervations")
                        .HasForeignKey("PriceVehicleId");

                    b.HasOne("Entities.Abstract.User", "Reference")
                        .WithMany("Rezervations")
                        .HasForeignKey("ReferenceId");

                    b.HasOne("Entities.Abstract.VehicleCategory", "VehicleCategory")
                        .WithMany("Rezervations")
                        .HasForeignKey("VehicleCategoryId");

                    b.Navigation("Company");

                    b.Navigation("Customer");

                    b.Navigation("Prices");

                    b.Navigation("Reference");

                    b.Navigation("VehicleCategory");
                });

            modelBuilder.Entity("Entities.Abstract.RoleAuthorization", b =>
                {
                    b.HasOne("Entities.Abstract.Menu", "Menu")
                        .WithMany("RoleAuthorizations")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Abstract.Role", "Role")
                        .WithMany("RoleAuthorizations")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Entities.Abstract.User", b =>
                {
                    b.HasOne("Entities.Abstract.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Entities.Abstract.UserRole", b =>
                {
                    b.HasOne("Entities.Abstract.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Abstract.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Abstract.Vehicle", b =>
                {
                    b.HasOne("Entities.Abstract.Company", "Companies")
                        .WithMany("Vehicles")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Abstract.VehicleBrand", "VehicleBrands")
                        .WithMany("Vehicles")
                        .HasForeignKey("VehicleBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Abstract.VehicleCategory", "VehicleCategory")
                        .WithMany("Vehicles")
                        .HasForeignKey("VehicleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Abstract.VehicleModel", "VehicleModels")
                        .WithMany("Vehicles")
                        .HasForeignKey("VehicleModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companies");

                    b.Navigation("VehicleBrands");

                    b.Navigation("VehicleCategory");

                    b.Navigation("VehicleModels");
                });

            modelBuilder.Entity("Entities.Abstract.VehicleModel", b =>
                {
                    b.HasOne("Entities.Abstract.VehicleBrand", "VehicleBrands")
                        .WithMany()
                        .HasForeignKey("VehicleBrandsId");

                    b.Navigation("VehicleBrands");
                });

            modelBuilder.Entity("Entities.Abstract.Company", b =>
                {
                    b.Navigation("Prices");

                    b.Navigation("Rezervations");

                    b.Navigation("Users");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Entities.Abstract.Customer", b =>
                {
                    b.Navigation("Rezervations");
                });

            modelBuilder.Entity("Entities.Abstract.Menu", b =>
                {
                    b.Navigation("RoleAuthorizations");
                });

            modelBuilder.Entity("Entities.Abstract.MenuCategory", b =>
                {
                    b.Navigation("Menus");
                });

            modelBuilder.Entity("Entities.Abstract.Price", b =>
                {
                    b.Navigation("Rezervations");
                });

            modelBuilder.Entity("Entities.Abstract.PriceVehicle", b =>
                {
                    b.Navigation("Rezervations");
                });

            modelBuilder.Entity("Entities.Abstract.Role", b =>
                {
                    b.Navigation("RoleAuthorizations");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Entities.Abstract.User", b =>
                {
                    b.Navigation("Rezervations");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Entities.Abstract.VehicleBrand", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Entities.Abstract.VehicleCategory", b =>
                {
                    b.Navigation("PriceCarriers");

                    b.Navigation("PriceVehicles");

                    b.Navigation("Rezervations");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Entities.Abstract.VehicleModel", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}