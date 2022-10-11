
namespace Crud_Coppel.CreateModal
{
    partial class AddPoliza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrupEmp = new System.Windows.Forms.GroupBox();
            this.TxtIdEmp = new System.Windows.Forms.TextBox();
            this.LbIdEmp = new System.Windows.Forms.Label();
            this.LbPuestoEmp = new System.Windows.Forms.Label();
            this.LbApellidosEmp = new System.Windows.Forms.Label();
            this.LbNombreEmp = new System.Windows.Forms.Label();
            this.TxtPuestoEmp = new System.Windows.Forms.TextBox();
            this.TxtApellidoEmp = new System.Windows.Forms.TextBox();
            this.TxtNombreEmp = new System.Windows.Forms.TextBox();
            this.GrupArt = new System.Windows.Forms.GroupBox();
            this.TxtIdArt = new System.Windows.Forms.TextBox();
            this.LbIdArt = new System.Windows.Forms.Label();
            this.LbCantidadArt = new System.Windows.Forms.Label();
            this.TxtCantidadArt = new System.Windows.Forms.TextBox();
            this.LbNombreArt = new System.Windows.Forms.Label();
            this.TxtNombreArt = new System.Windows.Forms.TextBox();
            this.GrupPoliza = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.TxtCantidadPol = new System.Windows.Forms.TextBox();
            this.LbCantidadPol = new System.Windows.Forms.Label();
            this.GrupEmp.SuspendLayout();
            this.GrupArt.SuspendLayout();
            this.GrupPoliza.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrupEmp
            // 
            this.GrupEmp.Controls.Add(this.TxtIdEmp);
            this.GrupEmp.Controls.Add(this.LbIdEmp);
            this.GrupEmp.Controls.Add(this.LbPuestoEmp);
            this.GrupEmp.Controls.Add(this.LbApellidosEmp);
            this.GrupEmp.Controls.Add(this.LbNombreEmp);
            this.GrupEmp.Controls.Add(this.TxtPuestoEmp);
            this.GrupEmp.Controls.Add(this.TxtApellidoEmp);
            this.GrupEmp.Controls.Add(this.TxtNombreEmp);
            this.GrupEmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GrupEmp.Location = new System.Drawing.Point(12, 12);
            this.GrupEmp.Name = "GrupEmp";
            this.GrupEmp.Size = new System.Drawing.Size(295, 274);
            this.GrupEmp.TabIndex = 0;
            this.GrupEmp.TabStop = false;
            this.GrupEmp.Text = "Info Empleado";
            // 
            // TxtIdEmp
            // 
            this.TxtIdEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtIdEmp.Location = new System.Drawing.Point(0, 57);
            this.TxtIdEmp.Name = "TxtIdEmp";
            this.TxtIdEmp.Size = new System.Drawing.Size(295, 29);
            this.TxtIdEmp.TabIndex = 14;
            this.TxtIdEmp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIdEmp_KeyDown);
            this.TxtIdEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdEmp_KeyPress);
            this.TxtIdEmp.Leave += new System.EventHandler(this.TxtIdEmp_Leave);
            // 
            // LbIdEmp
            // 
            this.LbIdEmp.AutoSize = true;
            this.LbIdEmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbIdEmp.Location = new System.Drawing.Point(6, 29);
            this.LbIdEmp.Name = "LbIdEmp";
            this.LbIdEmp.Size = new System.Drawing.Size(123, 25);
            this.LbIdEmp.TabIndex = 13;
            this.LbIdEmp.Text = "Id Empleado";
            // 
            // LbPuestoEmp
            // 
            this.LbPuestoEmp.AutoSize = true;
            this.LbPuestoEmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbPuestoEmp.Location = new System.Drawing.Point(6, 209);
            this.LbPuestoEmp.Name = "LbPuestoEmp";
            this.LbPuestoEmp.Size = new System.Drawing.Size(73, 25);
            this.LbPuestoEmp.TabIndex = 12;
            this.LbPuestoEmp.Text = "Puesto";
            // 
            // LbApellidosEmp
            // 
            this.LbApellidosEmp.AutoSize = true;
            this.LbApellidosEmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbApellidosEmp.Location = new System.Drawing.Point(6, 149);
            this.LbApellidosEmp.Name = "LbApellidosEmp";
            this.LbApellidosEmp.Size = new System.Drawing.Size(94, 25);
            this.LbApellidosEmp.TabIndex = 11;
            this.LbApellidosEmp.Text = "Apellidos";
            // 
            // LbNombreEmp
            // 
            this.LbNombreEmp.AutoSize = true;
            this.LbNombreEmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbNombreEmp.Location = new System.Drawing.Point(6, 89);
            this.LbNombreEmp.Name = "LbNombreEmp";
            this.LbNombreEmp.Size = new System.Drawing.Size(99, 25);
            this.LbNombreEmp.TabIndex = 10;
            this.LbNombreEmp.Text = "Nombres ";
            // 
            // TxtPuestoEmp
            // 
            this.TxtPuestoEmp.Enabled = false;
            this.TxtPuestoEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPuestoEmp.Location = new System.Drawing.Point(0, 237);
            this.TxtPuestoEmp.Name = "TxtPuestoEmp";
            this.TxtPuestoEmp.Size = new System.Drawing.Size(295, 29);
            this.TxtPuestoEmp.TabIndex = 9;
            // 
            // TxtApellidoEmp
            // 
            this.TxtApellidoEmp.Enabled = false;
            this.TxtApellidoEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtApellidoEmp.Location = new System.Drawing.Point(0, 177);
            this.TxtApellidoEmp.Name = "TxtApellidoEmp";
            this.TxtApellidoEmp.Size = new System.Drawing.Size(295, 29);
            this.TxtApellidoEmp.TabIndex = 8;
            // 
            // TxtNombreEmp
            // 
            this.TxtNombreEmp.Enabled = false;
            this.TxtNombreEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreEmp.Location = new System.Drawing.Point(0, 117);
            this.TxtNombreEmp.Name = "TxtNombreEmp";
            this.TxtNombreEmp.Size = new System.Drawing.Size(295, 29);
            this.TxtNombreEmp.TabIndex = 7;
            // 
            // GrupArt
            // 
            this.GrupArt.Controls.Add(this.TxtIdArt);
            this.GrupArt.Controls.Add(this.LbIdArt);
            this.GrupArt.Controls.Add(this.LbCantidadArt);
            this.GrupArt.Controls.Add(this.TxtCantidadArt);
            this.GrupArt.Controls.Add(this.LbNombreArt);
            this.GrupArt.Controls.Add(this.TxtNombreArt);
            this.GrupArt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GrupArt.Location = new System.Drawing.Point(313, 12);
            this.GrupArt.Name = "GrupArt";
            this.GrupArt.Size = new System.Drawing.Size(295, 274);
            this.GrupArt.TabIndex = 1;
            this.GrupArt.TabStop = false;
            this.GrupArt.Text = "Info Articulo";
            // 
            // TxtIdArt
            // 
            this.TxtIdArt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtIdArt.Location = new System.Drawing.Point(0, 57);
            this.TxtIdArt.Name = "TxtIdArt";
            this.TxtIdArt.Size = new System.Drawing.Size(295, 29);
            this.TxtIdArt.TabIndex = 15;
            this.TxtIdArt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIdArt_KeyDown);
            this.TxtIdArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdArt_KeyPress);
            this.TxtIdArt.Leave += new System.EventHandler(this.TxtIdArt_Leave);
            // 
            // LbIdArt
            // 
            this.LbIdArt.AutoSize = true;
            this.LbIdArt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbIdArt.Location = new System.Drawing.Point(6, 29);
            this.LbIdArt.Name = "LbIdArt";
            this.LbIdArt.Size = new System.Drawing.Size(107, 25);
            this.LbIdArt.TabIndex = 14;
            this.LbIdArt.Text = "Id Articulo";
            // 
            // LbCantidadArt
            // 
            this.LbCantidadArt.AutoSize = true;
            this.LbCantidadArt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbCantidadArt.Location = new System.Drawing.Point(6, 149);
            this.LbCantidadArt.Name = "LbCantidadArt";
            this.LbCantidadArt.Size = new System.Drawing.Size(92, 25);
            this.LbCantidadArt.TabIndex = 13;
            this.LbCantidadArt.Text = "Cantidad";
            // 
            // TxtCantidadArt
            // 
            this.TxtCantidadArt.Enabled = false;
            this.TxtCantidadArt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtCantidadArt.Location = new System.Drawing.Point(0, 177);
            this.TxtCantidadArt.Name = "TxtCantidadArt";
            this.TxtCantidadArt.Size = new System.Drawing.Size(295, 29);
            this.TxtCantidadArt.TabIndex = 12;
            // 
            // LbNombreArt
            // 
            this.LbNombreArt.AutoSize = true;
            this.LbNombreArt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbNombreArt.Location = new System.Drawing.Point(6, 89);
            this.LbNombreArt.Name = "LbNombreArt";
            this.LbNombreArt.Size = new System.Drawing.Size(99, 25);
            this.LbNombreArt.TabIndex = 11;
            this.LbNombreArt.Text = "Nombres ";
            // 
            // TxtNombreArt
            // 
            this.TxtNombreArt.Enabled = false;
            this.TxtNombreArt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreArt.Location = new System.Drawing.Point(0, 117);
            this.TxtNombreArt.Name = "TxtNombreArt";
            this.TxtNombreArt.Size = new System.Drawing.Size(295, 29);
            this.TxtNombreArt.TabIndex = 10;
            // 
            // GrupPoliza
            // 
            this.GrupPoliza.Controls.Add(this.BtnGuardar);
            this.GrupPoliza.Controls.Add(this.TxtCantidadPol);
            this.GrupPoliza.Controls.Add(this.LbCantidadPol);
            this.GrupPoliza.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GrupPoliza.Location = new System.Drawing.Point(614, 12);
            this.GrupPoliza.Name = "GrupPoliza";
            this.GrupPoliza.Size = new System.Drawing.Size(295, 274);
            this.GrupPoliza.TabIndex = 16;
            this.GrupPoliza.TabStop = false;
            this.GrupPoliza.Text = "Info Poliza";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Lime;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.SquarePlus;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(4, 209);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(287, 57);
            this.BtnGuardar.TabIndex = 16;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtCantidadPol
            // 
            this.TxtCantidadPol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtCantidadPol.Location = new System.Drawing.Point(0, 57);
            this.TxtCantidadPol.Name = "TxtCantidadPol";
            this.TxtCantidadPol.Size = new System.Drawing.Size(295, 29);
            this.TxtCantidadPol.TabIndex = 15;
            this.TxtCantidadPol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // LbCantidadPol
            // 
            this.LbCantidadPol.AutoSize = true;
            this.LbCantidadPol.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbCantidadPol.Location = new System.Drawing.Point(6, 29);
            this.LbCantidadPol.Name = "LbCantidadPol";
            this.LbCantidadPol.Size = new System.Drawing.Size(92, 25);
            this.LbCantidadPol.TabIndex = 14;
            this.LbCantidadPol.Text = "Cantidad";
            // 
            // AddPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 298);
            this.Controls.Add(this.GrupPoliza);
            this.Controls.Add(this.GrupArt);
            this.Controls.Add(this.GrupEmp);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(937, 337);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(937, 337);
            this.Name = "AddPoliza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Poliza";
            this.Load += new System.EventHandler(this.AddPoliza_Load);
            this.GrupEmp.ResumeLayout(false);
            this.GrupEmp.PerformLayout();
            this.GrupArt.ResumeLayout(false);
            this.GrupArt.PerformLayout();
            this.GrupPoliza.ResumeLayout(false);
            this.GrupPoliza.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrupEmp;
        private System.Windows.Forms.GroupBox GrupArt;
        private System.Windows.Forms.Label LbPuestoEmp;
        private System.Windows.Forms.Label LbApellidosEmp;
        private System.Windows.Forms.Label LbNombreEmp;
        private System.Windows.Forms.TextBox TxtPuestoEmp;
        private System.Windows.Forms.TextBox TxtApellidoEmp;
        public System.Windows.Forms.TextBox TxtNombreEmp;
        private System.Windows.Forms.Label LbCantidadArt;
        public System.Windows.Forms.TextBox TxtCantidadArt;
        private System.Windows.Forms.Label LbNombreArt;
        public System.Windows.Forms.TextBox TxtNombreArt;
        public System.Windows.Forms.TextBox TxtIdEmp;
        private System.Windows.Forms.Label LbIdEmp;
        private System.Windows.Forms.Label LbIdArt;
        public System.Windows.Forms.TextBox TxtIdArt;
        private System.Windows.Forms.GroupBox GrupPoliza;
        public System.Windows.Forms.TextBox TxtCantidadPol;
        private System.Windows.Forms.Label LbCantidadPol;
        private FontAwesome.Sharp.IconButton BtnGuardar;
    }
}