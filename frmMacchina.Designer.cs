namespace AutoAnrangoRamosGionsi
{
    partial class frmCambioAutomatico
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
            this.prgbGiriMotore = new System.Windows.Forms.ProgressBar();
            this.btnAccelera = new System.Windows.Forms.Button();
            this.btnFrena = new System.Windows.Forms.Button();
            this.btnSpegni = new System.Windows.Forms.Button();
            this.btnAccendi = new System.Windows.Forms.Button();
            this.lblNGiri = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prgbGiriMotore
            // 
            this.prgbGiriMotore.Location = new System.Drawing.Point(108, 246);
            this.prgbGiriMotore.Maximum = 7000;
            this.prgbGiriMotore.Name = "prgbGiriMotore";
            this.prgbGiriMotore.Size = new System.Drawing.Size(312, 33);
            this.prgbGiriMotore.TabIndex = 0;
            // 
            // btnAccelera
            // 
            this.btnAccelera.Location = new System.Drawing.Point(108, 165);
            this.btnAccelera.Name = "btnAccelera";
            this.btnAccelera.Size = new System.Drawing.Size(106, 51);
            this.btnAccelera.TabIndex = 1;
            this.btnAccelera.Text = "ACCELERA";
            this.btnAccelera.UseVisualStyleBackColor = true;
            this.btnAccelera.Click += new System.EventHandler(this.btnAccelera_Click);
            // 
            // btnFrena
            // 
            this.btnFrena.Location = new System.Drawing.Point(314, 165);
            this.btnFrena.Name = "btnFrena";
            this.btnFrena.Size = new System.Drawing.Size(106, 51);
            this.btnFrena.TabIndex = 2;
            this.btnFrena.Text = "FRENA";
            this.btnFrena.UseVisualStyleBackColor = true;
            this.btnFrena.Click += new System.EventHandler(this.btnFrena_Click);
            // 
            // btnSpegni
            // 
            this.btnSpegni.Location = new System.Drawing.Point(314, 81);
            this.btnSpegni.Name = "btnSpegni";
            this.btnSpegni.Size = new System.Drawing.Size(106, 51);
            this.btnSpegni.TabIndex = 4;
            this.btnSpegni.Text = "SPEGNI";
            this.btnSpegni.UseVisualStyleBackColor = true;
            this.btnSpegni.Click += new System.EventHandler(this.btnSpegni_Click);
            // 
            // btnAccendi
            // 
            this.btnAccendi.Location = new System.Drawing.Point(108, 81);
            this.btnAccendi.Name = "btnAccendi";
            this.btnAccendi.Size = new System.Drawing.Size(106, 51);
            this.btnAccendi.TabIndex = 3;
            this.btnAccendi.Text = "METTI IN MOTO";
            this.btnAccendi.UseVisualStyleBackColor = true;
            this.btnAccendi.Click += new System.EventHandler(this.btnAccendi_Click);
            // 
            // lblNGiri
            // 
            this.lblNGiri.AutoSize = true;
            this.lblNGiri.Location = new System.Drawing.Point(462, 263);
            this.lblNGiri.Name = "lblNGiri";
            this.lblNGiri.Size = new System.Drawing.Size(0, 16);
            this.lblNGiri.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giri: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "max:7000rpm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "min:600rpm";
            // 
            // frmCambioAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNGiri);
            this.Controls.Add(this.btnSpegni);
            this.Controls.Add(this.btnAccendi);
            this.Controls.Add(this.btnFrena);
            this.Controls.Add(this.btnAccelera);
            this.Controls.Add(this.prgbGiriMotore);
            this.Name = "frmCambioAutomatico";
            this.Text = "AUTO con C A M B I O automatico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgbGiriMotore;
        private System.Windows.Forms.Button btnAccelera;
        private System.Windows.Forms.Button btnFrena;
        private System.Windows.Forms.Button btnSpegni;
        private System.Windows.Forms.Button btnAccendi;
        private System.Windows.Forms.Label lblNGiri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

