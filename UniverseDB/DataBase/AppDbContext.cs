using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UniverseDB.DataBase.Entities;

namespace UniverseDB.DataBase.Repositories
{
    public class AppDbContext:IdentityDbContext<IdentityUser>// DbContext//
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<GameGenre> GameGenres { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            /////////////////////////Horizon


            modelBuilder.Entity<Publisher>().HasData(new Publisher
            {
                Id = new Guid("45e09bab-85b4-49f5-bdf2-b2d0c098279b"),
                Name = "PlayStation Mobile, Inc."
            });
            modelBuilder.Entity<Developer>().HasData(new Developer
            {
                Id = new Guid("04ea3a70-6696-4556-ba4a-e9b5aa9462dc"),
                Name = "Guerrilla"
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = new Guid("9ef28210-56bc-4747-bb53-72fbf1e79d07"),
                ReleaseDate = new DateTime(2020, 08, 7),
                Name = "Horizon Zero Dawn™ Complete Edition",
                PicturePath = "Horizon Zero Dawn™ Complete Edition.jpg",
                IsGame = true,
                Description = "Разгадайте тайны Земли будущего, которой правят машины," +
                " в легендарном путешествии Элой. Используйте сокрушительные атаки против" +
                " своих жертв и исследуйте прекрасный открытый мир этой знаменитой ролевой игры!",
                Cost = 25.99,
                DeveloperId = new Guid("04ea3a70-6696-4556-ba4a-e9b5aa9462dc"),
                PublisherId = new Guid("45e09bab-85b4-49f5-bdf2-b2d0c098279b")

            });



             ////////////////////Forza 4


            modelBuilder.Entity<Publisher>().HasData(new Publisher
            {
                Id = new Guid("84addd5e-752e-4d04-82c5-36b23c5f3366"),
                Name = "Xbox Game Studios"
            });
            modelBuilder.Entity<Developer>().HasData(new Developer
            {
                Id = new Guid("50c6e424-fe36-4ec1-bb5d-a02bc7b3d31e"),
                Name = "Playground Games"
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = new Guid("84cf8582-01c2-4d73-ab51-2dacecc013f1"),
                ReleaseDate = new DateTime(2021, 03, 9),
                Name = "Forza Horizon 4",
                PicturePath = "Forza Horizon 4.jpg",
                IsGame = true,
                Description = "Времена года полностью меняют облик главного автомобильного фестиваля планеты. " +
                "Исследуйте чудесные пейзажи и исторические достопримечательности Великобритании, путешествуя " +
                "по открытому миру в одиночку или вместе с другими игроками.",
                Cost = 27.99,
                DeveloperId = new Guid("50c6e424-fe36-4ec1-bb5d-a02bc7b3d31e"),
                PublisherId = new Guid("84addd5e-752e-4d04-82c5-36b23c5f3366")

            });



           ///////////////Need for Speed™ Hot Pursuit Remastered


            modelBuilder.Entity<Publisher>().HasData(new Publisher
            {
                Id = new Guid("656b3e77-7799-40d9-b868-a283fc624d70"),
                Name = "Electronic Arts"
            });
            modelBuilder.Entity<Developer>().HasData(new Developer
            {
                Id = new Guid("83700258-e6e9-4d17-bb4d-9ef011c84ee6"),
                Name = "Stellar Entertainment Limited"
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = new Guid("5f8550b2-78b1-4dce-a071-d5759725fc03"),
                ReleaseDate = new DateTime(2020, 06, 11),
                Name = "Need for Speed™ Hot Pursuit Remastered",
                PicturePath = "Need for Speed™ Hot Pursuit Remastered.jpg",
                IsGame = true,
                Description = "Почувствуйте азарт погони и получите настоящий драйв, " +
                "гоняйте на самых крутых и мощных машинах мира в Need for Speed™ " +
                "Hot Pursuit Remastered — невероятном мире захватывающих гонок, где можно состязаться вместе с друзьями.",
                Cost = 29.99,
                DeveloperId = new Guid("83700258-e6e9-4d17-bb4d-9ef011c84ee6"),
                PublisherId = new Guid("656b3e77-7799-40d9-b868-a283fc624d70")

            });





             ///////////////////Valheim



            modelBuilder.Entity<Publisher>().HasData(new Publisher
            {
                Id = new Guid("645785e8-ea3c-4878-9a44-12503d2abc68"),
                Name = "Coffee Stain Publishing"
            });
            modelBuilder.Entity<Developer>().HasData(new Developer
            {
                Id = new Guid("6b3df09a-3673-43b9-bd2c-2dd4a1b1af02"),
                Name = "Iron Gate AB"
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = new Guid("95316702-2ee2-4bae-9da1-28b2362d86eb"),
                ReleaseDate = new DateTime(2021, 02, 2),
                Name = "Valheim",
                PicturePath = "Valheim.jpg",
                IsGame = true,
                Description = "Игра в жанре выживание, в которой вам предстоит исследовать огромный фэнтезийный мир, пропитанный скандинавской мифологией и культурой викингов.",
                Cost = 10.49,
                DeveloperId = new Guid("6b3df09a-3673-43b9-bd2c-2dd4a1b1af02"),
                PublisherId = new Guid("645785e8-ea3c-4878-9a44-12503d2abc68")

            });





            //////////////Total War rome remastered

            modelBuilder.Entity<Publisher>().HasData(new Publisher
            {
                Id = new Guid("6454648e-d186-4c20-b43e-bffbb621f369"),
                Name = "SEGA"
            });
            modelBuilder.Entity<Developer>().HasData(new Developer
            {
                Id = new Guid("d921df9e-9dd0-4072-9428-fc6ea4087269"),
                Name = "Creative Assembly, Feral Interactive"
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = new Guid("9e3352eb-ace3-4e56-aab3-4e039a9d148c"),
                ReleaseDate = new DateTime(2021, 06, 29),
                Name = "Total War rome remastered",
                PicturePath = "Total War rome remastered.jpg",
                IsGame = true,
                Description = "Total War: ROME REMASTERED предоставляет вам возможность" +
                " заново пережить события одной из частей знаменитой серии стратегических игр. " +
                "Это ставшая классикой игра в разрешении 4К с множеством улучшений графики и игрового процесса.",
                Cost = 23.99,
                DeveloperId = new Guid("d921df9e-9dd0-4072-9428-fc6ea4087269"),
                PublisherId = new Guid("6454648e-d186-4c20-b43e-bffbb621f369")

            });




            ////////////////////////Journey To The Savage Planet

            modelBuilder.Entity<Publisher>().HasData(new Publisher
            {
                Id = new Guid("65e50120-20ad-4a52-8b4e-e618bb96fbf4") ,
                Name = "505 Games"
            });
            modelBuilder.Entity<Developer>().HasData(new Developer
            {
                Id = new Guid("628e3912-3d6e-4eb8-8a4b-38efe12d6fe6"),
                Name = "Typhoon"
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = new Guid("216bbc04-7d43-407e-8cc6-944970d42bb6"),
                ReleaseDate = new DateTime(2021, 01, 28),
                Name = "Journey To The Savage Planet",
                PicturePath = "Journey To The Savage Planet.jpg",
                IsGame = true,
                Description = "Добро пожаловать в программу «ПЕРВОПРОХОДЕЦ» от «Киндред Аэроспейс», " +
                "4-ой по рейтингам компании по исследованию космоса! Твоя задача — определить, пригодна" +
                " ли планета ARY-26 для жизни. И пусть мы тебя не обучили и не снабдили нужным оборудованием, всё равно удачи!",
                Cost = 19.99,
                DeveloperId = new Guid("628e3912-3d6e-4eb8-8a4b-38efe12d6fe6") ,
                PublisherId = new Guid("65e50120-20ad-4a52-8b4e-e618bb96fbf4")

            });




            //////////////////////It Takes Two

            //modelBuilder.Entity<Publisher>().HasData(new Publisher
            //{
            //    Id = new Guid("218cf1fc-2a30-4a30-87d0-80c2e2e31d0a"),
            //    Name = "Electronic Arts"
            //});
            modelBuilder.Entity<Developer>().HasData(new Developer
            {
                Id = new Guid("8afe14c1-a623-48cd-ad6f-4569ddd94c8f"),
                Name = "Hazelight"
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = new Guid("4275112a-c4c5-4102-9f55-57a9cbdbcd7a"),
                ReleaseDate = new DateTime(2021, 04, 26),
                Name = "It Takes Two",
                PicturePath = "It Takes Two.jpg",
                IsGame = true,
                Description = "Отправьтесь в самое безумное путешествие в жизни в игре It Takes Two." +
                " Пригласите друга присоединиться бесплатно благодаря версии для друга*, радостно преодолевая многочисленные испытания.",
                Cost = 25.99,
                DeveloperId = new Guid("8afe14c1-a623-48cd-ad6f-4569ddd94c8f"),
                PublisherId = new Guid("45e09bab-85b4-49f5-bdf2-b2d0c098279b")

            });

            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = new Guid("83302afa-bc65-4e5e-acf7-755c5ea7c43c"),
                Name = "Экшен"
            });

            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = new Guid("31b31b58-ca69-42f1-b2ba-7738e6c6b670"),
                Name = "Приключенческие игры"
            });

            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = new Guid("8aa92810-73f1-4109-84ef-c553f701f273"),
                Name = " Ролевые игры"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = new Guid("7361c244-98c1-4e55-83dd-101db54b92b5"),
                Name = " Гонки"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = new Guid("a97ba28c-7f48-40e9-a051-4a72ba584f18"),
                Name = "Открытый мир"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = new Guid("ed3e3fa5-8176-4489-a11d-c226651d7a8b"),
                Name = " Кооператив"
            });



            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "71538667-69c3-49d9-b553-0d375cd0645b",
                Name = "admin",
                NormalizedName="ADMIN"
                
            });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "4a10238f-6cd0-4839-a20e-ca5785a31c7a",
                Name = "user",
                NormalizedName = "USER",
                
            });


            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "682ede7d-9ff4-440e-9c39-e434a8f28d75",
                //RealName = "Инокентий",
                // NickName = "Kesha322",
                UserName = "Kesha322",
                NormalizedUserName = "KESHA322",
                //WalletBalance = 48.92,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password"),
                //CountryId = 1,
                SecurityStamp = string.Empty,
                Email = "3@gmail.com",
                NormalizedEmail = "3@gmail.com",
                EmailConfirmed = true,
            }); 
            

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "958fcfb8-bf16-401a-86f1-1f247eaa2930",
               // RealName = "Vlad",
                //NickName = "VlaDICK",
                UserName = "vladoschikindos",
                NormalizedUserName = "VLADOSCHIKINDOS",
                //WalletBalance = 2.65,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password1"),
                //CountryId = 2,
                SecurityStamp = string.Empty,
                Email = "1@gmail.com",
                NormalizedEmail = "1@gmail.com",
                EmailConfirmed =true,
                

            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "a07e901a-1ab8-48e5-bf07-dda2b2c1cde9",
                //RealName = "Eugeniy",
               // NickName = "NIck",
                UserName = "kipr",
                NormalizedUserName = "KIPR",
                //WalletBalance = 300,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password1"),
                //CountryId = 1,
                SecurityStamp = string.Empty,
                Email = "2@gmail.com",
                NormalizedEmail= "2@gmail.com",
                EmailConfirmed = true

            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "953f010b-fc67-4f75-83a1-27d5bc37bcd3",
                //RealName = "Eugeniy",
                // NickName = "NIck",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                //WalletBalance = 1000,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "qwerty"),
                //CountryId = 1,
                SecurityStamp = string.Empty,
                Email = "0@gmail.com",
                NormalizedEmail = "0@gmail.com",
                EmailConfirmed = true

            });

            modelBuilder.Entity<Wallet>().HasData(new Wallet
            {
                Id = new Guid("838dee2e-63d6-4e02-a9db-66871e2244db"),
                UserId = "682ede7d-9ff4-440e-9c39-e434a8f28d75",
                Balance = 48.92
            });
            modelBuilder.Entity<Wallet>().HasData(new Wallet
            {
                Id = new Guid("8d8ea1e0-af41-44b0-9351-d26e83c2be3f"),
                UserId = "958fcfb8-bf16-401a-86f1-1f247eaa2930",
                Balance = 2.54
            });
            modelBuilder.Entity<Wallet>().HasData(new Wallet
            {
                Id = new Guid("01ee0337-ac13-4ac5-b045-2d2b8c7155be"),
                UserId = "a07e901a-1ab8-48e5-bf07-dda2b2c1cde9",
                Balance = 300
            });
            modelBuilder.Entity<Wallet>().HasData(new Wallet
            {
                Id = new Guid("c86a5f47-3d1f-41ba-ab07-444d621ac222"),
                UserId = "953f010b-fc67-4f75-83a1-27d5bc37bcd3",
                Balance = 549.54
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = "682ede7d-9ff4-440e-9c39-e434a8f28d75",
                RoleId = "4a10238f-6cd0-4839-a20e-ca5785a31c7a"

            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = "958fcfb8-bf16-401a-86f1-1f247eaa2930",
                RoleId = "4a10238f-6cd0-4839-a20e-ca5785a31c7a"

            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = "a07e901a-1ab8-48e5-bf07-dda2b2c1cde9",
                RoleId = "4a10238f-6cd0-4839-a20e-ca5785a31c7a"
            });
             
            ////////         admin

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = "a07e901a-1ab8-48e5-bf07-dda2b2c1cde9",
                RoleId = "71538667-69c3-49d9-b553-0d375cd0645b"

            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = "953f010b-fc67-4f75-83a1-27d5bc37bcd3",
                RoleId = "71538667-69c3-49d9-b553-0d375cd0645b"

            });


            modelBuilder.Entity<GameGenre>().HasData(new GameGenre
            {
                Id = new Guid("a0565de2-ec97-4159-90ca-9540245ef1d7"),
                GameId = new Guid("9ef28210-56bc-4747-bb53-72fbf1e79d07"),
                GenreId = new Guid("83302afa-bc65-4e5e-acf7-755c5ea7c43c")
            });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre
            {
                Id = new Guid("4709dd14-25c3-430e-a13c-f80a5774f71e"),
                GameId = new Guid("9ef28210-56bc-4747-bb53-72fbf1e79d07"),
                GenreId = new Guid("31b31b58-ca69-42f1-b2ba-7738e6c6b670")
            });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre
            {
                Id = new Guid("b39948bf-6d67-4431-857c-b294bdefcc1f"),
                GameId = new Guid("9ef28210-56bc-4747-bb53-72fbf1e79d07"),
                GenreId = new Guid("8aa92810-73f1-4109-84ef-c553f701f273")
            });

            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = new Guid("531e67eb-b5d4-4b7d-b404-3f49daccbb1b"),
                PurchaseDate = new DateTime(2020, 10, 17),
                UserIdFK = "682ede7d-9ff4-440e-9c39-e434a8f28d75",
                GameId = new Guid("9ef28210-56bc-4747-bb53-72fbf1e79d07")
            });


        }

       
    }
}
