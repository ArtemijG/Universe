﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniverseDB.DataBase.Repositories;

namespace UniverseDB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210517152240_a")]
    partial class a
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.HasData(
                        new
                        {
                            Id = "71538667-69c3-49d9-b553-0d375cd0645b",
                            ConcurrencyStamp = "3c947778-95dd-4230-9c97-0c4c30b2da5e",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "4a10238f-6cd0-4839-a20e-ca5785a31c7a",
                            ConcurrencyStamp = "10725f09-3bfc-4fe2-8213-ea9853d7db52",
                            Name = "user",
                            NormalizedName = "USER"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = "682ede7d-9ff4-440e-9c39-e434a8f28d75",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c9d14f45-0ec7-4bdf-a641-474c4cb95cd8",
                            Email = "3@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "3@gmail.com",
                            NormalizedUserName = "KESHA322",
                            PasswordHash = "AQAAAAEAACcQAAAAEAQZXnkPDC3LkUHPTh2sYlkAZMyJvn+HQtz4oqkZYHK8Ua5B1Li9uZbMVGY2axBAAg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Kesha322"
                        },
                        new
                        {
                            Id = "958fcfb8-bf16-401a-86f1-1f247eaa2930",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "568a3909-dd76-48d7-a51e-50c1fd8344e0",
                            Email = "1@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "1@gmail.com",
                            NormalizedUserName = "VLADOSCHIKINDOS",
                            PasswordHash = "AQAAAAEAACcQAAAAEO7xjJEJb+sq6pO7nfgCLkDKlMes+RgolcsJyxsei5pz3x7zITKD5zThXvEAHpPV7Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "vladoschikindos"
                        },
                        new
                        {
                            Id = "a07e901a-1ab8-48e5-bf07-dda2b2c1cde9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8e28c71f-bb81-4f37-97fc-67aae3a294eb",
                            Email = "2@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "2@gmail.com",
                            NormalizedUserName = "KIPR",
                            PasswordHash = "AQAAAAEAACcQAAAAEA33YN492AockC4sy9LmhTWxtx8BVI+LtCVJMD6lx4o1pIkE7ta8LMH4qZhcgxc+SA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "kipr"
                        },
                        new
                        {
                            Id = "953f010b-fc67-4f75-83a1-27d5bc37bcd3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "32cd8a25-377a-4528-8d0c-8842b6866d27",
                            Email = "0@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "0@gmail.com",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAELhNNn0UIqZ9vaAgaaV95QSn0NWH2h9J5s5Xoz1jhD/Ge9umkpehfLQr7cW5Fol5VQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = "682ede7d-9ff4-440e-9c39-e434a8f28d75",
                            RoleId = "4a10238f-6cd0-4839-a20e-ca5785a31c7a"
                        },
                        new
                        {
                            UserId = "958fcfb8-bf16-401a-86f1-1f247eaa2930",
                            RoleId = "4a10238f-6cd0-4839-a20e-ca5785a31c7a"
                        },
                        new
                        {
                            UserId = "a07e901a-1ab8-48e5-bf07-dda2b2c1cde9",
                            RoleId = "4a10238f-6cd0-4839-a20e-ca5785a31c7a"
                        },
                        new
                        {
                            UserId = "a07e901a-1ab8-48e5-bf07-dda2b2c1cde9",
                            RoleId = "71538667-69c3-49d9-b553-0d375cd0645b"
                        },
                        new
                        {
                            UserId = "953f010b-fc67-4f75-83a1-27d5bc37bcd3",
                            RoleId = "71538667-69c3-49d9-b553-0d375cd0645b"
                        });
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

            modelBuilder.Entity("UniverseDB.DataBase.Entities.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserIdFK")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Cart");

                    b.HasData(
                        new
                        {
                            Id = new Guid("531e67eb-b5d4-4b7d-b404-3f49daccbb1b"),
                            GameId = new Guid("9ef28210-56bc-4747-bb53-72fbf1e79d07"),
                            PurchaseDate = new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserIdFK = "682ede7d-9ff4-440e-9c39-e434a8f28d75"
                        });
                });

            modelBuilder.Entity("UniverseDB.DataBase.Entities.Developer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Developers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("04ea3a70-6696-4556-ba4a-e9b5aa9462dc"),
                            Name = "Guerrilla"
                        },
                        new
                        {
                            Id = new Guid("50c6e424-fe36-4ec1-bb5d-a02bc7b3d31e"),
                            Name = "Playground Games"
                        },
                        new
                        {
                            Id = new Guid("83700258-e6e9-4d17-bb4d-9ef011c84ee6"),
                            Name = "Stellar Entertainment Limited"
                        },
                        new
                        {
                            Id = new Guid("6b3df09a-3673-43b9-bd2c-2dd4a1b1af02"),
                            Name = "Iron Gate AB"
                        },
                        new
                        {
                            Id = new Guid("d921df9e-9dd0-4072-9428-fc6ea4087269"),
                            Name = "Creative Assembly, Feral Interactive"
                        },
                        new
                        {
                            Id = new Guid("628e3912-3d6e-4eb8-8a4b-38efe12d6fe6"),
                            Name = "Typhoon"
                        },
                        new
                        {
                            Id = new Guid("8afe14c1-a623-48cd-ad6f-4569ddd94c8f"),
                            Name = "Hazelight"
                        });
                });

            modelBuilder.Entity("UniverseDB.DataBase.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DeveloperId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsGame")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicturePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PublisherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9ef28210-56bc-4747-bb53-72fbf1e79d07"),
                            Cost = 25.989999999999998,
                            Description = "Разгадайте тайны Земли будущего, которой правят машины, в легендарном путешествии Элой. Используйте сокрушительные атаки против своих жертв и исследуйте прекрасный открытый мир этой знаменитой ролевой игры!",
                            DeveloperId = new Guid("04ea3a70-6696-4556-ba4a-e9b5aa9462dc"),
                            IsGame = true,
                            Name = "Horizon Zero Dawn™ Complete Edition",
                            PicturePath = "Horizon Zero Dawn™ Complete Edition.jpg",
                            PublisherId = new Guid("45e09bab-85b4-49f5-bdf2-b2d0c098279b"),
                            ReleaseDate = new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("84cf8582-01c2-4d73-ab51-2dacecc013f1"),
                            Cost = 27.989999999999998,
                            Description = "Времена года полностью меняют облик главного автомобильного фестиваля планеты. Исследуйте чудесные пейзажи и исторические достопримечательности Великобритании, путешествуя по открытому миру в одиночку или вместе с другими игроками.",
                            DeveloperId = new Guid("50c6e424-fe36-4ec1-bb5d-a02bc7b3d31e"),
                            IsGame = true,
                            Name = "Forza Horizon 4",
                            PicturePath = "Forza Horizon 4.jpg",
                            PublisherId = new Guid("84addd5e-752e-4d04-82c5-36b23c5f3366"),
                            ReleaseDate = new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("5f8550b2-78b1-4dce-a071-d5759725fc03"),
                            Cost = 29.989999999999998,
                            Description = "Почувствуйте азарт погони и получите настоящий драйв, гоняйте на самых крутых и мощных машинах мира в Need for Speed™ Hot Pursuit Remastered — невероятном мире захватывающих гонок, где можно состязаться вместе с друзьями.",
                            DeveloperId = new Guid("83700258-e6e9-4d17-bb4d-9ef011c84ee6"),
                            IsGame = true,
                            Name = "Need for Speed™ Hot Pursuit Remastered",
                            PicturePath = "Need for Speed™ Hot Pursuit Remastered.jpg",
                            PublisherId = new Guid("656b3e77-7799-40d9-b868-a283fc624d70"),
                            ReleaseDate = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("95316702-2ee2-4bae-9da1-28b2362d86eb"),
                            Cost = 10.49,
                            Description = "Игра в жанре выживание, в которой вам предстоит исследовать огромный фэнтезийный мир, пропитанный скандинавской мифологией и культурой викингов.",
                            DeveloperId = new Guid("6b3df09a-3673-43b9-bd2c-2dd4a1b1af02"),
                            IsGame = true,
                            Name = "Valheim",
                            PicturePath = "Valheim.jpg",
                            PublisherId = new Guid("645785e8-ea3c-4878-9a44-12503d2abc68"),
                            ReleaseDate = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("9e3352eb-ace3-4e56-aab3-4e039a9d148c"),
                            Cost = 23.989999999999998,
                            Description = "Total War: ROME REMASTERED предоставляет вам возможность заново пережить события одной из частей знаменитой серии стратегических игр. Это ставшая классикой игра в разрешении 4К с множеством улучшений графики и игрового процесса.",
                            DeveloperId = new Guid("d921df9e-9dd0-4072-9428-fc6ea4087269"),
                            IsGame = true,
                            Name = "Total War rome remastered",
                            PicturePath = "Total War rome remastered.jpg",
                            PublisherId = new Guid("6454648e-d186-4c20-b43e-bffbb621f369"),
                            ReleaseDate = new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("216bbc04-7d43-407e-8cc6-944970d42bb6"),
                            Cost = 19.989999999999998,
                            Description = "Добро пожаловать в программу «ПЕРВОПРОХОДЕЦ» от «Киндред Аэроспейс», 4-ой по рейтингам компании по исследованию космоса! Твоя задача — определить, пригодна ли планета ARY-26 для жизни. И пусть мы тебя не обучили и не снабдили нужным оборудованием, всё равно удачи!",
                            DeveloperId = new Guid("628e3912-3d6e-4eb8-8a4b-38efe12d6fe6"),
                            IsGame = true,
                            Name = "Journey To The Savage Planet",
                            PicturePath = "Journey To The Savage Planet.jpg",
                            PublisherId = new Guid("65e50120-20ad-4a52-8b4e-e618bb96fbf4"),
                            ReleaseDate = new DateTime(2021, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("4275112a-c4c5-4102-9f55-57a9cbdbcd7a"),
                            Cost = 25.989999999999998,
                            Description = "Отправьтесь в самое безумное путешествие в жизни в игре It Takes Two. Пригласите друга присоединиться бесплатно благодаря версии для друга*, радостно преодолевая многочисленные испытания.",
                            DeveloperId = new Guid("8afe14c1-a623-48cd-ad6f-4569ddd94c8f"),
                            IsGame = true,
                            Name = "It Takes Two",
                            PicturePath = "It Takes Two.jpg",
                            PublisherId = new Guid("45e09bab-85b4-49f5-bdf2-b2d0c098279b"),
                            ReleaseDate = new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("UniverseDB.DataBase.Entities.GameGenre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("GenreId");

                    b.ToTable("GameGenres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a0565de2-ec97-4159-90ca-9540245ef1d7"),
                            GameId = new Guid("9ef28210-56bc-4747-bb53-72fbf1e79d07"),
                            GenreId = new Guid("83302afa-bc65-4e5e-acf7-755c5ea7c43c")
                        },
                        new
                        {
                            Id = new Guid("4709dd14-25c3-430e-a13c-f80a5774f71e"),
                            GameId = new Guid("9ef28210-56bc-4747-bb53-72fbf1e79d07"),
                            GenreId = new Guid("31b31b58-ca69-42f1-b2ba-7738e6c6b670")
                        },
                        new
                        {
                            Id = new Guid("b39948bf-6d67-4431-857c-b294bdefcc1f"),
                            GameId = new Guid("9ef28210-56bc-4747-bb53-72fbf1e79d07"),
                            GenreId = new Guid("8aa92810-73f1-4109-84ef-c553f701f273")
                        });
                });

            modelBuilder.Entity("UniverseDB.DataBase.Entities.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("83302afa-bc65-4e5e-acf7-755c5ea7c43c"),
                            Name = "Экшен"
                        },
                        new
                        {
                            Id = new Guid("31b31b58-ca69-42f1-b2ba-7738e6c6b670"),
                            Name = "Приключенческие игры"
                        },
                        new
                        {
                            Id = new Guid("8aa92810-73f1-4109-84ef-c553f701f273"),
                            Name = " Ролевые игры"
                        },
                        new
                        {
                            Id = new Guid("7361c244-98c1-4e55-83dd-101db54b92b5"),
                            Name = " Гонки"
                        },
                        new
                        {
                            Id = new Guid("a97ba28c-7f48-40e9-a051-4a72ba584f18"),
                            Name = "Открытый мир"
                        },
                        new
                        {
                            Id = new Guid("ed3e3fa5-8176-4489-a11d-c226651d7a8b"),
                            Name = " Кооператив"
                        });
                });

            modelBuilder.Entity("UniverseDB.DataBase.Entities.Publisher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("45e09bab-85b4-49f5-bdf2-b2d0c098279b"),
                            Name = "PlayStation Mobile, Inc."
                        },
                        new
                        {
                            Id = new Guid("84addd5e-752e-4d04-82c5-36b23c5f3366"),
                            Name = "Xbox Game Studios"
                        },
                        new
                        {
                            Id = new Guid("656b3e77-7799-40d9-b868-a283fc624d70"),
                            Name = "Electronic Arts"
                        },
                        new
                        {
                            Id = new Guid("645785e8-ea3c-4878-9a44-12503d2abc68"),
                            Name = "Coffee Stain Publishing"
                        },
                        new
                        {
                            Id = new Guid("6454648e-d186-4c20-b43e-bffbb621f369"),
                            Name = "SEGA"
                        },
                        new
                        {
                            Id = new Guid("65e50120-20ad-4a52-8b4e-e618bb96fbf4"),
                            Name = "505 Games"
                        });
                });

            modelBuilder.Entity("UniverseDB.DataBase.Entities.Wallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Wallets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("838dee2e-63d6-4e02-a9db-66871e2244db"),
                            Balance = 48.920000000000002,
                            UserId = "682ede7d-9ff4-440e-9c39-e434a8f28d75"
                        },
                        new
                        {
                            Id = new Guid("8d8ea1e0-af41-44b0-9351-d26e83c2be3f"),
                            Balance = 2.54,
                            UserId = "958fcfb8-bf16-401a-86f1-1f247eaa2930"
                        },
                        new
                        {
                            Id = new Guid("01ee0337-ac13-4ac5-b045-2d2b8c7155be"),
                            Balance = 300.0,
                            UserId = "a07e901a-1ab8-48e5-bf07-dda2b2c1cde9"
                        },
                        new
                        {
                            Id = new Guid("c86a5f47-3d1f-41ba-ab07-444d621ac222"),
                            Balance = 549.53999999999996,
                            UserId = "953f010b-fc67-4f75-83a1-27d5bc37bcd3"
                        });
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

            modelBuilder.Entity("UniverseDB.DataBase.Entities.Cart", b =>
                {
                    b.HasOne("UniverseDB.DataBase.Entities.Game", "Game")
                        .WithOne("Cart")
                        .HasForeignKey("UniverseDB.DataBase.Entities.Cart", "GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("UniverseDB.DataBase.Entities.Game", b =>
                {
                    b.HasOne("UniverseDB.DataBase.Entities.Developer", "Developer")
                        .WithMany("Games")
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniverseDB.DataBase.Entities.Publisher", "Publisher")
                        .WithMany("Games")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniverseDB.DataBase.Entities.GameGenre", b =>
                {
                    b.HasOne("UniverseDB.DataBase.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniverseDB.DataBase.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniverseDB.DataBase.Entities.Wallet", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
