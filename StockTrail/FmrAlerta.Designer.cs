namespace StockTrail
{
    partial class FmrAlerta
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
            this.dgvAlerta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlerta
            // 
            this.dgvAlerta.AllowUserToDeleteRows = false;
            this.dgvAlerta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlerta.Location = new System.Drawing.Point(12, 12);
            this.dgvAlerta.Name = "dgvAlerta";
            this.dgvAlerta.ReadOnly = true;
            this.dgvAlerta.Size = new System.Drawing.Size(776, 426);
            this.dgvAlerta.TabIndex = 0;
            // 
            // FmrAlerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAlerta);
            this.Name = "FmrAlerta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrAlerta";
            this.Load += new System.EventHandler(this.FmrAlerta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlerta;
    }
}