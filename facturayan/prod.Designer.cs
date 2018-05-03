namespace facturayan
{
    partial class prod
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
            this.txtdecrip = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.btnagre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // txtdecrip
            // 
            this.txtdecrip.Location = new System.Drawing.Point(83, 13);
            this.txtdecrip.Name = "txtdecrip";
            this.txtdecrip.Size = new System.Drawing.Size(100, 20);
            this.txtdecrip.TabIndex = 2;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(83, 63);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 3;
            // 
            // btnagre
            // 
            this.btnagre.Location = new System.Drawing.Point(16, 231);
            this.btnagre.Name = "btnagre";
            this.btnagre.Size = new System.Drawing.Size(75, 23);
            this.btnagre.TabIndex = 4;
            this.btnagre.Text = "Agregar";
            this.btnagre.UseVisualStyleBackColor = true;
            this.btnagre.Click += new System.EventHandler(this.btnagre_Click);
            // 
            // prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 266);
            this.Controls.Add(this.btnagre);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtdecrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "prod";
            this.Text = "prod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdecrip;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Button btnagre;
    }
}