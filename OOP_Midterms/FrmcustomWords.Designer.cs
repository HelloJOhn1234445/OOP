namespace OOP_Midterms
{
    partial class FrmcustomWords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmcustomWords));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblAdd = new Label();
            textBox1 = new TextBox();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            lstVWords = new ListView();
            txthint = new TextBox();
            LBL = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.BackColor = Color.Transparent;
            lblAdd.Location = new Point(141, 89);
            lblAdd.Margin = new Padding(5, 0, 5, 0);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(94, 26);
            lblAdd.TabIndex = 0;
            lblAdd.Text = "Words:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 224, 192);
            textBox1.Location = new Point(255, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 32);
            textBox1.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(224, 228);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(73, 65);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 9;
            guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            guna2PictureBox2.BackColor = Color.Transparent;
            guna2PictureBox2.CustomizableEdges = customizableEdges3;
            guna2PictureBox2.Image = (Image)resources.GetObject("guna2PictureBox2.Image");
            guna2PictureBox2.ImageRotate = 0F;
            guna2PictureBox2.Location = new Point(471, 228);
            guna2PictureBox2.Name = "guna2PictureBox2";
            guna2PictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox2.Size = new Size(66, 68);
            guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox2.TabIndex = 10;
            guna2PictureBox2.TabStop = false;
            // 
            // lstVWords
            // 
            lstVWords.BackColor = Color.FromArgb(255, 224, 192);
            lstVWords.Location = new Point(188, 313);
            lstVWords.Name = "lstVWords";
            lstVWords.Size = new Size(413, 253);
            lstVWords.TabIndex = 11;
            lstVWords.UseCompatibleStateImageBehavior = false;
            // 
            // txthint
            // 
            txthint.BackColor = Color.FromArgb(255, 224, 192);
            txthint.Location = new Point(255, 157);
            txthint.Name = "txthint";
            txthint.Size = new Size(282, 32);
            txthint.TabIndex = 12;
            // 
            // LBL
            // 
            LBL.AutoSize = true;
            LBL.BackColor = Color.Transparent;
            LBL.Location = new Point(167, 160);
            LBL.Margin = new Padding(5, 0, 5, 0);
            LBL.Name = "LBL";
            LBL.Size = new Size(68, 26);
            LBL.TabIndex = 13;
            LBL.Text = "hint:";
            // 
            // FrmcustomWords
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(717, 593);
            Controls.Add(LBL);
            Controls.Add(txthint);
            Controls.Add(lstVWords);
            Controls.Add(guna2PictureBox2);
            Controls.Add(guna2PictureBox1);
            Controls.Add(textBox1);
            Controls.Add(lblAdd);
            Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmcustomWords";
            Text = "FrmcustomWords";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdd;
        private TextBox textBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private ListView lstVWords;
        private TextBox txthint;
        private Label LBL;
    }
}