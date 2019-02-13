using System;

// Pablo Martinez Arana
namespace PatronAbstractFactory
{
    /// <summary>
    /// Archivo 
    /// </summary>
    public class Archivo : IEnlace
    {
        //Nombre del archivo
        string nombre;
        //Tamanho del archivo en KB
        double tamanho;
        //Numero de archivos que contiene el elemento
        const int NUM_ARCHIVOS = 1;

        /// <summary>
        /// Constructor de la clase Archivo.
        /// </summary>
        /// <param name="nombre">Nombre del elemento que se crea.</param>
        /// <param name="tamanho">Tamanho del archivo que se crea</param>
        public Archivo(String nombre, double tamanho)
        {
            this.nombre = nombre;
            this.tamanho = tamanho;
        }//Archivo

        /// <summary>
        /// Propiedad Nombre.
        /// </summary>
        public string Nombre
        {
            // Pre: value != null && value != ""
            set
            {
                nombre = value;
            }// set
            // Post: nombre == value

            get
            {
                return nombre;
            }// get
        }// Nombre

        /// <summary>
        /// Propiedad Tamanho.
        /// </summary>
        public double Tamanho
        {
            // Pre: value >=0.0
            set
            {
                tamanho = value;
            }// set
            // Post: tamanho == value

            get
            {
                return tamanho;
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
        /// Metodo que retorna el String que contiene la impresion del archivo
        /// </summary>
        /// <param name="impresora"> impresora concreta para imprimir el archivo </param>
        /// <returns> impresion del archivo </returns>
        public String Accept(Impresora impresora)
        {
            return impresora.ImprimirArchivo(this);
        }// Accept
    }// Archivo
}// namespace
