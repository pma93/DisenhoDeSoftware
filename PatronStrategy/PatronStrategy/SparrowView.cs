using System;

// Pablo Martinez Arana
namespace PatronStrategy
{
    public class SparrowView
    {
        /// <summary>
        /// Muestra cualquier elemento del sistema sparrow en formato
        /// extendido.
        /// </summary>
        /// <param name="elemento">Elemento del sistema sparrow.</param>
        public void MostrarSistemaSparrow(IElementoSistema elemento)
        {
            Console.Out.WriteLine("======= Sparrow Viewer =======");
            Console.Out.WriteLine();
            Console.Out.WriteLine("======= Impresora Extendidda =======");
            Console.Out.WriteLine();
            Console.Out.WriteLine("Castellano: \n" + elemento.Accept(new ImpresoraExtendida(new EstrategiaCastellana())));
            Console.Out.WriteLine();
            Console.Out.WriteLine("Catalan: \n" + elemento.Accept(new ImpresoraExtendida(new EstrategiaCatalana())));
            Console.Out.WriteLine();
            Console.Out.WriteLine("Gallego: \n" + elemento.Accept(new ImpresoraExtendida(new EstrategiaGallega())));
            Console.Out.WriteLine();
            Console.Out.WriteLine("Internacional Catalan: \n" + elemento.Accept(new ImpresoraExtendida(new EstrategiaInternacionalCatalana())));
            Console.Out.WriteLine();
            Console.Out.WriteLine("Internacional Gallego: \n" + elemento.Accept(new ImpresoraExtendida(new EstrategiaInternacionalGallega())));
            Console.Out.WriteLine();
            Console.Out.WriteLine("==============================");
        }// MostrarSistemaSparrow
    }// SparrowView
}// namespace
