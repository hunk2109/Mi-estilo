namespace facturayan
{
    partial class vercliente
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
            this.dgvclien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvclien
            // 
            this.dgvclien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclien.Location = new System.Drawing.Point(12, 78);
            this.dgvclien.Name = "dgvclien";
            this.dgvclien.Size = new System.Drawing.Size(679, 289);
            this.dgvclien.TabIndex = 0;
            // 
            // vercliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 379);
            this.Controls.Add(this.dgvclien);
            this.Name = "vercliente";
            this.Text = "vercliente";
            this.Load += new System.EventHandler(this.vercliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvclien;
    }
}