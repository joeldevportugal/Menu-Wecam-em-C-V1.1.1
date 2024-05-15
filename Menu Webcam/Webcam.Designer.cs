namespace Menu_Webcam
{
    partial class Webcam
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Webcam));
            this.CMBWebcam = new System.Windows.Forms.ComboBox();
            this.Pimagem = new System.Windows.Forms.PictureBox();
            this.Pcopia = new System.Windows.Forms.PictureBox();
            this.BtnCapturar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnParar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Pimagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcopia)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMBWebcam
            // 
            this.CMBWebcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBWebcam.FormattingEnabled = true;
            this.CMBWebcam.Location = new System.Drawing.Point(13, 13);
            this.CMBWebcam.Name = "CMBWebcam";
            this.CMBWebcam.Size = new System.Drawing.Size(940, 37);
            this.CMBWebcam.TabIndex = 0;
            // 
            // Pimagem
            // 
            this.Pimagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pimagem.Location = new System.Drawing.Point(13, 57);
            this.Pimagem.Name = "Pimagem";
            this.Pimagem.Size = new System.Drawing.Size(467, 463);
            this.Pimagem.TabIndex = 1;
            this.Pimagem.TabStop = false;
            // 
            // Pcopia
            // 
            this.Pcopia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pcopia.Location = new System.Drawing.Point(486, 57);
            this.Pcopia.Name = "Pcopia";
            this.Pcopia.Size = new System.Drawing.Size(465, 463);
            this.Pcopia.TabIndex = 2;
            this.Pcopia.TabStop = false;
            // 
            // BtnCapturar
            // 
            this.BtnCapturar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCapturar.BackgroundImage")));
            this.BtnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCapturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCapturar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCapturar.Image")));
            this.BtnCapturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCapturar.Location = new System.Drawing.Point(3, 3);
            this.BtnCapturar.Name = "BtnCapturar";
            this.BtnCapturar.Size = new System.Drawing.Size(180, 38);
            this.BtnCapturar.TabIndex = 3;
            this.BtnCapturar.Text = "Capturar";
            this.BtnCapturar.UseVisualStyleBackColor = true;
            this.BtnCapturar.Click += new System.EventHandler(this.BtnCapturar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.BackgroundImage")));
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.Location = new System.Drawing.Point(190, 3);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(181, 38);
            this.BtnLimpar.TabIndex = 4;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.BackgroundImage")));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(377, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(181, 38);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.Location = new System.Drawing.Point(751, 3);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(184, 38);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnParar
            // 
            this.BtnParar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnParar.BackgroundImage")));
            this.BtnParar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnParar.Image = ((System.Drawing.Image)(resources.GetObject("BtnParar.Image")));
            this.BtnParar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnParar.Location = new System.Drawing.Point(564, 3);
            this.BtnParar.Name = "BtnParar";
            this.BtnParar.Size = new System.Drawing.Size(181, 38);
            this.BtnParar.TabIndex = 7;
            this.BtnParar.Text = "Parar";
            this.BtnParar.UseVisualStyleBackColor = true;
            this.BtnParar.Click += new System.EventHandler(this.BtnParar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.BtnCapturar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnSair, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnParar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnLimpar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnGuardar, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 526);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(938, 44);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Webcam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(963, 575);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Pcopia);
            this.Controls.Add(this.Pimagem);
            this.Controls.Add(this.CMBWebcam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Webcam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webcam Dev Joel 2024 Portugal ©";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Webcam_FormClosed);
            this.Load += new System.EventHandler(this.Webcam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pimagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcopia)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CMBWebcam;
        private System.Windows.Forms.PictureBox Pimagem;
        private System.Windows.Forms.PictureBox Pcopia;
        private System.Windows.Forms.Button BtnCapturar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnParar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

