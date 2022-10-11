using Crud_Coppel.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Coppel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AuthenticarLogin();
            }
        }

        public void AuthenticarLogin() {
            if (TxtUserName.Text == string.Empty)
            {
                MessageBox.Show("El usuario no puede ser vacio");
                return;
            }
            if (TxtPassword.Text == string.Empty)
            {
                MessageBox.Show("La contraseña no puede ser vacia");
                return;
            }

            var RequestLogin = new
            {
                celular = TxtUserName.Text, //"6871157648", 
                password = TxtPassword.Text //"password"
            };
            string responseStatus = string.Empty;
            string response= Utilerias.MethodHttp.PostItem("http://localhost:8080/auth/InitSesion", "", RequestLogin,ref responseStatus);
            if (string.IsNullOrEmpty(response)) {
                MessageBox.Show("Credenciales incorrectas");
                return;
            }
            var responseToken= JsonConvert.DeserializeObject<TokenEntity>(response);
            Utilerias.Global.token = responseToken.tokenAcceso;

            this.Dispose();
            this.Close();
            
            Thread threadSecundario = new Thread(new ThreadStart(OpenMenu));
            threadSecundario.Start();
            
        }

        private void BtnAcceso_Click(object sender, EventArgs e)
        {
            AuthenticarLogin();
        }

        public void OpenMenu()
        {
            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }
}
