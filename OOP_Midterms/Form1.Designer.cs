namespace OOP_Midterms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblNewGame = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            lblStartGame = new PictureBox();
            lblQuit = new PictureBox();
            pictureBox2 = new PictureBox();
            btnCustomWords = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblStartGame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblQuit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblNewGame
            // 
            lblNewGame.AutoSize = true;
            lblNewGame.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewGame.Location = new Point(171, 153);
            lblNewGame.Name = "lblNewGame";
            lblNewGame.Size = new Size(273, 59);
            lblNewGame.TabIndex = 2;
            lblNewGame.Text = "New Game";
            lblNewGame.Click += lblNewGame_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(129, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblStartGame
            // 
            lblStartGame.BackColor = Color.Transparent;
            lblStartGame.Image = (Image)resources.GetObject("lblStartGame.Image");
            lblStartGame.Location = new Point(308, 329);
            lblStartGame.Name = "lblStartGame";
            lblStartGame.Size = new Size(108, 91);
            lblStartGame.SizeMode = PictureBoxSizeMode.StretchImage;
            lblStartGame.TabIndex = 5;
            lblStartGame.TabStop = false;
            lblStartGame.Click += lblStartGame_Click;
            // 
            // lblQuit
            // 
            lblQuit.BackColor = Color.Transparent;
            lblQuit.Image = (Image)resources.GetObject("lblQuit.Image");
            lblQuit.Location = new Point(497, 471);
            lblQuit.Name = "lblQuit";
            lblQuit.Size = new Size(177, 82);
            lblQuit.SizeMode = PictureBoxSizeMode.StretchImage;
            lblQuit.TabIndex = 6;
            lblQuit.TabStop = false;
            lblQuit.Click += lblQuit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 456);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(151, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnCustomWords
            // 
            btnCustomWords.CustomizableEdges = customizableEdges1;
            btnCustomWords.DisabledState.BorderColor = Color.DarkGray;
            btnCustomWords.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCustomWords.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCustomWords.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCustomWords.FillColor = Color.NavajoWhite;
            btnCustomWords.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomWords.ForeColor = Color.Black;
            btnCustomWords.Location = new Point(288, 481);
            btnCustomWords.Name = "btnCustomWords";
            btnCustomWords.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCustomWords.Size = new Size(143, 56);
            btnCustomWords.TabIndex = 9;
            btnCustomWords.Text = "Custom Words";
            btnCustomWords.Click += btnCustomWords_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(733, 604);
            Controls.Add(btnCustomWords);
            Controls.Add(pictureBox2);
            Controls.Add(lblQuit);
            Controls.Add(lblStartGame);
            Controls.Add(pictureBox1);
            Controls.Add(lblNewGame);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblStartGame).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblQuit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNewGame;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        private PictureBox pictureBox1;
        private PictureBox lblStartGame;
        private PictureBox lblQuit;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnCustomWords;
    }
}
