using System;

// Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Programa de pruebas.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos varias fotos
            Archivo foto1 = new Archivo("Lasaña.jpg", 2);
            Archivo foto2 = new Archivo("LAsaña.jpg", 2);
            Archivo foto3 = new Archivo("LASaña.jpg", 2);
            Archivo foto4 = new Archivo("LASAña.jpg", 2);
            Archivo foto5 = new Archivo("LASAñaa.jpg", 2);
            Archivo foto6 = new Archivo("LASAñA.jpg", 2);
            Archivo foto7 = new Archivo("LAsañA.jpg", 2);
            Archivo foto8 = new Archivo("laSAña.jpg", 2);

            // Creamos varios archivos comprimidos
            ArchivoComprimido comprimido1 = new ArchivoComprimido("Paté.zip");
            ArchivoComprimido comprimido2 = new ArchivoComprimido("Maíz.zip");
            ArchivoComprimido comprimido3 = new ArchivoComprimido("Vermú.zip");

            // Creamos varios directorios
            Directorio directorio1 = new Directorio("Lasañá");
            Directorio directorio2 = new Directorio("Lasañé");
            Directorio directorio3 = new Directorio("Lasañí");
            Directorio directorio4 = new Directorio("Lasañó");
            Directorio directorio5 = new Directorio("Lasañú");
            Directorio directorio6 = new Directorio("Leseñé");
            Directorio directorio7 = new Directorio("Lusuñú");

            // Creamos varios enlaces
            EnlaceDir enlace1 = new EnlaceDir(directorio2);
            EnlaceDir enlace2 = new EnlaceDir(foto1);
            EnlaceDir enlace3 = new EnlaceDir(comprimido1);

            // Anhadimos los elementos siguiendo el esquema de practicas
            // anteriores
            comprimido3.AnhadeElemento(foto7);
            comprimido2.AnhadeElemento(comprimido3);
            comprimido2.AnhadeElemento(foto8);
            directorio7.AnhadeElemento(foto5);
            directorio7.AnhadeElemento(foto6);
            directorio7.AnhadeElemento(comprimido2);
            directorio6.AnhadeElemento(foto4);
            directorio6.AnhadeElemento(enlace3);
            directorio6.AnhadeElemento(enlace1);
            directorio6.AnhadeElemento(directorio7);
            comprimido1.AnhadeElemento(directorio5);
            comprimido1.AnhadeElemento(foto3);
            comprimido1.AnhadeElemento(enlace2);
            directorio4.AnhadeElemento(foto2);
            directorio4.AnhadeElemento(enlace2);
            directorio4.AnhadeElemento(comprimido1);
            directorio3.AnhadeElemento(foto1);
            directorio1.AnhadeElemento(directorio2);
            directorio1.AnhadeElemento(directorio3);
            directorio1.AnhadeElemento(directorio4);
            directorio1.AnhadeElemento(directorio6);

            // Creamos un SparrowView y varias factorias para visualizar el 
            // resultado de las diferentes estrategias, 
            SparrowView sv = new SparrowView();

            // Visualizamos el resultado de la factoria extendida gallega
            // Se corresponde con el punto 4
            IFactoriaEstrategia factoriaExtGallega = FactoriaExtendidaGallega.GetInstance();
            Estrategia visualizacionExtGallega = factoriaExtGallega.CrearVisualizacionEstrategia();
            Impresora impresoraExtGallega = factoriaExtGallega.CrearImpresora(visualizacionExtGallega);
            Console.Out.WriteLine("------Extendida Gallega-------");
            Console.Out.Write(impresoraExtGallega.ImprimirDirectorio(directorio1));
            Console.Out.WriteLine("------------------------------------\n");

            // Visualizamos el resultado de la factoria abierta
            // Se corresponde con el punto 8
            IFactoriaEstrategia factoriaAbierta = FactoriaAbierta.GetInstance();
            Estrategia visualizacionAbierta = factoriaAbierta.CrearVisualizacionEstrategia();
            Impresora impresoraAbierta = factoriaAbierta.CrearImpresora(visualizacionAbierta);
            Console.Out.WriteLine("------Abierta-------");
            Console.Out.Write(impresoraAbierta.ImprimirDirectorio(directorio1));
            Console.Out.WriteLine("------------------------------------\n");
            // Visualizamos el resultado del SparrowView
            sv.MostrarSistemaSparrow(directorio1);
        }// Main
    }// Program
}// namespace
