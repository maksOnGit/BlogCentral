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
    [Migration("20220327201109_InitialMigration")]
    partial class InitialMigration
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
                            Date = new DateTime(2022, 3, 26, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(3417),
                            Likes = 1,
                            Title = "BlogPost1"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content2",
                            Date = new DateTime(2022, 3, 25, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4239),
                            Likes = 1,
                            Title = "BlogPost2"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content3",
                            Date = new DateTime(2022, 3, 24, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4271),
                            Likes = 3,
                            Title = "BlogPost3"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content4",
                            Date = new DateTime(2022, 3, 23, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4277),
                            Likes = 1,
                            Title = "BlogPost4"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content5",
                            Date = new DateTime(2022, 3, 22, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4282),
                            Likes = 1,
                            Title = "BlogPost5"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content6",
                            Date = new DateTime(2022, 3, 21, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4286),
                            Likes = 6,
                            Title = "BlogPost6"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content7",
                            Date = new DateTime(2022, 3, 20, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4291),
                            Likes = 1,
                            Title = "BlogPost7"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content8",
                            Date = new DateTime(2022, 3, 19, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4295),
                            Likes = 1,
                            Title = "BlogPost8"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content9",
                            Date = new DateTime(2022, 3, 18, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4300),
                            Likes = 1,
                            Title = "BlogPost9"
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content10",
                            Date = new DateTime(2022, 3, 17, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4304),
                            Likes = 1,
                            Title = "BlogPost10"
                        },
                        new
                        {
                            Id = 11,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content11",
                            Date = new DateTime(2022, 3, 16, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4308),
                            Likes = 1,
                            Title = "BlogPost11"
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content1",
                            Date = new DateTime(2022, 3, 15, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4314),
                            Likes = 1,
                            Title = "BlogPost12"
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content2",
                            Date = new DateTime(2022, 3, 14, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4319),
                            Likes = 1,
                            Title = "BlogPost13"
                        },
                        new
                        {
                            Id = 14,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content3",
                            Date = new DateTime(2022, 3, 13, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4323),
                            Likes = 3,
                            Title = "BlogPost14"
                        },
                        new
                        {
                            Id = 15,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content4",
                            Date = new DateTime(2022, 3, 12, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4327),
                            Likes = 1,
                            Title = "BlogPost15"
                        },
                        new
                        {
                            Id = 16,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content5",
                            Date = new DateTime(2022, 3, 11, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4332),
                            Likes = 1,
                            Title = "BlogPost16"
                        },
                        new
                        {
                            Id = 17,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content6",
                            Date = new DateTime(2022, 3, 10, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4336),
                            Likes = 6,
                            Title = "BlogPost17"
                        },
                        new
                        {
                            Id = 18,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content7",
                            Date = new DateTime(2022, 3, 9, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4340),
                            Likes = 1,
                            Title = "BlogPost18"
                        },
                        new
                        {
                            Id = 19,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content8",
                            Date = new DateTime(2022, 3, 8, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4344),
                            Likes = 1,
                            Title = "BlogPost19"
                        },
                        new
                        {
                            Id = 20,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content9",
                            Date = new DateTime(2022, 3, 7, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4349),
                            Likes = 1,
                            Title = "BlogPost20"
                        },
                        new
                        {
                            Id = 21,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content10",
                            Date = new DateTime(2022, 3, 6, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4353),
                            Likes = 1,
                            Title = "BlogPost21"
                        },
                        new
                        {
                            Id = 22,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content11",
                            Date = new DateTime(2022, 3, 5, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4357),
                            Likes = 1,
                            Title = "BlogPost22"
                        },
                        new
                        {
                            Id = 23,
                            AuthorId = "ce8a91ab-41ca-4e08-8cae-40d4cda1a938",
                            Content = "De Japanse regering waarschuwt vandaag voor mogelijke stroomonderbrekingen in de regio van Tokio. Een koudeprik in combinatie met verschillende centrales die er uitliggen na de aardbeving van vorige week zetten het stroomnet er onder druk. De overheden waarschuwen voor mogelijke stroomonderbrekingen dinsdagavond. Twee tot drie miljoen huishoudens dreigen er enkele uren in het donker te zitten.De regering roept gezinnen en bedrijven op deze week zo weinig mogelijk elektriciteit te verbruiken.Door abnormaal koud weer is er veel vraag naar stroom, terwijl de capaciteit krap is. Japan werd vorige week getroffen door een zware aardbeving. Verscheidene thermische centrales liggen als gevolg uit.Het gaat om de eerste waarschuwingen voor black-outs sinds 2011, toen een tsunami een kernramp veroorzaakte in Fukushima.",
                            Date = new DateTime(2022, 3, 27, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(4362),
                            Likes = 10,
                            Title = "Japan waarschuwt voor black-outs in Tokio"
                        });
                });

            modelBuilder.Entity("BlogCentralLib.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BlogpostId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BlogpostId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            BlogpostId = 23,
                            Content = "Comment 01",
                            CreationDate = new DateTime(2022, 3, 26, 22, 11, 7, 738, DateTimeKind.Local).AddTicks(7684)
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            BlogpostId = 23,
                            Content = "Comment 02",
                            CreationDate = new DateTime(2022, 3, 25, 22, 11, 7, 743, DateTimeKind.Local).AddTicks(1375)
                        });
                });

            modelBuilder.Entity("BlogCentralLib.Entities.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("BlogPostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BlogPostId");

                    b.ToTable("Likes");
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
                            ConcurrencyStamp = "fe402905-c52a-4056-b561-f92c656a3a2e",
                            Email = "ibrahim@intec.be",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "IBRAHIM@INTEC.BE",
                            NormalizedUserName = "IBRAHIM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHAu2LHW6X6ksG8Y3aXR5bMhwy1OnUK88x8U63mwTOuxRn376bJkJ3N7uHKDgTUVpQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5615f4c5-ea75-44cc-a164-c607b2a8e0ed",
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
                            ConcurrencyStamp = "1eabebf2-8caa-49a4-8e4a-d9305e91e474",
                            Email = "quinten@intec.be",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "QUINTEN@INTEC.BE",
                            NormalizedUserName = "QUINTEN",
                            PasswordHash = "AQAAAAEAACcQAAAAEHAu2LHW6X6ksG8Y3aXR5bMhwy1OnUK88x8U63mwTOuxRn376bJkJ3N7uHKDgTUVpQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7bff7eb3-d353-4f9c-baef-657bcea1687b",
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
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlogCentralLib.Entities.Comment", b =>
                {
                    b.HasOne("BlogCentralLib.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("BlogCentralLib.Entities.BlogPost", null)
                        .WithMany("Comments")
                        .HasForeignKey("BlogpostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogCentralLib.Entities.Like", b =>
                {
                    b.HasOne("BlogCentralLib.Entities.Author", "Author")
                        .WithMany("Likes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlogCentralLib.Entities.BlogPost", "BlogPost")
                        .WithMany("likes")
                        .HasForeignKey("BlogPostId");
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
