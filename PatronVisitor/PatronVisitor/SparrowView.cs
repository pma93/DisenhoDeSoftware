using System;

// Pablo Martinez Arana
namespace PatronVisitor
{
    /// <summary>
    /// SparrowView.
    /// </summary>
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
            Console.Out.WriteLine(elemento.Accept(new ImpresoraExtendida()));
            Console.Out.WriteLine();
            Console.Out.WriteLine("==============================");
        }// MostrarSistemaSparrow
    }// SparrowView
}// namespace
