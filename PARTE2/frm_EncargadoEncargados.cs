using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patitasOrgMILAV
{
    //SQLHENV hEnv;
    //SQLHDBC hDbc;
    //SQLHSTMT hStmt;
    //SQLRETURN ret;
    public partial class frm_EncargadoEncargados : Form
    {
        public frm_EncargadoEncargados()
        {
            InitializeComponent();
        }

        accesoBD objBD = new accesoBD();

        private void btnBuscarAE_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsUsr = objBD.ConsultarEnacargadoUno(txtIDEmpAE.Text);
                if (dsUsr.Tables[0].Rows.Count < 1)
                {
                    MessageBox.Show("No existe el usuario");
                }
                else
                {
                    DataRow fila = dsUsr.Tables[0].Rows[0];
                    txtIDAE.Text = fila["idEncargado"].ToString();
                    txtNombreAE.Text = fila["nombre"].ToString();
                    txtApellido1AE.Text = fila["apePa"].ToString();
                    txtApellido2AE.Text = fila["apeMa"].ToString();
                    txtContactoAE.Text = fila["contacto"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la ocnexion: " + ex.Message);
            }
        }

        private void btnGuardarAE_Click(object sender, EventArgs e)
        {
            try
            {
                string idEnc = txtIDAE.Text;
                string nombre = txtNombreAE.Text;
                string ape1 = txtApellido1AE.Text;
                string ape2 = txtApellido2AE.Text;
                string contacto = txtContactoAE.Text;

                if (objBD.ActualizarEncargado(idEnc, nombre, ape1, ape2, contacto))
                {
                    MessageBox.Show("Chin");
                }
                else
                {
                    MessageBox.Show("Datos actualizados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarEE_Click(object sender, EventArgs e) //escribiendo...
        {
            try
            {
                string usr = txtIDEmpEE.Text.ToString();
                if (objBD.EliminarEncargado(usr))
                {
                    MessageBox.Show("Usuario Eliminado");
                    limpiarTabEliminar();
                }
                else
                {
                    MessageBox.Show("¡Sorry!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la operacón " + ex.Message);
            }
        }

        private void limpiarTabEliminar()
        {
            try
            {
                txtNombreEE.Clear();
                txtApellido1EE.Clear();
                txtApellido2EE.Clear();
                txtContactoEE.Clear();
                txtIDEE.Clear();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnRE_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = objBD.AgregarEncargado(txtIDRE.Text, txtNombreRE.Text, txtApellido1RE.Text, txtApellido2RE.Text, txtContactoRE.Text);
                if (res)
                {
                    MessageBox.Show("Encargado no agregado.");
                }
                else
                {
                    MessageBox.Show("Encargado agregado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la operacion: " + ex.Message);
            }
        }

        private void btnCargInfoEE_Click(object sender, EventArgs e)
        {
            try
            {
                dgvInfoEE.DataSource = objBD.ConsultarEnacargados();
                dgvInfoEE.DataMember = "tbEncargados";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarEE_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsUsr = objBD.ConsultarEnacargadoUno(txtIDEmpEE.Text);
                if (dsUsr.Tables[0].Rows.Count < 1)
                {
                    MessageBox.Show("No existe el encargado");
                }
                else
                {
                    DataRow fila = dsUsr.Tables[0].Rows[0];
                    txtNombreEE.Text = fila["nombre"].ToString();
                    txtApellido1EE.Text = fila["apePa"].ToString();
                    txtApellido2EE.Text = fila["apeMa"].ToString();
                    txtContactoEE.Text = fila["contacto"].ToString();
                    txtIDEE.Text = fila["idEncargado"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la operacón " + ex.Message);
            }

        }

        private void btnCerrarEE_Click(object sender, EventArgs e)
        {
            paginaInicial miForm = new paginaInicial();
            miForm.ShowDialog();
            this.Close();
        }
    }
}
