using auctionHouse.clases;
using listaPersonalizada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auctionHouse
{

    public partial class AuctionHouse : Form
    {
        /// <summary>
        /// Constante que define el alto de los UserControl: filaLista e itemToBuy
        /// </summary>
        private readonly int verticalPos = 70;
        /// <summary>
        /// Variable que guarda el alto del panel en el que establecemos los items encontrados por los parametros de busqueda
        /// </summary>
        private int maxHeightList;
        /// <summary>
        /// Variable que guarda el alto del panel en el que establecemos los items que deseamos comprar
        /// </summary>
        private int maxHeightToBuy;

        /// <summary>
        /// Variable que guarda el total de monedas del usuario
        /// </summary>
        private string coins;
        /// <summary>
        /// Variable que guarda el total a pagar por los items en la lista de compra
        /// </summary>
        private string total = "0";

        /// <summary>
        /// Variables que vinculan el estado del filtro del ToolStripButton con su grado
        /// <para>      Permite la carga dinamica de items segun los filtros de grado establecidos</para>
        /// </summary>
        private bool isCrude, isBasic, isGrand, isRare, isArcane, isHeroic,
            isUnique, isCelestial, isDivine, isEpic, isLegendary, isMythic;

        /// <summary>
        /// Array usado para almacenar los items de los que dispone nuestra AH
        /// </summary>
        private Item[] items;
        /// <summary>
        /// Coleccion que almacena los controles del panel de compra
        /// <para>      Permite persistir los items que deseamos comprar (Necesario al realizar la traduccion dinamica)</para>
        /// </summary>
        private List<Control> controls = new List<Control>();

        /// <summary>
        /// Objeto que genera una coleccion que administra las funciones Undo&Redo
        /// </summary>
        private UndoRedo history;

        /// <summary>
        /// Inicializacion basica del formulario
        /// <para>Se recupera la localizacion del equipo y se establece el idioma en funcion de la misma</para>
        /// <para>Se inicializan los componenetes y se establece una cantidad de monedas para el usuario</para>
        /// <para>En funcion de la localizacion establecemos el icono del lenguaje de nuesta app</para>
        /// </summary>
        public AuctionHouse()
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(CultureInfo.CurrentUICulture.Name);
            } catch (CultureNotFoundException ex) {
            } catch (ArgumentException ex) {
            }

            initialiceForm("10000000");

            if (CultureInfo.CurrentUICulture.Name == "es-ES")
            {
                imgLogo.Image = drawable.aaEs;
            }
            else
            {
                imgLogo.Image = drawable.aaEn;
            }
        }

        /// <summary>
        /// Permite filtar los items en funcion del estado del ToolStipButton pulsado
        /// <para>Establece la imagen del ToolStripButton en funcion de su variable booleana vinculada</para>
        /// <para>Carga los items basandose en el valor de todas la variables booleanas</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGrade_Click(object sender, EventArgs e)
        {
            setButtonGrade((ToolStripButton)sender, true);
            buscarItems();
        }

        /// <summary>
        /// Establece el valor de la imagen asociada al ToolStripButton pulsado y modifica el valor de su booleana asociada si es necesario
        /// </summary>
        /// <param name="sender">ToolStripButton sender: ToolSripButton pulsado</param>
        /// <param name="isClick">boolean isClick: Define si se debe modificar la booleana asociada al ToolSTripButton</param>
        private void setButtonGrade (ToolStripButton sender, bool isClick)
        {
            switch (sender.Name)
            {

                case "btnGradeCrude":
                    if (isClick)
                    {
                        isCrude = setGrade(isCrude, sender, drawableGrade.crudeOn, drawableGrade.crudeOff);
                    } else
                    {
                        setGrade(isCrude, sender, drawableGrade.crudeOff, drawableGrade.crudeOn);
                    }
                    break;

                case "btnGradeBasic":
                    if (isClick)
                    {
                        isBasic = setGrade(isBasic, sender, drawableGrade.basicOn, drawableGrade.basicOff);
                    } else
                    {
                        setGrade(isBasic, sender, drawableGrade.basicOff, drawableGrade.basicOn);
                    }
                    break;

                case "btnGradeGrand":
                    if (isClick)
                    {
                        isGrand = setGrade(isGrand, sender, drawableGrade.grandOn, drawableGrade.grandOff);
                    } else
                    {
                        setGrade(isGrand, sender, drawableGrade.grandOff, drawableGrade.grandOn);
                    }
                    break;

                case "btnGradeRare":
                    if (isClick)
                    {
                        isRare = setGrade(isRare, sender, drawableGrade.rareOn, drawableGrade.rareOff);
                    } else
                    {
                        setGrade(isRare, sender, drawableGrade.rareOff, drawableGrade.rareOn);
                    }
                    break;

                case "btnGradeArcane":
                    if (isClick) {
                        isArcane = setGrade(isArcane, sender, drawableGrade.arcaneOn, drawableGrade.arcaneOff);
                    } else
                    {
                        setGrade(isArcane, sender, drawableGrade.arcaneOff, drawableGrade.arcaneOn);
                    }
                    break;

                case "btnGradeHeroic":
                    if (isClick) {
                        isHeroic = setGrade(isHeroic, sender, drawableGrade.heroicOn, drawableGrade.heroicOff);
                    } else {
                        setGrade(isHeroic, sender, drawableGrade.heroicOff, drawableGrade.heroicOn);
                    }
                    break;

                case "btnGradeUnique":
                    if (isClick)
                    {
                        isUnique = setGrade(isUnique, sender, drawableGrade.uniqueOn, drawableGrade.uniqueOff);
                    } else
                    {
                        setGrade(isUnique, sender, drawableGrade.uniqueOff, drawableGrade.uniqueOn);
                    }
                    break;

                case "btnGradeCelestial":
                    if (isClick)
                    {
                        isCelestial = setGrade(isCelestial, sender, drawableGrade.celestialOn, drawableGrade.celestialOff);
                    } else
                    {
                        setGrade(isCelestial, sender, drawableGrade.celestialOff, drawableGrade.celestialOn);
                    }
                    break;

                case "btnGradeDivine":
                    if (isClick)
                    {
                        isDivine = setGrade(isDivine, sender, drawableGrade.divineOn, drawableGrade.divineOff);
                    } else
                    {
                        setGrade(isDivine, sender, drawableGrade.divineOff, drawableGrade.divineOn);
                    }
                    break;

                case "btnGradeEpic":
                    if (isClick) {
                        isEpic = setGrade(isEpic, sender, drawableGrade.epicOn, drawableGrade.epicOff);
                    } else
                    {
                        setGrade(isEpic, sender, drawableGrade.epicOff, drawableGrade.epicOn);
                    }
                    break;

                case "btnGradeLegendary":
                    if (isClick)
                    {
                        isLegendary = setGrade(isLegendary, sender, drawableGrade.legendaryOn, drawableGrade.legendaryOff);
                    } else
                    {
                        setGrade(isLegendary, sender, drawableGrade.legendaryOff, drawableGrade.legendaryOn);
                    }
                    break;

                case "btnGradeMythic":
                    if (isClick)
                    {
                        isMythic = setGrade(isMythic, sender, drawableGrade.mythicOn, drawableGrade.mythicOff);
                    } else
                    {
                        setGrade(isMythic, sender, drawableGrade.mythicOff, drawableGrade.mythicOn);
                    }
                    break;

                default:
                    //Botones deshacer y rehacer
                    break;
            }
        }

        /// <summary>
        /// Establece la imagen del ToolStripButton en funcion de la booleana y modifica el valor de la misma
        /// </summary>
        /// <param name="isGrade">boolean isGrade: Valor de la booleana asociada al ToolStripButton</param>
        /// <param name="btnGrade">ToolStripButton btnGrade: ToolStripBotton que genera el evento</param>
        /// <param name="gradeOn">Bitmap gradeOn: Establece la imagen del ToolStripButton asociada al boton activo (isGrade = true)</param>
        /// <param name="gradeOff">Bitmap gradeOff: Establece la imagen del ToolStripButton asociada al boton inactivo (isGrade = false)</param>
        /// <returns></returns>
        private bool setGrade (bool isGrade, ToolStripButton btnGrade, Bitmap gradeOn, Bitmap gradeOff)
        {

            if (isGrade)
            {
                btnGrade.Image = gradeOff;
                isGrade = false;
            } else
            {

                btnGrade.Image = gradeOn;
                isGrade = true;
            }

            return isGrade;
        }

        /// <summary>
        /// Limpia el panel de items buscados y muestra los items basandose en los nuevos parametros de busqueda
        /// <para>      Este proceso se realiza revisando el grado del item y comprobando si el valor del grado (variable boolean) esta activo</para>
        /// </summary>
        private void buscarItems()
        {
            pnlListItems.Controls.Clear();
            int total = 0;
            for (int i = 0; i < items.Length; i++)
            {

                switch (Convert.ToString(items[i].grade))
                {

                    case "Color [Gray]": //CRUDE
                        total = isGrade(items[i], isCrude, total);
                        break;

                    case "Color [Silver]": //BASIC
                        total = isGrade(items[i], isBasic, total);
                        break;

                    case "Color [LimeGreen]": //GRAND
                        total = isGrade(items[i], isGrand, total);
                        break;

                    case "Color [RoyalBlue]": //RARE
                        total = isGrade(items[i], isRare, total);
                        break;

                    case "Color [Magenta]": //ARCANE
                        total = isGrade(items[i], isArcane, total);
                        break;

                    case "Color [Coral]": //HEROIC
                        total = isGrade(items[i], isHeroic, total);
                        break;

                    case "Color [LightCoral]": //UNIQUE
                        total = isGrade(items[i], isUnique, total);
                        break;

                    case "Color [Crimson]": //CELESTIAL
                        total = isGrade(items[i], isCelestial, total);
                        break;

                    case "Color [Tomato]": //DIVINE
                        total = isGrade(items[i], isDivine, total);
                        break;

                    case "Color [LightSteelBlue]": //EPIC
                        total = isGrade(items[i], isEpic, total);
                        break;

                    case "Color [Goldenrod]": //LEGENDARY
                        total = isGrade(items[i], isLegendary, total);
                        break;

                    case "Color [Red]": //MYTHIC
                        total = isGrade(items[i], isMythic, total);
                        break;
                }
            }
        }

        /// <summary>
        /// Comprueba si el grado (variable boolean) es coincidente con el del item y lo carga en el panel de busqueda
        /// </summary>
        /// <param name="item">Item item: Objeto de la clase Item</param>
        /// <param name="grade">boolean grade: Variable global asociada al grado del item (Ejemplo: GradoItem = Divine - boolean isDivine)</param>
        /// <param name="total">int total: Valor actual del total de items en el panel de busqueda</param>
        /// <returns>int total: Valor total de items en el panel de busqueda (necesario para calcular la posicion del siguiente en el eje Y)</returns>
        private int isGrade (Item item, bool grade, int total)
        {
            if (grade)
            {
                anadirItem(item, total);
                ++total;
            }
            return total;
        }

        /// <summary>
        /// Instancia un UserControl filaLista con los datos del item el el panel de busqueda
        /// <para>Segun el total de items en el panel se establece su posicion en el eje Y</para>
        /// </summary>
        /// <param name="item">Item item: Objeto de la clase Item</param>
        /// <param name="pos">int pos: Valor total de Controles dentro del panel de busqueda</param>
        private void anadirItem(Item item, int pos)
        {
            filaLista pnlFila = new filaLista();
            if (verticalPos * pos < maxHeightList)
            {
                pnlFila.Size = new Size(pnlListItems.Width, verticalPos);
            } else
            {
                pnlFila.Size = new Size(pnlListItems.Width - 18, verticalPos);
            }
            pnlFila.Location = new Point(0, verticalPos * pos);
            pnlFila.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            pnlFila.setImagenItem(item.imagen);
            pnlFila.setNombreItem(item.nombre);
            pnlFila.setPrecioItem(Convert.ToString(item.precio));
            pnlFila.setGradeColor(item.grade);
            pnlListItems.Controls.Add(pnlFila);
        }

        /// <summary>
        /// Inicializa el formulario basandose en la nueva localizacion
        /// <para>Establece el maximo de caracteres en la busqueda por nivel</para>
        /// <para>Reinicia la seleccion del arbol de filtros</para>
        /// <para>Reactiva los campos de busqueda por grado</para>
        /// <para>Persiste los items en la lista de compra y los items buscados</para>
        /// <para>Persiste el total a pagar por los items en la lista de compra</para>
        /// <para>Reinicia el historial de Undo&Redo</para>
        /// </summary>
        /// <param name="coins">String coins: Establece la cantidad de monedas del usuario</param>
        private void initialiceForm (string coins)
        {
            this.Controls.Clear();
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;

            lblBuyList.AllowDrop = true;
            maxHeightList = pnlListItems.Height;
            maxHeightToBuy = pnlItemsToBuy.Height;

            foreach (ToolStripItem button in toolStrip.Items)
            {
                if (button is ToolStripButton)
                {
                    setButtonGrade((ToolStripButton)button, false);
                }
            }

            foreach (Control control in controls)
            {
                pnlItemsToBuy.Controls.Add(control);
            }

            history = new UndoRedo();
            btnUndo.Enabled = false;
            btnRedo.Enabled = false;

            txtMaxLevel.MaxLength = 2;
            txtMinLevel.MaxLength = 2;
            treeAH.SelectedNode = treeAH.Nodes[0];
            lblTextMyCoins.setPrecio(coins);
            lblPrecio.setPrecio(total);
            items = Operaciones.cargarItems();
            buscarItems();
        }

        /// <summary>
        /// Establece el nuevo idioma de la app en funcion del idioma seleccionado en el menu contextual
        /// <para>Persiste el total de monedas del usuario</para>
        /// </summary>
        /// <param name="sender">Object sender: ToolStripMenuItem que desencadena el evento y establece el idioma de traduccion</param>
        /// <param name="e"></param>
        private void languageMenuItem_Click(object sender, EventArgs e)
        {
            coins = lblTextMyCoins.getPrecio();
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "englishToolStripMenuItem":
                    translateForm("en");
                    break;

                case "spanishToolStripMenuItem":
                    translateForm("es-ES");
                    break;
            }
        }

        /// <summary>
        /// Carga la nueva cultura asociada al idioma pasado como parametro
        /// <para>Persiste los controles en el panel de compra</para>
        /// <para>Recarga el formulario y establece el icono del lenguaje de nuestra app</para>
        /// </summary>
        /// <param name="language">String language: Codigo del idioma</param>
        private void translateForm (string language)
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            }
            catch (CultureNotFoundException ex) {
            } catch (ArgumentException ex) {
            }

            foreach (Control control in pnlItemsToBuy.Controls)
            {
                controls.Add(control);
            }

            switch (language)
            {

                case "en":
                    initialiceForm(coins);
                    imgLogo.Image = drawable.aaEn;
                    break;

                case "es-ES":
                    initialiceForm(coins);
                    imgLogo.Image = drawable.aaEs;
                    break;
            }
        }

        /// <summary>
        /// Metodo para implementar Drag&Drop
        /// <para>Establece el efecto que se desencadena al arrastrar un UserControl filaLista al panel de compra</para>
        /// <para>Efecto de Drag&Drop: Copia (Genera una copia simplificada del UserControl)</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlItemsToBuy_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        /// <summary>
        /// Metodo para implementar Drag&Drop
        /// <para>Instancia un UserControl itemToBuy basandose en los datos copiados del UserControl arrastrado (filaLista)</para>
        /// <para>Se genera una copia simplifaca del UserControl y se instancia en el panel de items a comprar</para>
        /// <para>      Recalcula el total a pagar</para>
        /// <para>      Se incrementa el historial de Undo&Redo</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlItemsToBuy_DragDrop(object sender, DragEventArgs e)
        {
            int pos = pnlItemsToBuy.Controls.Count;
            itemToBuy toBuy = new itemToBuy();
            if (verticalPos * pos < maxHeightToBuy)
            {
                toBuy.Size = new Size(pnlItemsToBuy.Width, verticalPos);
            }
            else
            {
                toBuy.Size = new Size(pnlItemsToBuy.Width - 18, verticalPos);
            }
            toBuy.Location = new Point(0, verticalPos * pos);
            toBuy.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            List<object> itemData = (List<object>)e.Data.GetData(typeof(List<object>));
            for (int i = 0; i < itemData.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        toBuy.setImagenItem((Bitmap)itemData[i]);
                        break;

                    case 1:
                        toBuy.setPrecioItem(itemData[i].ToString());
                        break;

                    case 2:
                        toBuy.setGradeColor(Color.FromName((string)itemData[i]));
                        break;
                }
            }

            total = Convert.ToString(Convert.ToInt64(lblPrecio.getPrecio()) + Convert.ToInt64(toBuy.getPrecioItem()));
            lblPrecio.setPrecio(total);

            pnlItemsToBuy.Controls.Add(toBuy);
            controls.Add(toBuy);

            ++history.mUndoCount;
            if (history.mUndoCount > 0)
            {
                btnUndo.Image = drawable.undoOn;
               btnUndo.Enabled = true;
            }
        }

        /// <summary>
        /// Establece los cambios en el historial de undo y habilita redo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (history.mUndoCount > 0)
            {
                Control toBuy = pnlItemsToBuy.Controls[controls.Count - 1];
                pnlItemsToBuy.Controls.Remove(toBuy);
                controls.Remove(toBuy);
                total = Convert.ToString(Convert.ToInt64(lblPrecio.getPrecio()) - Convert.ToInt64(((itemToBuy)toBuy).getPrecioItem()));
                lblPrecio.setPrecio(total);
                history.undo(toBuy);
                if (history.mUndoCount == 0)
                {
                    btnUndo.Image = drawable.undoOff;
                    btnUndo.Enabled = false;
                }
                if (history.mRedoCount >= 0)
                {
                    btnRedo.Image = drawable.redoOn;
                    btnRedo.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Establece los cambios en el historial de redo y habilita undo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRedo_Click(object sender, EventArgs e)
        {
            Control toBuy = history.redo();
            if (toBuy != null)
            {
                pnlItemsToBuy.Controls.Add(toBuy);
                controls.Add(toBuy);
                total = Convert.ToString(Convert.ToInt64(lblPrecio.getPrecio()) + Convert.ToInt64(((itemToBuy)toBuy).getPrecioItem()));
                lblPrecio.setPrecio(total);
            }

            if (history.mRedoCount < 0)
            {
                btnRedo.Image = drawable.redoOff;
                btnRedo.Enabled = false;
            }
            if (history.mUndoCount > 0)
            {
                btnUndo.Image = drawable.undoOn;
                btnUndo.Enabled = true;
            }
        }
    }
}
