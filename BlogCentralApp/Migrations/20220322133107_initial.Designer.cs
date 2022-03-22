﻿// <auto-generated />
using System;
using BlogCentralApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogCentralApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220322133107_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogCentralLib.Entities.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("BlogPosts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content1",
                            Date = new DateTime(2022, 3, 21, 14, 31, 6, 947, DateTimeKind.Local).AddTicks(703),
                            Likes = 1,
                            Title = "BlogPost1"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content2",
                            Date = new DateTime(2022, 3, 20, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2159),
                            Likes = 1,
                            Title = "BlogPost2"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content3",
                            Date = new DateTime(2022, 3, 19, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2215),
                            Likes = 3,
                            Title = "BlogPost3"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content4",
                            Date = new DateTime(2022, 3, 18, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2220),
                            Likes = 1,
                            Title = "BlogPost4"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content5",
                            Date = new DateTime(2022, 3, 17, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2223),
                            Likes = 1,
                            Title = "BlogPost5"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content6",
                            Date = new DateTime(2022, 3, 16, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2227),
                            Likes = 6,
                            Title = "BlogPost6"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content7",
                            Date = new DateTime(2022, 3, 15, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2230),
                            Likes = 1,
                            Title = "BlogPost7"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content8",
                            Date = new DateTime(2022, 3, 14, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2234),
                            Likes = 1,
                            Title = "BlogPost8"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content9",
                            Date = new DateTime(2022, 3, 13, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2237),
                            Likes = 1,
                            Title = "BlogPost9"
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content10",
                            Date = new DateTime(2022, 3, 12, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2240),
                            Likes = 1,
                            Title = "BlogPost10"
                        },
                        new
                        {
                            Id = 11,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content11",
                            Date = new DateTime(2022, 3, 11, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2243),
                            Likes = 1,
                            Title = "BlogPost11"
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content1",
                            Date = new DateTime(2022, 3, 10, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2247),
                            Likes = 1,
                            Title = "BlogPost12"
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content2",
                            Date = new DateTime(2022, 3, 9, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2250),
                            Likes = 1,
                            Title = "BlogPost13"
                        },
                        new
                        {
                            Id = 14,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content3",
                            Date = new DateTime(2022, 3, 8, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2253),
                            Likes = 3,
                            Title = "BlogPost14"
                        },
                        new
                        {
                            Id = 15,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content4",
                            Date = new DateTime(2022, 3, 7, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2256),
                            Likes = 1,
                            Title = "BlogPost15"
                        },
                        new
                        {
                            Id = 16,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content5",
                            Date = new DateTime(2022, 3, 6, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2259),
                            Likes = 1,
                            Title = "BlogPost16"
                        },
                        new
                        {
                            Id = 17,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content6",
                            Date = new DateTime(2022, 3, 5, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2262),
                            Likes = 6,
                            Title = "BlogPost17"
                        },
                        new
                        {
                            Id = 18,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content7",
                            Date = new DateTime(2022, 3, 4, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2265),
                            Likes = 1,
                            Title = "BlogPost18"
                        },
                        new
                        {
                            Id = 19,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content8",
                            Date = new DateTime(2022, 3, 3, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2268),
                            Likes = 1,
                            Title = "BlogPost19"
                        },
                        new
                        {
                            Id = 20,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content9",
                            Date = new DateTime(2022, 3, 2, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2271),
                            Likes = 1,
                            Title = "BlogPost20"
                        },
                        new
                        {
                            Id = 21,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content10",
                            Date = new DateTime(2022, 3, 1, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2274),
                            Likes = 1,
                            Title = "BlogPost21"
                        },
                        new
                        {
                            Id = 22,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content11",
                            Date = new DateTime(2022, 2, 28, 14, 31, 6, 950, DateTimeKind.Local).AddTicks(2278),
                            Likes = 1,
                            Title = "BlogPost22"
                        });
                });

            modelBuilder.Entity("BlogCentralLib.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BlogpostId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogpostId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            BlogpostId = 1,
                            Content = "Comment 01"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
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

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BlogCentralLib.Entities.Author", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HouseNumber")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZipCode")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Author");

                    b.HasData(
                        new
                        {
                            Id = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "63723dca-6b6d-4c15-bbc7-0a27af18fc44",
                            Email = "ibrahim@intec.be",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "IBRAHIM@INTEC.BE",
                            NormalizedUserName = "IBRAHIM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKsr1MqvM0HXqZeVnuEo/Vbt0UaqKwPowiZqEfmf/zlld/w4f0euW+K9waDEdCCLQg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8fc8534a-6c5a-44dc-88a8-873c6fd9b254",
                            TwoFactorEnabled = false,
                            UserName = "Ibrahim",
                            FirstName = "Ibrahim",
                            ImageUrl = "\\images\\Default.png",
                            LastName = "Awad"
                        },
                        new
                        {
                            Id = "ce8a91ab-41ca-4e08-8cae-40d4cda1a938",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "48fb643a-b5b2-438f-90c2-199af6979854",
                            Email = "quinten@intec.be",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "QUINTEN@INTEC.BE",
                            NormalizedUserName = "QUINTEN",
                            PasswordHash = "AQAAAAEAACcQAAAAEKsr1MqvM0HXqZeVnuEo/Vbt0UaqKwPowiZqEfmf/zlld/w4f0euW+K9waDEdCCLQg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "93f6201d-8683-407a-bedc-577f0b3b3cea",
                            TwoFactorEnabled = false,
                            UserName = "Quinten",
                            FirstName = "Quinten",
                            ImageUrl = "\\images\\Default.png",
                            LastName = "De Clerck"
                        });
                });

            modelBuilder.Entity("BlogCentralLib.Entities.BlogPost", b =>
                {
                    b.HasOne("BlogCentralLib.Entities.Author", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId");
                });

            modelBuilder.Entity("BlogCentralLib.Entities.Comment", b =>
                {
                    b.HasOne("BlogCentralLib.Entities.BlogPost", null)
                        .WithMany("Comments")
                        .HasForeignKey("BlogpostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
#pragma warning restore 612, 618
        }
    }
}
