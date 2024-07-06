using ApiCrud.Estudantes;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Data;

public class AppDbContext : DbContext {
    public DbSet<Estudante> Estudantes { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Em caso de dúvida consultar "connectionstrings.com"dotnet 
        optionsBuilder.UseSqlite(connectionString:"Data Source=Banco.sqlite");
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        optionsBuilder.EnableSensitiveDataLogging(); //usar só no desenvolvimento... NÃO NA PRODUÇÃO

        base.OnConfiguring(optionsBuilder);
    }
}