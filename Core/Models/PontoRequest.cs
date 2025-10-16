namespace SistemaPonto.Models;
public record PontoRequest(int idColaborador, PontoModels.tipoRegistro tipo);//metodo DTO para requisições da minha API
// o famoso carteiro que pega as requisições do front end e leva para a api que conversa com o backend