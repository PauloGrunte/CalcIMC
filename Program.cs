Console.WriteLine("Digite sua altura em Metros (por exemplo 1,60)");
double altura = double.Parse(Console.ReadLine());
if (altura > 3)
{
    Console.WriteLine("A altura foi digitada em cm mas já foi convertido");
    altura = altura / 100;
}
else
{
}
Console.WriteLine("Digite seu peso em Kg (por exemplo 70)");
double peso = double.Parse(Console.ReadLine());
double imc = (peso / (Math.Pow(altura, 2)));
Console.WriteLine($"O imc é {Math.Round(imc, 2)}");
if (imc < 17)
{
    Console.WriteLine("Muito abaixo do peso");
}
else if (imc > 17 && imc < 18.49)
{
    Console.WriteLine("Abaixo do peso");
}
else if (imc >= 18.5 && imc < 24.99)
{
    Console.WriteLine("Peso normal");
}
else if (imc >= 25 && imc < 29.99)
{
    Console.WriteLine("Acima do peso");
}
else if (imc >= 30 && imc < 34.99)
{
    Console.WriteLine("Obesidade 1");
}
else if (imc >= 35 && imc < 39.99)
{
    Console.WriteLine("Obesidade 2 (severa)");
}
else if (imc >= 40)
{
    Console.WriteLine("Obesidade 3 (mórbida)");
}
