// Em Infrastructure/Persistence/PontoRepository.cs
using SistemaPonto.Data;
using SistemaPonto.Models;

namespace SistemaPonto.Persistence;

public class PontoRepository
{
    public void addPonto(PontoModels apontamento)
    {
        using (var context = new PontoDbContext())
        {
            context.Apontamentos.Add(apontamento);
            context.SaveChanges();
        }
    }

    public List<PontoModels> ObterTodos()
    {
        using (var context = new PontoDbContext())
        {
            return context.Apontamentos.ToList();
        }
    }
}