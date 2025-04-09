namespace OOP_Midterms
{
    partial class FrmGame
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            lblWordDisplay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnGuess = new Guna.UI2.WinForms.Guna2Button();
            txtGuess = new Guna.UI2.WinForms.Guna2TextBox();
            lblWordDisplay1 = new Label();
            txtbox = new TextBox();
            lblNum = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblScore = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblWordDisplay
            // 
            lblWordDisplay.BackColor = Color.Transparent;
            lblWordDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWordDisplay.Location = new Point(115, 67);
            lblWordDisplay.Name = "lblWordDisplay";
            lblWordDisplay.Size = new Size(3, 2);
            lblWordDisplay.TabIndex = 1;
            lblWordDisplay.Text = null;
            // 
            // btnGuess
            // 
            btnGuess.CustomizableEdges = customizableEdges1;
            btnGuess.DisabledState.BorderColor = Color.DarkGray;
            btnGuess.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGuess.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGuess.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGuess.FillColor = Color.NavajoWhite;
            btnGuess.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuess.ForeColor = Color.Black;
            btnGuess.HoverState.BorderColor = Color.DarkOrange;
            btnGuess.HoverState.CustomBorderColor = Color.DarkOrange;
            btnGuess.Location = new Point(32, 437);
            btnGuess.Name = "btnGuess";
            btnGuess.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnGuess.Size = new Size(173, 51);
            btnGuess.TabIndex = 2;
            btnGuess.Text = "Guess";
            btnGuess.Click += btnGuess_Click;
            // 
            // txtGuess
            // 
            txtGuess.CustomizableEdges = customizableEdges3;
            txtGuess.DefaultText = "";
            txtGuess.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtGuess.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtGuess.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtGuess.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtGuess.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtGuess.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuess.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtGuess.Location = new Point(563, 1152);
            txtGuess.Margin = new Padding(6, 8, 6, 8);
            txtGuess.Name = "txtGuess";
            txtGuess.PasswordChar = '\0';
            txtGuess.PlaceholderText = "";
            txtGuess.SelectedText = "";
            txtGuess.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtGuess.Size = new Size(293, 96);
            txtGuess.TabIndex = 3;
            // 
            // lblWordDisplay1
            // 
            lblWordDisplay1.BackColor = Color.Transparent;
            lblWordDisplay1.BorderStyle = BorderStyle.Fixed3D;
            lblWordDisplay1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWordDisplay1.Location = new Point(97, 67);
            lblWordDisplay1.Name = "lblWordDisplay1";
            lblWordDisplay1.Size = new Size(308, 51);
            lblWordDisplay1.TabIndex = 4;
            lblWordDisplay1.TextAlign = ContentAlignment.MiddleCenter;
            lblWordDisplay1.Click += lblWordDisplay1_Click;
            // 
            // txtbox
            // 
            txtbox.BackColor = Color.Azure;
            txtbox.Font = new Font("Rockwell Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbox.Location = new Point(240, 445);
            txtbox.Name = "txtbox";
            txtbox.Size = new Size(247, 43);
            txtbox.TabIndex = 5;
            txtbox.TextChanged += textBox1_TextChanged;
            // 
            // lblNum
            // 
            lblNum.BackColor = Color.Transparent;
            lblNum.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNum.Location = new Point(23, 12);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(40, 28);
            lblNum.TabIndex = 6;
            lblNum.Text = "1/10";
            // 
            // lblScore
            // 
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(319, 12);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(72, 28);
            lblScore.TabIndex = 7;
            lblScore.Text = "Score:";
            lblScore.Click += lblScore_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(440, 518);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(115, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(258, 283);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FrmGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(525, 576);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblScore);
            Controls.Add(lblNum);
            Controls.Add(txtbox);
            Controls.Add(lblWordDisplay1);
            Controls.Add(txtGuess);
            Controls.Add(btnGuess);
            Controls.Add(lblWordDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGame";
            Load += FrmGame_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWordDisplay;
        private Guna.UI2.WinForms.Guna2Button btnGuess;
        private Guna.UI2.WinForms.Guna2TextBox txtGuess;
        private Label lblWordDisplay1;
        private TextBox txtbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNum;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblScore;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}