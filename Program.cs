
using SistemaPonto.Services;
using SistemaPonto.Persistence;
using SistemaPonto.Interfaces;

// 1. Crie as instâncias das suas classes (o maestro contratando os músicos)
IPontoServices pontoService = new PontoService();
PontoRepository pontoRepository = new PontoRepository();

Console.WriteLine("Bem-vindo ao Sistema de Ponto!");

while (true)
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("1 - Registrar Ponto");
    Console.WriteLine("2 - Visualizar Registros de Hoje");
    Console.WriteLine("3 - Sair");
    Console.Write("Opção: ");

    string? opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Registrar();
            break;
        case "2":
            Visualizar();
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

void Registrar()
{
    Console.Write("Digite o ID do Colaborador: ");
    if (!int.TryParse(Console.ReadLine(), out int id))
    {
        Console.WriteLine("ID inválido.");
        return;
    }

    // 2. O maestro comanda as ações
    var registrosAtuais = pontoRepository.ObterTodos();
    var novoApontamento = pontoService.RegistrarPonto(id, registrosAtuais);
    pontoRepository.addPonto(novoApontamento);

    Console.WriteLine($"Ponto registrado: {novoApontamento.Tipo} às {novoApontamento.DataHora.ToShortTimeString()}");
}

void Visualizar()
{
    Console.Write("Digite o ID do Colaborador: ");
    if (!int.TryParse(Console.ReadLine(), out int id))
    {
        Console.WriteLine("ID inválido.");
        return;
    }

    var registrosAtuais = pontoRepository.ObterTodos();
    var registrosDoDia = pontoService.ObterApontamentosDoDia(id, registrosAtuais);

    if (!registrosDoDia.Any())
    {
        Console.WriteLine("Nenhum registro encontrado.");
        return;
    }

    foreach (var registro in registrosDoDia)
    {
        Console.WriteLine($"- Tipo: {registro.Tipo}, Horário: {registro.DataHora.ToLongTimeString()}");
    }
}