using System;
using Ninject;

// Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Clase impresora extendida. Permite imprimir de forma 
    /// extendida un sistema de ficheros.
    /// </summary>
    public class ImpresoraExtendida : Impresora
    {
        //Nivel de anidamiento dentro del sistema de ficheros
        int nivelAnidamiento = 0;

        /// <summary>
        /// Constructor de la clase ImpresoraExtendida
        /// </summary>
        /// <param name="estrategia"> estrategia de visualizacion a utilizar </param>
        [Inject]
        public ImpresoraExtendida(Estrategia estrategia) : base(estrategia) { }

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
            String str = "c " + archivoComprimido.Nombre + "\n";
            str = ImprimirElementos(archivoComprimido, str);

            return Estrategia.ReemplazoString(str);
        }// ImprimirArchivoComprimido

        /// <summary>
        /// Metodo que permite imprimir un directorio
        /// </summary>
        /// <param name="directorio">directorio a imprimir</param>
        /// <returns>String conteniendo la impresion del directorio</returns>
        public override string ImprimirDirectorio(Directorio directorio)
        {
            String str = "d " + directorio.Nombre + "\n";
            str = ImprimirElementos(directorio, str);

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

        /// <summary>
        /// Metodo auxiliar para recorrer los elementos contenidos en un grupo 
        /// (directorio o archivo comprimido).
        /// </summary>
        /// <param name="grupo"> grupo a recorrer </param>
        /// <param name="str"> estructura del sistema de ficheros 
        /// hasta este momento </param>
        /// <returns> string con la impresion de los elementos contenidos en el 
        /// grupo que se recibe como parametro </returns>
        private string ImprimirElementos(GrupoElementos grupo, string str)
        {
            nivelAnidamiento++;

            foreach (IElementoSistema e in grupo.ObtenerElementos())
            {
                str = str + AnhadirTabuladores(nivelAnidamiento) + e.Accept(this);
            }

            nivelAnidamiento--;

            return str;
        }// ImprimirElementos
    }// ImpresoraExtendida
}// namespace
