// Em Infrastructure/Persistence/PontoRepository.cs
using SistemaPonto.Data;
using SistemaPonto.Models;

namespace SistemaPonto.Persistence;

public class PontoRepository
{
    //basicamente a lógica para salvar no banco de dados
    public void addPonto(PontoModels apontamento)
    {
        using (var context = new PontoDbContext())
        {
            context.Apontamentos.Add(apontamento);
            context.SaveChanges();
        }
    }

    //e aqui temos a lógica para obter todos os registro, mas no caso no PontoService temos a especificação do tempo
    // e no caso seria os do dia, assim no Program temos essa iteração buscando especificamente os do dia
    public List<PontoModels> ObterTodos()
    {
        using (var context = new PontoDbContext())
        {
            return context.Apontamentos.ToList();
        }
    }
}