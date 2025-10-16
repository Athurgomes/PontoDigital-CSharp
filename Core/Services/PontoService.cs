using SistemaPonto.Models;
using SistemaPonto.Interfaces;

namespace SistemaPonto.Services;
public class PontoService : IPontoServices //aqui estamos definindo que a nossa class PontoServices irá atender os metodos 
{//especificados no IPontoServices
    public PontoModels RegistrarPonto(int colaboradorId, List<PontoModels> registrosAtuais)
    {
        throw new NotImplementedException();
    }
    public List<PontoModels> ObterApontamentosDoDia(int colaboradorID, List<PontoModels> registrosAtuais)
    {
        throw new NotImplementedException();
    }
}