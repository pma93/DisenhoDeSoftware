using System;

//Pablo Martinez Arana
namespace PatronStrategy
{
    /// <summary>
    /// EnlaceDir.
    /// </summary>
    public class EnlaceDir : IElementoSistema 
    {
        //Numero de archivos que contiene el elemento
        const int NUM_ARCHIVOS = 0;
        //Tamanho de la definicion de un nuevo enlace(KB)
        const int TAM_DEF = 1;
        //Elemento enlazado
        IEnlace destino;

        /// <summary>
        /// Contructor de la clase EnlaceDir.
        /// </summary>
        /// <param name="enlace"> Elemento enlazado </param>
        public EnlaceDir(IEnlace enlace)
        {
            destino = enlace;
        }// EnlaceDir

        /// <summary>
        /// Propiedad Nombre.
        /// </summary>
        public String Nombre
        {
            // Pre: value != null && value != ""
            set
            {
                destino.Nombre = value;
            }// set
            //Post: nombre == value

            get
            {
                return destino.Nombre;
            }// get
        }// Nombre

        /// <summary>
        /// Propiedad Tamanho.
        /// </summary>
        public double Tamanho
        {
            set 
            { 
            }// set

            get
            {
                return TAM_DEF;
            }// get
        }// Tamanho

        /// <summary>
        /// Propiedad TotalArchivos.
        /// </summary>
        public int TotalArchivos
        {
            get
            {
                return NUM_ARCHIVOS;
            }// get
        }// TotalArchivos

        /// <summary>
        /// Metodo que retorna el String que contiene la impresion del enlace
        /// </summary>
        /// <param name="impresora"> impresora concreta para imprimir el enlace </param>
        /// <returns> impresion del archivo </returns>
        public String Accept(Impresora impresora, Func<String, String> visualizacion)
        {
            return impresora.ImprimirEnlace(this, visualizacion);
        }// Accept
    }// EnlaceDir
}// namespace
