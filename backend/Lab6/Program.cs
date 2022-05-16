using Microsoft.AspNetCore;

namespace Lab6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program.BuildWebHost(args).MigrateDatabase().Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
