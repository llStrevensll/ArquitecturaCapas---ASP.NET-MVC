using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS {
    public class DepartamentoDALC {

        public List<Departamento> ListarDepartamentos() {//Lista de Departamentos
            
            using (var db = new ProyectosContext()) {//Acceder a la BD
                return db.Departamento.ToList();
            }
        }
    }
}
