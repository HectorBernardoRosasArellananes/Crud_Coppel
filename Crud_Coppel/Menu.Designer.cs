
namespace Crud_Coppel
{
    partial class Menu
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnAddPoliza = new FontAwesome.Sharp.IconButton();
            this.BtnAddArticulo = new FontAwesome.Sharp.IconButton();
            this.BtnAddEmpleado = new FontAwesome.Sharp.IconButton();
            this.BtnPolizas = new FontAwesome.Sharp.IconButton();
            this.BtnEmpleados = new FontAwesome.Sharp.IconButton();
            this.BtnArticulos = new FontAwesome.Sharp.IconButton();
            this.PanelListado = new System.Windows.Forms.Panel();
            this.GridListados = new System.Windows.Forms.DataGridView();
            this.PanelMenu.SuspendLayout();
            this.PanelListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridListados)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.White;
            this.PanelMenu.Controls.Add(this.BtnAddPoliza);
            this.PanelMenu.Controls.Add(this.BtnAddArticulo);
            this.PanelMenu.Controls.Add(this.BtnAddEmpleado);
            this.PanelMenu.Controls.Add(this.BtnPolizas);
            this.PanelMenu.Controls.Add(this.BtnEmpleados);
            this.PanelMenu.Controls.Add(this.BtnArticulos);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(729, 155);
            this.PanelMenu.TabIndex = 0;
            // 
            // BtnAddPoliza
            // 
            this.BtnAddPoliza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAddPoliza.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.BtnAddPoliza.IconColor = System.Drawing.Color.White;
            this.BtnAddPoliza.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddPoliza.IconSize = 40;
            this.BtnAddPoliza.Location = new System.Drawing.Point(485, 113);
            this.BtnAddPoliza.Name = "BtnAddPoliza";
            this.BtnAddPoliza.Size = new System.Drawing.Size(230, 42);
            this.BtnAddPoliza.TabIndex = 5;
            this.BtnAddPoliza.UseVisualStyleBackColor = false;
            this.BtnAddPoliza.Click += new System.EventHandler(this.BtnAddPoliza_Click);
            // 
            // BtnAddArticulo
            // 
            this.BtnAddArticulo.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnAddArticulo.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.BtnAddArticulo.IconColor = System.Drawing.Color.White;
            this.BtnAddArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddArticulo.IconSize = 40;
            this.BtnAddArticulo.Location = new System.Drawing.Point(249, 113);
            this.BtnAddArticulo.Name = "BtnAddArticulo";
            this.BtnAddArticulo.Size = new System.Drawing.Size(230, 42);
            this.BtnAddArticulo.TabIndex = 4;
            this.BtnAddArticulo.UseVisualStyleBackColor = false;
            this.BtnAddArticulo.Click += new System.EventHandler(this.BtnAddArticulo_Click);
            // 
            // BtnAddEmpleado
            // 
            this.BtnAddEmpleado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnAddEmpleado.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.BtnAddEmpleado.IconColor = System.Drawing.Color.White;
            this.BtnAddEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddEmpleado.IconSize = 40;
            this.BtnAddEmpleado.Location = new System.Drawing.Point(13, 113);
            this.BtnAddEmpleado.Name = "BtnAddEmpleado";
            this.BtnAddEmpleado.Size = new System.Drawing.Size(230, 42);
            this.BtnAddEmpleado.TabIndex = 3;
            this.BtnAddEmpleado.UseVisualStyleBackColor = false;
            this.BtnAddEmpleado.Click += new System.EventHandler(this.BtnAddEmpleado_Click);
            // 
            // BtnPolizas
            // 
            this.BtnPolizas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPolizas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPolizas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPolizas.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.BtnPolizas.IconColor = System.Drawing.Color.White;
            this.BtnPolizas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPolizas.IconSize = 100;
            this.BtnPolizas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPolizas.Location = new System.Drawing.Point(485, 3);
            this.BtnPolizas.Name = "BtnPolizas";
            this.BtnPolizas.Size = new System.Drawing.Size(230, 113);
            this.BtnPolizas.TabIndex = 2;
            this.BtnPolizas.Text = "Polizas";
            this.BtnPolizas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPolizas.UseVisualStyleBackColor = false;
            this.BtnPolizas.Click += new System.EventHandler(this.BtnPolizas_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnEmpleados.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.BtnEmpleados.IconColor = System.Drawing.Color.White;
            this.BtnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEmpleados.IconSize = 100;
            this.BtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpleados.Location = new System.Drawing.Point(13, 3);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(230, 113);
            this.BtnEmpleados.TabIndex = 1;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEmpleados.UseVisualStyleBackColor = false;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // BtnArticulos
            // 
            this.BtnArticulos.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnArticulos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnArticulos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnArticulos.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.BtnArticulos.IconColor = System.Drawing.Color.White;
            this.BtnArticulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnArticulos.IconSize = 100;
            this.BtnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnArticulos.Location = new System.Drawing.Point(249, 3);
            this.BtnArticulos.Name = "BtnArticulos";
            this.BtnArticulos.Size = new System.Drawing.Size(230, 113);
            this.BtnArticulos.TabIndex = 0;
            this.BtnArticulos.Text = "Articulos";
            this.BtnArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnArticulos.UseVisualStyleBackColor = false;
            this.BtnArticulos.Click += new System.EventHandler(this.BtnArticulos_Click);
            // 
            // PanelListado
            // 
            this.PanelListado.BackColor = System.Drawing.Color.White;
            this.PanelListado.Controls.Add(this.GridListados);
            this.PanelListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelListado.Location = new System.Drawing.Point(0, 155);
            this.PanelListado.Name = "PanelListado";
            this.PanelListado.Size = new System.Drawing.Size(729, 295);
            this.PanelListado.TabIndex = 1;
            // 
            // GridListados
            // 
            this.GridListados.AllowUserToAddRows = false;
            this.GridListados.AllowUserToDeleteRows = false;
            this.GridListados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridListados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridListados.Location = new System.Drawing.Point(0, 0);
            this.GridListados.MultiSelect = false;
            this.GridListados.Name = "GridListados";
            this.GridListados.RowTemplate.Height = 25;
            this.GridListados.Size = new System.Drawing.Size(729, 295);
            this.GridListados.TabIndex = 0;
            this.GridListados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListados_CellClick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.PanelListado);
            this.Controls.Add(this.PanelMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(745, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(745, 489);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.PanelMenu.ResumeLayout(false);
            this.PanelListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridListados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelListado;
        private FontAwesome.Sharp.IconButton BtnEmpleados;
        private FontAwesome.Sharp.IconButton BtnArticulos;
        private FontAwesome.Sharp.IconButton BtnPolizas;
        private System.Windows.Forms.DataGridView GridListados;
        private FontAwesome.Sharp.IconButton BtnAddEmpleado;
        private FontAwesome.Sharp.IconButton BtnAddPoliza;
        private FontAwesome.Sharp.IconButton BtnAddArticulo;
    }
}