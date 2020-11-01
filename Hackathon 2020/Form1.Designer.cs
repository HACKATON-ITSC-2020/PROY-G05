namespace Hackathon_2020
{
    partial class Farmacia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Farmacia));
            this.dtg = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeElaboracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblFechadeIngreso = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.dtpFechadeIngreso = new System.Windows.Forms.DateTimePicker();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.LblFechadeVencimiento = new System.Windows.Forms.Label();
            this.dtpFechadeVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechadeElaboracion = new System.Windows.Forms.Label();
            this.dtpFechadeElaboracion = new System.Windows.Forms.DateTimePicker();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg
            // 
            this.dtg.AllowUserToOrderColumns = true;
            this.dtg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.FechadeIngreso,
            this.Cantidad,
            this.FechaDeElaboracion,
            this.FechaDeVencimiento});
            resources.ApplyResources(this.dtg, "dtg");
            this.dtg.Name = "dtg";
            this.dtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellClick);
            // 
            // Producto
            // 
            resources.ApplyResources(this.Producto, "Producto");
            this.Producto.Name = "Producto";
            // 
            // FechadeIngreso
            // 
            resources.ApplyResources(this.FechadeIngreso, "FechadeIngreso");
            this.FechadeIngreso.Name = "FechadeIngreso";
            // 
            // Cantidad
            // 
            resources.ApplyResources(this.Cantidad, "Cantidad");
            this.Cantidad.Name = "Cantidad";
            // 
            // FechaDeElaboracion
            // 
            resources.ApplyResources(this.FechaDeElaboracion, "FechaDeElaboracion");
            this.FechaDeElaboracion.Name = "FechaDeElaboracion";
            // 
            // FechaDeVencimiento
            // 
            resources.ApplyResources(this.FechaDeVencimiento, "FechaDeVencimiento");
            this.FechaDeVencimiento.Name = "FechaDeVencimiento";
            // 
            // lblProducto
            // 
            resources.ApplyResources(this.lblProducto, "lblProducto");
            this.lblProducto.Name = "lblProducto";
            // 
            // lblFechadeIngreso
            // 
            resources.ApplyResources(this.lblFechadeIngreso, "lblFechadeIngreso");
            this.lblFechadeIngreso.Name = "lblFechadeIngreso";
            // 
            // lblCantidad
            // 
            resources.ApplyResources(this.lblCantidad, "lblCantidad");
            this.lblCantidad.Name = "lblCantidad";
            // 
            // txtProducto
            // 
            resources.ApplyResources(this.txtProducto, "txtProducto");
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
            // 
            // dtpFechadeIngreso
            // 
            resources.ApplyResources(this.dtpFechadeIngreso, "dtpFechadeIngreso");
            this.dtpFechadeIngreso.Name = "dtpFechadeIngreso";
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.nudCantidad, "nudCantidad");
            this.nudCantidad.Name = "nudCantidad";
            // 
            // LblFechadeVencimiento
            // 
            resources.ApplyResources(this.LblFechadeVencimiento, "LblFechadeVencimiento");
            this.LblFechadeVencimiento.Name = "LblFechadeVencimiento";
            // 
            // dtpFechadeVencimiento
            // 
            resources.ApplyResources(this.dtpFechadeVencimiento, "dtpFechadeVencimiento");
            this.dtpFechadeVencimiento.Name = "dtpFechadeVencimiento";
            // 
            // lblFechadeElaboracion
            // 
            resources.ApplyResources(this.lblFechadeElaboracion, "lblFechadeElaboracion");
            this.lblFechadeElaboracion.Name = "lblFechadeElaboracion";
            // 
            // dtpFechadeElaboracion
            // 
            resources.ApplyResources(this.dtpFechadeElaboracion, "dtpFechadeElaboracion");
            this.dtpFechadeElaboracion.Name = "dtpFechadeElaboracion";
            // 
            // btnCargar
            // 
            resources.ApplyResources(this.btnCargar, "btnCargar");
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBorrar
            // 
            resources.ApplyResources(this.btnBorrar, "btnBorrar");
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Farmacia
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dtpFechadeElaboracion);
            this.Controls.Add(this.lblFechadeElaboracion);
            this.Controls.Add(this.dtpFechadeVencimiento);
            this.Controls.Add(this.LblFechadeVencimiento);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.dtpFechadeIngreso);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblFechadeIngreso);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.dtg);
            this.Name = "Farmacia";
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeElaboracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeVencimiento;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblFechadeIngreso;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DateTimePicker dtpFechadeIngreso;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label LblFechadeVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechadeVencimiento;
        private System.Windows.Forms.Label lblFechadeElaboracion;
        private System.Windows.Forms.DateTimePicker dtpFechadeElaboracion;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBorrar;
    }
}

