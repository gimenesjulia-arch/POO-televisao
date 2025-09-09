// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, seja bem vindo!");

        Televisao tv = new Televisao(42f);
        Console.WriteLine($"A TV tem o tamanho {tv.Tamanho} polegadas");

        tv.Ligar();

        tv.AumentarVolume();
        tv.AumentarVolume();
        Console.WriteLine($"Volume atual: {tv.Volume}");

        tv.MudarParaCanal(520);
        Console.WriteLine($"Canal atual: {tv.Canal}");

        tv.MudarParaCanal(-5); 
        tv.MudarParaCanal(600); 

        
        tv.Desligar();
    }
}