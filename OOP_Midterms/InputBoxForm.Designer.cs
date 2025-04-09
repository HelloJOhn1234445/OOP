namespace OOP_Midterms
{
    partial class InputBoxForm
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
            lblPrompt = new Label();
            txtInput = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(88, 89);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(78, 20);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Username:";
            lblPrompt.Click += lblPrompt_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(31, 123);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(189, 27);
            txtInput.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.SkyBlue;
            btnOk.BackgroundImageLayout = ImageLayout.None;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Location = new Point(43, 184);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(66, 64);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SkyBlue;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(147, 184);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(79, 64);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // InputBoxForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(285, 300);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(txtInput);
            Controls.Add(lblPrompt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InputBoxForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InputBoxForm";
            Load += InputBoxForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private TextBox txtInput;
        private Button btnOk;
        private Button btnCancel;
    }
}