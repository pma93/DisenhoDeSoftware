using System;
using System.Collections.Generic;

// Pablo Martinez Arana
namespace PatronObserver
{
    /// <summary>
    /// EnlaceDir
    /// </summary>
    public class EnlaceDir : ElementoSistema, IElementoSistemaObserver
    {
        //Numero de archivos que contiene el elemento
        const int NUM_ARCHIVOS = 0;
        //Tamanho de la definicion de un nuevo enlace(KB)
        const int TAM_DEF = 1;
        //Elemento enlazado
        ElementoEnlace destino;
        //Conjunto de elementos
        protected ISet<ElementoSistema> elementos;

        /// <summary>
        /// Contructor de la clase EnlaceDir.
        /// </summary>
        /// <param name="enlace"> Elemento enlazado </param>
        public EnlaceDir(ElementoEnlace enlace) 
        {   
            destino = enlace;
            elementos = new HashSet<ElementoSistema>();
            observers = new List<IElementoSistemaObserver>();
            enlace.AnhadeObserver(this);
        }// EnlaceDir

        /// <summary>
        /// Propiedad Nombre.
        /// </summary>
        public override String Nombre
        {
            // Pre: value != null && value != ""
            set 
            { 
                destino.Nombre = value;
                Notify();
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
        public override double Tamanho
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
        public override int TotalArchivos
        {
            get 
            { 
                return NUM_ARCHIVOS; 
            }// get
        }// TotalArchivos

        /// <summary>
        /// Devuelve los elementos que tiene el enlace. En concreto, devuelve
        /// una lista vacia ya que un enlace no tiene elementos.
        /// </summary>
        public override ISet<ElementoSistema> Archivos
        {
            get
            {
                return elementos;
            }// get
        }// Archivos

        /// <summary>
        /// Actualiza la informacion del enlace con la nueva 
        /// informacion del elemento.
        /// </summary>
        /// <param name="e">Elemento del sistema sparrow.</param>
        public void Update(ElementoSistema e)
        {
            Nombre = e.Nombre;
        }// Update 
    }// EnlaceDir
}// namespace
