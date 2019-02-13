using System;
using Ninject;
 
// Pablo Martinez Arana
namespace PatronAbstractFactory
{
    public class SparrowView
    {
       
        /// <summary>
        /// Muestra cualquier elemento del sistema sparrow en formato
        /// extendido usando inyeccion de dependencias.
        /// </summary>
        /// <param name="elemento">Elemento del sistema sparrow.</param>
        public void MostrarSistemaSparrow(IElementoSistema elemento)
        {
            IKernel injectorExtGallega = new StandardKernel(new InyeccionExtendidaGallega());
            IKernel injectorExtCatalana = new StandardKernel(new InyeccionExtendidaCatalana());
            IKernel injectorBasica = new StandardKernel(new InyecccionBasica());
            IKernel injectorEstandar = new StandardKernel(new InyeccionEstandar());
            Impresora impresoraEstandar = injectorEstandar.Get<Impresora>();
            Impresora impresoraBasica = injectorBasica.Get<Impresora>();
            Impresora impresoraExtGallega = injectorExtGallega.Get<Impresora>();
            Impresora impresoraExtCatalana = injectorExtCatalana.Get<Impresora>();

            Console.Out.WriteLine("======= Sparrow Viewer =======");
            Console.Out.WriteLine();
            Console.Out.WriteLine("======= Impresoras =======");
            Console.Out.WriteLine();
            Console.Out.WriteLine("Estandar (Castellano): \n" + elemento.Accept(impresoraEstandar));
            Console.Out.WriteLine();
            Console.Out.WriteLine("Extendida Catalana (Internacional Catalan): \n" + elemento.Accept(impresoraExtCatalana));
            Console.Out.WriteLine();
            Console.Out.WriteLine("Basica (Internacional Gallego): \n" + elemento.Accept(impresoraBasica));
            Console.Out.WriteLine();
            Console.Out.WriteLine("Extendida Gallega (Internacional Gallega): \n" + elemento.Accept(impresoraExtGallega));
            Console.Out.WriteLine();
            Console.Out.WriteLine("==============================");
        }// MostrarSistemaSparrow
    }// SparrowView
}// namespace
