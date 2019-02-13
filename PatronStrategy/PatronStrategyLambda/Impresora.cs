using System;

// Pablo Martinez Arana
namespace PatronStrategy
{
    /// <summary>
    /// Clase abstracta impresora. Define los metodos que permiten visualizar un sistema de ficheros
    /// </summary>
    public abstract class Impresora
    {
        /// <summary>
        /// Metodo que permite imprimir un archivo
        /// </summary>
        /// <param name="archivo">archivo a imprimir</param>
        /// <returns>String conteniendo la impresion del archivo</returns>
        public abstract String ImprimirArchivo(Archivo archivo, Func<String, String> visualizacion);

        /// <summary>
        /// Metodo que permite imprimir un archivo comprimido
        /// </summary>
        /// <param name="comprimido">archivo comprimido a imprimir</param>
        /// <returns>String conteniendo la impresion del archivo comprimido</returns>
        public abstract String ImprimirArchivoComprimido(ArchivoComprimido archivoComprimido, Func<String, String> visualizacion);

        /// <summary>
        /// Metodo que permite imprimir un directorio
        /// </summary>
        /// <param name="directorio">directorio a imprimir</param>
        /// <returns>String conteniendo la impresion del directorio</returns>
        public abstract String ImprimirDirectorio(Directorio directorio, Func<String, String> visualizacion);

        /// <summary>
        /// Metodo que permite imprimir un enlace directo
        /// </summary>
        /// <param name="enlace">enlace directo a imprimir</param>
        /// <returns>String conteniendo la impresion del enlace directo</returns>
        public abstract String ImprimirEnlace(EnlaceDir enlace, Func<String, String> visualizacion);
    }// Impresora
}// namespace
