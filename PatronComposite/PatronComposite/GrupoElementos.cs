using System;
using System.Collections.Generic;

// Pablo Martinez Arana
namespace PatronComposite
{
    /// <summary>
    /// Clase abstracta que representa a un grupo de elementos
    /// del sistema sparrow.
    /// </summary>
    public abstract class GrupoElementos : IElementoSistema
    {
        //Nombre del elemento
        string nombre;
        //Conjunto de elementos 
        protected ISet<IElementoSistema> elementos;

        /// <summary>
        /// Constructor de la clase GrupoElementos.
        /// </summary>
        /// <param name="nombre">Nombre del elemento.</param>
        protected GrupoElementos(String nombre)
        {
            this.nombre = nombre;
        }// GrupoElementos

        /// <summary>
        /// Propiedad Nombre.
        /// </summary>
        public virtual string Nombre
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
        public virtual double Tamanho
        {
            get;
            set;
        }// Tamanho

        /// <summary>
        /// Propiedad TotalArchivos.
        /// </summary>
        public virtual int TotalArchivos 
        {
            get;
        }// TotalArchivos

        /// <summary>
        /// Metodo que permite anhadir un elemento al conjunto de elementos
        /// </summary>
        /// <param name="elemento"> Elemento a anhadir </param>
        public void AnhadeElemento(IElementoSistema elemento)
        {
            elementos.Add(elemento);
        }// AnhadeElemento

        /// <summary>
        /// Metodo que permite eliminar un elemento del conjunto de elementos
        /// </summary>
        /// <param name="elemento"> Elemento a eliminar </param>
        public void EliminaElemento(IElementoSistema elemento)
        {
            elementos.Remove(elemento);
        }// EliminaElemento
    }// GrupoElementos
}// namespace
