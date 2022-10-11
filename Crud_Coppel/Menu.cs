using Crud_Coppel.Entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Coppel
{
    public partial class Menu : Form
    {
        public static int Tipo_Modulo_activo;
        public Menu()
        {
            InitializeComponent();
        }


        public void inicializaGridBotton() {

            DataGridViewButtonColumn DeleteButtonColumn = new DataGridViewButtonColumn();
            DeleteButtonColumn.Name = "Delete";
            DeleteButtonColumn.Text = "Eliminar";
            DeleteButtonColumn.UseColumnTextForButtonValue = true;
            GridListados.Columns.Add(DeleteButtonColumn);

            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.Name = "Update";
            updateButtonColumn.Text = "Actualizar";
            updateButtonColumn.UseColumnTextForButtonValue = true;
            GridListados.Columns.Add(updateButtonColumn);

            //GridListados.CellClick += GridListadoseUpdate_CellClick;

        }

        public void GridListadoseOptionSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { 
                return; 
            }
            else
            {
                if (e.ColumnIndex == GridListados.Columns["Update"].Index)
                {
                    if (Tipo_Modulo_activo == 1)
                    {
                        int IdEmpleado = Convert.ToInt32(GridListados.Rows[e.RowIndex].Cells[0].Value.ToString());
                        string nombres = GridListados.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string apellidos = GridListados.Rows[e.RowIndex].Cells[2].Value.ToString();
                        string puesto = GridListados.Rows[e.RowIndex].Cells[3].Value.ToString();
                        Empleado Emp = new Empleado();
                        Emp.idEmpleado = IdEmpleado;
                        Emp.nombre = nombres;
                        Emp.apellido = apellidos;
                        Emp.puesto = puesto;
                        OpenAddEmpleado("Update", Emp);
                    }
                    if (Tipo_Modulo_activo == 2)
                    {
                        int IdArticulo = Convert.ToInt32(GridListados.Rows[e.RowIndex].Cells[0].Value.ToString());
                        string nombres = GridListados.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string Cantidad =  GridListados.Rows[e.RowIndex].Cells[2].Value.ToString();
                        Detallearticulo Inv = new Detallearticulo();
                        Inv.sku = IdArticulo;
                        Inv.nombre = nombres;
                        Inv.cantidad = Cantidad;
                        OpenAddArticulo("Update", Inv);
                    }
                    if (Tipo_Modulo_activo == 3)
                    {
                        int IdPoliza = Convert.ToInt32(GridListados.Rows[e.RowIndex].Cells[0].Value.ToString());
                        string IdArticulo = GridListados.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string IdEmpleado = GridListados.Rows[e.RowIndex].Cells[2].Value.ToString();
                        string Cantidad = GridListados.Rows[e.RowIndex].Cells[3].Value.ToString();

                        Poliza Pol = new Poliza();

                        Pol.idPolizas = IdPoliza;
                        Pol.empleadoGenero = Convert.ToInt32(IdArticulo);
                        Pol.sku = Convert.ToInt32(IdEmpleado);
                        Pol.cantidad = Cantidad;
                        OpenAddPoliza("Update", Pol);

                    }
                }
                if (e.ColumnIndex == GridListados.Columns["Delete"].Index)
                {

                    if (MessageBox.Show("¿Desea eliminar el registro", "Confirma eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (Tipo_Modulo_activo == 1)
                        {
                            int IdEmpleado = Convert.ToInt32(GridListados.Rows[e.RowIndex].Cells[0].Value.ToString());
                            if (DeleteEmpleado(IdEmpleado))
                            {
                                GridListados.Rows.RemoveAt(e.RowIndex);
                            }
                            return;
                        }
                        if (Tipo_Modulo_activo == 2)
                        {
                            int IdInv = Convert.ToInt32(GridListados.Rows[e.RowIndex].Cells[0].Value.ToString());
                            if (Deletearticulo(IdInv))
                            {
                                GridListados.Rows.RemoveAt(e.RowIndex);
                            }
                            return;
                        }
                        if (Tipo_Modulo_activo == 3)
                        {
                            int IdPol = Convert.ToInt32(GridListados.Rows[e.RowIndex].Cells[0].Value.ToString());
                            if (DeletePoliza(IdPol))
                            {
                                GridListados.Rows.RemoveAt(e.RowIndex);
                            }
                            return;
                        }
                    }
                    else
                    {
                        return;

                    }

                }

            }
        }
 
        private void BtnArticulos_Click(object sender, EventArgs e)
        {
            Tipo_Modulo_activo = 2;
            GetArticulosList();
        }

        public bool DeleteEmpleado(int id) {
            string responseStatus = string.Empty;
            string response = Utilerias.MethodHttp.DeleteItem("http://localhost:8080/Empleado/DeleteEmp/", Utilerias.Global.token,id);
            var responseEmp = JsonConvert.DeserializeObject<ResponseEntity>(response);
            var objstatus = JsonConvert.DeserializeObject<StatusEntity>(responseEmp.meta.ToString());
            var objMesaje = JsonConvert.DeserializeObject<StatusEntity>(responseEmp.data.ToString());
            if (objstatus.Status == "OK")
            {
                MessageBox.Show(objMesaje.Mensaje + ": id " + id.ToString());
                return true;
            }
            else {
                MessageBox.Show(objMesaje.Mensaje);
                return false;
            }
        }

        public bool Deletearticulo(int id)
        {
            string responseStatus = string.Empty;
            string response = Utilerias.MethodHttp.DeleteItem("http://localhost:8080/Inven/DeleteInv/", Utilerias.Global.token, id);
            var responseInv = JsonConvert.DeserializeObject<ResponseEntity>(response);
            var objstatus = JsonConvert.DeserializeObject<StatusEntity>(responseInv.meta.ToString());
            var objMesaje = JsonConvert.DeserializeObject<StatusEntity>(responseInv.data.ToString());
            if (objstatus.Status == "OK")
            {
                MessageBox.Show(objMesaje.Mensaje + ": id " + id.ToString());
                return true;
            }
            else
            {
                MessageBox.Show(objMesaje.Mensaje);
                return false;
            }
        }

        public bool DeletePoliza(int id)
        {
            string responseStatus = string.Empty;
            string response = Utilerias.MethodHttp.DeleteItem("http://localhost:8080/Poliza/DeletePol/", Utilerias.Global.token, id);
            var responseInv = JsonConvert.DeserializeObject<ResponseEntity>(response);
            var objstatus = JsonConvert.DeserializeObject<StatusEntity>(responseInv.meta.ToString());
            var objMesaje = JsonConvert.DeserializeObject<StatusEntity>(responseInv.data.ToString());
            if (objstatus.Status == "OK")
            {
                MessageBox.Show(objMesaje.Mensaje + ": id " + id.ToString());
                return true;
            }
            else
            {
                MessageBox.Show(objMesaje.Mensaje);
                return false;
            }
        }

        public  void GetEmpleadosList() {
            GridListados.Columns.Clear();
            GridListados.Rows.Clear();
            string responseStatus = string.Empty;
            string response =  Utilerias.MethodHttp.GetItems("http://localhost:8080/Empleado/SelectAll");
            var responseEmp = JsonConvert.DeserializeObject<ResponseEntity>(response);

            var objstatus = JsonConvert.DeserializeObject<StatusEntity>(responseEmp.meta.ToString());

            if (objstatus.Status == "OK")
            {

                var objEmpleado = JsonConvert.DeserializeObject<EmpleadoDetalleList>(responseEmp.data.ToString());

                GridListados.ColumnCount = 4;
                GridListados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                // Set the column header style.
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Aqua;
                columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
                GridListados.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

                GridListados.Columns[0].Name = "Id Empleado";
                GridListados.Columns[1].Name = "Nombre";
                GridListados.Columns[2].Name = "Apellido";
                GridListados.Columns[3].Name = "Puesto";


                foreach (Empleado rowArray in objEmpleado.Empleado)
                {
                    string[] row = new string[] { rowArray.idEmpleado.ToString(), rowArray.nombre, rowArray.apellido, rowArray.puesto };
                    GridListados.Rows.Add(row);
                }

                inicializaGridBotton();
            }
            else {
                var objMensaje = JsonConvert.DeserializeObject<StatusEntity>(responseEmp.data.ToString());
                MessageBox.Show(objMensaje.Mensaje);
            }
        }

        public void GetArticulosList()
        {
            GridListados.Columns.Clear();
            GridListados.Rows.Clear();
            string responseStatus = string.Empty;
            string response = Utilerias.MethodHttp.GetItems("http://localhost:8080/Inven/SelectAll");
            var responseInv = JsonConvert.DeserializeObject<ResponseEntity>(response);

            var objstatus = JsonConvert.DeserializeObject<StatusEntity>(responseInv.meta.ToString());

            if (objstatus.Status == "OK")
            {

                var objArt = JsonConvert.DeserializeObject<InventarioDetalleList>(responseInv.data.ToString());

                GridListados.ColumnCount = 3;
                GridListados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                // Set the column header style.
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Aqua;
                columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
                GridListados.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

                GridListados.Columns[0].Name = "Id Articulo";
                GridListados.Columns[1].Name = "Nombre";
                GridListados.Columns[2].Name = "Cantidad Inv";

                foreach (Detallearticulo rowArray in objArt.Detallearticulo)
                {
                    string[] row = new string[] { rowArray.sku.ToString(), rowArray.nombre, rowArray.cantidad };
                    GridListados.Rows.Add(row);
                }

                inicializaGridBotton();
            }
            else {
                var objMensaje = JsonConvert.DeserializeObject<StatusEntity>(responseInv.data.ToString());
                MessageBox.Show(objMensaje.Mensaje);
            }
        }

        public void GetPolizasList()
        {
            GridListados.Columns.Clear();
            GridListados.Rows.Clear();
            string responseStatus = string.Empty;
            string response = Utilerias.MethodHttp.GetItems("http://localhost:8080/Poliza/SelectAll");
            var responsePol = JsonConvert.DeserializeObject<ResponseEntity>(response);

            var objstatus = JsonConvert.DeserializeObject<StatusEntity>(responsePol.meta.ToString());

            if (objstatus.Status == "OK")
            {

                var objPoliza = JsonConvert.DeserializeObject<PolizaList>(responsePol.data.ToString());

                GridListados.ColumnCount = 5;
                GridListados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                // Set the column header style.
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Aqua;
                columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
                GridListados.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

                GridListados.Columns[0].Name = "Id poliza ";
                GridListados.Columns[1].Name = "Id articulo";
                GridListados.Columns[2].Name = "Id empleado";
                GridListados.Columns[3].Name = "Cantidad";
                GridListados.Columns[4].Name = "Fecha";


                foreach (Poliza rowArray in objPoliza.Poliza)
                {
                    string Fecha = DateTime.Parse(rowArray.fecha).ToString("MM/dd/yyyy hh:mm tt");
                    string[] row = new string[] { rowArray.idPolizas.ToString(), rowArray.sku.ToString(), rowArray.empleadoGenero.ToString(), rowArray.cantidad.ToString(), Fecha };
                    GridListados.Rows.Add(row);
                }

                inicializaGridBotton();
            }
            else
            {
                var objMensaje = JsonConvert.DeserializeObject<StatusEntity>(responsePol.data.ToString());
                MessageBox.Show(objMensaje.Mensaje);
            }
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            Tipo_Modulo_activo = 1;
            GetEmpleadosList();
        }

        private void BtnAddEmpleado_Click(object sender, EventArgs e)
        {
            OpenAddEmpleado("Save",new Empleado());
        }

        public void OpenAddEmpleado(string TipoAccion,Empleado emp) {
            if (TipoAccion == "Save")
            {
                CreateModal.AddEmpleado AddEmp = new CreateModal.AddEmpleado();
                AddEmp.TxtNombre.Focus();
                AddEmp.ShowDialog();
                
            }
            else
            {

                CreateModal.AddEmpleado AddEmp = new CreateModal.AddEmpleado(emp.idEmpleado.ToString(),emp.nombre,emp.apellido,emp.puesto);
                AddEmp.TxtNombre.Focus();
                AddEmp.ShowDialog();
                
            }
            GetEmpleadosList();
        }

        public void OpenAddArticulo(string TipoAccion, Detallearticulo Inv)
        {
            if (TipoAccion == "Save")
            {
                CreateModal.AddArticulo AddArt = new CreateModal.AddArticulo();
                AddArt.TxtNombre.Focus();
                AddArt.ShowDialog();

            }
            else
            {

                CreateModal.AddArticulo AddArt = new CreateModal.AddArticulo(Inv.sku.ToString(), Inv.nombre, Inv.cantidad);
                AddArt.TxtNombre.Focus();
                AddArt.ShowDialog();

            }
            GetArticulosList();
        }

        public void OpenAddPoliza(string TipoAccion, Poliza Pol)
        {
            if (TipoAccion == "Save")
            {
                CreateModal.AddPoliza AddPol = new CreateModal.AddPoliza();
                AddPol.ShowDialog();

            }
            else
            {

                CreateModal.AddPoliza AddPol = new CreateModal.AddPoliza(Pol.idPolizas.ToString(), Pol.empleadoGenero.ToString(), Pol.sku.ToString(),Pol.cantidad.ToString());
                AddPol.ShowDialog();

            }
            GetPolizasList();
        }

        private void GridListados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridListadoseOptionSelect(sender, e);
        }

        private void BtnAddArticulo_Click(object sender, EventArgs e)
        {
            OpenAddArticulo("Save", new Detallearticulo());
        }

        private void BtnPolizas_Click(object sender, EventArgs e)
        {
            Tipo_Modulo_activo = 3;
            GetPolizasList();
        }

        private void BtnAddPoliza_Click(object sender, EventArgs e)
        {
            OpenAddPoliza("Save", new Poliza());
        }
    }

 
}
