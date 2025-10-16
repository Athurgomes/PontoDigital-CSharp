//em Core/Interfaces/IPontoService.cs
using SistemaPonto.Models;

namespace SistemaPonto.Interfaces;

//aqui temos a definição de quais metodos vamos ter na nossa interface, ou seja 
// vamos registar o ponto, sendo entrada ou saida e também podemos solicitar o 
// historioco daquele colaborador especifico por ID
public interface IPontoServices
{
    PontoModels RegistrarPonto(int colaboradorId, List<PontoModels> registrosAtuais);
    List<PontoModels> ObterApontamentosDoDia(int colaboradorID, List<PontoModels> registrosAtuais);
}