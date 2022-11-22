
namespace Carl_s_Jetpack_Adventure
{
    partial class Game
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
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.distanceText = new System.Windows.Forms.Label();
            this.zapperTimer = new System.Windows.Forms.Timer(this.components);
            this.coinTimer = new System.Windows.Forms.Timer(this.components);
            this.HZapperTimer = new System.Windows.Forms.Timer(this.components);
            this.carlCollider = new System.Windows.Forms.PictureBox();
            this.carl = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carlCollider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
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
            this.coinText.BackColor = System.Drawing.Color.Transparent;
            this.coinText.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.coinText.Location = new System.Drawing.Point(12, 18);
            this.coinText.Name = "coinText";
            this.coinText.Size = new System.Drawing.Size(62, 30);
            this.coinText.TabIndex = 5;
            this.coinText.Text = "coins";
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Interval = 200;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // distanceText
            // 
            this.distanceText.AutoSize = true;
            this.distanceText.BackColor = System.Drawing.Color.Transparent;
            this.distanceText.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.distanceText.Location = new System.Drawing.Point(12, 43);
            this.distanceText.Name = "distanceText";
            this.distanceText.Size = new System.Drawing.Size(97, 30);
            this.distanceText.TabIndex = 8;
            this.distanceText.Text = "distance";
            // 
            // zapperTimer
            // 
            this.zapperTimer.Enabled = true;
            this.zapperTimer.Interval = 2500;
            this.zapperTimer.Tick += new System.EventHandler(this.zapperTimer_Tick);
            // 
            // coinTimer
            // 
            this.coinTimer.Enabled = true;
            this.coinTimer.Interval = 1000;
            this.coinTimer.Tick += new System.EventHandler(this.coinTimer_Tick);
            // 
            // HZapperTimer
            // 
            this.HZapperTimer.Enabled = true;
            this.HZapperTimer.Interval = 2600;
            this.HZapperTimer.Tick += new System.EventHandler(this.HZapper_tick);
            // 
            // carlCollider
            // 
            this.carlCollider.BackColor = System.Drawing.Color.Transparent;
            this.carlCollider.Location = new System.Drawing.Point(128, 155);
            this.carlCollider.Name = "carlCollider";
            this.carlCollider.Size = new System.Drawing.Size(35, 55);
            this.carlCollider.TabIndex = 6;
            this.carlCollider.TabStop = false;
            // 
            // carl
            // 
            this.carl.BackColor = System.Drawing.Color.Transparent;
            this.carl.Location = new System.Drawing.Point(78, 139);
            this.carl.Name = "carl";
            this.carl.Size = new System.Drawing.Size(109, 90);
            this.carl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carl.TabIndex = 0;
            this.carl.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.White;
            this.ground.Location = new System.Drawing.Point(67, 409);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(159, 29);
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.distanceText);
            this.Controls.Add(this.carlCollider);
            this.Controls.Add(this.coinText);
            this.Controls.Add(this.carl);
            this.Controls.Add(this.ground);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carl\'s Jetpack Adventure";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.carlCollider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox carl;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label coinText;
        private System.Windows.Forms.PictureBox carlCollider;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Label distanceText;
        private System.Windows.Forms.Timer zapperTimer;
        private System.Windows.Forms.Timer coinTimer;
        private System.Windows.Forms.Timer HZapperTimer;
    }
}

