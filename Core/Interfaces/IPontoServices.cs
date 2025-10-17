//em Core/Interfaces/IPontoService.cs
using SistemaPonto.Models;

namespace SistemaPonto.Interfaces;

//aqui temos a definição de quais metodos vamos ter na nossa interface, ou seja 
// vamos registar o ponto, sendo entrada ou saida e também podemos solicitar o 
// historioco daquele colaborador especifico por ID
public interface IPontoServices
{
    PontoModels RegistrarPonto(int colaboradorId, List<PontoModels> registrosAtuais);//esse metodo será responsavel por registrar o ponto
    List<PontoModels> ObterApontamentosDoDia(int colaboradorID, List<PontoModels> registrosAtuais);//e esse aqui retorna os registros do dia para 
    //o id que passar a informação
}