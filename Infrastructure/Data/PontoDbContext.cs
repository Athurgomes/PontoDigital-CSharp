using Microsoft.EntityFrameworkCore;
using SistemaPonto.Models;
//basicamente aqui temos a mesma configuração que eu utilizei na minha api todo
namespace SistemaPonto.Data;

public class PontoDbContext : DbContext//aqui definimos que vamos implementar uma parte
//da DbContext, ou seja, essa função já existe por conta do EFCore
{
    public DbSet<PontoModels> Apontamentos { get; set; }//basicamente o trabalho de gerente, aqui
    //cada linha da minha tabela deve ser tratada como um objeto da minha classe PontoModels
    
    //aqui fica definido qual o banco de dados que vamos usar/iniciar, e em seguida aqueles que forem salvos
    //deverão ir para esse banco também
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = registroPonto.db");
        base.OnConfiguring(optionsBuilder);
    }
}