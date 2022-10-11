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
    public partial class AddPoliza : Form
    {
        bool isUpdate = false;
        public static string IdPolUpdate = string.Empty;
        public AddPoliza()
        {
            InitializeComponent();
      
        }
        public AddPoliza(string idpoliza,string idempleado,string idarticulo1,string cantidad)
        {
            InitializeComponent();
            TxtIdEmp.Text = idempleado;
            ConsultarEmpId(idempleado);
            TxtIdArt.Text = idarticulo1;
            ConsultarArtId(idarticulo1);

            TxtCantidadPol.Text = Convert.ToDouble( cantidad).ToString();
            IdPolUpdate = idpoliza;
            TxtCantidadPol.Focus();
        }

        private void TxtIdEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtIdArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtIdEmp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtIdArt.Focus();
            }
        }

        private void TxtIdArt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                TxtCantidadPol.Focus();
            }
        }

        private void TxtIdEmp_Leave(object sender, EventArgs e)
        {
            ConsultarEmpId(TxtIdEmp.Text);
        }

        public void ConsultarEmpId(string id) {


            if (TxtIdEmp.Text == string.Empty) {
                MessageBox.Show("El id empleado no puede ser vacio");
                TxtIdEmp.Text = string.Empty;
                TxtIdEmp.Focus();
                return;
            }

            if (Convert.ToInt32( TxtIdEmp.Text) <= 0)
            {
                MessageBox.Show("El id empleado no puede ser menor a 1");
                TxtIdEmp.Text = string.Empty;
                TxtIdEmp.Focus();
                return;
            }

            string responseStatus = string.Empty;
            string response = Utilerias.MethodHttp.GetItem("http://localhost:8080/Empleado/SelectEmpid/",Convert.ToInt32( id));
            var responseInv = JsonConvert.DeserializeObject<ResponseEntity>(response);

            var objstatus = JsonConvert.DeserializeObject<StatusEntity>(responseInv.meta.ToString());

            if (objstatus.Status == "OK")
            { 
                var objEmp = JsonConvert.DeserializeObject<EmpleadoDetalle>(responseInv.data.ToString());
                TxtNombreEmp.Text = objEmp.Empleado.nombre;
                TxtApellidoEmp.Text = objEmp.Empleado.apellido;
                TxtPuestoEmp.Text = objEmp.Empleado.puesto;
                
                TxtIdArt.Focus();
            }
            else
            {
                var objMensaje = JsonConvert.DeserializeObject<StatusEntity>(responseInv.data.ToString());
                MessageBox.Show(objMensaje.Mensaje);
                TxtIdEmp.Text = string.Empty;
                TxtIdEmp.Focus();
            }

        }

        public void ConsultarArtId(string id)
        {
            if (TxtIdArt.Text == string.Empty)
            {
                MessageBox.Show("El id articulo no puede ser vacio");
                TxtIdArt.Text = string.Empty;
                TxtIdArt.Focus();
                return;
            }

            if (Convert.ToInt32(TxtIdArt.Text) <= 0)
            {
                MessageBox.Show("El id articulo no puede ser menor a 1");
                TxtIdArt.Text = string.Empty;
                TxtIdArt.Focus();
                return;
            }

            string responseStatus = string.Empty;
            string response = Utilerias.MethodHttp.GetItem("http://localhost:8080/Inven/SelectId/", Convert.ToInt32(id));
            var responseInv = JsonConvert.DeserializeObject<ResponseEntity>(response);

            var objstatus = JsonConvert.DeserializeObject<StatusEntity>(responseInv.meta.ToString());

            if (objstatus.Status == "OK")
            {
                var objEmp = JsonConvert.DeserializeObject<InventarioDetalle>(responseInv.data.ToString());
                TxtNombreArt.Text = objEmp.Detallearticulo.nombre;
                TxtCantidadArt.Text = Convert.ToDouble( objEmp.Detallearticulo.cantidad).ToString();
                TxtCantidadPol.Focus();
            }
            else
            {
                var objMensaje = JsonConvert.DeserializeObject<StatusEntity>(responseInv.data.ToString());
                MessageBox.Show(objMensaje.Mensaje);
                TxtIdArt.Text = string.Empty;
                TxtIdArt.Focus();
            }

        }

        private void AddPoliza_Load(object sender, EventArgs e)
        {
            //TxtIdEmp.Text = string.Empty;
            //TxtIdEmp.Focus();
        }

        private void TxtIdArt_Leave(object sender, EventArgs e)
        {
            ConsultarArtId(TxtIdArt.Text);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtCantidadPol.Text == string.Empty) {
                MessageBox.Show("La cantidad de la poliza no puede ser vacia");
                TxtCantidadPol.Text = string.Empty;
                TxtCantidadPol.Focus();
                return;
            }

            if (Convert.ToInt32( TxtCantidadPol.Text) <= 1)
            {
                MessageBox.Show("La cantidad de la poliza no puede ser menor a 1");
                TxtCantidadPol.Text = string.Empty;
                TxtCantidadPol.Focus();
                return;
            }

            if (Convert.ToInt32( TxtCantidadPol.Text) > Convert.ToInt32( TxtCantidadArt.Text)) {
                MessageBox.Show("La cantidad poliza no puede ser mayor a la cantidad del inventario.");
                TxtCantidadPol.Text = string.Empty;
                TxtCantidadPol.Focus();
                return;
            }


            var RequestPol = (dynamic)null;

            if (isUpdate)
            {
                RequestPol = new
                {
                    idPolizas= IdPolUpdate,
                    empleadoGenero = Convert.ToInt32(TxtIdEmp.Text),
                    sku = Convert.ToInt32(TxtIdArt.Text),
                    cantidad = Convert.ToInt32(TxtCantidadPol.Text)

                };
            }
            else
            {
                RequestPol = new
                {
                    empleadoGenero = Convert.ToInt32(TxtIdEmp.Text),
                    sku = Convert.ToInt32(TxtIdArt.Text),
                    cantidad = Convert.ToInt32(TxtCantidadPol.Text)
                };
            }
            string responseStatus = string.Empty;
            string response = Utilerias.MethodHttp.PostItem("http://localhost:8080/Poliza/SavePol", Utilerias.Global.token, RequestPol, ref responseStatus);
            var responseInv = JsonConvert.DeserializeObject<ResponseEntity>(response);
            var objstatus = JsonConvert.DeserializeObject<StatusEntity>(responseInv.meta.ToString());

            if (objstatus.Status == "OK")
            {
                var responseSave = JsonConvert.DeserializeObject<PolizaItem>(responseInv.data.ToString());
                if (responseSave != null)
                {
                    if (isUpdate)
                    {
                        MessageBox.Show("La poliza se actualizo correctamete, Id:" + IdPolUpdate);
                        IdPolUpdate = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("La poliza se guardo correctamete, Id:" + responseSave.Poliza.idPolizas.ToString());
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
