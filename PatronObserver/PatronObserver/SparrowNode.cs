using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronObserver
{
    /// <summary>
    ///     Clase utilizada para visualizar un elemento cualquiera del 
    ///     sistema de archivos Sparrow como nodo de un TreeView. 
    /// </summary>
    public class SparrowNode : TreeNode, IElementoSistemaObserver
    {

        #region Atributos y Propiedades

        /// <summary>
        ///     Elemento del sistema de archivos visualizado por este nodo.
        /// </summary>
        /// <inv>(referencedElement != null)</inv>
        protected ElementoSistema referencedElement;

        /// <summary>
        ///     Elemento del sistema de archivos Sparrow referenciado por
        ///     el nodo.
        /// </summary>
        public ElementoSistema ReferencedElement
        {
            get
            {
                return referencedElement;
            }
        }

        #endregion

        #region Constructores

        /// <summary>
        ///     Constructor de la clase
        /// </summary>
        /// <param name="sa">
        ///     Elemento del sistema de archivos Sparrow a visualizar
        /// </param>
        /// <pre>(sa != null)</pre>
        public SparrowNode(ElementoSistema sa) : base(sa.Nombre)
        {
            this.referencedElement = sa;
            sa.AnhadeObserver(this);
            this.Text = referencedElement.Nombre;
        } // SparrowNode

        /// <summary>
        /// Actualiza la informacion del elemento con la nueva informacion.
        /// </summary>
        public void Update(ElementoSistema e)
        {
            this.Text = e.Nombre;
        }// Update

        #endregion

    } // class SparrowNode 
} // namespace
