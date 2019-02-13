using System;
using System.Collections.Generic;

// Pablo Martinez Arana
namespace PatronObserver
{
    /// <summary>
    /// Archivo 
    /// </summary>
    public class Archivo : ElementoEnlace
    {
        //Nombre del archivo
        string nombre;
        //Tamanho del archivo en KB
        double tamanho;
        //Numero de archivos que contiene el elemento
        const int NUM_ARCHIVOS = 1;
        //Conjunto de elementos 
        protected ISet<ElementoSistema> elementos;

        /// <summary>
        /// Constructor de la clase Archivo.
        /// </summary>
        /// <param name="nombre">Nombre del elemento que se crea.</param>
        /// <param name="tamanho">Tamanho del archivo que se crea</param>
        public Archivo(String nombre, double tamanho)
        {
            this.nombre = nombre;
            this.tamanho = tamanho;
            observers = new List<IElementoSistemaObserver>();
            elementos = new HashSet<ElementoSistema>();
        }//Archivo

        /// <summary>
        /// Propiedad Nombre.
        /// </summary>
        public override string Nombre
        {
            // Pre: value != null && value != ""
            set
            {
                nombre = value;
                Notify();
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
        public override double Tamanho
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
        public override int TotalArchivos
        {
            get
            {
                return NUM_ARCHIVOS;
            }// get
        }// TotalArchivos

        /// <summary>
        /// Devuelve los elementos que tiene el archivo. En concreto, devuelve
        /// una lista vacia ya que un archivo no tiene elementos.
        /// </summary>
        public override ISet<ElementoSistema> Archivos 
        { 
            get
            {
                return elementos;
            }// get
        }// Archivos
    }// Archivo
}// namespace
