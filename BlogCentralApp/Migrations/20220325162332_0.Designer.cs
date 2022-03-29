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
    [Migration("20220325162332_0")]
    partial class _0
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
                            Date = new DateTime(2022, 3, 24, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(3866),
                            Likes = 1,
                            Title = "BlogPost1"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content2",
                            Date = new DateTime(2022, 3, 23, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4906),
                            Likes = 1,
                            Title = "BlogPost2"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content3",
                            Date = new DateTime(2022, 3, 22, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4941),
                            Likes = 3,
                            Title = "BlogPost3"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content4",
                            Date = new DateTime(2022, 3, 21, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4946),
                            Likes = 1,
                            Title = "BlogPost4"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content5",
                            Date = new DateTime(2022, 3, 20, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4949),
                            Likes = 1,
                            Title = "BlogPost5"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content6",
                            Date = new DateTime(2022, 3, 19, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4953),
                            Likes = 6,
                            Title = "BlogPost6"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content7",
                            Date = new DateTime(2022, 3, 18, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4957),
                            Likes = 1,
                            Title = "BlogPost7"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content8",
                            Date = new DateTime(2022, 3, 17, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4963),
                            Likes = 1,
                            Title = "BlogPost8"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content9",
                            Date = new DateTime(2022, 3, 16, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4966),
                            Likes = 1,
                            Title = "BlogPost9"
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content10",
                            Date = new DateTime(2022, 3, 15, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4970),
                            Likes = 1,
                            Title = "BlogPost10"
                        },
                        new
                        {
                            Id = 11,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content11",
                            Date = new DateTime(2022, 3, 14, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4973),
                            Likes = 1,
                            Title = "BlogPost11"
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content1",
                            Date = new DateTime(2022, 3, 13, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4978),
                            Likes = 1,
                            Title = "BlogPost12"
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content2",
                            Date = new DateTime(2022, 3, 12, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4981),
                            Likes = 1,
                            Title = "BlogPost13"
                        },
                        new
                        {
                            Id = 14,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content3",
                            Date = new DateTime(2022, 3, 11, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4985),
                            Likes = 3,
                            Title = "BlogPost14"
                        },
                        new
                        {
                            Id = 15,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content4",
                            Date = new DateTime(2022, 3, 10, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4989),
                            Likes = 1,
                            Title = "BlogPost15"
                        },
                        new
                        {
                            Id = 16,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content5",
                            Date = new DateTime(2022, 3, 9, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4994),
                            Likes = 1,
                            Title = "BlogPost16"
                        },
                        new
                        {
                            Id = 17,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content6",
                            Date = new DateTime(2022, 3, 8, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(4997),
                            Likes = 6,
                            Title = "BlogPost17"
                        },
                        new
                        {
                            Id = 18,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content7",
                            Date = new DateTime(2022, 3, 7, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(5001),
                            Likes = 1,
                            Title = "BlogPost18"
                        },
                        new
                        {
                            Id = 19,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content8",
                            Date = new DateTime(2022, 3, 6, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(5005),
                            Likes = 1,
                            Title = "BlogPost19"
                        },
                        new
                        {
                            Id = 20,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content9",
                            Date = new DateTime(2022, 3, 5, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(5008),
                            Likes = 1,
                            Title = "BlogPost20"
                        },
                        new
                        {
                            Id = 21,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content10",
                            Date = new DateTime(2022, 3, 4, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(5012),
                            Likes = 1,
                            Title = "BlogPost21"
                        },
                        new
                        {
                            Id = 22,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            Content = "content11",
                            Date = new DateTime(2022, 3, 3, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(5015),
                            Likes = 1,
                            Title = "BlogPost22"
                        },
                        new
                        {
                            Id = 23,
                            AuthorId = "ce8a91ab-41ca-4e08-8cae-40d4cda1a938",
                            Content = "De Japanse regering waarschuwt vandaag voor mogelijke stroomonderbrekingen in de regio van Tokio. Een koudeprik in combinatie met verschillende centrales die er uitliggen na de aardbeving van vorige week zetten het stroomnet er onder druk. De overheden waarschuwen voor mogelijke stroomonderbrekingen dinsdagavond. Twee tot drie miljoen huishoudens dreigen er enkele uren in het donker te zitten.De regering roept gezinnen en bedrijven op deze week zo weinig mogelijk elektriciteit te verbruiken.Door abnormaal koud weer is er veel vraag naar stroom, terwijl de capaciteit krap is. Japan werd vorige week getroffen door een zware aardbeving. Verscheidene thermische centrales liggen als gevolg uit.Het gaat om de eerste waarschuwingen voor black-outs sinds 2011, toen een tsunami een kernramp veroorzaakte in Fukushima.",
                            Date = new DateTime(2022, 3, 25, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(5019),
                            Likes = 10,
                            Title = "Japan waarschuwt voor black-outs in Tokio"
                        },
                        new
                        {
                            Id = 24,
                            AuthorId = "ce8a91ab-41ca-4e08-8cae-40d4cda1a938",
                            Content = "JapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapan",
                            Date = new DateTime(2022, 3, 25, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(5022),
                            Likes = 10,
                            Title = "JapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapanJapan"
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

                    b.Property<int?>("BlogpostId")
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
                            CreationDate = new DateTime(2022, 3, 24, 17, 23, 31, 726, DateTimeKind.Local).AddTicks(409)
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            BlogpostId = 23,
                            Content = "Comment 02",
                            CreationDate = new DateTime(2022, 3, 23, 17, 23, 31, 728, DateTimeKind.Local).AddTicks(1766)
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

            modelBuilder.Entity("BlogCentralLib.Entities.Visit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Views");
                });

            modelBuilder.Entity("BlogCentralLib.Entities.Visitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Visitors");
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

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.Property<int?>("ZipCode")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Author");

                    b.HasData(
                        new
                        {
                            Id = "09f8c9a1-2263-4eb5-8fd9-600ba680b94a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e08bf34a-31f2-404d-af18-cd7aa4b8cf1f",
                            Email = "ibrahim@intec.be",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "IBRAHIM@INTEC.BE",
                            NormalizedUserName = "IBRAHIM",
                            PasswordHash = "AQAAAAEAACcQAAAAEM+WcuyPZf0lh2ajr40YkwFGALonkCmWBqwLrUHQTjV5T6Gmy9mahxdq/I8m8IVamQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "da2788e4-8ca1-4408-b60a-1c4797db18f3",
                            TwoFactorEnabled = false,
                            UserName = "Ibrahim",
                            FirstName = "Ibrahim",
                            ImageUrl = "\\images\\Default.png",
                            LastName = "Awad",
                            Views = 0
                        },
                        new
                        {
                            Id = "ce8a91ab-41ca-4e08-8cae-40d4cda1a938",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d12b8618-66c6-4d7e-9757-fba91e77fff6",
                            Email = "quinten@intec.be",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "QUINTEN@INTEC.BE",
                            NormalizedUserName = "QUINTEN",
                            PasswordHash = "AQAAAAEAACcQAAAAEM+WcuyPZf0lh2ajr40YkwFGALonkCmWBqwLrUHQTjV5T6Gmy9mahxdq/I8m8IVamQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "421296e2-e7bc-4105-9bc8-b14859ea3635",
                            TwoFactorEnabled = false,
                            UserName = "Quinten",
                            FirstName = "Quinten",
                            ImageUrl = "\\images\\Default.png",
                            LastName = "De Clerck",
                            Views = 0
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
                        .WithMany("Comments")
                        .HasForeignKey("AuthorId");

                    b.HasOne("BlogCentralLib.Entities.BlogPost", "BlogPost")
                        .WithMany("Comments")
                        .HasForeignKey("BlogpostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlogCentralLib.Entities.Like", b =>
                {
                    b.HasOne("BlogCentralLib.Entities.Author", "Author")
                        .WithMany("Likes")
                        .HasForeignKey("AuthorId");

                    b.HasOne("BlogCentralLib.Entities.BlogPost", "BlogPost")
                        .WithMany("likes")
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade);
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