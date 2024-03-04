﻿// <auto-generated />
using System;
using ELabel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ELabel.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ELabel.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("PixelDensity")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId", "PixelDensity")
                        .IsUnique()
                        .HasFilter("[PixelDensity] IS NOT NULL");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("ELabel.Models.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Allergen")
                        .HasColumnType("bit");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<bool>("Custom")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name", "Category")
                        .IsUnique();

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("ELabel.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kind")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PackagingGases")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<float?>("Volume")
                        .HasColumnType("real");

                    b.Property<float?>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ELabel.Models.ProductIngredient", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IngredientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<short>("Order")
                        .HasColumnType("smallint");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("ProductId", "IngredientId")
                        .IsUnique();

                    b.ToTable("ProductIngredient");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ELabel.Models.Image", b =>
                {
                    b.HasOne("ELabel.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ELabel.Models.Ingredient", b =>
                {
                    b.OwnsOne("ELabel.Models.LocalizableStrings", "LocalizableStrings", b1 =>
                        {
                            b1.Property<Guid>("IngredientId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Bulgarian")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("bg")
                                .HasAnnotation("Relational:JsonPropertyName", "bg");

                            b1.Property<string>("Croatian")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("hr")
                                .HasAnnotation("Relational:JsonPropertyName", "hr");

                            b1.Property<string>("Czech")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("cs")
                                .HasAnnotation("Relational:JsonPropertyName", "cs");

                            b1.Property<string>("Danish")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("da")
                                .HasAnnotation("Relational:JsonPropertyName", "da");

                            b1.Property<string>("Dutch")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("nl")
                                .HasAnnotation("Relational:JsonPropertyName", "nl");

                            b1.Property<string>("English")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("en")
                                .HasAnnotation("Relational:JsonPropertyName", "en");

                            b1.Property<string>("Estonian")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("et")
                                .HasAnnotation("Relational:JsonPropertyName", "et");

                            b1.Property<string>("Finnish")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("fi")
                                .HasAnnotation("Relational:JsonPropertyName", "fi");

                            b1.Property<string>("French")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("fr")
                                .HasAnnotation("Relational:JsonPropertyName", "fr");

                            b1.Property<string>("German")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("de")
                                .HasAnnotation("Relational:JsonPropertyName", "de");

                            b1.Property<string>("Greek")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("el")
                                .HasAnnotation("Relational:JsonPropertyName", "el");

                            b1.Property<string>("Hungarian")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("hu")
                                .HasAnnotation("Relational:JsonPropertyName", "hu");

                            b1.Property<string>("Irish")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("ga")
                                .HasAnnotation("Relational:JsonPropertyName", "ga");

                            b1.Property<string>("Italian")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("it")
                                .HasAnnotation("Relational:JsonPropertyName", "it");

                            b1.Property<string>("Latvian")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("lv")
                                .HasAnnotation("Relational:JsonPropertyName", "lv");

                            b1.Property<string>("Lithuanian")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("lt")
                                .HasAnnotation("Relational:JsonPropertyName", "lt");

                            b1.Property<string>("Maltese")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("mt")
                                .HasAnnotation("Relational:JsonPropertyName", "mt");

                            b1.Property<string>("Polish")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("pl")
                                .HasAnnotation("Relational:JsonPropertyName", "pl");

                            b1.Property<string>("Portuguese")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("pt")
                                .HasAnnotation("Relational:JsonPropertyName", "pt");

                            b1.Property<string>("Romanian")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("ro")
                                .HasAnnotation("Relational:JsonPropertyName", "ro");

                            b1.Property<string>("Slovak")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("sk")
                                .HasAnnotation("Relational:JsonPropertyName", "sk");

                            b1.Property<string>("Slovene")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("sl")
                                .HasAnnotation("Relational:JsonPropertyName", "sl");

                            b1.Property<string>("Spanish")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("es")
                                .HasAnnotation("Relational:JsonPropertyName", "es");

                            b1.Property<string>("Swedish")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("sv")
                                .HasAnnotation("Relational:JsonPropertyName", "sv");

                            b1.HasKey("IngredientId");

                            b1.ToTable("Ingredient");

                            b1.ToJson("LocalizableStrings");

                            b1.WithOwner()
                                .HasForeignKey("IngredientId");
                        });

                    b.Navigation("LocalizableStrings")
                        .IsRequired();
                });

            modelBuilder.Entity("ELabel.Models.Product", b =>
                {
                    b.OwnsOne("ELabel.Models.Certifications", "Certifications", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<bool>("Organic")
                                .HasColumnType("bit");

                            b1.Property<bool>("Vegan")
                                .HasColumnType("bit");

                            b1.Property<bool>("Vegetarian")
                                .HasColumnType("bit");

                            b1.HasKey("ProductId");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ELabel.Models.FoodBusinessOperator", "FoodBusinessOperator", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("AdditionalInfo")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("FBOAdditionalInfo");

                            b1.Property<string>("Address")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("FBOAddress");

                            b1.Property<string>("BusinessName")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("FBOBusinessName");

                            b1.Property<string>("Name")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("FBOName");

                            b1.Property<int>("Type")
                                .HasColumnType("int")
                                .HasColumnName("FBOType");

                            b1.HasKey("ProductId");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ELabel.Models.Logistics", "Logistics", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Country")
                                .HasMaxLength(2)
                                .HasColumnType("nvarchar(2)")
                                .HasColumnName("Country");

                            b1.Property<decimal?>("Ean")
                                .HasColumnType("decimal(20,0)")
                                .HasColumnName("Ean");

                            b1.Property<string>("Sku")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)")
                                .HasColumnName("Sku");

                            b1.HasKey("ProductId");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ELabel.Models.NutritionInformation", "NutritionInformation", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<float>("CarbohydrateSugar")
                                .HasColumnType("real");

                            b1.Property<float>("CarbohydrateTotal")
                                .HasColumnType("real");

                            b1.Property<float>("FatSaturates")
                                .HasColumnType("real");

                            b1.Property<float>("FatTotal")
                                .HasColumnType("real");

                            b1.Property<float>("PortionVolume")
                                .HasColumnType("real");

                            b1.Property<float>("Protein")
                                .HasColumnType("real");

                            b1.Property<float>("Salt")
                                .HasColumnType("real");

                            b1.HasKey("ProductId");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");

                            b1.OwnsOne("ELabel.Models.Energy", "Energy", b2 =>
                                {
                                    b2.Property<Guid>("NutritionInformationProductId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<float>("Kilocalorie")
                                        .HasColumnType("real");

                                    b2.Property<float?>("Kilojoule")
                                        .HasColumnType("real");

                                    b2.HasKey("NutritionInformationProductId");

                                    b2.ToTable("Product");

                                    b2.WithOwner()
                                        .HasForeignKey("NutritionInformationProductId");
                                });

                            b1.Navigation("Energy")
                                .IsRequired();
                        });

                    b.OwnsOne("ELabel.Models.Portability", "Portability", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("ExternalShortUrl")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)")
                                .HasColumnName("ExternalShortUrl");

                            b1.Property<string>("RedirectUrl")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("RedirectUrl");

                            b1.HasKey("ProductId");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ELabel.Models.ResponsibleConsumption", "ResponsibleConsumption", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<bool>("WarningDrinkingBelowLegalAge")
                                .HasColumnType("bit");

                            b1.Property<bool>("WarningDrinkingDuringPregnancy")
                                .HasColumnType("bit");

                            b1.Property<bool>("WarningDrinkingWhenDriving")
                                .HasColumnType("bit");

                            b1.HasKey("ProductId");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ELabel.Models.WineInformation", "WineInformation", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<float?>("Alcohol")
                                .HasColumnType("real")
                                .HasColumnName("WineAlcohol");

                            b1.Property<string>("Appellation")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("WineAppellation");

                            b1.Property<int?>("SugarContent")
                                .HasColumnType("int")
                                .HasColumnName("WineSugarContent");

                            b1.Property<int?>("Type")
                                .HasColumnType("int")
                                .HasColumnName("WineType");

                            b1.Property<int?>("Vintage")
                                .HasColumnType("int")
                                .HasColumnName("WineVintage");

                            b1.HasKey("ProductId");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.Navigation("Certifications")
                        .IsRequired();

                    b.Navigation("FoodBusinessOperator")
                        .IsRequired();

                    b.Navigation("Logistics")
                        .IsRequired();

                    b.Navigation("NutritionInformation")
                        .IsRequired();

                    b.Navigation("Portability")
                        .IsRequired();

                    b.Navigation("ResponsibleConsumption")
                        .IsRequired();

                    b.Navigation("WineInformation")
                        .IsRequired();
                });

            modelBuilder.Entity("ELabel.Models.ProductIngredient", b =>
                {
                    b.HasOne("ELabel.Models.Ingredient", "Ingredient")
                        .WithMany("ProductIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELabel.Models.Product", "Product")
                        .WithMany("ProductIngredients")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ELabel.Models.Ingredient", b =>
                {
                    b.Navigation("ProductIngredients");
                });

            modelBuilder.Entity("ELabel.Models.Product", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("ProductIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
