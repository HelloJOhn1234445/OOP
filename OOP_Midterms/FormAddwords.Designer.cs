namespace OOP_Midterms
{
    partial class FormAddwords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddwords));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtWordInput = new TextBox();
            lstWords = new ListBox();
            btnAddWord = new Button();
            pictureBox1 = new PictureBox();
            txtDeletewords = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnDelete = new Button();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtWordInput
            // 
            txtWordInput.BackColor = Color.Azure;
            txtWordInput.Location = new Point(231, 80);
            txtWordInput.Margin = new Padding(5, 4, 5, 4);
            txtWordInput.Name = "txtWordInput";
            txtWordInput.Size = new Size(265, 31);
            txtWordInput.TabIndex = 0;
            // 
            // lstWords
            // 
            lstWords.BackColor = Color.Azure;
            lstWords.FormattingEnabled = true;
            lstWords.ItemHeight = 27;
            lstWords.Location = new Point(106, 265);
            lstWords.Margin = new Padding(5, 4, 5, 4);
            lstWords.Name = "lstWords";
            lstWords.Size = new Size(587, 274);
            lstWords.TabIndex = 1;
            lstWords.SelectedIndexChanged += lstWords_SelectedIndexChanged;
            lstWords.SelectedValueChanged += lstWords_SelectedValueChanged;
            // 
            // btnAddWord
            // 
            btnAddWord.Location = new Point(368, 13);
            btnAddWord.Margin = new Padding(5, 4, 5, 4);
            btnAddWord.Name = "btnAddWord";
            btnAddWord.Size = new Size(141, 39);
            btnAddWord.TabIndex = 2;
            btnAddWord.Text = "Add";
            btnAddWord.UseVisualStyleBackColor = true;
            btnAddWord.Click += btnAddWord_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(605, 562);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtDeletewords
            // 
            txtDeletewords.BackColor = Color.Azure;
            txtDeletewords.Location = new Point(231, 163);
            txtDeletewords.Margin = new Padding(5, 4, 5, 4);
            txtDeletewords.Name = "txtDeletewords";
            txtDeletewords.Size = new Size(265, 31);
            txtDeletewords.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(34, 80);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 27);
            label1.TabIndex = 5;
            label1.Text = "Add Words:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(34, 167);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 27);
            label2.TabIndex = 6;
            label2.Text = "Delete Words:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(530, 13);
            btnDelete.Margin = new Padding(5, 4, 5, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 39);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(568, 62);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(73, 65);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 8;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.Click += guna2PictureBox1_Click;
            // 
            // guna2PictureBox2
            // 
            guna2PictureBox2.BackColor = Color.Transparent;
            guna2PictureBox2.CustomizableEdges = customizableEdges3;
            guna2PictureBox2.Image = (Image)resources.GetObject("guna2PictureBox2.Image");
            guna2PictureBox2.ImageRotate = 0F;
            guna2PictureBox2.Location = new Point(568, 150);
            guna2PictureBox2.Name = "guna2PictureBox2";
            guna2PictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox2.Size = new Size(66, 68);
            guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox2.TabIndex = 9;
            guna2PictureBox2.TabStop = false;
            guna2PictureBox2.Click += guna2PictureBox2_Click;
            // 
            // FormAddwords
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(743, 660);
            Controls.Add(guna2PictureBox2);
            Controls.Add(guna2PictureBox1);
            Controls.Add(btnDelete);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDeletewords);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddWord);
            Controls.Add(lstWords);
            Controls.Add(txtWordInput);
            Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormAddwords";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormAddwords";
            Load += FormAddwords_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWordInput;
        private ListBox lstWords;
        private Button btnAddWord;
        private PictureBox pictureBox1;
        private TextBox txtDeletewords;
        private Label label1;
        private Label label2;
        private Button btnDelete;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}