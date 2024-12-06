using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace patitasOrgMILAV
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        accesoBD objBD = new accesoBD();

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string idUsr = "1";
                bool res = objBD.AutenticarUsuarios(textBox1.Text, textBox2.Text);
                if (res)
                {
                    //verificacion
                    try
                    {
                        DataSet dsUsr = objBD.Consultarid(textBox2.Text);
                        if (dsUsr.Tables[0].Rows.Count < 1)
                        {
                            MessageBox.Show("Error");
                        }
                        else
                        {
                            DataRow fila = dsUsr.Tables[0].Rows[0];
                            idUsr = fila["idEncargado"].ToString();
                            if (idUsr == "1" || idUsr == "2" || idUsr == "3" || idUsr == "4" || idUsr == "5")
                            {
                                //mostrar interfaz
                                frm_EncargadoEncargados miForm = new frm_EncargadoEncargados();
                                miForm.ShowDialog();
                                this.Hide();
                                this.Close();
                            }
                            else
                            {
                                if (idUsr == "6" || idUsr == "7" || idUsr == "8" || idUsr == "9" || idUsr == "10")
                                {
                                    //mostrar interfaz
                                    EncargadoReportes miForm = new EncargadoReportes();
                                    miForm.ShowDialog();
                                    this.Hide();
                                    this.Close();
                                }
                                else
                                {
                                    if (idUsr == "11" || idUsr == "12" || idUsr == "13" || idUsr == "14" || idUsr == "15")
                                    {
                                        //mostrar interfaz
                                        frmEncargadoCampañas miForm = new frmEncargadoCampañas();
                                        miForm.ShowDialog();
                                        this.Hide();
                                        this.Close();
                                    }
                                    else
                                    {
                                        if (idUsr == "16" || idUsr == "17" || idUsr == "18" || idUsr == "19" || idUsr == "20")
                                        {
                                            //mostrar interfaz
                                            EncargadoControlAnimales miForm = new EncargadoControlAnimales();
                                            miForm.ShowDialog();
                                            this.Hide();
                                            this.Close();
                                        }
                                        else
                                        {
                                            if (idUsr == "21" || idUsr == "22" || idUsr == "23" || idUsr == "24" || idUsr == "25")
                                            {
                                                //mostrar interfaz
                                                frmEncargadoVeterinaria miForm = new frmEncargadoVeterinaria();
                                                miForm.ShowDialog();
                                                this.Hide();
                                                this.Close();
                                            }
                                            else
                                            {
                                                if (idUsr == "26" || idUsr == "27" || idUsr == "28" || idUsr == "29" || idUsr == "30")
                                                {
                                                    //mostrar interfaz
                                                    frmEncargadoVoluntarios miForm = new frmEncargadoVoluntarios();
                                                    miForm.ShowDialog();
                                                    this.Hide();
                                                    this.Close();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fallo la conexion: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Verificar usuario y contraseña", "Mensaje del sistema", MessageBoxButtons.OK);
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }


    }

