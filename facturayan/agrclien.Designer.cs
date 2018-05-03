namespace facturayan
{
    partial class agrclien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnomb = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtdirec = new System.Windows.Forms.TextBox();
            this.btnagre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DIreccion";
            // 
            // txtnomb
            // 
            this.txtnomb.Location = new System.Drawing.Point(72, 10);
            this.txtnomb.Name = "txtnomb";
            this.txtnomb.Size = new System.Drawing.Size(100, 20);
            this.txtnomb.TabIndex = 3;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(72, 46);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 4;
            // 
            // txtdirec
            // 
            this.txtdirec.Location = new System.Drawing.Point(72, 81);
            this.txtdirec.Name = "txtdirec";
            this.txtdirec.Size = new System.Drawing.Size(100, 20);
            this.txtdirec.TabIndex = 5;
            // 
            // btnagre
            // 
            this.btnagre.Location = new System.Drawing.Point(16, 230);
            this.btnagre.Name = "btnagre";
            this.btnagre.Size = new System.Drawing.Size(75, 23);
            this.btnagre.TabIndex = 6;
            this.btnagre.Text = "Agregar";
            this.btnagre.UseVisualStyleBackColor = true;
            this.btnagre.Click += new System.EventHandler(this.btnagre_Click);
            // 
            // agrclien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 265);
            this.Controls.Add(this.btnagre);
            this.Controls.Add(this.txtdirec);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtnomb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "agrclien";
            this.Text = "agrclien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnomb;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtdirec;
        private System.Windows.Forms.Button btnagre;
    }
}