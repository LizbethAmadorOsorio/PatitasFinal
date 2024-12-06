namespace patitasOrgMILAV
{
    partial class login
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
            panel1 = new Panel();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnLogIn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(253, 193, 186);
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(0, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 87);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(139, 81, 75);
            btnClose.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(255, 234, 232);
            btnClose.Location = new Point(265, 20);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(44, 54);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(139, 81, 75);
            label1.Location = new Point(124, 98);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(139, 81, 75);
            label2.Location = new Point(109, 178);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 25);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 221);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 25);
            textBox2.TabIndex = 5;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(139, 81, 75);
            btnLogIn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.FromArgb(255, 234, 232);
            btnLogIn.Location = new Point(79, 274);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(158, 49);
            btnLogIn.TabIndex = 6;
            btnLogIn.Text = "Iniciar Sesión";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources.Golden;
            ClientSize = new Size(321, 469);
            Controls.Add(btnLogIn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            Text = "login";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnLogIn;
    }
}