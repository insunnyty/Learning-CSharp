// && = operador lógico "E" (AND)
int level = 12;
bool hasKey = true;

if (level >= 10 && hasKey)
{
    Console.WriteLine("Você desbloqueou uma nova área!");
}
else
{
    Console.WriteLine("Você não pode acessar esta área.");
}

// || = operador lógico "OU" (OR)
int playerLevel = 5;
bool hasSpecialItem = false;

if (playerLevel >= 10 || hasSpecialItem)
{
    Console.WriteLine("Você pode entrar na arena especial!");
}
else
{
    Console.WriteLine("Você não pode entrar na arena especial.");
}

// '!' = operador lógico "NÃO" (NOT)
bool isDoorLocked = true;

if (!isDoorLocked)
{
    Console.WriteLine("A porta está destrancada. Você pode entrar.");
}
else
{
    Console.WriteLine("A porta está trancada. Você não pode entrar.");
}

// Combinação de operadores lógicos
int playerLevel2 = 20;
string playerClass = "Mago";
bool hasMagicKey = true;
int coins = 50;

if (!playerClass.Equals("Mago") && (playerLevel2 >= 10 && hasMagicKey || coins >= 100))
{
    Console.WriteLine("Você pode acessar a sala secreta!");
}
else
{
    Console.WriteLine("Você não pode acessar a sala secreta.");
}