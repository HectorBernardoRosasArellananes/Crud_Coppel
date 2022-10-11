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
    public partial class AddEmpleado : Form
    {
        bool isUpdate = false;
        public static string IdEmpUpdate=string.Empty;
        public AddEmpleado()
        {
            InitializeComponent();
        }

        public AddEmpleado(string idEmpleado,string nombres,string apellidos,string puesto)
        {
            
            InitializeComponent();
            isUpdate = true;
            TxtNombre.Text = nombres;
            TxtApellido.Text = apellidos;
            TxtPuesto.Text = puesto;
            IdEmpUpdate = idEmpleado;
            this.Text = "Update Empleado Id:" + idEmpleado;
        }


        private void AddEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == string.Empty) {
                MessageBox.Show("Los nombres no pueden estar vacios");
                return;
            }
            if (TxtApellido.Text == string.Empty)
            {
                MessageBox.Show("Los apellidos no pueden estar vacios");
                return;
            }
            
            if(TxtPuesto.Text == string.Empty)
            {
                MessageBox.Show("El puesto no puede estar vacio");
                return;
            }

            var RequestEmp = (dynamic)null;

            if (isUpdate)
            {
                RequestEmp = new
                {
                    idEmpleado = IdEmpUpdate,
                    nombre = TxtNombre.Text,
                    apellido = TxtApellido.Text,
                    puesto = TxtPuesto.Text
                };
            }
            else {
                RequestEmp = new
                {
                    nombre = TxtNombre.Text,
                    apellido = TxtApellido.Text,
                    puesto = TxtPuesto.Text
                };
            }

            string responseStatus = string.Empty;
            string response = Utilerias.MethodHttp.PostItem("http://localhost:8080/Empleado/SaveEmp", Utilerias.Global.token, RequestEmp, ref responseStatus);
            var responseEmp = JsonConvert.DeserializeObject<ResponseEntity>(response);
            var objstatus = JsonConvert.DeserializeObject<StatusEntity>(responseEmp.meta.ToString());
            if (objstatus.Status == "OK")
            {
                var responseSave = JsonConvert.DeserializeObject<EmpleadoDetalle>(responseEmp.data.ToString());
                if (responseSave != null)
                {
                    if (isUpdate) {
                        MessageBox.Show("El empleado se actualizo correctamete, Id:" + IdEmpUpdate);
                        IdEmpUpdate = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("El empleado se guardo correctamete, Id:" + responseSave.Empleado.idEmpleado.ToString());
                    }
                }

                this.Dispose();
                this.Close();
                
            }
            else {
                var objMesaje = JsonConvert.DeserializeObject<StatusEntity>(responseEmp.data.ToString());
                MessageBox.Show(objMesaje.Mensaje);
            }

            
        }
    }
 
}
