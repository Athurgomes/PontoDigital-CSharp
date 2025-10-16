namespace SistemaPonto.Models;
//utilizamos um enum para limitar o tipo de registro 
//assim evitando escritas como entrar, entrando, e assim 
//por diante
public enum tipoRegistro
{
    Entrada,
    Saida
}

public class Ponto
{
    //aqui temos os metodos get set para os dados necessarios
    // de cada colaborador
    public int idColaborador { get; set; }
    public DateTime DataHora { get; set; }
    public tipoRegistro tipo { get; set; }

    //aqui temos o construtor responsavel pela criação de novos pontos
    // ou seja cada vez que é registado seja saida ou entrada o construtor 
    // será chamado
    public Ponto(int idColaborador, tipoRegistro tipo)
    {
        idColaborador = idColaborador;
        tipo = tipo;
        DataHora = DateTime.Now;//aqui pegamos a data e hora atuais
    }
}