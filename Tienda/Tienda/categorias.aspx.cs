using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class categorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultarCategorias();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var cnn = new TiendaEntities())
            {
                var nuevaCategoria = new Categoria() {
                    NombreCategoria = txtNombreCategoria.Text,
                    Imagen = txtImagen.Text
                };

                cnn.Categoria.Add(nuevaCategoria);
                cnn.SaveChanges();
                ConsultarCategorias();
            }
        }

        private void ConsultarCategorias() {
            using (var cnn = new TiendaEntities())
            {
                lstCategorias.DataSource = cnn.Categoria.ToList();
                lstCategorias.DataTextField = "NombreCategoria";
                lstCategorias.DataValueField = "IdCategoria";
                lstCategorias.DataBind();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var cnn = new TiendaEntities())
            {
                
                if (txtBuscar.Text.Trim()=="")
                {
                    lstCategorias.DataSource = cnn.Categoria.ToList();
                }
                else
                {
                    var q = from c in cnn.Categoria
                            where c.NombreCategoria.ToUpper().StartsWith(txtBuscar.Text.ToUpper())
                            select c;
                    lstCategorias.DataSource = q.ToList();
                }
                lstCategorias.DataTextField = "NombreCategoria";
                lstCategorias.DataValueField = "IdCategoria";
                lstCategorias.DataBind();
            }
        }
    }
}