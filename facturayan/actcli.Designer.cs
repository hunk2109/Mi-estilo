namespace facturayan
{
    partial class actcli
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
            this.dgvclie = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbusc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnnom = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtdirec = new System.Windows.Forms.TextBox();
            this.btnact = new System.Windows.Forms.Button();
            this.btnborr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvclie
            // 
            this.dgvclie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclie.Location = new System.Drawing.Point(12, 177);
            this.dgvclie.Name = "dgvclie";
            this.dgvclie.ReadOnly = true;
            this.dgvclie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvclie.Size = new System.Drawing.Size(776, 261);
            this.dgvclie.TabIndex = 0;
            this.dgvclie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclie_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // txtbusc
            // 
            this.txtbusc.Location = new System.Drawing.Point(55, 20);
            this.txtbusc.Name = "txtbusc";
            this.txtbusc.Size = new System.Drawing.Size(309, 20);
            this.txtbusc.TabIndex = 2;
            this.txtbusc.TextChanged += new System.EventHandler(this.txtbusc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Direccion";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(77, 55);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 7;
            // 
            // txtnnom
            // 
            this.txtnnom.Location = new System.Drawing.Point(77, 83);
            this.txtnnom.Name = "txtnnom";
            this.txtnnom.Size = new System.Drawing.Size(100, 20);
            this.txtnnom.TabIndex = 8;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(77, 113);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 9;
            // 
            // txtdirec
            // 
            this.txtdirec.Location = new System.Drawing.Point(77, 140);
            this.txtdirec.Name = "txtdirec";
            this.txtdirec.Size = new System.Drawing.Size(100, 20);
            this.txtdirec.TabIndex = 10;
            // 
            // btnact
            // 
            this.btnact.Location = new System.Drawing.Point(268, 143);
            this.btnact.Name = "btnact";
            this.btnact.Size = new System.Drawing.Size(75, 23);
            this.btnact.TabIndex = 11;
            this.btnact.Text = "Actualizar";
            this.btnact.UseVisualStyleBackColor = true;
            this.btnact.Click += new System.EventHandler(this.btnact_Click);
            // 
            // btnborr
            // 
            this.btnborr.Location = new System.Drawing.Point(409, 143);
            this.btnborr.Name = "btnborr";
            this.btnborr.Size = new System.Drawing.Size(75, 23);
            this.btnborr.TabIndex = 12;
            this.btnborr.Text = "Borrar";
            this.btnborr.UseVisualStyleBackColor = true;
            this.btnborr.Click += new System.EventHandler(this.btnborr_Click);
            // 
            // actcli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnborr);
            this.Controls.Add(this.btnact);
            this.Controls.Add(this.txtdirec);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtnnom);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbusc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvclie);
            this.Name = "actcli";
            this.Text = "actcli";
            this.Load += new System.EventHandler(this.actcli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvclie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbusc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnnom;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtdirec;
        private System.Windows.Forms.Button btnact;
        private System.Windows.Forms.Button btnborr;
    }
}