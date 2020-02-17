using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO {
    public class DepartamentoCN {
        //Instanciar objeto de la capa de datos
        private static DepartamentoDALC departamentoDALC = new DepartamentoDALC();
        public static List<Departamento> ListarDepartamentos() {

            return departamentoDALC.ListarDepartamentos();;//Metodo
        }
    }
}
