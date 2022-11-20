
namespace Carl_s_Jetpack_Adventure
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.coinText = new System.Windows.Forms.Label();
            this.carlCollider = new System.Windows.Forms.PictureBox();
            this.zapper2 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.zapper1 = new System.Windows.Forms.PictureBox();
            this.carl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carlCollider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carl)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // coinText
            // 
            this.coinText.AutoSize = true;
            this.coinText.Location = new System.Drawing.Point(12, 9);
            this.coinText.Name = "coinText";
            this.coinText.Size = new System.Drawing.Size(35, 13);
            this.coinText.TabIndex = 5;
            this.coinText.Text = "label1";
            // 
            // carlCollider
            // 
            this.carlCollider.Location = new System.Drawing.Point(128, 155);
            this.carlCollider.Name = "carlCollider";
            this.carlCollider.Size = new System.Drawing.Size(35, 55);
            this.carlCollider.TabIndex = 6;
            this.carlCollider.TabStop = false;
            // 
            // zapper2
            // 
            this.zapper2.Location = new System.Drawing.Point(706, 64);
            this.zapper2.Name = "zapper2";
            this.zapper2.Size = new System.Drawing.Size(49, 113);
            this.zapper2.TabIndex = 4;
            this.zapper2.TabStop = false;
            // 
            // ground
            // 
            this.ground.Location = new System.Drawing.Point(-6, 404);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(813, 50);
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // zapper1
            // 
            this.zapper1.Location = new System.Drawing.Point(411, 255);
            this.zapper1.Name = "zapper1";
            this.zapper1.Size = new System.Drawing.Size(48, 120);
            this.zapper1.TabIndex = 1;
            this.zapper1.TabStop = false;
            // 
            // carl
            // 
            this.carl.Location = new System.Drawing.Point(78, 139);
            this.carl.Name = "carl";
            this.carl.Size = new System.Drawing.Size(109, 90);
            this.carl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carl.TabIndex = 0;
            this.carl.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.carlCollider);
            this.Controls.Add(this.coinText);
            this.Controls.Add(this.zapper2);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.zapper1);
            this.Controls.Add(this.carl);
            this.Name = "Form1";
            this.Text = "Carl\'s Jetpack Adventure";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.carlCollider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox carl;
        private System.Windows.Forms.PictureBox zapper1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox zapper2;
        private System.Windows.Forms.Label coinText;
        private System.Windows.Forms.PictureBox carlCollider;
    }
}

