using System;
using System.Collections.Generic;

// Pablo Martinez Arana
namespace PatronVisitor
{
    /// <summary>
    /// Archivo comprimido.
    /// </summary>
    public class ArchivoComprimido : GrupoElementos
    {
        //Tamanho de la definicion de un nuevo archivo comprimido(KB)
        const int TAM_DEF = 1;
        //Factor de compresion del sistema Sparrow
        const double FACTOR_COMPRESION = 0.3;
        //Numero de archivos que contiene el elemento
        const int NUM_ARCHIVOS = 1;

        /// <summary>
        /// Inicializa la clase ArchivoComprimido
        /// con un conjunto de elemntos vacio, y le asigna
        /// un nombre.
        /// <param name="nombre">Nombre del elemento que se crea.</param>
        /// </summary>
        public ArchivoComprimido(String nombre) : base(nombre)
        {
            elementos = new HashSet<IElementoSistema>();
        }// ArchivoComprimido

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
        /// Propiedad Tamanho.
        /// </summary>
        public override double Tamanho
        {
            get
            {
                double total = 0.0;
                //Se suma el tamanho de los elementos dentro del directorio
                foreach (IElementoSistema es in elementos)
                {
                    total += es.Tamanho;
                }
                return (total * FACTOR_COMPRESION) + TAM_DEF;
            }// get
            // Post: total >=0.0

            set 
            {
            }// set
        }// Tamanho

        /// <summary>
        /// Metodo que permite obtener los elementos contenidos por 
        /// el archivo comprimido.
        /// </summary>
        /// <returns> lista con los elementos contenidos por el 
        /// archivo comprimido </returns>
        public override ISet<IElementoSistema> ObtenerElementos()
        {
            return elementos;
        }// ObtenerElementos

        /// <summary>
        /// Metodo que retorna el String que contiene la impresion del archivo
        /// </summary>
        /// <param name="impresora"> impresora concreta para imprimir el archivo </param>
        /// <returns> impresion del archivo </returns>
        public override String Accept(Impresora impresora)
        {
            return impresora.ImprimirArchivoComprimido(this);
        }// Accept
    }// ArchivoComprimido
}// namespace
