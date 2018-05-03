namespace facturayan
{
    partial class actualizarp
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
            this.dgvactu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbucar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprod = new System.Windows.Forms.TextBox();
            this.txtpreci = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnact = new System.Windows.Forms.Button();
            this.btnborr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvactu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvactu
            // 
            this.dgvactu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvactu.Location = new System.Drawing.Point(12, 174);
            this.dgvactu.Name = "dgvactu";
            this.dgvactu.ReadOnly = true;
            this.dgvactu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvactu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvactu.Size = new System.Drawing.Size(776, 264);
            this.dgvactu.TabIndex = 0;
            this.dgvactu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvactu_CellContentClick);
            this.dgvactu.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvactu_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // txtbucar
            // 
            this.txtbucar.Location = new System.Drawing.Point(68, 27);
            this.txtbucar.Name = "txtbucar";
            this.txtbucar.Size = new System.Drawing.Size(249, 20);
            this.txtbucar.TabIndex = 2;
            this.txtbucar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // txtprod
            // 
            this.txtprod.Location = new System.Drawing.Point(68, 103);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(100, 20);
            this.txtprod.TabIndex = 5;
            // 
            // txtpreci
            // 
            this.txtpreci.Location = new System.Drawing.Point(68, 140);
            this.txtpreci.Name = "txtpreci";
            this.txtpreci.Size = new System.Drawing.Size(100, 20);
            this.txtpreci.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 70);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(18, 13);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(68, 67);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 8;
            // 
            // btnact
            // 
            this.btnact.Location = new System.Drawing.Point(232, 138);
            this.btnact.Name = "btnact";
            this.btnact.Size = new System.Drawing.Size(75, 23);
            this.btnact.TabIndex = 9;
            this.btnact.Text = "Actualizar";
            this.btnact.UseVisualStyleBackColor = true;
            this.btnact.Click += new System.EventHandler(this.btnact_Click);
            // 
            // btnborr
            // 
            this.btnborr.Location = new System.Drawing.Point(358, 138);
            this.btnborr.Name = "btnborr";
            this.btnborr.Size = new System.Drawing.Size(75, 23);
            this.btnborr.TabIndex = 10;
            this.btnborr.Text = "Borrar";
            this.btnborr.UseVisualStyleBackColor = true;
            this.btnborr.Click += new System.EventHandler(this.btnborr_Click);
            // 
            // actualizarp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnborr);
            this.Controls.Add(this.btnact);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtpreci);
            this.Controls.Add(this.txtprod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbucar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvactu);
            this.Name = "actualizarp";
            this.Text = "actualizarp";
            this.Load += new System.EventHandler(this.actualizarp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvactu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvactu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbucar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprod;
        private System.Windows.Forms.TextBox txtpreci;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnact;
        private System.Windows.Forms.Button btnborr;
    }
}