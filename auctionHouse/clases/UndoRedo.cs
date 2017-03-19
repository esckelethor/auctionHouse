using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auctionHouse.clases
{
    /// <summary>
    /// Genera objetos que administran el historial Undo&Redo
    /// </summary>
    class UndoRedo
    {
        /// <summary>
        /// Variable que establece el numero de operaciones undo que podemos deshacer
        /// </summary>
        public int mUndoCount = 0;
        /// <summary>
        /// Variable que establece el numero de operaciones redo que podemos rehacer (-1: Ninguna)
        /// </summary>
        public int mRedoCount = -1;

        /// <summary>
        /// Coleccion que almacena los controles eliminados del formulario con undo
        /// </summary>
        private List<Control> history;

        /// <summary>
        /// Constructor que permite instanciar un administrador de historiales Undo&Redo
        /// </summary>
        public UndoRedo()
        {
            history = new List<Control>();
        }

        /// <summary>
        /// Añade el control al historial y modifica los valores del numero de operaciones del mismo
        /// </summary>
        /// <param name="toBuy">Control toBuy: UserControl itemToBuy eliminado del panel de compra</param>
        public void undo (Control toBuy)
        {
            history.Add(toBuy);
            --mUndoCount;
            ++mRedoCount;
        }

        /// <summary>
        /// Devuelve el control asociado al numero de operaciones realizadas sobre el historial
        /// </summary>
        /// <returns>Control toBuy: UserControl asociado a la posicion indicada | null: Si no es posible recuperar el UserControl</returns>
        public Control redo()
        {
            if ((history.Count - 1) - mRedoCount >= 0)
            {
                Control toBuy = history[mRedoCount];
                history.Remove(toBuy);
                --mRedoCount;
                ++mUndoCount;
                return toBuy;
            } else
            {
                return null;
            }
        }
    }
}
