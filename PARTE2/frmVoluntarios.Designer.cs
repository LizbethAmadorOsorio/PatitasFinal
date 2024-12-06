namespace patitasOrgMILAV
{
    partial class frmVoluntarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoluntarios));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvVoluntarios = new DataGridView();
            btnInfoVoluntario = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            áreaToolStripMenuItem = new ToolStripMenuItem();
            campañasToolStripMenuItem = new ToolStripMenuItem();
            animalesToolStripMenuItem = new ToolStripMenuItem();
            veterinariaToolStripMenuItem = new ToolStripMenuItem();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnCerrarEV = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVoluntarios).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(-1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(625, 424);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(255, 234, 232);
            tabPage1.Controls.Add(dgvVoluntarios);
            tabPage1.Controls.Add(btnInfoVoluntario);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(menuStrip1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(617, 394);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consultar";
            // 
            // dgvVoluntarios
            // 
            dgvVoluntarios.BackgroundColor = Color.FromArgb(253, 193, 186);
            dgvVoluntarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVoluntarios.Location = new Point(39, 137);
            dgvVoluntarios.Name = "dgvVoluntarios";
            dgvVoluntarios.Size = new Size(550, 224);
            dgvVoluntarios.TabIndex = 3;
            // 
            // btnInfoVoluntario
            // 
            btnInfoVoluntario.BackColor = Color.FromArgb(139, 81, 75);
            btnInfoVoluntario.FlatStyle = FlatStyle.Flat;
            btnInfoVoluntario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInfoVoluntario.ForeColor = Color.FromArgb(255, 234, 232);
            btnInfoVoluntario.Location = new Point(479, 60);
            btnInfoVoluntario.Name = "btnInfoVoluntario";
            btnInfoVoluntario.Size = new Size(110, 53);
            btnInfoVoluntario.TabIndex = 2;
            btnInfoVoluntario.Text = "Cargar información";
            btnInfoVoluntario.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(139, 81, 75);
            label1.Location = new Point(39, 75);
            label1.Name = "label1";
            label1.Size = new Size(315, 21);
            label1.TabIndex = 1;
            label1.Text = "Consulta la información de tu área aquí.\r\n";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { áreaToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(611, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // áreaToolStripMenuItem
            // 
            áreaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { campañasToolStripMenuItem, animalesToolStripMenuItem, veterinariaToolStripMenuItem });
            áreaToolStripMenuItem.Name = "áreaToolStripMenuItem";
            áreaToolStripMenuItem.Size = new Size(47, 21);
            áreaToolStripMenuItem.Text = "Área";
            // 
            // campañasToolStripMenuItem
            // 
            campañasToolStripMenuItem.Name = "campañasToolStripMenuItem";
            campañasToolStripMenuItem.Size = new Size(180, 22);
            campañasToolStripMenuItem.Text = "Campañas";
            // 
            // animalesToolStripMenuItem
            // 
            animalesToolStripMenuItem.Name = "animalesToolStripMenuItem";
            animalesToolStripMenuItem.Size = new Size(180, 22);
            animalesToolStripMenuItem.Text = "Animales";
            // 
            // veterinariaToolStripMenuItem
            // 
            veterinariaToolStripMenuItem.Name = "veterinariaToolStripMenuItem";
            veterinariaToolStripMenuItem.Size = new Size(180, 22);
            veterinariaToolStripMenuItem.Text = "Veterinaria";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LogoMILAV_Final;
            pictureBox3.InitialImage = Properties.Resources.LogoMILAV_Final;
            pictureBox3.Location = new Point(639, 317);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(95, 95);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.LogoMILAV_Final;
            pictureBox1.Location = new Point(639, 203);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnCerrarEV
            // 
            btnCerrarEV.BackColor = Color.FromArgb(139, 81, 75);
            btnCerrarEV.FlatStyle = FlatStyle.Flat;
            btnCerrarEV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarEV.ForeColor = Color.FromArgb(255, 234, 232);
            btnCerrarEV.Location = new Point(647, 25);
            btnCerrarEV.Name = "btnCerrarEV";
            btnCerrarEV.Size = new Size(87, 50);
            btnCerrarEV.TabIndex = 15;
            btnCerrarEV.Text = "Cerrar Sesión";
            btnCerrarEV.UseVisualStyleBackColor = false;
            // 
            // frmVoluntarios
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 193, 186);
            ClientSize = new Size(748, 424);
            Controls.Add(btnCerrarEV);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "frmVoluntarios";
            Text = "frmVoluntarios";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVoluntarios).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem áreaToolStripMenuItem;
        private ToolStripMenuItem campañasToolStripMenuItem;
        private ToolStripMenuItem animalesToolStripMenuItem;
        private ToolStripMenuItem veterinariaToolStripMenuItem;
        private Button btnInfoVoluntario;
        private Label label1;
        private DataGridView dgvVoluntarios;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Button btnCerrarEV;
    }
}