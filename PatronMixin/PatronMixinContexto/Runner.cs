using System;
namespace PatronMixinContexto
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
            //Crea un PasiegoLebaniego con contexto inicial Liebana
            PasiegoLebaniego p = new PasiegoLebaniego(TipoContexto.LIEBANA);

            //Muestra el resultado de todos los metodos menos el hacerCocido
            //del pasiego
            Console.Out.WriteLine(p.hacerCocido());
            Console.Out.WriteLine(p.hacerOrujo());
            Console.Out.WriteLine(p.hacerSobaos());
            Console.Out.WriteLine(p.hacerQuesada());

            //Cambio el contexto
            p.Contexto = TipoContexto.PAS;

            //Muestra el resultado del metodo hacerCocido() para el contexto PAS
            Console.Out.WriteLine(p.hacerCocido());
        } //Main
    } //Runner
} //namespace
