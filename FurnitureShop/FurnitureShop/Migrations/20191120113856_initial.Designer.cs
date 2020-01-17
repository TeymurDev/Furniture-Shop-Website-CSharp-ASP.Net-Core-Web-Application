﻿// <auto-generated />
using System;
using FurnitureShop.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FurnitureShop.Migrations
{
    [DbContext(typeof(FurnitureContext))]
    [Migration("20191120113856_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FurnitureShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryImage")
                        .HasMaxLength(300);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, CategoryImage = "bathroom.png", Name = "Bathroom" },
                        new { Id = 2, CategoryImage = "livingroom.png", Name = "Livingroom" },
                        new { Id = 3, CategoryImage = "bedroom.png", Name = "Bedroom" },
                        new { Id = 4, CategoryImage = "kitchen.png", Name = "Kitchen" }
                    );
                });

            modelBuilder.Entity("FurnitureShop.Models.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("FurnitureShop.Models.FurnitureUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTime>("Birthdate");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Firstname")
                        .HasMaxLength(256);

                    b.Property<string>("Lastname")
                        .HasMaxLength(256);

                    b.Property<string>("Livingplace")
                        .HasMaxLength(256);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("FurnitureShop.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MainImage")
                        .HasMaxLength(300);

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");

                    b.HasData(
                        new { Id = 1, MainImage = "product_1.png", ProductId = 1 },
                        new { Id = 2, MainImage = "product_1.png", ProductId = 1 },
                        new { Id = 3, MainImage = "product_1.png", ProductId = 1 },
                        new { Id = 4, MainImage = "product_1.png", ProductId = 1 },
                        new { Id = 5, MainImage = "product_2.png", ProductId = 2 },
                        new { Id = 6, MainImage = "product_2.png", ProductId = 2 },
                        new { Id = 7, MainImage = "product_2.png", ProductId = 2 },
                        new { Id = 8, MainImage = "product_2.png", ProductId = 2 },
                        new { Id = 9, MainImage = "product_3.png", ProductId = 3 },
                        new { Id = 10, MainImage = "product_3.png", ProductId = 3 },
                        new { Id = 11, MainImage = "product_3.png", ProductId = 3 },
                        new { Id = 12, MainImage = "product_3.png", ProductId = 3 },
                        new { Id = 13, MainImage = "product_4.png", ProductId = 4 },
                        new { Id = 14, MainImage = "product_4.png", ProductId = 4 },
                        new { Id = 15, MainImage = "product_4.png", ProductId = 4 },
                        new { Id = 16, MainImage = "product_4.png", ProductId = 4 },
                        new { Id = 17, MainImage = "product_5.png", ProductId = 5 },
                        new { Id = 18, MainImage = "product_5.png", ProductId = 5 },
                        new { Id = 19, MainImage = "product_5.png", ProductId = 5 },
                        new { Id = 20, MainImage = "product_5.png", ProductId = 5 },
                        new { Id = 21, MainImage = "product_6.png", ProductId = 6 },
                        new { Id = 22, MainImage = "product_6.png", ProductId = 6 },
                        new { Id = 23, MainImage = "product_6.png", ProductId = 6 },
                        new { Id = 24, MainImage = "product_6.png", ProductId = 6 },
                        new { Id = 25, MainImage = "product_7.png", ProductId = 7 },
                        new { Id = 26, MainImage = "product_7.png", ProductId = 7 },
                        new { Id = 27, MainImage = "product_7.png", ProductId = 7 },
                        new { Id = 28, MainImage = "product_7.png", ProductId = 7 },
                        new { Id = 29, MainImage = "product_8.png", ProductId = 8 },
                        new { Id = 30, MainImage = "product_8.png", ProductId = 8 },
                        new { Id = 31, MainImage = "product_8.png", ProductId = 8 },
                        new { Id = 32, MainImage = "product_8.png", ProductId = 8 }
                    );
                });

            modelBuilder.Entity("FurnitureShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<decimal>("DiscountedPrice");

                    b.Property<bool>("HasDiscount");

                    b.Property<int>("Height");

                    b.Property<int>("Length");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<decimal>("Price");

                    b.Property<int>("Width");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, CategoryId = 4, DiscountedPrice = 100m, HasDiscount = true, Height = 508, Length = 58, Name = "Green Kitchen Chair", Price = 150m, Width = 128 },
                        new { Id = 2, CategoryId = 4, DiscountedPrice = 90m, HasDiscount = true, Height = 408, Length = 40, Name = "Orange Kitchen Chair", Price = 130m, Width = 118 },
                        new { Id = 3, CategoryId = 4, DiscountedPrice = 80m, HasDiscount = true, Height = 510, Length = 30, Name = "Yellow Kitchen Chair", Price = 100m, Width = 111 },
                        new { Id = 4, CategoryId = 2, DiscountedPrice = 0m, HasDiscount = false, Height = 500, Length = 58, Name = "Livingroom Chair", Price = 250m, Width = 128 },
                        new { Id = 5, CategoryId = 1, DiscountedPrice = 180m, HasDiscount = true, Height = 508, Length = 58, Name = "Comfortable Bathroom Chair", Price = 200m, Width = 128 },
                        new { Id = 6, CategoryId = 3, DiscountedPrice = 0m, HasDiscount = false, Height = 508, Length = 58, Name = "Green Bedroom Chair", Price = 160m, Width = 128 },
                        new { Id = 7, CategoryId = 1, DiscountedPrice = 0m, HasDiscount = false, Height = 508, Length = 58, Name = "Bathroom Chair", Price = 70m, Width = 128 },
                        new { Id = 8, CategoryId = 4, DiscountedPrice = 140m, HasDiscount = true, Height = 508, Length = 58, Name = "Red Kitchen Chair", Price = 170m, Width = 128 }
                    );
                });

            modelBuilder.Entity("FurnitureShop.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId");

                    b.Property<decimal>("Score");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FurnitureShop.Models.Favorite", b =>
                {
                    b.HasOne("FurnitureShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FurnitureShop.Models.FurnitureUser", "FurnitureUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FurnitureShop.Models.Image", b =>
                {
                    b.HasOne("FurnitureShop.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FurnitureShop.Models.Product", b =>
                {
                    b.HasOne("FurnitureShop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FurnitureShop.Models.Rating", b =>
                {
                    b.HasOne("FurnitureShop.Models.Product", "Product")
                        .WithMany("Ratings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FurnitureShop.Models.FurnitureUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FurnitureShop.Models.FurnitureUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FurnitureShop.Models.FurnitureUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FurnitureShop.Models.FurnitureUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
