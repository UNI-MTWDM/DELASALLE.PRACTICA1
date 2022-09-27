using System;
using DELASALLE.PRACTICA1.Core.Entities;
using DELASALLE.PRACTICA1.Core.Managers;
using DELASALLE.PRACTICA1.Core.Services;

namespace DELASALLE.PRACTICA1.App;

public static class Program
{
    public static void Main(string[] args)
    {
        float pesoTierra = 0;

        Console.WriteLine("Calculo de peso en Marte!");
        Console.WriteLine("Cual es tu peso en la Tierra [KG]: ");
        Single.TryParse(System.Console.ReadLine(), out pesoTierra);

        var peso = new Peso();
        peso.PesoTierra = pesoTierra;
        

        var manager = new PesoManager(new PesoService());

        Peso marte = manager.CalcPeso(peso);

        Console.WriteLine($"Tu peso en Marte es {marte.PesoMarte} KG");

    }
}