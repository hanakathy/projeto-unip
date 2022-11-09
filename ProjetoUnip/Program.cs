using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using ProjetoUnip.Data;
using ProjetoUnip.Models;

public class Program
{
    public static void Main(string[] args)
        => CreateHostBuilder(args).Build().Run();

    // EF Core uses this method at design time to access the DbContext
    public static IHostBuilder CreateHostBuilder(string[] args)
        => Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(
                webBuilder => webBuilder.UseStartup<Startup>());
}

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddEntityFrameworkMySQL().AddDbContext<ProjetoUnipContext>(options =>
            options.UseMySQL("server=localhost;port=3306;user=root;password=root;database=projetounip;"));
    }
        
    /*services.AddDbContext<>( options => options.UseMySQL(conexao));
     GetConnectionString("DefaultConnection") */

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
    }
}

public class ProjetoUnipContext : DbContext
{
    public ProjetoUnipContext(DbContextOptions<ProjetoUnipContext> options)
        : base(options) 
    {
    }

    public DbSet<Pessoa> Pessoa { get; set; }
    public DbSet<Endereco> Endereco { get; set; }
    public DbSet<Telefone> Telefone { get; set; }
    public DbSet<TipoTelefone> TipoTelefone { get; set; }
}