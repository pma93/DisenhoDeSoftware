using System;
using Ninject;

// Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Clase impresora compacta. Permite imprimir de 
    /// forma compacta un sistema de ficheros.
    /// </summary>
    public class ImpresoraCompacta : Impresora
    {
        //Nivel de anidamiento dentro del sistema de ficheros
        int nivelAnidamiento = 0;

        /// <summary>
        /// Constructor de la clase ImpresoraCompacta
        /// </summary>
        /// <param name="estrategia"> estrategia de visualizacion a utilizar </param>
        [Inject]
        public ImpresoraCompacta(Estrategia estrategia) : base(estrategia) { }

        /// <summary>
        /// Metodo que permite imprimir un archivo
        /// </summary>
        /// <param name="archivo">archivo a imprimir</param>
        /// <returns>String conteniendo la impresion del archivo</returns>
        public override string ImprimirArchivo(Archivo archivo)
        {
            return Estrategia.ReemplazoString("f " + archivo.Nombre + "\n");
        }// ImprimirArchivo

        /// <summary>
        /// Metodo que permite imprimir un archivo comprimido
        /// </summary>
        /// <param name="archivoComprimido">archivo comprimido a imprimir</param>
        /// <returns>String conteniendo la impresion del archivo comprimido</returns>
        public override string ImprimirArchivoComprimido(ArchivoComprimido archivoComprimido)
        {
            return Estrategia.ReemplazoString("c " + archivoComprimido.Nombre + "\n");
        }// ImprimirArchivoComprimido

        /// <summary>
        /// Metodo que permite imprimir un directorio
        /// </summary>
        /// <param name="directorio">directorio a imprimir</param>
        /// <returns>String conteniendo la impresion del directorio</returns>
        public override string ImprimirDirectorio(Directorio directorio)
        {
            String str = "d " + directorio.Nombre + "\n";
            nivelAnidamiento++;

            foreach (IElementoSistema e in directorio.ObtenerElementos())
            {
                str = str + AnhadirTabuladores(nivelAnidamiento) + e.Accept(this);
            }

            nivelAnidamiento--;

            return Estrategia.ReemplazoString(str);
        }// ImprimirDirectorio

        /// <summary>
        /// Metodo que permite imprimir un enlace directo
        /// </summary>
        /// <param name="enlace">enlace directo a imprimir</param>
        /// <returns>String conteniendo la impresion del enlace directo</returns>
        public override string ImprimirEnlace(EnlaceDir enlace)
        {
            return Estrategia.ReemplazoString("e " + enlace.Nombre + "\n");
        }// ImprimirEnlace

        /// <summary>
        /// Metodo auxiliar que permite tabular los elementos del sistema de 
        /// ficheros en funcion de su nivel de anidamiento.
        /// </summary>
        /// <param name="anidamiento"></param>
        /// <returns> string con los espacios necesarios para 
        /// tabular el elemento actual </returns>
        private String AnhadirTabuladores(int anidamiento)
        {
            String str = "";
            for (int i = 0; i < anidamiento; i++)
            {
                str = str + "   ";
            }

            return str;
        }// AnhadirTabuladores
    }// ImpresoraCompacta
}// namespace
