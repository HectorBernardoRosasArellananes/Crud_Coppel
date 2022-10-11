using Crud_Coppel.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Coppel.CreateModal
{
    public partial class AddArticulo : Form
    {
        bool isUpdate = false;
        public static string IdInvUpdate = string.Empty;
        public AddArticulo()
        {
            InitializeComponent();
        }
        public AddArticulo(string IdArticulo,string nombre,string cantidad)
        {
            InitializeComponent();
            isUpdate = true;
            TxtNombre.Text = nombre;
            TxtCantidad.Text = Convert.ToDouble( cantidad).ToString();
            IdInvUpdate = IdArticulo;
            this.Text = "Update Articulo Id:" + IdArticulo;
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
         {
            if (TxtNombre.Text == string.Empty)
            {
                MessageBox.Show("Los nombre no puede estar vacio");
                return;
            }
            if (TxtCantidad.Text == string.Empty )
            {
                MessageBox.Show("La cantida no puede estar vacia");
                return;
            }

            if (Convert.ToInt32(TxtCantidad.Text) <= 0)
            {
                MessageBox.Show("Lacantidad no puede ser menor a 1");
                return;
            }

            var RequestInv = (dynamic)null;

            if (isUpdate)
            {
                RequestInv = new
                {
                    sku = IdInvUpdate,
                    nombre = TxtNombre.Text,
                    cantidad= Convert.ToInt32( TxtCantidad.Text),
                    
                };
            }
            else
            {
                RequestInv = new
                {
                    nombre = TxtNombre.Text,
                    cantidad = Convert.ToInt32(TxtCantidad.Text)
                };
            }
            string responseStatus = string.Empty;
            string response = Utilerias.MethodHttp.PostItem("http://localhost:8080/Inven/SaveInv", Utilerias.Global.token, RequestInv, ref responseStatus);
            var responseInv = JsonConvert.DeserializeObject<ResponseEntity>(response);
            var objstatus = JsonConvert.DeserializeObject<StatusEntity>(responseInv.meta.ToString());

            if (objstatus.Status == "OK")
            {
                var responseSave = JsonConvert.DeserializeObject<InventarioDetalle>(responseInv.data.ToString());
                if (responseSave != null)
                {
                    if (isUpdate)
                    {
                        MessageBox.Show("El articulo se actualizo correctamete, Id:" + IdInvUpdate);
                        IdInvUpdate = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("El articulo se guardo correctamete, Id:" + responseSave.Detallearticulo.sku.ToString());
                    }
                }

                this.Dispose();
                this.Close();

            }
            else
            {
                var objMesaje = JsonConvert.DeserializeObject<StatusEntity>(responseInv.data.ToString());
                MessageBox.Show(objMesaje.Mensaje);
            }
        }
    }

}
