using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack) //Valida, si es la primera vez que se carga la pagina
            {
                ConsultarCategorias();
            }
        }

        private void ConsultarCategorias()
        {
            using (var cnn = new TiendaEntities())
            {
                var listaCategorias = cnn.Categoria.OrderBy(c => c.NombreCategoria).ToList();
                listaCategorias.Insert(0, new Categoria() { IdCategoria = -1, NombreCategoria = "Todas" });
                cmbCategorias.DataSource = listaCategorias;
                cmbCategorias.DataTextField = "NombreCategoria";
                cmbCategorias.DataValueField = "IdCategoria";
                cmbCategorias.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var cnn = new TiendaEntities())
            {
                Producto producto = null;
                if (lstProductos.SelectedValue != null)
                {
                    producto = ConsultarProductoPorId(int.Parse(lstProductos.SelectedValue));
                }
                else
                {
                    producto = new Producto();
                }

                producto.IdCategoria = int.Parse(cmbCategorias.SelectedValue);
                producto.NombreProducto = txtNombreProducto.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.Precio = decimal.Parse(txtPrecio.Text);
                producto.Imagen = "IMG";


                if (producto.IdProducto == 0)
                {
                    cnn.Producto.Add(producto);
                }

                cnn.SaveChanges();
                LimpiarFormulario();
                ConsultarProductosPorCategoria();
            }

        }

        private void LimpiarFormulario()
        {
            txtNombreProducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }

        protected void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarProductosPorCategoria();
        }

        private void ConsultarProductosPorCategoria()
        {
            int idCategoria = int.Parse(cmbCategorias.SelectedValue);
            using (var cnn = new TiendaEntities())
            {
                var productos = (idCategoria > 0)
                                    ? cnn.Producto.Where(p => p.IdCategoria.Equals(idCategoria))
                                                  .OrderBy(p => p.NombreProducto).ToList()

                                    : cnn.Producto.OrderBy(p => p.NombreProducto).ToList();
                lstProductos.DataSource = productos;
                lstProductos.DataTextField = "NombreProducto";
                lstProductos.DataValueField = "IdProducto";
                lstProductos.DataBind();
            }
        }

        protected void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idProducto = int.Parse(lstProductos.SelectedValue);
            var producto = ConsultarProductoPorId(idProducto);
            txtNombreProducto.Text = producto.NombreProducto;
            txtDescripcion.Text = producto.Descripcion;
            txtPrecio.Text = producto.Precio.ToString();

        }

        private Producto ConsultarProductoPorId(int idProducto)
        {
            using (var cnn = new TiendaEntities())
            {
                return cnn.Producto.SingleOrDefault(p => p.IdProducto.Equals(idProducto));
            }
        }
    }
}