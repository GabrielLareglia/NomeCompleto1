string nome, sobrenome;
Console.Write("coloque seu nome.......: ");
nome = Console.ReadLine()!;

Console.Write("coloque seu sobrenome..: ");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");