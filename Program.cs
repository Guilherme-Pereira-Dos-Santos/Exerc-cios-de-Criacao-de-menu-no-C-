string? opcao;


while (true)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção ");
    Console.WriteLine("1- Cadrastar cliente");
    Console.WriteLine("2- Buscar cliente");
    Console.WriteLine("3- Apagar cliente");
    Console.WriteLine("4- Encerrar");

    opcao = Console.ReadLine();
    
    switch (opcao)
    {
        case "1":
        Console.WriteLine("Cadrastar cliente");
        break;

        case "2":
        Console.WriteLine("Buscar cliente");
        break;

        case "3":
        Console.WriteLine("Apagar cliente");
        break;

        case "4":
        Console.WriteLine("Encerrar");
        Environment.Exit(0);
        break;
        
        default:
        Console.WriteLine("Opção invalida");
        break;
    }
}
