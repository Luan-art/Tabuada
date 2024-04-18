//Faça um programa que leia um numero inteiro positivo e imprima a sua tabuada
int numero = 0, aux = 0;
Console.WriteLine("Digite um numero para descobrirmos sua tabuada: ");
numero = int.Parse(Console.ReadLine());
aux = numero;
if (numero > 0)
{
     for(int i = 1; i <= 10; i++)
    {
        Console.WriteLine($" {aux} vezes {i} = {aux * i}");
    }
}
else
{
    Console.WriteLine("numero invalido");
}  

