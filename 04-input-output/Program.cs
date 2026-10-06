// Input Nome
Console.Write("Digite o seu nome: ");
string name = Console.ReadLine();

Console.WriteLine($"Olá, {name}! Seja bem-vindo(a)!");

// Input Soma
Console.Write("Digite o seu primeiro número: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o seu segundo número: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A soma de {n1} + {n2} é: {n1 + n2}");
