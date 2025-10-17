using SistemaPonto.Models;
using SistemaPonto.Interfaces;

namespace SistemaPonto.Services;
public class PontoService : IPontoServices //aqui estamos definindo que a nossa class PontoServices irá atender os metodos 
{//especificados no IPontoServices

    //basicamente o cerebro da operação, aqui temos o registro do nosso ponto
    public PontoModels RegistrarPonto(int colaboradorId, List<PontoModels> registrosAtuais)
    {
        PontoModels.tipoRegistro tipo;//criamos uma variavel "tipo" sendo o seu tipo ( o que ficou bem redundante) PontoModels.tipoRegistro, ou seja, ela pode assumir apenas o Enum como tipo

        //nosso lastRegistro retorna basicamente o ultimo registro, isso é feito da seguinte forma:
        //primeiro busca na nossa lista usando um operador lambda "x" aquele igual ao ID digitado, depois ordena do mais recente para o mais antigo
        // e então pega o primeiro, que pode ser o ultimo registrou ou se nunca foi registrado então é null
        var lastRegistro = registrosAtuais.Where(x => x.idColaborador == colaboradorId).OrderByDescending(x => x.DataHora).FirstOrDefault();

        //com isso se for null ou o ultimo for saida, então agora será uma entrada
        if (lastRegistro == null || lastRegistro.Tipo == PontoModels.tipoRegistro.Saida)
            tipo = PontoModels.tipoRegistro.Entrada;
        else//casso contrario então é uma saida
            tipo = PontoModels.tipoRegistro.Saida;
        return new PontoModels(colaboradorId, tipo);//por fim retornamos um novo registro de ponto, alocamos mais um registro

    }

    //aqui queremos retornar uma lista dos registros do dia do id especificado
    public List<PontoModels> ObterApontamentosDoDia(int colaboradorID, List<PontoModels> registrosAtuais)
    {
        //ou seja filtra pelo id digitado buscando na lista, em seguida procura somente os do dia/mes/ano atual, e então ordena do mais antigo 
        // até o mais novo, e por fim retorna o resultado em uma lista dos registros daquele colaborador do dia X
        var historyRegistro = registrosAtuais.Where(y => y.idColaborador == colaboradorID && y.DataHora.Date == DateTime.Today).OrderBy(y => y.DataHora).ToList();
        return historyRegistro;
    }
}