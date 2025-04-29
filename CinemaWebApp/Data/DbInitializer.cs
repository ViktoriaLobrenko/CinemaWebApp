using CinemaWebApp.Models;
using CinemaWebApp.Data;


namespace CinemaManagement.Data
{
    public static class DbInitializer
    {
        public static void Seed(CinemaContext context)
        {
            if (context.Movies.Any()) return; 

            // Додавання фільмів
            var movies = new List<Movie>
            {
                new Movie { Title = "Дорама Щастя", Genre = "Драма", Director = "Кiм Джун", Duration = 120, ReleaseYear = 2021, AgeLimit = "16+", Description = "Iсторiя боротьби за виживання в умовах пандемiї." },
                new Movie { Title = "Миша", Genre = "Трилер", Director = "Пак Сон У", Duration = 110, ReleaseYear = 2021, AgeLimit = "18+", Description = "Психологiчний трилер про серiйного вбивцю." },
                new Movie { Title = "Вiнченцо", Genre = "Кримiнал", Director = "Кiм Хi Вон", Duration = 130, ReleaseYear = 2021, AgeLimit = "16+", Description = "Мафiозi повертається в Корею з Iталiї." },
                new Movie { Title = "Завтра", Genre = "Фентезi", Director = "Кiм Те Юн", Duration = 100, ReleaseYear = 2022, AgeLimit = "12+", Description = "Жнець рятує тих, хто хоче вкоротити собi вiку." }
            };
            context.Movies.AddRange(movies);

            // Додавання залів
            var halls = new List<Hall>
            {
                new Hall { Number = 1, SeatCount = 100, Type = HallType.Standard },
                new Hall { Number = 2, SeatCount = 150, Type = HallType.Standard },
                new Hall { Number = 3, SeatCount = 200, Type = HallType.VIP }
            };
            context.Halls.AddRange(halls);
            context.SaveChanges();

            // Додавання сеансів
            var sessions = new List<Session>
            {
                new Session { MovieId = movies[0].Id, HallId = halls[0].Id, StartTime = DateTime.Now.AddHours(2), TicketPrice = 150, Status = SessionStatus.Active},
                new Session { MovieId = movies[1].Id, HallId = halls[1].Id, StartTime = DateTime.Now.AddHours(4), TicketPrice = 180, Status = SessionStatus.Active },
                new Session { MovieId = movies[2].Id, HallId = halls[2].Id, StartTime = DateTime.Now.AddHours(6), TicketPrice = 200, Status = SessionStatus.Active },
                new Session { MovieId = movies[3].Id, HallId = halls[0].Id, StartTime = DateTime.Now.AddHours(8), TicketPrice = 140, Status = SessionStatus.Active }
            };
            context.Sessions.AddRange(sessions);
            context.SaveChanges();

            // Додавання користувачів
            var users = new List<User>
            {
                new User { Name = "Адмiн", Email = "admin@cinema.com", Type = UserType.Admin, BonusPoints = 0 },
                new User { Name = "User", Email = "useh@gmail.com", Type = UserType.Customer, BonusPoints = 50 }
            };
            context.Users.AddRange(users);

            // Додавання знижок
            var discount = new Discount
            {
                Description = "10% знижка для постiйних клiєнтiв",
                Percentage = 10
            };
            context.Discounts.Add(discount);

            context.SaveChanges();

            // Додавання квитків (один придбаний, один заброньований)
            var tickets = new List<Ticket>
            {
                new Ticket { SessionId = sessions[0].Id, SeatNumber = 1, Price = 150, Status = TicketStatus.Purchased },
                new Ticket { SessionId = sessions[0].Id, SeatNumber = 2, Price = 150, Status = TicketStatus.Reserved }
            };
            context.Tickets.AddRange(tickets);

            // Додавання продажів
            var sales = new List<Sale>
            {
                new Sale
                {
                    UserId = users[1].Id,
                    TicketCount = 1,
                    TotalAmount = 150,
                    PurchaseDate = DateTime.Now
                }
            };
            context.Sales.AddRange(sales);

            context.SaveChanges();
        }
    }
}
