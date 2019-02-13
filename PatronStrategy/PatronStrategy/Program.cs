using System;

// Pablo Martinez Arana
namespace PatronStrategy
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

            // Creamos varias impresoras compactas y un objeto de la clase
            // SparrowView(impresora extendida) para poder visualizar el 
            // resultado de las diferentes estrategias, 
            SparrowView sv = new SparrowView();

            ImpresoraCompacta comp1 = new ImpresoraCompacta(new EstrategiaCastellana());
            ImpresoraCompacta comp2 = new ImpresoraCompacta(new EstrategiaGallega());
            ImpresoraCompacta comp3 = new ImpresoraCompacta(new EstrategiaCatalana());
            ImpresoraCompacta comp4 = new ImpresoraCompacta(new EstrategiaInternacionalCatalana());
            ImpresoraCompacta comp5 = new ImpresoraCompacta(new EstrategiaInternacionalGallega());

            // Visualizamos el resultado
            sv.MostrarSistemaSparrow(directorio1);

            Console.Out.WriteLine("-------- Impresora Compacta --------\n");
            Console.Out.WriteLine("Castellano: \n" + comp1.ImprimirDirectorio(directorio1));
            Console.Out.WriteLine("Gallego: \n" + comp2.ImprimirDirectorio(directorio1));
            Console.Out.WriteLine("Catalan: \n" + comp3.ImprimirDirectorio(directorio1));
            Console.Out.WriteLine("Internacional Catalan: \n" + comp4.ImprimirDirectorio(directorio1));
            Console.Out.WriteLine("Internacional Gallego: \n" + comp5.ImprimirDirectorio(directorio1));
            Console.Out.WriteLine("------------------------------------\n");
        }// Main
    }// Program
}// namespace
