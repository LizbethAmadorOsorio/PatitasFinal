namespace patitasOrgMILAV
{
    partial class frmEncargadoVoluntarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncargadoVoluntarios));
            btnCerrarEV = new Button();
            tabControlEV = new TabControl();
            tbPConsultarEV = new TabPage();
            panel1 = new Panel();
            dgvInfoEV = new DataGridView();
            btnCargInfoEV = new Button();
            label1 = new Label();
            tbPRegistrarEV = new TabPage();
            panel2 = new Panel();
            button4 = new Button();
            txtEdadREV = new TextBox();
            label9 = new Label();
            txtIdREV = new TextBox();
            label8 = new Label();
            txtAreaREV = new TextBox();
            txtContactoREV = new TextBox();
            txtApellido2REV = new TextBox();
            txtApellido1REV = new TextBox();
            txtNombreREV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbPActualizarEV = new TabPage();
            panel5 = new Panel();
            button1 = new Button();
            txtBuscarIdAEV = new TextBox();
            label18 = new Label();
            label19 = new Label();
            panel3 = new Panel();
            button13 = new Button();
            panel4 = new Panel();
            txtEdadAEV = new TextBox();
            label10 = new Label();
            txtIdAEV = new TextBox();
            label11 = new Label();
            txtAreaAEV = new TextBox();
            txtContactoAEV = new TextBox();
            txtApellido2AEV = new TextBox();
            txtApellido1AEV = new TextBox();
            txtNombreAEV = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            tbPEliminarEV = new TabPage();
            panel8 = new Panel();
            button3 = new Button();
            txtIDBuscarEEV = new TextBox();
            label38 = new Label();
            label39 = new Label();
            panel7 = new Panel();
            button2 = new Button();
            txtEdadEEV = new TextBox();
            label30 = new Label();
            txtIDEEV = new TextBox();
            label31 = new Label();
            txtAreaEEV = new TextBox();
            txtContactoEEV = new TextBox();
            txtApellido2EEV = new TextBox();
            txtApellido1EEV = new TextBox();
            txtNombreEEV = new TextBox();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            label37 = new Label();
            panel6 = new Panel();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            btnEliminarEV = new Button();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            btnBuscarEEV = new Button();
            txtBuscIdEEV = new TextBox();
            label28 = new Label();
            label29 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            tabControlEV.SuspendLayout();
            tbPConsultarEV.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfoEV).BeginInit();
            tbPRegistrarEV.SuspendLayout();
            panel2.SuspendLayout();
            tbPActualizarEV.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            tbPEliminarEV.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnCerrarEV
            // 
            btnCerrarEV.BackColor = Color.FromArgb(139, 81, 75);
            btnCerrarEV.FlatStyle = FlatStyle.Flat;
            btnCerrarEV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarEV.ForeColor = Color.FromArgb(255, 234, 232);
            btnCerrarEV.Location = new Point(628, 40);
            btnCerrarEV.Name = "btnCerrarEV";
            btnCerrarEV.Size = new Size(87, 50);
            btnCerrarEV.TabIndex = 8;
            btnCerrarEV.Text = "Cerrar Sesión";
            btnCerrarEV.UseVisualStyleBackColor = false;
            // 
            // tabControlEV
            // 
            tabControlEV.Controls.Add(tbPConsultarEV);
            tabControlEV.Controls.Add(tbPRegistrarEV);
            tabControlEV.Controls.Add(tbPActualizarEV);
            tabControlEV.Controls.Add(tbPEliminarEV);
            tabControlEV.Location = new Point(12, 12);
            tabControlEV.Name = "tabControlEV";
            tabControlEV.SelectedIndex = 0;
            tabControlEV.Size = new Size(597, 382);
            tabControlEV.TabIndex = 9;
            // 
            // tbPConsultarEV
            // 
            tbPConsultarEV.BackColor = Color.White;
            tbPConsultarEV.Controls.Add(panel1);
            tbPConsultarEV.Location = new Point(4, 26);
            tbPConsultarEV.Name = "tbPConsultarEV";
            tbPConsultarEV.Padding = new Padding(3);
            tbPConsultarEV.Size = new Size(589, 352);
            tbPConsultarEV.TabIndex = 0;
            tbPConsultarEV.Text = "Consultar";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 234, 232);
            panel1.Controls.Add(dgvInfoEV);
            panel1.Controls.Add(btnCargInfoEV);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 348);
            panel1.TabIndex = 0;
            // 
            // dgvInfoEV
            // 
            dgvInfoEV.BackgroundColor = Color.FromArgb(253, 193, 186);
            dgvInfoEV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfoEV.Location = new Point(27, 104);
            dgvInfoEV.Name = "dgvInfoEV";
            dgvInfoEV.Size = new Size(529, 219);
            dgvInfoEV.TabIndex = 8;
            // 
            // btnCargInfoEV
            // 
            btnCargInfoEV.BackColor = Color.FromArgb(139, 81, 75);
            btnCargInfoEV.FlatStyle = FlatStyle.Flat;
            btnCargInfoEV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargInfoEV.ForeColor = Color.FromArgb(255, 234, 232);
            btnCargInfoEV.Location = new Point(450, 21);
            btnCargInfoEV.Name = "btnCargInfoEV";
            btnCargInfoEV.Size = new Size(106, 60);
            btnCargInfoEV.TabIndex = 7;
            btnCargInfoEV.Text = "Cargar información";
            btnCargInfoEV.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(139, 81, 75);
            label1.Location = new Point(27, 40);
            label1.Name = "label1";
            label1.Size = new Size(376, 21);
            label1.TabIndex = 6;
            label1.Text = "Consulta aquí la información sobre los animales";
            // 
            // tbPRegistrarEV
            // 
            tbPRegistrarEV.Controls.Add(panel2);
            tbPRegistrarEV.Location = new Point(4, 26);
            tbPRegistrarEV.Name = "tbPRegistrarEV";
            tbPRegistrarEV.Padding = new Padding(3);
            tbPRegistrarEV.Size = new Size(589, 352);
            tbPRegistrarEV.TabIndex = 1;
            tbPRegistrarEV.Text = "Registrar";
            tbPRegistrarEV.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 234, 232);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(txtEdadREV);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtIdREV);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtAreaREV);
            panel2.Controls.Add(txtContactoREV);
            panel2.Controls.Add(txtApellido2REV);
            panel2.Controls.Add(txtApellido1REV);
            panel2.Controls.Add(txtNombreREV);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 351);
            panel2.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(139, 81, 75);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(255, 234, 232);
            button4.Location = new Point(473, 277);
            button4.Name = "button4";
            button4.Size = new Size(90, 38);
            button4.TabIndex = 42;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = false;
            // 
            // txtEdadREV
            // 
            txtEdadREV.BackColor = Color.FromArgb(253, 193, 186);
            txtEdadREV.Location = new Point(25, 283);
            txtEdadREV.Name = "txtEdadREV";
            txtEdadREV.Size = new Size(152, 25);
            txtEdadREV.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(139, 81, 75);
            label9.Location = new Point(25, 252);
            label9.Name = "label9";
            label9.Size = new Size(45, 17);
            label9.TabIndex = 40;
            label9.Text = "Edad: ";
            // 
            // txtIdREV
            // 
            txtIdREV.BackColor = Color.FromArgb(253, 193, 186);
            txtIdREV.Location = new Point(411, 202);
            txtIdREV.Name = "txtIdREV";
            txtIdREV.Size = new Size(152, 25);
            txtIdREV.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(139, 81, 75);
            label8.Location = new Point(223, 168);
            label8.Name = "label8";
            label8.Size = new Size(139, 17);
            label8.TabIndex = 38;
            label8.Text = "Área de voluntariado:";
            // 
            // txtAreaREV
            // 
            txtAreaREV.BackColor = Color.FromArgb(253, 193, 186);
            txtAreaREV.Location = new Point(223, 202);
            txtAreaREV.Name = "txtAreaREV";
            txtAreaREV.Size = new Size(150, 25);
            txtAreaREV.TabIndex = 37;
            // 
            // txtContactoREV
            // 
            txtContactoREV.BackColor = Color.FromArgb(253, 193, 186);
            txtContactoREV.Location = new Point(24, 202);
            txtContactoREV.Name = "txtContactoREV";
            txtContactoREV.Size = new Size(152, 25);
            txtContactoREV.TabIndex = 36;
            // 
            // txtApellido2REV
            // 
            txtApellido2REV.BackColor = Color.FromArgb(253, 193, 186);
            txtApellido2REV.Location = new Point(407, 110);
            txtApellido2REV.Name = "txtApellido2REV";
            txtApellido2REV.Size = new Size(156, 25);
            txtApellido2REV.TabIndex = 35;
            // 
            // txtApellido1REV
            // 
            txtApellido1REV.BackColor = Color.FromArgb(253, 193, 186);
            txtApellido1REV.Location = new Point(223, 110);
            txtApellido1REV.Name = "txtApellido1REV";
            txtApellido1REV.Size = new Size(152, 25);
            txtApellido1REV.TabIndex = 34;
            // 
            // txtNombreREV
            // 
            txtNombreREV.BackColor = Color.FromArgb(253, 193, 186);
            txtNombreREV.Location = new Point(24, 110);
            txtNombreREV.Name = "txtNombreREV";
            txtNombreREV.Size = new Size(157, 25);
            txtNombreREV.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(139, 81, 75);
            label7.Location = new Point(407, 168);
            label7.Name = "label7";
            label7.Size = new Size(24, 17);
            label7.TabIndex = 32;
            label7.Text = "ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(139, 81, 75);
            label6.Location = new Point(24, 170);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 30;
            label6.Text = "Contacto: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(139, 81, 75);
            label5.Location = new Point(411, 78);
            label5.Name = "label5";
            label5.Size = new Size(71, 17);
            label5.TabIndex = 29;
            label5.Text = "Apellido 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(139, 81, 75);
            label4.Location = new Point(223, 73);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 28;
            label4.Text = "Apellido 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(139, 81, 75);
            label3.Location = new Point(25, 78);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 27;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(139, 81, 75);
            label2.Location = new Point(209, 13);
            label2.Name = "label2";
            label2.Size = new Size(187, 21);
            label2.TabIndex = 26;
            label2.Text = "Registro de voluntarios";
            // 
            // tbPActualizarEV
            // 
            tbPActualizarEV.BackColor = Color.White;
            tbPActualizarEV.Controls.Add(panel5);
            tbPActualizarEV.Controls.Add(panel3);
            tbPActualizarEV.Location = new Point(4, 26);
            tbPActualizarEV.Name = "tbPActualizarEV";
            tbPActualizarEV.Size = new Size(589, 352);
            tbPActualizarEV.TabIndex = 2;
            tbPActualizarEV.Text = "Actualizar";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 234, 232);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(txtBuscarIdAEV);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label19);
            panel5.Location = new Point(422, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(167, 348);
            panel5.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(139, 81, 75);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(255, 234, 232);
            button1.Location = new Point(49, 275);
            button1.Name = "button1";
            button1.Size = new Size(79, 32);
            button1.TabIndex = 37;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtBuscarIdAEV
            // 
            txtBuscarIdAEV.BackColor = Color.FromArgb(253, 193, 186);
            txtBuscarIdAEV.Location = new Point(39, 157);
            txtBuscarIdAEV.Name = "txtBuscarIdAEV";
            txtBuscarIdAEV.Size = new Size(100, 25);
            txtBuscarIdAEV.TabIndex = 33;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(139, 81, 75);
            label18.Location = new Point(27, 119);
            label18.Name = "label18";
            label18.Size = new Size(112, 17);
            label18.TabIndex = 32;
            label18.Text = "ID del voluntario:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(139, 81, 75);
            label19.Location = new Point(49, 20);
            label19.Name = "label19";
            label19.Size = new Size(63, 21);
            label19.TabIndex = 31;
            label19.Text = "Buscar";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 234, 232);
            panel3.Controls.Add(button13);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(txtEdadAEV);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtIdAEV);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtAreaAEV);
            panel3.Controls.Add(txtContactoAEV);
            panel3.Controls.Add(txtApellido2AEV);
            panel3.Controls.Add(txtApellido1AEV);
            panel3.Controls.Add(txtNombreAEV);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label17);
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(423, 347);
            panel3.TabIndex = 0;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(139, 81, 75);
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.FromArgb(255, 234, 232);
            button13.Location = new Point(327, 274);
            button13.Name = "button13";
            button13.Size = new Size(79, 32);
            button13.TabIndex = 58;
            button13.Text = "Guardar";
            button13.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Location = new Point(422, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(167, 345);
            panel4.TabIndex = 1;
            // 
            // txtEdadAEV
            // 
            txtEdadAEV.BackColor = Color.FromArgb(253, 193, 186);
            txtEdadAEV.Location = new Point(33, 274);
            txtEdadAEV.Name = "txtEdadAEV";
            txtEdadAEV.Size = new Size(113, 25);
            txtEdadAEV.TabIndex = 57;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(139, 81, 75);
            label10.Location = new Point(33, 243);
            label10.Name = "label10";
            label10.Size = new Size(45, 17);
            label10.TabIndex = 56;
            label10.Text = "Edad: ";
            // 
            // txtIdAEV
            // 
            txtIdAEV.BackColor = Color.FromArgb(253, 193, 186);
            txtIdAEV.Location = new Point(296, 190);
            txtIdAEV.Name = "txtIdAEV";
            txtIdAEV.Size = new Size(110, 25);
            txtIdAEV.TabIndex = 55;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(139, 81, 75);
            label11.Location = new Point(157, 159);
            label11.Name = "label11";
            label11.Size = new Size(139, 17);
            label11.TabIndex = 54;
            label11.Text = "Área de voluntariado:";
            // 
            // txtAreaAEV
            // 
            txtAreaAEV.BackColor = Color.FromArgb(253, 193, 186);
            txtAreaAEV.Location = new Point(164, 190);
            txtAreaAEV.Name = "txtAreaAEV";
            txtAreaAEV.Size = new Size(113, 25);
            txtAreaAEV.TabIndex = 53;
            // 
            // txtContactoAEV
            // 
            txtContactoAEV.BackColor = Color.FromArgb(253, 193, 186);
            txtContactoAEV.Location = new Point(33, 190);
            txtContactoAEV.Name = "txtContactoAEV";
            txtContactoAEV.Size = new Size(113, 25);
            txtContactoAEV.TabIndex = 52;
            // 
            // txtApellido2AEV
            // 
            txtApellido2AEV.BackColor = Color.FromArgb(253, 193, 186);
            txtApellido2AEV.Location = new Point(296, 110);
            txtApellido2AEV.Name = "txtApellido2AEV";
            txtApellido2AEV.Size = new Size(110, 25);
            txtApellido2AEV.TabIndex = 51;
            // 
            // txtApellido1AEV
            // 
            txtApellido1AEV.BackColor = Color.FromArgb(253, 193, 186);
            txtApellido1AEV.Location = new Point(164, 110);
            txtApellido1AEV.Name = "txtApellido1AEV";
            txtApellido1AEV.Size = new Size(113, 25);
            txtApellido1AEV.TabIndex = 50;
            // 
            // txtNombreAEV
            // 
            txtNombreAEV.BackColor = Color.FromArgb(253, 193, 186);
            txtNombreAEV.Location = new Point(32, 110);
            txtNombreAEV.Name = "txtNombreAEV";
            txtNombreAEV.Size = new Size(114, 25);
            txtNombreAEV.TabIndex = 49;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(139, 81, 75);
            label12.Location = new Point(339, 159);
            label12.Name = "label12";
            label12.Size = new Size(24, 17);
            label12.TabIndex = 48;
            label12.Text = "ID:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(139, 81, 75);
            label13.Location = new Point(33, 159);
            label13.Name = "label13";
            label13.Size = new Size(70, 17);
            label13.TabIndex = 46;
            label13.Text = "Contacto: ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(139, 81, 75);
            label14.Location = new Point(296, 78);
            label14.Name = "label14";
            label14.Size = new Size(71, 17);
            label14.TabIndex = 45;
            label14.Text = "Apellido 2:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(139, 81, 75);
            label15.Location = new Point(164, 78);
            label15.Name = "label15";
            label15.Size = new Size(69, 17);
            label15.TabIndex = 44;
            label15.Text = "Apellido 1:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(139, 81, 75);
            label16.Location = new Point(33, 78);
            label16.Name = "label16";
            label16.Size = new Size(61, 17);
            label16.TabIndex = 43;
            label16.Text = "Nombre:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(139, 81, 75);
            label17.Location = new Point(64, 19);
            label17.Name = "label17";
            label17.Size = new Size(299, 21);
            label17.TabIndex = 42;
            label17.Text = "Actualizar información de voluntarios";
            // 
            // tbPEliminarEV
            // 
            tbPEliminarEV.Controls.Add(panel8);
            tbPEliminarEV.Controls.Add(panel7);
            tbPEliminarEV.Controls.Add(panel6);
            tbPEliminarEV.Location = new Point(4, 26);
            tbPEliminarEV.Name = "tbPEliminarEV";
            tbPEliminarEV.Size = new Size(589, 352);
            tbPEliminarEV.TabIndex = 3;
            tbPEliminarEV.Text = "Eliminar";
            tbPEliminarEV.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 234, 232);
            panel8.Controls.Add(button3);
            panel8.Controls.Add(txtIDBuscarEEV);
            panel8.Controls.Add(label38);
            panel8.Controls.Add(label39);
            panel8.Location = new Point(418, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(171, 348);
            panel8.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(139, 81, 75);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(255, 234, 232);
            button3.Location = new Point(53, 279);
            button3.Name = "button3";
            button3.Size = new Size(79, 32);
            button3.TabIndex = 75;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = false;
            // 
            // txtIDBuscarEEV
            // 
            txtIDBuscarEEV.BackColor = Color.FromArgb(253, 193, 186);
            txtIDBuscarEEV.Location = new Point(44, 172);
            txtIDBuscarEEV.Name = "txtIDBuscarEEV";
            txtIDBuscarEEV.Size = new Size(100, 25);
            txtIDBuscarEEV.TabIndex = 37;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label38.ForeColor = Color.FromArgb(139, 81, 75);
            label38.Location = new Point(32, 139);
            label38.Name = "label38";
            label38.Size = new Size(112, 17);
            label38.TabIndex = 36;
            label38.Text = "ID del voluntario:";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label39.ForeColor = Color.FromArgb(139, 81, 75);
            label39.Location = new Point(55, 33);
            label39.Name = "label39";
            label39.Size = new Size(60, 21);
            label39.TabIndex = 35;
            label39.Text = "Buscar";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 234, 232);
            panel7.Controls.Add(button2);
            panel7.Controls.Add(txtEdadEEV);
            panel7.Controls.Add(label30);
            panel7.Controls.Add(txtIDEEV);
            panel7.Controls.Add(label31);
            panel7.Controls.Add(txtAreaEEV);
            panel7.Controls.Add(txtContactoEEV);
            panel7.Controls.Add(txtApellido2EEV);
            panel7.Controls.Add(txtApellido1EEV);
            panel7.Controls.Add(txtNombreEEV);
            panel7.Controls.Add(label32);
            panel7.Controls.Add(label33);
            panel7.Controls.Add(label34);
            panel7.Controls.Add(label35);
            panel7.Controls.Add(label36);
            panel7.Controls.Add(label37);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(419, 348);
            panel7.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(139, 81, 75);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(255, 234, 232);
            button2.Location = new Point(315, 279);
            button2.Name = "button2";
            button2.Size = new Size(79, 32);
            button2.TabIndex = 74;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtEdadEEV
            // 
            txtEdadEEV.BackColor = Color.FromArgb(253, 193, 186);
            txtEdadEEV.Location = new Point(25, 288);
            txtEdadEEV.Name = "txtEdadEEV";
            txtEdadEEV.Size = new Size(113, 25);
            txtEdadEEV.TabIndex = 73;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.FromArgb(139, 81, 75);
            label30.Location = new Point(25, 256);
            label30.Name = "label30";
            label30.Size = new Size(45, 17);
            label30.TabIndex = 72;
            label30.Text = "Edad: ";
            // 
            // txtIDEEV
            // 
            txtIDEEV.BackColor = Color.FromArgb(253, 193, 186);
            txtIDEEV.Location = new Point(284, 204);
            txtIDEEV.Name = "txtIDEEV";
            txtIDEEV.Size = new Size(110, 25);
            txtIDEEV.TabIndex = 71;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.ForeColor = Color.FromArgb(139, 81, 75);
            label31.Location = new Point(149, 172);
            label31.Name = "label31";
            label31.Size = new Size(139, 17);
            label31.TabIndex = 70;
            label31.Text = "Área de voluntariado:";
            // 
            // txtAreaEEV
            // 
            txtAreaEEV.BackColor = Color.FromArgb(253, 193, 186);
            txtAreaEEV.Location = new Point(156, 204);
            txtAreaEEV.Name = "txtAreaEEV";
            txtAreaEEV.Size = new Size(113, 25);
            txtAreaEEV.TabIndex = 69;
            // 
            // txtContactoEEV
            // 
            txtContactoEEV.BackColor = Color.FromArgb(253, 193, 186);
            txtContactoEEV.Location = new Point(25, 204);
            txtContactoEEV.Name = "txtContactoEEV";
            txtContactoEEV.Size = new Size(113, 25);
            txtContactoEEV.TabIndex = 68;
            // 
            // txtApellido2EEV
            // 
            txtApellido2EEV.BackColor = Color.FromArgb(253, 193, 186);
            txtApellido2EEV.Location = new Point(284, 124);
            txtApellido2EEV.Name = "txtApellido2EEV";
            txtApellido2EEV.Size = new Size(110, 25);
            txtApellido2EEV.TabIndex = 67;
            // 
            // txtApellido1EEV
            // 
            txtApellido1EEV.BackColor = Color.FromArgb(253, 193, 186);
            txtApellido1EEV.Location = new Point(156, 124);
            txtApellido1EEV.Name = "txtApellido1EEV";
            txtApellido1EEV.Size = new Size(113, 25);
            txtApellido1EEV.TabIndex = 66;
            // 
            // txtNombreEEV
            // 
            txtNombreEEV.BackColor = Color.FromArgb(253, 193, 186);
            txtNombreEEV.Location = new Point(24, 124);
            txtNombreEEV.Name = "txtNombreEEV";
            txtNombreEEV.Size = new Size(114, 25);
            txtNombreEEV.TabIndex = 65;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.ForeColor = Color.FromArgb(139, 81, 75);
            label32.Location = new Point(318, 172);
            label32.Name = "label32";
            label32.Size = new Size(24, 17);
            label32.TabIndex = 64;
            label32.Text = "ID:";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.ForeColor = Color.FromArgb(139, 81, 75);
            label33.Location = new Point(25, 172);
            label33.Name = "label33";
            label33.Size = new Size(70, 17);
            label33.TabIndex = 62;
            label33.Text = "Contacto: ";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.ForeColor = Color.FromArgb(139, 81, 75);
            label34.Location = new Point(288, 92);
            label34.Name = "label34";
            label34.Size = new Size(71, 17);
            label34.TabIndex = 61;
            label34.Text = "Apellido 2:";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.ForeColor = Color.FromArgb(139, 81, 75);
            label35.Location = new Point(156, 92);
            label35.Name = "label35";
            label35.Size = new Size(69, 17);
            label35.TabIndex = 60;
            label35.Text = "Apellido 1:";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.ForeColor = Color.FromArgb(139, 81, 75);
            label36.Location = new Point(25, 92);
            label36.Name = "label36";
            label36.Size = new Size(61, 17);
            label36.TabIndex = 59;
            label36.Text = "Nombre:";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label37.ForeColor = Color.FromArgb(139, 81, 75);
            label37.Location = new Point(56, 33);
            label37.Name = "label37";
            label37.Size = new Size(286, 21);
            label37.TabIndex = 58;
            label37.Text = "Eliminar información de voluntarios";
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 113);
            panel6.TabIndex = 1;
            // 
            // label20
            // 
            label20.Location = new Point(0, 0);
            label20.Name = "label20";
            label20.Size = new Size(100, 23);
            label20.TabIndex = 0;
            // 
            // label21
            // 
            label21.Location = new Point(0, 0);
            label21.Name = "label21";
            label21.Size = new Size(100, 23);
            label21.TabIndex = 0;
            // 
            // label22
            // 
            label22.Location = new Point(0, 0);
            label22.Name = "label22";
            label22.Size = new Size(100, 23);
            label22.TabIndex = 0;
            // 
            // btnEliminarEV
            // 
            btnEliminarEV.Location = new Point(0, 0);
            btnEliminarEV.Name = "btnEliminarEV";
            btnEliminarEV.Size = new Size(75, 23);
            btnEliminarEV.TabIndex = 0;
            // 
            // label23
            // 
            label23.Location = new Point(0, 0);
            label23.Name = "label23";
            label23.Size = new Size(100, 23);
            label23.TabIndex = 0;
            // 
            // label24
            // 
            label24.Location = new Point(0, 0);
            label24.Name = "label24";
            label24.Size = new Size(100, 23);
            label24.TabIndex = 0;
            // 
            // label25
            // 
            label25.Location = new Point(0, 0);
            label25.Name = "label25";
            label25.Size = new Size(100, 23);
            label25.TabIndex = 0;
            // 
            // label26
            // 
            label26.Location = new Point(0, 0);
            label26.Name = "label26";
            label26.Size = new Size(100, 23);
            label26.TabIndex = 0;
            // 
            // label27
            // 
            label27.Location = new Point(0, 0);
            label27.Name = "label27";
            label27.Size = new Size(100, 23);
            label27.TabIndex = 0;
            // 
            // btnBuscarEEV
            // 
            btnBuscarEEV.Location = new Point(0, 0);
            btnBuscarEEV.Name = "btnBuscarEEV";
            btnBuscarEEV.Size = new Size(75, 23);
            btnBuscarEEV.TabIndex = 0;
            // 
            // txtBuscIdEEV
            // 
            txtBuscIdEEV.Location = new Point(0, 0);
            txtBuscIdEEV.Name = "txtBuscIdEEV";
            txtBuscIdEEV.Size = new Size(100, 25);
            txtBuscIdEEV.TabIndex = 0;
            // 
            // label28
            // 
            label28.Location = new Point(0, 0);
            label28.Name = "label28";
            label28.Size = new Size(100, 23);
            label28.TabIndex = 0;
            // 
            // label29
            // 
            label29.Location = new Point(0, 0);
            label29.Name = "label29";
            label29.Size = new Size(100, 23);
            label29.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.LogoMILAV_Final;
            pictureBox1.Location = new Point(620, 179);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LogoMILAV_Final;
            pictureBox3.InitialImage = Properties.Resources.LogoMILAV_Final;
            pictureBox3.Location = new Point(620, 293);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(95, 95);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // frmEncargadoVoluntarios
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 193, 186);
            ClientSize = new Size(727, 407);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(tabControlEV);
            Controls.Add(btnCerrarEV);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmEncargadoVoluntarios";
            Text = "frmEncargadoVoluntarios";
            tabControlEV.ResumeLayout(false);
            tbPConsultarEV.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfoEV).EndInit();
            tbPRegistrarEV.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tbPActualizarEV.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tbPEliminarEV.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrarEV;
        private TabControl tabControlEV;
        private TabPage tbPConsultarEV;
        private TabPage tbPRegistrarEV;
        private TabPage tbPActualizarEV;
        private TabPage tbPEliminarEV;
        private Panel panel1;
        private Button btnCargInfoEV;
        private Label label1;
        private DataGridView dgvInfoEV;
        private Panel panel2;
        private TextBox txtIdREV;
        private Label label8;
        private TextBox txtAreaREV;
        private TextBox txtContactoREV;
        private TextBox txtApellido2REV;
        private TextBox txtApellido1REV;
        private TextBox txtNombreREV;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEdadREV;
        private Label label9;
        private Panel panel3;
        private TextBox txtEdadAEV;
        private Label label10;
        private TextBox txtIdAEV;
        private Label label11;
        private TextBox txtAreaAEV;
        private TextBox txtContactoAEV;
        private TextBox txtApellido2AEV;
        private TextBox txtApellido1AEV;
        private TextBox txtNombreAEV;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Panel panel4;
        private Panel panel5;
        private TextBox txtBuscarIdAEV;
        private Label label18;
        private Label label19;
        private Panel panel6;
        private TextBox txtEdadEEV;
        private Label label20;
        private TextBox txtIDEEV;
        private Label label21;
        private TextBox txtAreaEEV;
        private TextBox txtContactoEEV;
        private TextBox txtApellido2EEV;
        private TextBox txtApellido1EEV;
        private TextBox txtNombreEEV;
        private Label label22;
        private Button btnEliminarEV;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Panel panel7;
        private Button btnBuscarEEV;
        private TextBox txtBuscIdEEV;
        private Label label28;
        private Label label29;
        private Panel panel8;
        private TextBox txtIDBuscarEEV;
        private Label label38;
        private Label label39;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button button4;
        private Button button1;
        private Button button13;
        private Button button2;
        private Button button3;
    }
}