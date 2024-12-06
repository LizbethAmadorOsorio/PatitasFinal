namespace patitasOrgMILAV
{
    partial class paginaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paginaInicial));
            tabCtrlPagPrin = new TabControl();
            Nosotros = new TabPage();
            panel1 = new Panel();
            btnLogin = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblInfoOrg = new Label();
            Campañas = new TabPage();
            lblCampañas = new Label();
            dgvCampañas = new DataGridView();
            Reportes = new TabPage();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            gbReportes = new GroupBox();
            btnSubirReporte = new Button();
            tbReportes = new TextBox();
            lblGbRepor = new Label();
            lblReportes = new Label();
            dataGridView1 = new DataGridView();
            tabCtrlPagPrin.SuspendLayout();
            Nosotros.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Campañas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCampañas).BeginInit();
            Reportes.SuspendLayout();
            gbReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabCtrlPagPrin
            // 
            tabCtrlPagPrin.Alignment = TabAlignment.Left;
            tabCtrlPagPrin.Controls.Add(Nosotros);
            tabCtrlPagPrin.Controls.Add(Campañas);
            tabCtrlPagPrin.Controls.Add(Reportes);
            tabCtrlPagPrin.Dock = DockStyle.Left;
            tabCtrlPagPrin.Location = new Point(0, 0);
            tabCtrlPagPrin.Margin = new Padding(0);
            tabCtrlPagPrin.Multiline = true;
            tabCtrlPagPrin.Name = "tabCtrlPagPrin";
            tabCtrlPagPrin.SelectedIndex = 0;
            tabCtrlPagPrin.Size = new Size(1000, 452);
            tabCtrlPagPrin.TabIndex = 0;
            // 
            // Nosotros
            // 
            Nosotros.BackColor = Color.White;
            Nosotros.Controls.Add(panel1);
            Nosotros.Controls.Add(lblInfoOrg);
            Nosotros.Cursor = Cursors.Hand;
            Nosotros.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nosotros.Location = new Point(28, 4);
            Nosotros.Name = "Nosotros";
            Nosotros.Padding = new Padding(3);
            Nosotros.Size = new Size(968, 444);
            Nosotros.TabIndex = 1;
            Nosotros.Text = "   Sobre Nosoros  ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(253, 193, 186);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(574, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 452);
            panel1.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(139, 81, 75);
            btnLogin.Dock = DockStyle.Top;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(0, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(121, 51);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = Properties.Resources.LogoMILAV_Final;
            pictureBox2.Location = new Point(0, 228);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 114);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.LogoMILAV_Final;
            pictureBox1.Location = new Point(0, 342);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblInfoOrg
            // 
            lblInfoOrg.BackColor = Color.Transparent;
            lblInfoOrg.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInfoOrg.ForeColor = Color.FromArgb(139, 81, 75);
            lblInfoOrg.Image = (Image)resources.GetObject("lblInfoOrg.Image");
            lblInfoOrg.ImageAlign = ContentAlignment.MiddleRight;
            lblInfoOrg.Location = new Point(0, 3);
            lblInfoOrg.Name = "lblInfoOrg";
            lblInfoOrg.Size = new Size(577, 445);
            lblInfoOrg.TabIndex = 0;
            lblInfoOrg.Text = resources.GetString("lblInfoOrg.Text");
            lblInfoOrg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Campañas
            // 
            Campañas.BackColor = Color.FromArgb(255, 234, 232);
            Campañas.BackgroundImage = (Image)resources.GetObject("Campañas.BackgroundImage");
            Campañas.BackgroundImageLayout = ImageLayout.Zoom;
            Campañas.Controls.Add(lblCampañas);
            Campañas.Controls.Add(dgvCampañas);
            Campañas.Cursor = Cursors.Hand;
            Campañas.Location = new Point(28, 4);
            Campañas.Name = "Campañas";
            Campañas.Padding = new Padding(3);
            Campañas.Size = new Size(968, 444);
            Campañas.TabIndex = 2;
            Campañas.Text = "  Campañas  ";
            // 
            // lblCampañas
            // 
            lblCampañas.AutoSize = true;
            lblCampañas.BackColor = Color.Transparent;
            lblCampañas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCampañas.ForeColor = Color.FromArgb(139, 81, 75);
            lblCampañas.Location = new Point(46, 321);
            lblCampañas.Name = "lblCampañas";
            lblCampañas.Size = new Size(344, 42);
            lblCampañas.TabIndex = 1;
            lblCampañas.Text = "En esta sección puedes apreciar las campañas \r\nque están activas en la organización";
            lblCampañas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCampañas
            // 
            dgvCampañas.BackgroundColor = Color.FromArgb(253, 193, 186);
            dgvCampañas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCampañas.Location = new Point(32, 18);
            dgvCampañas.Name = "dgvCampañas";
            dgvCampañas.Size = new Size(613, 225);
            dgvCampañas.TabIndex = 0;
            // 
            // Reportes
            // 
            Reportes.BackColor = Color.FromArgb(255, 234, 232);
            Reportes.Controls.Add(textBox3);
            Reportes.Controls.Add(textBox2);
            Reportes.Controls.Add(textBox1);
            Reportes.Controls.Add(gbReportes);
            Reportes.Controls.Add(lblReportes);
            Reportes.Controls.Add(dataGridView1);
            Reportes.Cursor = Cursors.Hand;
            Reportes.Location = new Point(28, 4);
            Reportes.Name = "Reportes";
            Reportes.Padding = new Padding(3);
            Reportes.Size = new Size(968, 444);
            Reportes.TabIndex = 3;
            Reportes.Text = "  Reportes  ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(218, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 25);
            textBox3.TabIndex = 5;
            textBox3.Text = "Descripción";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 4;
            textBox2.Text = "Fecha";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 3;
            textBox1.Text = "Nombre";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // gbReportes
            // 
            gbReportes.BackgroundImageLayout = ImageLayout.Zoom;
            gbReportes.Controls.Add(btnSubirReporte);
            gbReportes.Controls.Add(tbReportes);
            gbReportes.Controls.Add(lblGbRepor);
            gbReportes.Location = new Point(380, 31);
            gbReportes.Name = "gbReportes";
            gbReportes.Size = new Size(257, 370);
            gbReportes.TabIndex = 2;
            gbReportes.TabStop = false;
            // 
            // btnSubirReporte
            // 
            btnSubirReporte.BackColor = Color.FromArgb(139, 81, 75);
            btnSubirReporte.FlatStyle = FlatStyle.Flat;
            btnSubirReporte.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubirReporte.ForeColor = Color.FromArgb(255, 234, 232);
            btnSubirReporte.Location = new Point(95, 312);
            btnSubirReporte.Name = "btnSubirReporte";
            btnSubirReporte.Size = new Size(92, 37);
            btnSubirReporte.TabIndex = 2;
            btnSubirReporte.Text = "Reportar";
            btnSubirReporte.UseVisualStyleBackColor = false;
            // 
            // tbReportes
            // 
            tbReportes.BackColor = Color.FromArgb(253, 193, 186);
            tbReportes.Location = new Point(16, 131);
            tbReportes.Multiline = true;
            tbReportes.Name = "tbReportes";
            tbReportes.Size = new Size(225, 156);
            tbReportes.TabIndex = 1;
            // 
            // lblGbRepor
            // 
            lblGbRepor.AutoSize = true;
            lblGbRepor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGbRepor.ForeColor = Color.FromArgb(139, 81, 75);
            lblGbRepor.Location = new Point(16, 21);
            lblGbRepor.Name = "lblGbRepor";
            lblGbRepor.Size = new Size(206, 34);
            lblGbRepor.TabIndex = 0;
            lblGbRepor.Text = "Escribe breve y objetivamente \r\nla situacion que deseas reportar:";
            lblGbRepor.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblReportes
            // 
            lblReportes.AutoSize = true;
            lblReportes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportes.ForeColor = Color.FromArgb(139, 81, 75);
            lblReportes.Location = new Point(73, 31);
            lblReportes.Name = "lblReportes";
            lblReportes.Size = new Size(172, 30);
            lblReportes.TabIndex = 1;
            lblReportes.Text = "Reportes/Avisos";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(253, 193, 186);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(296, 315);
            dataGridView1.TabIndex = 0;
            // 
            // paginaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 193, 186);
            ClientSize = new Size(718, 452);
            Controls.Add(tabCtrlPagPrin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "paginaInicial";
            Text = "Pagina principal";
            tabCtrlPagPrin.ResumeLayout(false);
            Nosotros.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Campañas.ResumeLayout(false);
            Campañas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCampañas).EndInit();
            Reportes.ResumeLayout(false);
            Reportes.PerformLayout();
            gbReportes.ResumeLayout(false);
            gbReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabCtrlPagPrin;
        private TabPage Campañas;
        private Button btnLogin;
        private PictureBox pictureBox2;
        private Label lblCampañas;
        private DataGridView dgvCampañas;
        private PictureBox pictureBox1;
        private TabPage Nosotros;
        private Label lblInfoOrg;
        private Panel panel1;
        private TabPage Reportes;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox gbReportes;
        private Button btnSubirReporte;
        private TextBox tbReportes;
        private Label lblGbRepor;
        private Label lblReportes;
        private DataGridView dataGridView1;
    }
}
