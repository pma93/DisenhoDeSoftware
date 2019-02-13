using System;
namespace PatronMixin
{
    /// <summary>
    /// Runner.
    /// Clase que muestra por pantalla la ejecucion
    /// de los diferentes metodos implementados.
    /// </summary>
    public class Runner
    {
        static void Main(string[] args)
        {
            //Crea un PasiegoLebaniego
            PasiegoLebaniego p = new PasiegoLebaniego();

            Console.Out.WriteLine(p.hacerQuesada());
            Console.Out.WriteLine(p.hacerSobaos());
            Console.Out.WriteLine(p.hacerCocido());
            Console.Out.WriteLine(p.hacerOrujo());
        } //Main
    } //Runner
} //namespace
