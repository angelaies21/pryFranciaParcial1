namespace pryFranciaParcial1
{
    partial class frmDatosAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosAlumnos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblAnalis = new System.Windows.Forms.Label();
            this.lblLabo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(50, 181);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(146, 18);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre Completo";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(50, 139);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(36, 18);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI";
            // 
            // lblAnalis
            // 
            this.lblAnalis.AutoSize = true;
            this.lblAnalis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalis.Location = new System.Drawing.Point(50, 64);
            this.lblAnalis.Name = "lblAnalis";
            this.lblAnalis.Size = new System.Drawing.Size(156, 18);
            this.lblAnalis.TabIndex = 3;
            this.lblAnalis.Text = "Analista de Sistema";
            this.lblAnalis.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLabo
            // 
            this.lblLabo.AutoSize = true;
            this.lblLabo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabo.Location = new System.Drawing.Point(50, 100);
            this.lblLabo.Name = "lblLabo";
            this.lblLabo.Size = new System.Drawing.Size(218, 18);
            this.lblLabo.TabIndex = 4;
            this.lblLabo.Text = "Laboratorio d programacion";
            // 
            // frmDatosAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 311);
            this.Controls.Add(this.lblLabo);
            this.Controls.Add(this.lblAnalis);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDatosAlumnos";
            this.Text = "Instancia Evaluativa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblAnalis;
        private System.Windows.Forms.Label lblLabo;
    }
}