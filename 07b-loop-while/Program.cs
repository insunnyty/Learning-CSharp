int enemyHealth = 100;
int swordDamage = 25;
int axeDamage = 40;

while (enemyHealth > 0)
{
    Console.WriteLine($"Enemy Health: {enemyHealth}");
    Console.Write("Enter damage to deal (1 for sword, 2 for axe): ");
    int choice = Convert.ToInt32(Console.ReadLine());
    int damage = choice == 1 ? swordDamage : axeDamage;

    enemyHealth -= damage;

    if (enemyHealth <= 0)
    {
        Console.WriteLine("Enemy defeated!");
    }
}
