using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class DPersonal
    {
        CD_Conexion Conect = new CD_Conexion();

        public bool insertarPersonal(string ced, string NomA, string direc, int Edad, int cel, string correo, string nacionalidad)
        {
            try
            {
                Conect.Abrir();
                SqlCommand AggUser = new SqlCommand("AgregarPersonal", CD_Conexion.conectar);
                AggUser.CommandType = CommandType.StoredProcedure;
                AggUser.Parameters.AddWithValue("@Cedula", ced);
                AggUser.Parameters.AddWithValue("@NomAp", NomA);
                AggUser.Parameters.AddWithValue("@Direccion", direc);
                AggUser.Parameters.AddWithValue("@Edad", Edad);
                AggUser.Parameters.AddWithValue("@cel", cel);
                AggUser.Parameters.AddWithValue("@Correo", correo);
                AggUser.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                AggUser.ExecuteNonQuery();
                MessageBox.Show("Se realizo el regitro con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conect.cerrar();

            }
        }
        public void MostarPersonal(ref DataTable dt)
        {
            try
            {
                Conect.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("ListarPersonal", CD_Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally { Conect.cerrar(); }
        }
        public bool editarPersonal(int Idpersonal, string ced, string NomA, string direc, int Edad, int cel, string correo, string nacionalidad)
        {
            try
            {
                Conect.Abrir();
                SqlCommand cmd = new SqlCommand("EditarPersonal", CD_Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpersonal", Idpersonal);
                cmd.Parameters.AddWithValue("@Cedula", ced);
                cmd.Parameters.AddWithValue("@NomAp", NomA);
                cmd.Parameters.AddWithValue("@Direccion", direc);
                cmd.Parameters.AddWithValue("@Edad", Edad);
                cmd.Parameters.AddWithValue("@cel", cel);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se actualizo el regitro con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conect.cerrar();
            }
        }
        public void EliminarPersonal(int id)
        {
            try
            {
                Conect.Abrir();
                SqlCommand cmd = new SqlCommand("EliminarPersonal", CD_Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpersonal", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);

            }
            finally
            {
                Conect.cerrar();
            }
        }
        public void BuscarPersonal(ref DataTable dt, string buscador)
        {
            try
            {
                Conect.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarPersonal", CD_Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally { Conect.cerrar(); }
        }
    }
}
