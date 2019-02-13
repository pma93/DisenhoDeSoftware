using System;

// Pablo Martinez Arana
namespace PatronCompositeEnlaceDir
{
    /// <summary>
    /// Programa de pruebas
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos varios archivos 
            Archivo foto1 = new Archivo("foto001.jpg", 2);
            Archivo foto2 = new Archivo("foto002.jpg", 2);
            Archivo foto3 = new Archivo("foto003.jpg", 2);
            Archivo foto4 = new Archivo("foto004.jpg", 2);
            Archivo foto5 = new Archivo("foto005.jpg", 2);
            Archivo foto6 = new Archivo("foto006.jpg", 2);
            Archivo foto7 = new Archivo("foto007.jpg", 2);
            Archivo foto8 = new Archivo("foto008.jpg", 2);

            //Creamos varios archivos comprimidos
            ArchivoComprimido comprimido1 = new ArchivoComprimido("ccSimple.zip");
            ArchivoComprimido comprimido2 = new ArchivoComprimido("ccComplejo.zip");
            ArchivoComprimido comprimido3 = new ArchivoComprimido("ccAnidado.zip");

            //Creamos varios directorios
            Directorio directorio1 = new Directorio("Raiz");
            Directorio directorio2 = new Directorio("Directorio Vacio");
            Directorio directorio3 = new Directorio("Directorio Con Archivo Unico");
            Directorio directorio4 = new Directorio("Directorio Con Archivo Comprimido Simple");
            Directorio directorio5 = new Directorio("Directorio Vacio En Archivo Comprimido");
            Directorio directorio6 = new Directorio("Directorio con Directorio Anidado");
            Directorio directorio7 = new Directorio("Directorio con Archivo Comprimido Complejo");

            //Creamos varios enlaces
            EnlaceDir enlace1 = new EnlaceDir(directorio2);
            EnlaceDir enlace2 = new EnlaceDir(foto1);
            EnlaceDir enlace3 = new EnlaceDir(comprimido1);

            //Anhadimos elementos a los directorios y a los archivos
            //comprimidos y enlazamos elementos siguiendo el esquema 
            //de la practica
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
            comprimido1.AnhadeElemento(enlace1);
            directorio4.AnhadeElemento(foto2);
            directorio4.AnhadeElemento(enlace1);
            directorio4.AnhadeElemento(comprimido1);
            directorio3.AnhadeElemento(foto1);
            directorio1.AnhadeElemento(directorio2);
            directorio1.AnhadeElemento(directorio3);
            directorio1.AnhadeElemento(directorio4);
            directorio1.AnhadeElemento(directorio6);

            //Comprobamos que los datos de algunos elementos del
            //sistema son correctos
            ImprimirPropiedadesElementoSparrow(foto1);
            ImprimirPropiedadesElementoSparrow(directorio3);
            ImprimirPropiedadesElementoSparrow(comprimido1);
            ImprimirPropiedadesElementoSparrow(enlace1);
        }// Main

        /// <summary>
        /// Funcion auxiliar para imprimir las propiedades 
        /// del elemento sparrow por pantalla.
        /// </summary>
        /// <param name="elemento">Elemento.</param>
        static void ImprimirPropiedadesElementoSparrow(IElementoSistema elemento)
        {
            Console.Out.WriteLine("============= Info ===============");
            Console.Out.WriteLine();
            Console.Out.WriteLine("Nombre        : " + elemento.Nombre);
            Console.Out.WriteLine("Tamaño        : " + elemento.Tamanho);
            Console.Out.WriteLine("Num. Archivos : " + elemento.TotalArchivos);
            Console.Out.WriteLine();
        }// ImprimirPropiedadesElementoSparrow
    }// Program
}// namespace
