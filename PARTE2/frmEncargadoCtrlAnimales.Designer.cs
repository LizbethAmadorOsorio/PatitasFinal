namespace patitasOrgMILAV
{
    partial class EncargadoControlAnimales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncargadoControlAnimales));
            tbCEncCtrlAnim = new TabControl();
            ConsultarECA = new TabPage();
            panel1 = new Panel();
            btnCargInfoECA = new Button();
            dgvInfoECA = new DataGridView();
            label1 = new Label();
            tbpRegistrarECA = new TabPage();
            panel2 = new Panel();
            button12 = new Button();
            txtIdRECA = new TextBox();
            label8 = new Label();
            txtFechaRegisRECA = new TextBox();
            txtEspecieRECA = new TextBox();
            txtRazaRECA = new TextBox();
            txtEdadRECA = new TextBox();
            txtNombreRECA = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbpActualizarECA = new TabPage();
            panel4 = new Panel();
            button2 = new Button();
            txtBuscarIdAECA = new TextBox();
            label16 = new Label();
            label17 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            txtIdAECA = new TextBox();
            label9 = new Label();
            txtFechaRegisAECA = new TextBox();
            txtEspecieAECA = new TextBox();
            txtRazaAECA = new TextBox();
            txtEdadAECA = new TextBox();
            txtNombreAECA = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            tbpEliminarECA = new TabPage();
            panel6 = new Panel();
            button4 = new Button();
            txtBuscIdEECA = new TextBox();
            label25 = new Label();
            label26 = new Label();
            panel5 = new Panel();
            button3 = new Button();
            txtIdEECA = new TextBox();
            label18 = new Label();
            txtFechaRegisEECA = new TextBox();
            txtEspecieEECA = new TextBox();
            txtRazaEECA = new TextBox();
            txtEdadEECA = new TextBox();
            txtNombreEECA = new TextBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            pictureBox3 = new PictureBox();
            btnCerrarEV = new Button();
            pictureBox1 = new PictureBox();
            tbCEncCtrlAnim.SuspendLayout();
            ConsultarECA.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfoECA).BeginInit();
            tbpRegistrarECA.SuspendLayout();
            panel2.SuspendLayout();
            tbpActualizarECA.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tbpEliminarECA.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbCEncCtrlAnim
            // 
            tbCEncCtrlAnim.Controls.Add(ConsultarECA);
            tbCEncCtrlAnim.Controls.Add(tbpRegistrarECA);
            tbCEncCtrlAnim.Controls.Add(tbpActualizarECA);
            tbCEncCtrlAnim.Controls.Add(tbpEliminarECA);
            tbCEncCtrlAnim.Location = new Point(19, 14);
            tbCEncCtrlAnim.Name = "tbCEncCtrlAnim";
            tbCEncCtrlAnim.SelectedIndex = 0;
            tbCEncCtrlAnim.Size = new Size(581, 372);
            tbCEncCtrlAnim.TabIndex = 0;
            // 
            // ConsultarECA
            // 
            ConsultarECA.Controls.Add(panel1);
            ConsultarECA.Location = new Point(4, 26);
            ConsultarECA.Name = "ConsultarECA";
            ConsultarECA.Padding = new Padding(3);
            ConsultarECA.Size = new Size(573, 342);
            ConsultarECA.TabIndex = 0;
            ConsultarECA.Text = "Consultar";
            ConsultarECA.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 234, 232);
            panel1.Controls.Add(btnCargInfoECA);
            panel1.Controls.Add(dgvInfoECA);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 341);
            panel1.TabIndex = 0;
            // 
            // btnCargInfoECA
            // 
            btnCargInfoECA.BackColor = Color.FromArgb(139, 81, 75);
            btnCargInfoECA.FlatStyle = FlatStyle.Flat;
            btnCargInfoECA.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargInfoECA.ForeColor = Color.FromArgb(255, 234, 232);
            btnCargInfoECA.Location = new Point(451, 11);
            btnCargInfoECA.Name = "btnCargInfoECA";
            btnCargInfoECA.Size = new Size(106, 60);
            btnCargInfoECA.TabIndex = 5;
            btnCargInfoECA.Text = "Cargar información";
            btnCargInfoECA.UseVisualStyleBackColor = false;
            // 
            // dgvInfoECA
            // 
            dgvInfoECA.BackgroundColor = Color.FromArgb(253, 193, 186);
            dgvInfoECA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfoECA.Location = new Point(19, 82);
            dgvInfoECA.Name = "dgvInfoECA";
            dgvInfoECA.Size = new Size(538, 248);
            dgvInfoECA.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(139, 81, 75);
            label1.Location = new Point(19, 30);
            label1.Name = "label1";
            label1.Size = new Size(376, 21);
            label1.TabIndex = 3;
            label1.Text = "Consulta aquí la información sobre los animales";
            // 
            // tbpRegistrarECA
            // 
            tbpRegistrarECA.Controls.Add(panel2);
            tbpRegistrarECA.Location = new Point(4, 26);
            tbpRegistrarECA.Name = "tbpRegistrarECA";
            tbpRegistrarECA.Padding = new Padding(3);
            tbpRegistrarECA.Size = new Size(573, 342);
            tbpRegistrarECA.TabIndex = 1;
            tbpRegistrarECA.Text = "Registrar";
            tbpRegistrarECA.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 234, 232);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(txtIdRECA);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtFechaRegisRECA);
            panel2.Controls.Add(txtEspecieRECA);
            panel2.Controls.Add(txtRazaRECA);
            panel2.Controls.Add(txtEdadRECA);
            panel2.Controls.Add(txtNombreRECA);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 340);
            panel2.TabIndex = 0;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(139, 81, 75);
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.FromArgb(255, 234, 232);
            button12.Location = new Point(460, 268);
            button12.Name = "button12";
            button12.Size = new Size(79, 32);
            button12.TabIndex = 33;
            button12.Text = "Guardar";
            button12.UseVisualStyleBackColor = false;
            // 
            // txtIdRECA
            // 
            txtIdRECA.BackColor = Color.FromArgb(253, 193, 186);
            txtIdRECA.Location = new Point(259, 273);
            txtIdRECA.Name = "txtIdRECA";
            txtIdRECA.Size = new Size(152, 25);
            txtIdRECA.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(139, 81, 75);
            label8.Location = new Point(58, 239);
            label8.Name = "label8";
            label8.Size = new Size(116, 17);
            label8.TabIndex = 24;
            label8.Text = "Fecha de registro:";
            // 
            // txtFechaRegisRECA
            // 
            txtFechaRegisRECA.BackColor = Color.FromArgb(253, 193, 186);
            txtFechaRegisRECA.Location = new Point(58, 273);
            txtFechaRegisRECA.Name = "txtFechaRegisRECA";
            txtFechaRegisRECA.Size = new Size(150, 25);
            txtFechaRegisRECA.TabIndex = 23;
            // 
            // txtEspecieRECA
            // 
            txtEspecieRECA.BackColor = Color.FromArgb(253, 193, 186);
            txtEspecieRECA.Location = new Point(259, 181);
            txtEspecieRECA.Name = "txtEspecieRECA";
            txtEspecieRECA.Size = new Size(152, 25);
            txtEspecieRECA.TabIndex = 22;
            // 
            // txtRazaRECA
            // 
            txtRazaRECA.BackColor = Color.FromArgb(253, 193, 186);
            txtRazaRECA.Location = new Point(52, 187);
            txtRazaRECA.Name = "txtRazaRECA";
            txtRazaRECA.Size = new Size(156, 25);
            txtRazaRECA.TabIndex = 21;
            // 
            // txtEdadRECA
            // 
            txtEdadRECA.BackColor = Color.FromArgb(253, 193, 186);
            txtEdadRECA.Location = new Point(259, 93);
            txtEdadRECA.Name = "txtEdadRECA";
            txtEdadRECA.Size = new Size(152, 25);
            txtEdadRECA.TabIndex = 20;
            // 
            // txtNombreRECA
            // 
            txtNombreRECA.BackColor = Color.FromArgb(253, 193, 186);
            txtNombreRECA.Location = new Point(51, 93);
            txtNombreRECA.Name = "txtNombreRECA";
            txtNombreRECA.Size = new Size(157, 25);
            txtNombreRECA.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(139, 81, 75);
            label7.Location = new Point(259, 239);
            label7.Name = "label7";
            label7.Size = new Size(24, 17);
            label7.TabIndex = 18;
            label7.Text = "ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(139, 81, 75);
            label6.Location = new Point(259, 150);
            label6.Name = "label6";
            label6.Size = new Size(55, 17);
            label6.TabIndex = 16;
            label6.Text = "Especie:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(139, 81, 75);
            label5.Location = new Point(56, 155);
            label5.Name = "label5";
            label5.Size = new Size(39, 17);
            label5.TabIndex = 15;
            label5.Text = "Raza:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(139, 81, 75);
            label4.Location = new Point(259, 56);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 14;
            label4.Text = "Edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(139, 81, 75);
            label3.Location = new Point(52, 61);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 13;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(139, 81, 75);
            label2.Location = new Point(176, 15);
            label2.Name = "label2";
            label2.Size = new Size(169, 21);
            label2.TabIndex = 12;
            label2.Text = "Registro de animales";
            // 
            // tbpActualizarECA
            // 
            tbpActualizarECA.Controls.Add(panel4);
            tbpActualizarECA.Controls.Add(panel3);
            tbpActualizarECA.Location = new Point(4, 26);
            tbpActualizarECA.Name = "tbpActualizarECA";
            tbpActualizarECA.Size = new Size(573, 342);
            tbpActualizarECA.TabIndex = 2;
            tbpActualizarECA.Text = "Actualizar";
            tbpActualizarECA.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 234, 232);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(txtBuscarIdAECA);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label17);
            panel4.Location = new Point(426, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(147, 340);
            panel4.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(139, 81, 75);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(255, 234, 232);
            button2.Location = new Point(34, 298);
            button2.Name = "button2";
            button2.Size = new Size(79, 32);
            button2.TabIndex = 34;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtBuscarIdAECA
            // 
            txtBuscarIdAECA.BackColor = Color.FromArgb(253, 193, 186);
            txtBuscarIdAECA.Location = new Point(23, 173);
            txtBuscarIdAECA.Name = "txtBuscarIdAECA";
            txtBuscarIdAECA.Size = new Size(100, 25);
            txtBuscarIdAECA.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(139, 81, 75);
            label16.Location = new Point(23, 142);
            label16.Name = "label16";
            label16.Size = new Size(90, 17);
            label16.TabIndex = 28;
            label16.Text = "ID del animal:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(139, 81, 75);
            label17.Location = new Point(39, 17);
            label17.Name = "label17";
            label17.Size = new Size(60, 21);
            label17.TabIndex = 27;
            label17.Text = "Buscar";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 234, 232);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(txtIdAECA);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtFechaRegisAECA);
            panel3.Controls.Add(txtEspecieAECA);
            panel3.Controls.Add(txtRazaAECA);
            panel3.Controls.Add(txtEdadAECA);
            panel3.Controls.Add(txtNombreAECA);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label15);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(427, 340);
            panel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(139, 81, 75);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(255, 234, 232);
            button1.Location = new Point(156, 298);
            button1.Name = "button1";
            button1.Size = new Size(79, 32);
            button1.TabIndex = 40;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtIdAECA
            // 
            txtIdAECA.BackColor = Color.FromArgb(253, 193, 186);
            txtIdAECA.Location = new Point(211, 239);
            txtIdAECA.Name = "txtIdAECA";
            txtIdAECA.Size = new Size(152, 25);
            txtIdAECA.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(139, 81, 75);
            label9.Location = new Point(15, 205);
            label9.Name = "label9";
            label9.Size = new Size(116, 17);
            label9.TabIndex = 38;
            label9.Text = "Fecha de registro:";
            // 
            // txtFechaRegisAECA
            // 
            txtFechaRegisAECA.BackColor = Color.FromArgb(253, 193, 186);
            txtFechaRegisAECA.Location = new Point(15, 239);
            txtFechaRegisAECA.Name = "txtFechaRegisAECA";
            txtFechaRegisAECA.Size = new Size(156, 25);
            txtFechaRegisAECA.TabIndex = 37;
            // 
            // txtEspecieAECA
            // 
            txtEspecieAECA.BackColor = Color.FromArgb(253, 193, 186);
            txtEspecieAECA.Location = new Point(211, 164);
            txtEspecieAECA.Name = "txtEspecieAECA";
            txtEspecieAECA.Size = new Size(152, 25);
            txtEspecieAECA.TabIndex = 36;
            // 
            // txtRazaAECA
            // 
            txtRazaAECA.BackColor = Color.FromArgb(253, 193, 186);
            txtRazaAECA.Location = new Point(14, 164);
            txtRazaAECA.Name = "txtRazaAECA";
            txtRazaAECA.Size = new Size(156, 25);
            txtRazaAECA.TabIndex = 35;
            // 
            // txtEdadAECA
            // 
            txtEdadAECA.BackColor = Color.FromArgb(253, 193, 186);
            txtEdadAECA.Location = new Point(211, 93);
            txtEdadAECA.Name = "txtEdadAECA";
            txtEdadAECA.Size = new Size(152, 25);
            txtEdadAECA.TabIndex = 34;
            // 
            // txtNombreAECA
            // 
            txtNombreAECA.BackColor = Color.FromArgb(253, 193, 186);
            txtNombreAECA.Location = new Point(14, 93);
            txtNombreAECA.Name = "txtNombreAECA";
            txtNombreAECA.Size = new Size(157, 25);
            txtNombreAECA.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(139, 81, 75);
            label10.Location = new Point(211, 205);
            label10.Name = "label10";
            label10.Size = new Size(24, 17);
            label10.TabIndex = 32;
            label10.Text = "ID:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(139, 81, 75);
            label11.Location = new Point(211, 133);
            label11.Name = "label11";
            label11.Size = new Size(55, 17);
            label11.TabIndex = 30;
            label11.Text = "Especie:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(139, 81, 75);
            label12.Location = new Point(18, 133);
            label12.Name = "label12";
            label12.Size = new Size(39, 17);
            label12.TabIndex = 29;
            label12.Text = "Raza:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(139, 81, 75);
            label13.Location = new Point(211, 56);
            label13.Name = "label13";
            label13.Size = new Size(41, 17);
            label13.TabIndex = 28;
            label13.Text = "Edad:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(139, 81, 75);
            label14.Location = new Point(15, 61);
            label14.Name = "label14";
            label14.Size = new Size(61, 17);
            label14.TabIndex = 27;
            label14.Text = "Nombre:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(139, 81, 75);
            label15.Location = new Point(67, 15);
            label15.Name = "label15";
            label15.Size = new Size(281, 21);
            label15.TabIndex = 26;
            label15.Text = "Actualizar información de animales";
            // 
            // tbpEliminarECA
            // 
            tbpEliminarECA.BackColor = Color.White;
            tbpEliminarECA.Controls.Add(panel6);
            tbpEliminarECA.Controls.Add(panel5);
            tbpEliminarECA.Location = new Point(4, 26);
            tbpEliminarECA.Name = "tbpEliminarECA";
            tbpEliminarECA.Size = new Size(573, 342);
            tbpEliminarECA.TabIndex = 3;
            tbpEliminarECA.Text = "Eliminar";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 234, 232);
            panel6.Controls.Add(button4);
            panel6.Controls.Add(txtBuscIdEECA);
            panel6.Controls.Add(label25);
            panel6.Controls.Add(label26);
            panel6.Location = new Point(424, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(149, 340);
            panel6.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(139, 81, 75);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(255, 234, 232);
            button4.Location = new Point(39, 289);
            button4.Name = "button4";
            button4.Size = new Size(79, 32);
            button4.TabIndex = 55;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = false;
            // 
            // txtBuscIdEECA
            // 
            txtBuscIdEECA.BackColor = Color.FromArgb(253, 193, 186);
            txtBuscIdEECA.Location = new Point(28, 170);
            txtBuscIdEECA.Name = "txtBuscIdEECA";
            txtBuscIdEECA.Size = new Size(100, 25);
            txtBuscIdEECA.TabIndex = 33;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.FromArgb(139, 81, 75);
            label25.Location = new Point(28, 138);
            label25.Name = "label25";
            label25.Size = new Size(90, 17);
            label25.TabIndex = 32;
            label25.Text = "ID del animal:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.FromArgb(139, 81, 75);
            label26.Location = new Point(49, 29);
            label26.Name = "label26";
            label26.Size = new Size(60, 21);
            label26.TabIndex = 31;
            label26.Text = "Buscar";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 234, 232);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(txtIdEECA);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(txtFechaRegisEECA);
            panel5.Controls.Add(txtEspecieEECA);
            panel5.Controls.Add(txtRazaEECA);
            panel5.Controls.Add(txtEdadEECA);
            panel5.Controls.Add(txtNombreEECA);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label20);
            panel5.Controls.Add(label21);
            panel5.Controls.Add(label22);
            panel5.Controls.Add(label23);
            panel5.Controls.Add(label24);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(427, 340);
            panel5.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(139, 81, 75);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(255, 234, 232);
            button3.Location = new Point(181, 289);
            button3.Name = "button3";
            button3.Size = new Size(79, 32);
            button3.TabIndex = 54;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = false;
            // 
            // txtIdEECA
            // 
            txtIdEECA.BackColor = Color.FromArgb(253, 193, 186);
            txtIdEECA.Location = new Point(236, 245);
            txtIdEECA.Name = "txtIdEECA";
            txtIdEECA.Size = new Size(152, 25);
            txtIdEECA.TabIndex = 53;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(139, 81, 75);
            label18.Location = new Point(40, 211);
            label18.Name = "label18";
            label18.Size = new Size(116, 17);
            label18.TabIndex = 52;
            label18.Text = "Fecha de registro:";
            // 
            // txtFechaRegisEECA
            // 
            txtFechaRegisEECA.BackColor = Color.FromArgb(253, 193, 186);
            txtFechaRegisEECA.Location = new Point(40, 245);
            txtFechaRegisEECA.Name = "txtFechaRegisEECA";
            txtFechaRegisEECA.Size = new Size(156, 25);
            txtFechaRegisEECA.TabIndex = 51;
            // 
            // txtEspecieEECA
            // 
            txtEspecieEECA.BackColor = Color.FromArgb(253, 193, 186);
            txtEspecieEECA.Location = new Point(236, 170);
            txtEspecieEECA.Name = "txtEspecieEECA";
            txtEspecieEECA.Size = new Size(152, 25);
            txtEspecieEECA.TabIndex = 50;
            // 
            // txtRazaEECA
            // 
            txtRazaEECA.BackColor = Color.FromArgb(253, 193, 186);
            txtRazaEECA.Location = new Point(39, 170);
            txtRazaEECA.Name = "txtRazaEECA";
            txtRazaEECA.Size = new Size(156, 25);
            txtRazaEECA.TabIndex = 49;
            // 
            // txtEdadEECA
            // 
            txtEdadEECA.BackColor = Color.FromArgb(253, 193, 186);
            txtEdadEECA.Location = new Point(236, 99);
            txtEdadEECA.Name = "txtEdadEECA";
            txtEdadEECA.Size = new Size(152, 25);
            txtEdadEECA.TabIndex = 48;
            // 
            // txtNombreEECA
            // 
            txtNombreEECA.BackColor = Color.FromArgb(253, 193, 186);
            txtNombreEECA.Location = new Point(39, 99);
            txtNombreEECA.Name = "txtNombreEECA";
            txtNombreEECA.Size = new Size(157, 25);
            txtNombreEECA.TabIndex = 47;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(139, 81, 75);
            label19.Location = new Point(236, 211);
            label19.Name = "label19";
            label19.Size = new Size(24, 17);
            label19.TabIndex = 46;
            label19.Text = "ID:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(139, 81, 75);
            label20.Location = new Point(236, 138);
            label20.Name = "label20";
            label20.Size = new Size(55, 17);
            label20.TabIndex = 44;
            label20.Text = "Especie:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(139, 81, 75);
            label21.Location = new Point(43, 138);
            label21.Name = "label21";
            label21.Size = new Size(39, 17);
            label21.TabIndex = 43;
            label21.Text = "Raza:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.FromArgb(139, 81, 75);
            label22.Location = new Point(236, 61);
            label22.Name = "label22";
            label22.Size = new Size(41, 17);
            label22.TabIndex = 42;
            label22.Text = "Edad:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.FromArgb(139, 81, 75);
            label23.Location = new Point(40, 67);
            label23.Name = "label23";
            label23.Size = new Size(61, 17);
            label23.TabIndex = 41;
            label23.Text = "Nombre:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.FromArgb(139, 81, 75);
            label24.Location = new Point(64, 29);
            label24.Name = "label24";
            label24.Size = new Size(268, 21);
            label24.TabIndex = 40;
            label24.Text = "Eliminar información de animales";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = Properties.Resources.LogoMILAV_Final;
            pictureBox3.Location = new Point(616, 287);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(95, 95);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // btnCerrarEV
            // 
            btnCerrarEV.BackColor = Color.FromArgb(139, 81, 75);
            btnCerrarEV.FlatStyle = FlatStyle.Flat;
            btnCerrarEV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarEV.ForeColor = Color.FromArgb(255, 234, 232);
            btnCerrarEV.Location = new Point(616, 40);
            btnCerrarEV.Name = "btnCerrarEV";
            btnCerrarEV.Size = new Size(87, 50);
            btnCerrarEV.TabIndex = 14;
            btnCerrarEV.Text = "Cerrar Sesión";
            btnCerrarEV.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.LogoMILAV_Final;
            pictureBox1.Location = new Point(616, 174);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // EncargadoControlAnimales
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 193, 186);
            ClientSize = new Size(723, 399);
            Controls.Add(pictureBox1);
            Controls.Add(btnCerrarEV);
            Controls.Add(pictureBox3);
            Controls.Add(tbCEncCtrlAnim);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "EncargadoControlAnimales";
            Text = "frmEncargadoCtrlAnimales";
            tbCEncCtrlAnim.ResumeLayout(false);
            ConsultarECA.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfoECA).EndInit();
            tbpRegistrarECA.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tbpActualizarECA.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tbpEliminarECA.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbCEncCtrlAnim;
        private TabPage ConsultarECA;
        private TabPage tbpRegistrarECA;
        private TabPage tbpActualizarECA;
        private TabPage tbpEliminarECA;
        private Panel panel1;
        private Button btnCargInfoECA;
        private DataGridView dgvInfoECA;
        private Label label1;
        private Panel panel2;
        private TextBox txtFechaRegisRECA;
        private TextBox txtEspecieRECA;
        private TextBox txtRazaRECA;
        private TextBox txtEdadRECA;
        private TextBox txtNombreRECA;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtIdRECA;
        private Label label8;
        private Panel panel4;
        private Panel panel3;
        private TextBox txtIdAECA;
        private Label label9;
        private TextBox txtFechaRegisAECA;
        private TextBox txtEspecieAECA;
        private TextBox txtRazaAECA;
        private TextBox txtEdadAECA;
        private TextBox txtNombreAECA;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtBuscarIdAECA;
        private Label label16;
        private Label label17;
        private Panel panel6;
        private Panel panel5;
        private TextBox txtIdEECA;
        private Label label18;
        private TextBox txtFechaRegisEECA;
        private TextBox txtEspecieEECA;
        private TextBox txtRazaEECA;
        private TextBox txtEdadEECA;
        private TextBox txtNombreEECA;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private TextBox txtBuscIdEECA;
        private Label label25;
        private Label label26;
        private PictureBox pictureBox3;
        private Button btnCerrarEV;
        private PictureBox pictureBox1;
        private Button button12;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button3;
    }
}