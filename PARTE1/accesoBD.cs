using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
//using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

namespace patitasOrgMILAV
{
    internal class accesoBD
    {

        public accesoBD() { }

        static string conexion = @"Data Source=localhost;Initial Catalog=BDAnimalitosMILAV;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        SqlConnection cadena = new SqlConnection(conexion);

        //comando
        SqlCommand comando = new SqlCommand();

        //lector
        SqlDataReader lector;

        //sentencia para sql
        string sentencia = "";

        #region UsuarioEncargados

        public bool AutenticarUsuarios(string _usuario, string _pass)
        {
            try
            {
                bool bandera = false;
                sentencia = "SELECT nombre, contacto FROM tbEncargado WHERE nombre = @usr AND contacto = @pass";
                comando = new SqlCommand(sentencia, cadena);
                comando.Parameters.AddWithValue("@usr", _usuario);
                comando.Parameters.AddWithValue("@pass", _pass);

                cadena.Open();

                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }

                return bandera;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cadena.Close();
            }
        }

        public DataSet ConsultarEnacargados()
        {
            try
            {
                sentencia = "select * from tbEncargado";

                SqlDataAdapter adaptador = new SqlDataAdapter(sentencia, cadena);
                DataSet datos = new DataSet();

                adaptador.Fill(datos, "tbEncargados");
                return datos;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cadena.Close();
            }
        }

        public DataSet ConsultarEnacargadoUno(string _id)
        {
            try
            {
                sentencia = "select * from tbEncargado where idEncargado = '" + _id + "';";

                SqlDataAdapter adaptador = new SqlDataAdapter(sentencia, cadena);
                DataSet datos = new DataSet();

                adaptador.Fill(datos, "tbEncargado");
                return datos;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cadena.Close();
            }
        }

        public DataSet Consultarid(string _pass)
        {
            try
            {
                sentencia = "select * from tbEncargado where contacto = '" + _pass + "';";

                SqlDataAdapter adaptador = new SqlDataAdapter(sentencia, cadena);
                DataSet datos = new DataSet();

                adaptador.Fill(datos, "tbEncargado");
                return datos;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cadena.Close();
            }
        }

