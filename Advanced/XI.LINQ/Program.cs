using Microsoft.Extensions.Hosting;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using static System.Console;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace XI.LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HostBuilder builder = new HostBuilder();
            builder
                .ConfigureServices((services) =>
            {
                services.AddSingleton<FoodieConsole>();
                services.AddHostedService<FoodieConsole>();
                services.AddDbContext<FoodieContext>();
            });

            builder.Build().Run();
        }
    }

    public class FoodieContext : DbContext
    {
        public DbSet<FoodItem> FoodItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=localhost\SQLEXpress;Initial Catalog=FoodieCorner;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodItem>()
                .ToTable("FoodItem");


            base.OnModelCreating(modelBuilder);
        }
    }

    public class FoodItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class FoodieConsole : IHostedService
    {
        private readonly FoodieContext _context;

        public FoodieConsole(FoodieContext context)
        {
            this._context = context;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            var foodItems = _context.FoodItems.ToList();

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }

    public class LegacySQL
    {
        public void Run()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXpress;Initial Catalog=FoodieCorner;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM FoodItem", conn);
            var rdr = cmd.ExecuteReader();

            var lstRecords = new List<FoodItem>();
            while (rdr.Read())
            {
                var foodItem = new FoodItem();
                foodItem.Name = rdr["Name"];
                foodItem.Id = Guid.Parse(rdr["Id"]);
                lstRecords.Add(foodItem);
            }
        }
    }
}