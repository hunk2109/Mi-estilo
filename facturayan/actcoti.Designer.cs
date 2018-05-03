namespace facturayan
{
    partial class actcoti
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
            this.dgvcot = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprod = new System.Windows.Forms.TextBox();
            this.txtcan = new System.Windows.Forms.TextBox();
            this.txtprec = new System.Windows.Forms.TextBox();
            this.txtidclien = new System.Windows.Forms.TextBox();
            this.txtidfac = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnborr = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbusc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcot)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcot
            // 
            this.dgvcot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcot.Location = new System.Drawing.Point(12, 223);
            this.dgvcot.Name = "dgvcot";
            this.dgvcot.ReadOnly = true;
            this.dgvcot.Size = new System.Drawing.Size(776, 215);
            this.dgvcot.TabIndex = 0;
            this.dgvcot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcot_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID Factura";
            // 
            // txtprod
            // 
            this.txtprod.Location = new System.Drawing.Point(76, 80);
            this.txtprod.Name = "txtprod";
            this.txtprod.ReadOnly = true;
            this.txtprod.Size = new System.Drawing.Size(104, 20);
            this.txtprod.TabIndex = 6;
            // 
            // txtcan
            // 
            this.txtcan.Location = new System.Drawing.Point(76, 106);
            this.txtcan.Name = "txtcan";
            this.txtcan.Size = new System.Drawing.Size(104, 20);
            this.txtcan.TabIndex = 7;
            // 
            // txtprec
            // 
            this.txtprec.Location = new System.Drawing.Point(76, 132);
            this.txtprec.Name = "txtprec";
            this.txtprec.ReadOnly = true;
            this.txtprec.Size = new System.Drawing.Size(104, 20);
            this.txtprec.TabIndex = 8;
            // 
            // txtidclien
            // 
            this.txtidclien.Location = new System.Drawing.Point(76, 162);
            this.txtidclien.Name = "txtidclien";
            this.txtidclien.Size = new System.Drawing.Size(104, 20);
            this.txtidclien.TabIndex = 9;
            // 
            // txtidfac
            // 
            this.txtidfac.Location = new System.Drawing.Point(76, 194);
            this.txtidfac.Name = "txtidfac";
            this.txtidfac.ReadOnly = true;
            this.txtidfac.Size = new System.Drawing.Size(104, 20);
            this.txtidfac.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnborr
            // 
            this.btnborr.Location = new System.Drawing.Point(338, 194);
            this.btnborr.Name = "btnborr";
            this.btnborr.Size = new System.Drawing.Size(75, 23);
            this.btnborr.TabIndex = 12;
            this.btnborr.Text = "Borrar";
            this.btnborr.UseVisualStyleBackColor = true;
            this.btnborr.Click += new System.EventHandler(this.btnborr_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(76, 51);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(104, 20);
            this.txtid.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Buscar";
            // 
            // txtbusc
            // 
            this.txtbusc.Location = new System.Drawing.Point(60, 6);
            this.txtbusc.Name = "txtbusc";
            this.txtbusc.Size = new System.Drawing.Size(381, 20);
            this.txtbusc.TabIndex = 16;
            this.txtbusc.TextChanged += new System.EventHandler(this.txtbusc_TextChanged);
            // 
            // actcoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbusc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnborr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtidfac);
            this.Controls.Add(this.txtidclien);
            this.Controls.Add(this.txtprec);
            this.Controls.Add(this.txtcan);
            this.Controls.Add(this.txtprod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvcot);
            this.Name = "actcoti";
            this.Text = "actcoti";
            this.Load += new System.EventHandler(this.actcoti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprod;
        private System.Windows.Forms.TextBox txtcan;
        private System.Windows.Forms.TextBox txtprec;
        private System.Windows.Forms.TextBox txtidclien;
        private System.Windows.Forms.TextBox txtidfac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnborr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbusc;
    }
}