namespace SistemaPonto.Models;
public class PontoModels
{
    //utilizamos um enum para limitar o tipo de registro 
    //assim evitando escritas como entrar, entrando, e assim 
    //por diante
    public enum tipoRegistro
    {
        Entrada,
        Saida
    }
    //aqui temos os metodos get set para os dados necessarios
    // de cada colaborador
    public int idColaborador { get; set; }
    public DateTime DataHora { get; set; }
    public tipoRegistro Tipo { get; set; }

    //aqui temos o construtor responsavel pela criação de novos pontos
    // ou seja cada vez que é registado seja saida ou entrada o construtor 
    // será chamado
    public PontoModels(int id, tipoRegistro tipo)
    {
        idColaborador = id;
        Tipo = tipo;
        DataHora = DateTime.Now;//aqui pegamos a data e hora atuais
    }
}