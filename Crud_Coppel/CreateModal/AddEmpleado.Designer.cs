
namespace Crud_Coppel.CreateModal
{
    partial class AddEmpleado
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
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtPuesto = new System.Windows.Forms.TextBox();
            this.LbNombre = new System.Windows.Forms.Label();
            this.LbApellidos = new System.Windows.Forms.Label();
            this.LbPuesto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Lime;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(6, 204);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(287, 60);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtNombre.Location = new System.Drawing.Point(6, 49);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(287, 29);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtApellido.Location = new System.Drawing.Point(6, 109);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(287, 29);
            this.TxtApellido.TabIndex = 2;
            // 
            // TxtPuesto
            // 
            this.TxtPuesto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPuesto.Location = new System.Drawing.Point(6, 169);
            this.TxtPuesto.Name = "TxtPuesto";
            this.TxtPuesto.Size = new System.Drawing.Size(287, 29);
            this.TxtPuesto.TabIndex = 3;
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbNombre.Location = new System.Drawing.Point(6, 21);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(99, 25);
            this.LbNombre.TabIndex = 4;
            this.LbNombre.Text = "Nombres ";
            // 
            // LbApellidos
            // 
            this.LbApellidos.AutoSize = true;
            this.LbApellidos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbApellidos.Location = new System.Drawing.Point(6, 81);
            this.LbApellidos.Name = "LbApellidos";
            this.LbApellidos.Size = new System.Drawing.Size(94, 25);
            this.LbApellidos.TabIndex = 5;
            this.LbApellidos.Text = "Apellidos";
            // 
            // LbPuesto
            // 
            this.LbPuesto.AutoSize = true;
            this.LbPuesto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbPuesto.Location = new System.Drawing.Point(6, 141);
            this.LbPuesto.Name = "LbPuesto";
            this.LbPuesto.Size = new System.Drawing.Size(73, 25);
            this.LbPuesto.TabIndex = 6;
            this.LbPuesto.Text = "Puesto";
            // 
            // AddEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 276);
            this.Controls.Add(this.LbPuesto);
            this.Controls.Add(this.LbApellidos);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.TxtPuesto);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BtnGuardar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(314, 315);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(314, 315);
            this.Name = "AddEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Empleado";
            this.Load += new System.EventHandler(this.AddEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtPuesto;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.Label LbApellidos;
        private System.Windows.Forms.Label LbPuesto;
        public System.Windows.Forms.TextBox TxtNombre;
    }
}