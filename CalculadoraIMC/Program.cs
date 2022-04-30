using System;

namespace CalculadoraIMC
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
         
            
            Console.WriteLine("Insira seu nome:");
            String nome = Console.ReadLine();
            
            Console.WriteLine("Insira sua altura(em metros):");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira seu peso(em kg):");
            float peso = Convert.ToSingle(Console.ReadLine());

            Pessoa pessoa = new Pessoa(nome, altura, peso);

           
    double imc = peso / (altura * altura);

       

if(imc < 18.5)
{
  Console.WriteLine("VOCÊ ESTÁ ABAIXO DO PESO!!!");
} 
if(imc > 18.5 && imc < 24.9)
{
  Console.WriteLine("VOCÊ ESTÁ NO SEU PESO IDEAL!!!");
}
if(imc > 25 && imc < 29.9)
{
  Console.WriteLine("VOCÊ ESTÁ ACIMA DO PESO!!!");
}
if(imc > 30 && imc < 34.9)
{
  Console.WriteLine("VOCÊ ESTÁ COM OBESIDADE GRAU I !!!");
} 
if(imc > 35 && imc < 39.9)
{
  Console.WriteLine("VOCÊ ESTÁ COM OBESIDADE GRAU II !!!");
}
if(imc > 40)
{
  Console.WriteLine("VOCÊ ESTÁ COM OBESIDADE GRAU III !!!");
}
    }
    }
}