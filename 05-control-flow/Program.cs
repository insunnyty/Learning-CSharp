int wallet = 200;

if (wallet >= 1000)
{
    wallet -= 1000;
    Console.WriteLine($"Parabéns. Você comprou a Espada!");
}
else
{
    Console.WriteLine("Você não tem dinheiro suficiente para comprar a Espada.");
}

Console.WriteLine($"Saldo restante: {wallet}");


