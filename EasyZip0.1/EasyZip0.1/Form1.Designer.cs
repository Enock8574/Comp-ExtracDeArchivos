namespace EasyZip0._1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textFolder = new System.Windows.Forms.TextBox();
            this.textArchivo = new System.Windows.Forms.TextBox();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.buttonZIPFolder = new System.Windows.Forms.Button();
            this.buttonArchivo = new System.Windows.Forms.Button();
            this.buttonZIPArchivo = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Archivo";
            // 
            // textFolder
            // 
            this.textFolder.Location = new System.Drawing.Point(94, 37);
            this.textFolder.Name = "textFolder";
            this.textFolder.Size = new System.Drawing.Size(296, 20);
            this.textFolder.TabIndex = 2;
            // 
            // textArchivo
            // 
            this.textArchivo.Location = new System.Drawing.Point(94, 98);
            this.textArchivo.Name = "textArchivo";
            this.textArchivo.Size = new System.Drawing.Size(296, 20);
            this.textArchivo.TabIndex = 3;
            this.textArchivo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonFolder
            // 
            this.buttonFolder.Location = new System.Drawing.Point(396, 35);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(24, 23);
            this.buttonFolder.TabIndex = 4;
            this.buttonFolder.Text = "...";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // buttonZIPFolder
            // 
            this.buttonZIPFolder.Location = new System.Drawing.Point(426, 34);
            this.buttonZIPFolder.Name = "buttonZIPFolder";
            this.buttonZIPFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonZIPFolder.TabIndex = 5;
            this.buttonZIPFolder.Text = "ZIP";
            this.buttonZIPFolder.UseVisualStyleBackColor = true;
            this.buttonZIPFolder.Click += new System.EventHandler(this.buttonZIPFolder_Click);
            // 
            // buttonArchivo
            // 
            this.buttonArchivo.Location = new System.Drawing.Point(396, 96);
            this.buttonArchivo.Name = "buttonArchivo";
            this.buttonArchivo.Size = new System.Drawing.Size(24, 23);
            this.buttonArchivo.TabIndex = 6;
            this.buttonArchivo.Text = "...";
            this.buttonArchivo.UseVisualStyleBackColor = true;
            this.buttonArchivo.Click += new System.EventHandler(this.buttonArchivo_Click);
            // 
            // buttonZIPArchivo
            // 
            this.buttonZIPArchivo.Location = new System.Drawing.Point(426, 95);
            this.buttonZIPArchivo.Name = "buttonZIPArchivo";
            this.buttonZIPArchivo.Size = new System.Drawing.Size(75, 23);
            this.buttonZIPArchivo.TabIndex = 7;
            this.buttonZIPArchivo.Text = "ZIP";
            this.buttonZIPArchivo.UseVisualStyleBackColor = true;
            this.buttonZIPArchivo.Click += new System.EventHandler(this.buttonZIPArchivo_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(94, 154);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 189);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonZIPArchivo);
            this.Controls.Add(this.buttonArchivo);
            this.Controls.Add(this.buttonZIPFolder);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.textArchivo);
            this.Controls.Add(this.textFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EasyZip0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFolder;
        private System.Windows.Forms.TextBox textArchivo;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Button buttonZIPFolder;
        private System.Windows.Forms.Button buttonArchivo;
        private System.Windows.Forms.Button buttonZIPArchivo;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

