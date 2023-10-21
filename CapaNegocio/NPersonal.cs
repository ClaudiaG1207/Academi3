using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class NPersonal
    {
       DPersonal perso = new DPersonal();

        public void AgregarPersonal(string Ced, string NomAp, string Direc, int edad, int Cel, string Correo, string Nacionalidad)
        {
           perso.insertarPersonal(Ced, NomAp, Direc, edad, Cel, Correo, Nacionalidad);
        }
        public void EliminarPersonal(int id)
        {
            perso.EliminarPersonal(id);
        }
        public void editarPersonal(int id, string Ced, string NomAp, string Direc, int edad, int Cel, string Correo, string Nacionalidad)
        {
            perso.editarPersonal(id, Ced, NomAp, Direc, edad, Cel, Correo, Nacionalidad);
        }
        public void MostarPersonal(DataTable dt)
        {
            perso.MostarPersonal(ref dt);
        }
        public void BuscarEstudiante(DataTable dt, string buscador)
        {
            perso.BuscarPersonal(ref dt, buscador);
        }
    }
}
