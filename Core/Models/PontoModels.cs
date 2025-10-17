namespace SistemaPonto.Models;
public class PontoModels
{
    public PontoModels() { }//construtor vazio para iniciar o EF, pois tive problemas ao tentar iniciar meu ef migrations
    
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

     public Guid Id { get; init; }//será nossa primary key

    //aqui temos o construtor responsavel pela criação de novos pontos
    // ou seja cada vez que é registado seja saida ou entrada o construtor 
    // será chamado
    public PontoModels(int colaboradorID, tipoRegistro tipo)
    {
        Id = Guid.NewGuid();//estou utilizando a mesma abordagem que utilizei na minha api, aqui ele retorna um id aleadorio de 
        //128bits
        idColaborador = colaboradorID;
        Tipo = tipo;
        DataHora = DateTime.Now;//aqui pegamos a data e hora atuais
    }
}