        public bool AgregarEncargado(string _id, string _nombre, string _apellido1, string _apellido2, string _contacto)
        {
            try
            {
                bool bandera = false;
                sentencia = "insert into tbEncargado(idEncargado, nombre, apePa, apeMa, contacto) values (@idEncargado, @nombre, @apePa, @apeMa, @contacto)";
                comando = new SqlCommand(sentencia, cadena);
                comando.Parameters.AddWithValue("@idEncargado", _id);
                comando.Parameters.AddWithValue("@nombre", _nombre);
                comando.Parameters.AddWithValue("@apePa", _apellido1);
                comando.Parameters.AddWithValue("@apeMa", _apellido2);
                comando.Parameters.AddWithValue("@contacto", _contacto);

                cadena.Open();

                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }
                return bandera;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cadena.Close();
            }
        }

        public bool ActualizarEncargado(string _id, string _nombre, string _apellido1, string _apellido2, string _contacto)
        {
            try
            {
                bool bandera = false;
                sentencia = "update tbEncargado set nombre = @nombre, apePa = @apePa, apeMa = @apeMa, contacto = @contacto where idEncargado = @idEncargado;";
                comando = new SqlCommand(sentencia, cadena);
                comando.Parameters.AddWithValue("@idEncargado", _id);
                comando.Parameters.AddWithValue("@nombre", _nombre);
                comando.Parameters.AddWithValue("@apePa", _apellido1);
                comando.Parameters.AddWithValue("@apeMa", _apellido2);
                comando.Parameters.AddWithValue("@contacto", _contacto);

                cadena.Open();

                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }
                return bandera;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cadena.Close();
            }
        }

        public bool EliminarEncargado(string _id)
        {
            try
            {
                bool bandera = false;
                sentencia = "delete from tbEncargado where idEncargado = @id ";
                comando = new SqlCommand(sentencia, cadena);

                comando.Parameters.AddWithValue("@id", _id);

                cadena.Open();
                if (comando.ExecuteNonQuery() > 0)
                {
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }
                return bandera;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                cadena.Close();
            }
        }
        #endregion

        #region EncCampañas
        public DataSet ConsultarCampañas()
        {
            try
            {
                sentencia = "select * from tbCampana";

                SqlDataAdapter adaptador = new SqlDataAdapter(sentencia, cadena);
                DataSet datos = new DataSet();

                adaptador.Fill(datos, "tbCampana");
                return datos;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cadena.Close();
            }
        }

        public DataSet ConsultarUnaCampaña(string _nombreC)
        {
            try
            {
                sentencia = "select * from tbCampana where nombre = '" + _nombreC + "';";

                SqlDataAdapter adaptador = new SqlDataAdapter(sentencia, cadena);
                DataSet datos = new DataSet();

                adaptador.Fill(datos, "tbCampana");
                return datos;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cadena.Close();
            }
        }

        public bool AgregarCampana(string _nombre, string _fecha, string _horario, string _descripcion)
        {
            try
            {
                bool bandera = false;
                sentencia = "insert into tbCampana(nombre, descripcion, horario, fecha) values (@nombre, @descripcion, @horario, @fecha)";
                comando = new SqlCommand(sentencia, cadena);
                comando.Parameters.AddWithValue("@nombre", _nombre);
                comando.Parameters.AddWithValue("@descripcion", _descripcion);
                comando.Parameters.AddWithValue("@horario", _horario);
                comando.Parameters.AddWithValue("@fecha", _fecha);

                cadena.Open();

                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }
                return bandera;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cadena.Close();
            }
        }

        public bool ActualizarCampana(string _nombre, string _fecha, string _horario, string _descripcion)
        {
            try
            {
                bool bandera = false;
                sentencia = "update tbCampana set nombre = @nombre, descripcion = @descripcion, horario = @horario, fecha = @fecha where nombre = @nombre;";
                comando = new SqlCommand(sentencia, cadena);
                comando.Parameters.AddWithValue("@nombre", _nombre);
                comando.Parameters.AddWithValue("@descripcion", _descripcion);
                comando.Parameters.AddWithValue("@horario", _horario);
                comando.Parameters.AddWithValue("@fecha", _fecha);

                cadena.Open();

                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }
                return bandera;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cadena.Close();
            }
        }

        public bool EliminarCampana(string _nombre)
        {
            try
            {
                bool bandera = false;
                sentencia = "delete from tbCampana where nombre = @nombre ";
                comando = new SqlCommand(sentencia, cadena);

                comando.Parameters.AddWithValue("@nombre", _nombre);

                cadena.Open();
                if (comando.ExecuteNonQuery() > 0)
                {
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }
                return bandera;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                cadena.Close();
            }
        }
        #endregion

        #region EncControlAnimales
        public DataSet ConsultarAnimales()
        {
            try
            {
                sentencia = "select * from tbAnimal";

                SqlDataAdapter adaptador = new SqlDataAdapter(sentencia, cadena);
                DataSet datos = new DataSet();

                adaptador.Fill(datos, "tbAnimal");
                return datos;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cadena.Close();
            }
        }

        public DataSet ConsultarUnAnimal(string _idAni)
        {
            try
            {
                sentencia = "select * from tbAnimal where idAnimal = '" + _idAni + "';";

                SqlDataAdapter adaptador = new SqlDataAdapter(sentencia, cadena);
                DataSet datos = new DataSet();

                adaptador.Fill(datos, "tbAnimal");
                return datos;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cadena.Close();
            }
        }

        public bool AgregarAnimal(string _idAni, string _nombre, string _edad, string _raza, string _especie, string _fecha_regis)
        {
            try
            {
                bool bandera = false;
                sentencia = "insert into tbAnimal(idAnimal, nombre, edad, raza, especie, fecha_registro) values (@idAnimal, @nombre, @edad, @raza, @especie, @fecha)";
                comando = new SqlCommand(sentencia, cadena);
                comando.Parameters.AddWithValue("@idAnimal", _idAni);
                comando.Parameters.AddWithValue("@nombre", _nombre);
                comando.Parameters.AddWithValue("@edad", _edad);
                comando.Parameters.AddWithValue("@raza", _raza);
                comando.Parameters.AddWithValue("@especie", _especie);
                comando.Parameters.AddWithValue("@fecha", _fecha_regis);

                cadena.Open();

                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }
                return bandera;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cadena.Close();
            }
        }

        public bool ActualizarAnimal(string _idAni, string _nombre, string _edad, string _raza, string _especie, string _fecharegis)
        {
            try
            {
                bool bandera = false;
                sentencia = "update tbAnimal set idAnimal = @idAnimal, nombre = @nombre, edad = @edad, raza = @raza, especie = @especie, fecha_registro = @fecha where idAnimal = @idAnimal;";
                comando = new SqlCommand(sentencia, cadena);
                comando.Parameters.AddWithValue("@idAnimal", _idAni);
                comando.Parameters.AddWithValue("@nombre", _nombre);
                comando.Parameters.AddWithValue("@edad", _edad);
                comando.Parameters.AddWithValue("@raza", _raza);
                comando.Parameters.AddWithValue("@especie", _especie);
                comando.Parameters.AddWithValue("@fecha", _fecharegis);

                cadena.Open();

                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }
                return bandera;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cadena.Close();
            }
        }

        public bool EliminarAnimal(string _idAni)
        {
            try
            {
                bool bandera = false;
                sentencia = "delete from tbAnimal where idAnimal = @idAn ";
                comando = new SqlCommand(sentencia, cadena);

                comando.Parameters.AddWithValue("@idAn", _idAni);

                cadena.Open();
                if (comando.ExecuteNonQuery() > 0)
                {
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }
                return bandera;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                cadena.Close();
            }
        }
        #endregion
    }
}


