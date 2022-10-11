using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Coppel.Entity
{
    public class Empleado
    {
        public int idEmpleado { set; get; }
        public String nombre { set; get; }
        public String apellido { set; get; }
        public String puesto { set; get; }
    }
    public class EmpleadoDetalle
    {
        public Empleado Empleado { set; get; }
    }

    public class EmpleadoDetalleList
    {
        
        public List<Empleado> Empleado { set; get; }
    }


}
