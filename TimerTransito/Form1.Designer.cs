namespace TimerTransito
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDelisgar = new System.Windows.Forms.Button();
            this.pxtSemafaro = new System.Windows.Forms.PictureBox();
            this.trmSemafaro = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pxtSemafaro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLigar
            // 
            this.btnLigar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.Location = new System.Drawing.Point(12, 27);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(291, 96);
            this.btnLigar.TabIndex = 0;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(12, 270);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(291, 96);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDelisgar
            // 
            this.btnDelisgar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelisgar.Location = new System.Drawing.Point(12, 141);
            this.btnDelisgar.Name = "btnDelisgar";
            this.btnDelisgar.Size = new System.Drawing.Size(291, 96);
            this.btnDelisgar.TabIndex = 2;
            this.btnDelisgar.Text = "Desligar";
            this.btnDelisgar.UseVisualStyleBackColor = true;
            this.btnDelisgar.Click += new System.EventHandler(this.btnDelisgar_Click);
            // 
            // pxtSemafaro
            // 
            this.pxtSemafaro.Image = global::TimerTransito.Properties.Resources.Vermelho;
            this.pxtSemafaro.Location = new System.Drawing.Point(415, 68);
            this.pxtSemafaro.Name = "pxtSemafaro";
            this.pxtSemafaro.Size = new System.Drawing.Size(277, 266);
            this.pxtSemafaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxtSemafaro.TabIndex = 3;
            this.pxtSemafaro.TabStop = false;
            // 
            // trmSemafaro
            // 
            this.trmSemafaro.Interval = 1000;
            this.trmSemafaro.Tick += new System.EventHandler(this.tmrSemafaro_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pxtSemafaro);
            this.Controls.Add(this.btnDelisgar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLigar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pxtSemafaro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDelisgar;
        private System.Windows.Forms.PictureBox pxtSemafaro;
        private System.Windows.Forms.Timer trmSemafaro;
    }
}

