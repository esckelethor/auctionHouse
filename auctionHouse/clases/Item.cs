using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auctionHouse.clases
{
    /// <summary>
    /// Calse con la que instaciaremos los objetos que venderemos en nuestra AH
    /// </summary>
    class Item
    {
        /// <summary>
        /// Constante que define el item con un grado de tier -1
        /// </summary>
        public static readonly Color CRUDE = Color.Gray;
        /// <summary>
        /// Constante que define el item con un grado de tier 0
        /// </summary>
        public static readonly Color BASIC = Color.Silver;
        /// <summary>
        /// Constante que define el item con un grado de tier 1
        /// </summary>
        public static readonly Color GRAND = Color.LimeGreen;
        /// <summary>
        /// Constante que define el item con un grado de tier 2
        /// </summary>
        public static readonly Color RARE = Color.RoyalBlue;
        /// <summary>
        /// Constante que define el item con un grado de tier 3
        /// </summary>
        public static readonly Color ARCANE = Color.Magenta;
        /// <summary>
        /// Constante que define el item con un grado de tier 4
        /// </summary>
        public static readonly Color HEROIC = Color.Coral;
        /// <summary>
        /// Constante que define el item con un grado de tier 5
        /// </summary>
        public static readonly Color UNIQUE = Color.LightCoral;
        /// <summary>
        /// Constante que define el item con un grado de tier 6
        /// </summary>
        public static readonly Color CELESTIAL = Color.Crimson;
        /// <summary>
        /// Constante que define el item con un grado de tier 7
        /// </summary>
        public static readonly Color DIVINE = Color.Tomato;
        /// <summary>
        /// Constante que define el item con un grado de tier 8
        /// </summary>
        public static readonly Color EPIC = Color.LightSteelBlue;
        /// <summary>
        /// Constante que define el item con un grado de tier 9
        /// </summary>
        public static readonly Color LEGENDARY = Color.Goldenrod;
        /// <summary>
        /// Constante que define el item con un grado de tier 10
        /// </summary>
        public static readonly Color MYTHIC = Color.Red;

        private Image mImagen;
        private string mNombre;
        private long mPrecio;
        private Boolean mDisponible;
        private int mCodigo;
        private int mUnidades;
        private string mCategoria;
        private Color mGrade;

        /// <summary>
        /// Constructor que permite instanciar un item con todo detalle
        /// </summary>
        /// <param name="imagen">Image imagen: Imagen del item (ResourceFile: drawableItems)</param>
        /// <param name="nombre">String nombre: Nombre del item</param>
        /// <param name="precio">long precio: Precio del item (Valores recomendados: 1000-400000)</param>
        /// <param name="disponible">boolean disponible: Establece si el item se puede comprar en funcion de las unidades</param>
        /// <param name="unidades">int unidades: Total de existencias del item</param>
        /// <param name="categoria">String categoria: Establece la categoria del item en el arbol (Ejemplo: WeaponH1Dagger)</param>
        /// <param name="grade">Color grade: Grado del item (Constante de la clase Item)</param>
        public Item(Image imagen, string nombre, long precio, Boolean disponible,
            int unidades, string categoria, Color grade) {

            this.mImagen = imagen;
            this.mNombre = nombre;
            this.mPrecio = precio;
            this.mDisponible = disponible;
            this.mUnidades = unidades;
            this.mCategoria = categoria;
            this.mGrade = grade;
        }

        /// <summary>
        /// Recupera o establece la imagen del item
        /// </summary>
        public Image imagen
        {
            get { return mImagen; }
            set { this.mImagen = imagen; }
        }

        /// <summary>
        /// Recupera o establece el nombre del item
        /// </summary>
        public string nombre
        {
            get { return mNombre; }
            set { this.mNombre = nombre; }
        }

        /// <summary>
        /// Recupera o establece el precio del item
        /// </summary>
        public long precio
        {
            get { return mPrecio; }
            set { this.mPrecio = precio; }
        }

        /// <summary>
        /// Recupera o establece la disponiblidad del item en funcion de las unidades
        /// </summary>
        public Boolean disponible
        {
            get { return mDisponible; }
            set { this.mDisponible = disponible; }
        }

        /// <summary>
        /// Recupera o establece el codigo del item
        /// </summary>
        public int codigo
        {
            get { return mCodigo; }
            set { this.mCodigo = codigo; }
        }

        /// <summary>
        /// Recupera o establece las existencias del item
        /// </summary>
        public int unidades
        {
            get { return mUnidades; }
            set { this.mUnidades = unidades; }
        }

        /// <summary>
        /// Recupera o establece la categoria del item en funcion de su situacion en el arbol
        /// </summary>
        public string categoria
        {
            get { return mCategoria; }
            set { this.mCategoria = categoria; }
        }

        /// <summary>
        /// Recupera o establece el grado del item
        /// </summary>
        public Color grade
        {
            get { return mGrade; }
            set { this.mGrade = grade; }
        }
    }
}
