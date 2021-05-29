using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniverseDB.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Balance = table.Column<double>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wallets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    IsGame = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    PicturePath = table.Column<string>(nullable: true),
                    DeveloperId = table.Column<Guid>(nullable: false),
                    PublisherId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Developers_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "Developers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    UserIdFK = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    GameId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameGenres",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    GameId = table.Column<Guid>(nullable: false),
                    GenreId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameGenres_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71538667-69c3-49d9-b553-0d375cd0645b", "3c947778-95dd-4230-9c97-0c4c30b2da5e", "admin", "ADMIN" },
                    { "4a10238f-6cd0-4839-a20e-ca5785a31c7a", "10725f09-3bfc-4fe2-8213-ea9853d7db52", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "682ede7d-9ff4-440e-9c39-e434a8f28d75", 0, "c9d14f45-0ec7-4bdf-a641-474c4cb95cd8", "3@gmail.com", true, false, null, "3@gmail.com", "KESHA322", "AQAAAAEAACcQAAAAEAQZXnkPDC3LkUHPTh2sYlkAZMyJvn+HQtz4oqkZYHK8Ua5B1Li9uZbMVGY2axBAAg==", null, false, "", false, "Kesha322" },
                    { "958fcfb8-bf16-401a-86f1-1f247eaa2930", 0, "568a3909-dd76-48d7-a51e-50c1fd8344e0", "1@gmail.com", true, false, null, "1@gmail.com", "VLADOSCHIKINDOS", "AQAAAAEAACcQAAAAEO7xjJEJb+sq6pO7nfgCLkDKlMes+RgolcsJyxsei5pz3x7zITKD5zThXvEAHpPV7Q==", null, false, "", false, "vladoschikindos" },
                    { "a07e901a-1ab8-48e5-bf07-dda2b2c1cde9", 0, "8e28c71f-bb81-4f37-97fc-67aae3a294eb", "2@gmail.com", true, false, null, "2@gmail.com", "KIPR", "AQAAAAEAACcQAAAAEA33YN492AockC4sy9LmhTWxtx8BVI+LtCVJMD6lx4o1pIkE7ta8LMH4qZhcgxc+SA==", null, false, "", false, "kipr" },
                    { "953f010b-fc67-4f75-83a1-27d5bc37bcd3", 0, "32cd8a25-377a-4528-8d0c-8842b6866d27", "0@gmail.com", true, false, null, "0@gmail.com", "ADMIN", "AQAAAAEAACcQAAAAELhNNn0UIqZ9vaAgaaV95QSn0NWH2h9J5s5Xoz1jhD/Ge9umkpehfLQr7cW5Fol5VQ==", null, false, "", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("628e3912-3d6e-4eb8-8a4b-38efe12d6fe6"), "Typhoon" },
                    { new Guid("d921df9e-9dd0-4072-9428-fc6ea4087269"), "Creative Assembly, Feral Interactive" },
                    { new Guid("6b3df09a-3673-43b9-bd2c-2dd4a1b1af02"), "Iron Gate AB" },
                    { new Guid("8afe14c1-a623-48cd-ad6f-4569ddd94c8f"), "Hazelight" },
                    { new Guid("50c6e424-fe36-4ec1-bb5d-a02bc7b3d31e"), "Playground Games" },
                    { new Guid("04ea3a70-6696-4556-ba4a-e9b5aa9462dc"), "Guerrilla" },
                    { new Guid("83700258-e6e9-4d17-bb4d-9ef011c84ee6"), "Stellar Entertainment Limited" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("83302afa-bc65-4e5e-acf7-755c5ea7c43c"), "Экшен" },
                    { new Guid("31b31b58-ca69-42f1-b2ba-7738e6c6b670"), "Приключенческие игры" },
                    { new Guid("8aa92810-73f1-4109-84ef-c553f701f273"), " Ролевые игры" },
                    { new Guid("7361c244-98c1-4e55-83dd-101db54b92b5"), " Гонки" },
                    { new Guid("a97ba28c-7f48-40e9-a051-4a72ba584f18"), "Открытый мир" },
                    { new Guid("ed3e3fa5-8176-4489-a11d-c226651d7a8b"), " Кооператив" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6454648e-d186-4c20-b43e-bffbb621f369"), "SEGA" },
                    { new Guid("45e09bab-85b4-49f5-bdf2-b2d0c098279b"), "PlayStation Mobile, Inc." },
                    { new Guid("84addd5e-752e-4d04-82c5-36b23c5f3366"), "Xbox Game Studios" },
                    { new Guid("656b3e77-7799-40d9-b868-a283fc624d70"), "Electronic Arts" },
                    { new Guid("645785e8-ea3c-4878-9a44-12503d2abc68"), "Coffee Stain Publishing" },
                    { new Guid("65e50120-20ad-4a52-8b4e-e618bb96fbf4"), "505 Games" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "682ede7d-9ff4-440e-9c39-e434a8f28d75", "4a10238f-6cd0-4839-a20e-ca5785a31c7a" },
                    { "958fcfb8-bf16-401a-86f1-1f247eaa2930", "4a10238f-6cd0-4839-a20e-ca5785a31c7a" },
                    { "a07e901a-1ab8-48e5-bf07-dda2b2c1cde9", "4a10238f-6cd0-4839-a20e-ca5785a31c7a" },
                    { "a07e901a-1ab8-48e5-bf07-dda2b2c1cde9", "71538667-69c3-49d9-b553-0d375cd0645b" },
                    { "953f010b-fc67-4f75-83a1-27d5bc37bcd3", "71538667-69c3-49d9-b553-0d375cd0645b" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Cost", "Description", "DeveloperId", "IsGame", "Name", "PicturePath", "PublisherId", "ReleaseDate" },
                values: new object[,]
                {
                    { new Guid("9ef28210-56bc-4747-bb53-72fbf1e79d07"), 25.989999999999998, "Разгадайте тайны Земли будущего, которой правят машины, в легендарном путешествии Элой. Используйте сокрушительные атаки против своих жертв и исследуйте прекрасный открытый мир этой знаменитой ролевой игры!", new Guid("04ea3a70-6696-4556-ba4a-e9b5aa9462dc"), true, "Horizon Zero Dawn™ Complete Edition", "Horizon Zero Dawn™ Complete Edition.jpg", new Guid("45e09bab-85b4-49f5-bdf2-b2d0c098279b"), new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4275112a-c4c5-4102-9f55-57a9cbdbcd7a"), 25.989999999999998, "Отправьтесь в самое безумное путешествие в жизни в игре It Takes Two. Пригласите друга присоединиться бесплатно благодаря версии для друга*, радостно преодолевая многочисленные испытания.", new Guid("8afe14c1-a623-48cd-ad6f-4569ddd94c8f"), true, "It Takes Two", "It Takes Two.jpg", new Guid("45e09bab-85b4-49f5-bdf2-b2d0c098279b"), new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("84cf8582-01c2-4d73-ab51-2dacecc013f1"), 27.989999999999998, "Времена года полностью меняют облик главного автомобильного фестиваля планеты. Исследуйте чудесные пейзажи и исторические достопримечательности Великобритании, путешествуя по открытому миру в одиночку или вместе с другими игроками.", new Guid("50c6e424-fe36-4ec1-bb5d-a02bc7b3d31e"), true, "Forza Horizon 4", "Forza Horizon 4.jpg", new Guid("84addd5e-752e-4d04-82c5-36b23c5f3366"), new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f8550b2-78b1-4dce-a071-d5759725fc03"), 29.989999999999998, "Почувствуйте азарт погони и получите настоящий драйв, гоняйте на самых крутых и мощных машинах мира в Need for Speed™ Hot Pursuit Remastered — невероятном мире захватывающих гонок, где можно состязаться вместе с друзьями.", new Guid("83700258-e6e9-4d17-bb4d-9ef011c84ee6"), true, "Need for Speed™ Hot Pursuit Remastered", "Need for Speed™ Hot Pursuit Remastered.jpg", new Guid("656b3e77-7799-40d9-b868-a283fc624d70"), new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("95316702-2ee2-4bae-9da1-28b2362d86eb"), 10.49, "Игра в жанре выживание, в которой вам предстоит исследовать огромный фэнтезийный мир, пропитанный скандинавской мифологией и культурой викингов.", new Guid("6b3df09a-3673-43b9-bd2c-2dd4a1b1af02"), true, "Valheim", "Valheim.jpg", new Guid("645785e8-ea3c-4878-9a44-12503d2abc68"), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e3352eb-ace3-4e56-aab3-4e039a9d148c"), 23.989999999999998, "Total War: ROME REMASTERED предоставляет вам возможность заново пережить события одной из частей знаменитой серии стратегических игр. Это ставшая классикой игра в разрешении 4К с множеством улучшений графики и игрового процесса.", new Guid("d921df9e-9dd0-4072-9428-fc6ea4087269"), true, "Total War rome remastered", "Total War rome remastered.jpg", new Guid("6454648e-d186-4c20-b43e-bffbb621f369"), new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("216bbc04-7d43-407e-8cc6-944970d42bb6"), 19.989999999999998, "Добро пожаловать в программу «ПЕРВОПРОХОДЕЦ» от «Киндред Аэроспейс», 4-ой по рейтингам компании по исследованию космоса! Твоя задача — определить, пригодна ли планета ARY-26 для жизни. И пусть мы тебя не обучили и не снабдили нужным оборудованием, всё равно удачи!", new Guid("628e3912-3d6e-4eb8-8a4b-38efe12d6fe6"), true, "Journey To The Savage Planet", "Journey To The Savage Planet.jpg", new Guid("65e50120-20ad-4a52-8b4e-e618bb96fbf4"), new DateTime(2021, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "Id", "Balance", "UserId" },
                values: new object[,]
                {
                    { new Guid("838dee2e-63d6-4e02-a9db-66871e2244db"), 48.920000000000002, "682ede7d-9ff4-440e-9c39-e434a8f28d75" },
                    { new Guid("8d8ea1e0-af41-44b0-9351-d26e83c2be3f"), 2.54, "958fcfb8-bf16-401a-86f1-1f247eaa2930" },
                    { new Guid("01ee0337-ac13-4ac5-b045-2d2b8c7155be"), 300.0, "a07e901a-1ab8-48e5-bf07-dda2b2c1cde9" },
                    { new Guid("c86a5f47-3d1f-41ba-ab07-444d621ac222"), 549.53999999999996, "953f010b-fc67-4f75-83a1-27d5bc37bcd3" }
                });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "Id", "GameId", "PurchaseDate", "UserId", "UserIdFK" },
                values: new object[] { new Guid("531e67eb-b5d4-4b7d-b404-3f49daccbb1b"), new Guid("9ef28210-56bc-4747-bb53-72fbf1e79d07"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "682ede7d-9ff4-440e-9c39-e434a8f28d75" });

            migrationBuilder.InsertData(
                table: "GameGenres",
                columns: new[] { "Id", "GameId", "GenreId" },
                values: new object[,]
                {
                    { new Guid("a0565de2-ec97-4159-90ca-9540245ef1d7"), new Guid("9ef28210-56bc-4747-bb53-72fbf1e79d07"), new Guid("83302afa-bc65-4e5e-acf7-755c5ea7c43c") },
                    { new Guid("4709dd14-25c3-430e-a13c-f80a5774f71e"), new Guid("9ef28210-56bc-4747-bb53-72fbf1e79d07"), new Guid("31b31b58-ca69-42f1-b2ba-7738e6c6b670") },
                    { new Guid("b39948bf-6d67-4431-857c-b294bdefcc1f"), new Guid("9ef28210-56bc-4747-bb53-72fbf1e79d07"), new Guid("8aa92810-73f1-4109-84ef-c553f701f273") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_GameId",
                table: "Cart",
                column: "GameId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GameGenres_GameId",
                table: "GameGenres",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameGenres_GenreId",
                table: "GameGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_DeveloperId",
                table: "Games",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_PublisherId",
                table: "Games",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_UserId",
                table: "Wallets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "GameGenres");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Developers");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
