// A) Crie um programa C# que faça as operações de soma, subtração, multiplicação e divisão de dois números reais(float) e mostre os resultados no console.

/*float nr1 = 10f;
float nr2 = 3.25f;

float sum = nr1 + nr2;
float sub = nr1 - nr2;
float mult = nr1 * nr2;
float div = nr1 / nr2;

Console.WriteLine($"Soma: {sum}");
Console.WriteLine($"Subtração: {sub}");
Console.WriteLine($"Multiplicação: {mult}");
Console.WriteLine($"Divisão: {div}");*/

//B) Crie um programa que mostre a tabuada de um numero no console. Você presa definir a variável com o número que será utilizado para a tabuada e multiplicá-lo por números de 1 a 10, mostrando o resultado no console.

/*int number = 7;

Console.WriteLine($"Tabuada do {number}:");
Console.WriteLine($"{number} x 1 = {number * 1}");
Console.WriteLine($"{number} x 2 = {number * 2}");
Console.WriteLine($"{number} x 3 = {number * 3}");
Console.WriteLine($"{number} x 4 = {number * 4}");
Console.WriteLine($"{number} x 5 = {number * 5}");
Console.WriteLine($"{number} x 6 = {number * 6}");
Console.WriteLine($"{number} x 7 = {number * 7}");
Console.WriteLine($"{number} x 8 = {number * 8}");
Console.WriteLine($"{number} x 9 = {number * 9}");
Console.WriteLine($"{number} x 10 = {number * 10}");*/

/*C) Considere um jogo em que o jogador controla um personagem que posssui barra de vida e que esse persoangem perde pontos de vida quando recebe ataques de seus inimigos.
Crie um programa que simule a seguinte situação: O persoangem começa com 100 pontos de vida (HP) e ele perde 10 pontos de vida ao receber o primeiro ataque de um inimigo.
Em seguida ele toma um segundo ataque mais poderoso, que faz com que ele perca 30 pontos de vida. A cada ataque receido, mostre em uma mensagem no console quantos pontos de vida o perosangem perdeu.*/

/*int hp = 100;

Console.WriteLine($"O personagem começa com {hp} pontos de vida.");
Console.WriteLine("O personagem recebeu o primeiro ataque e perdeu 10 pontos de vida.");

hp -= 10;

Console.WriteLine($"O personagem agora tem {hp} pontos de vida.");
Console.WriteLine("O personagem recebeu o segundo ataque e perdeu 30 pontos de vida.");

hp -= 30;

Console.WriteLine($"O personagem agora tem {hp} pontos de vida.");
Console.WriteLine($"O Seu personagem perdeu um total de {100 - hp} pontos de vida e agora possui {hp} pontos de vida restantes.");*/

/*D) Considere um jogo de RPG em que o jogador pode criar seus próprios personagens, atribuindo suas caracteristicas.
Crie um programa C# em que o jogador possa cadastrar os seguintes atributos do seu pergoangem: Nome(String), Altura(Float), Força(Integer), Agilidade(Integer) e se É um heroi ou vilão(Boolean).
Ao fim mostre uma mensagem no console com todas as informações do personagem criado.*/

string nome = "Arthas";
float altura = 1.85f;

int forca = 80;
int agilidade = 60;
bool heroi = true;

Console.WriteLine($"Sejá bem vindo {nome}! Essas são as informações do seu personagem:");
Console.WriteLine($"Altura: {altura} m");
Console.WriteLine($"Força: {forca}");
Console.WriteLine($"Agilidade: {agilidade}");
Console.WriteLine($"É um herói: {heroi}");
