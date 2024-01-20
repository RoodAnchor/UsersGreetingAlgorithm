namespace UsersGreetingAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = GetUsers();

            GreetUsers(users);
        }

        static void GreetUsers(List<User> users)
        {
            if (users == null) return;

            foreach(User user in users)
            {
                String greetings = $"Привет, {user.Name}!";

                Console.WriteLine(greetings);

                if (!user.IsPremium) ShowAds();
            }
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        static List<User> GetUsers() =>
            new List<User>()
            {
                new User() { Login = "User1", Name = "Иван", IsPremium = true },
                new User() { Login = "User2", Name = "Сергей", IsPremium = false },
                new User() { Login = "User3", Name = "Андрей", IsPremium = false },
                new User() { Login = "User4", Name = "Александр", IsPremium = true },
                new User() { Login = "User5", Name = "Евгений", IsPremium = false },
            };
    }
}