using System;
using System.Collections.Generic;

// Pablo Martinez Arana
namespace PatronObserver
{
    /// <summary>
    /// Clase abstracta que representa a un grupo de elementos
    /// del sistema sparrow.
    /// </summary>
    public abstract class GrupoElementos : ElementoEnlace
    {
        //Nombre del elemento
        string nombre;
        //Conjunto de elementos 
        protected ISet<ElementoSistema> elementos;

        /// <summary>
        /// Constructor de la clase GrupoElementos.
        /// </summary>
        /// <param name="nombre">Nombre del elemento.</param>
        protected GrupoElementos(String nombre)
        {
            this.nombre = nombre;
            observers = new List<IElementoSistemaObserver>();
        }// GrupoElementos

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
            get;
            set;
        }// Tamanho

        /// <summary>
        /// Propiedad TotalArchivos.
        /// </summary>
        public override int TotalArchivos
        {
            get;
        }// TotalArchivos

        /// <summary>
        /// Metodo que permite anhadir un elemento al conjunto. 
        /// </summary>
        /// <param name="elemento"> Elemento a anhadir </param>
        public void AnhadeElemento(ElementoSistema elemento)
        {
            elementos.Add(elemento);
        }// AnhadeElemento

        /// <summary>
        /// Metodo que permite eliminar un elemento del conjunto
        /// </summary>
        /// <param name="elemento"> Elemento a eliminar </param>
        public void EliminaElemento(ElementoSistema elemento)
        {
            elementos.Remove(elemento);
        }// EliminaElemento
    }// GrupoElementos
}// namespace
