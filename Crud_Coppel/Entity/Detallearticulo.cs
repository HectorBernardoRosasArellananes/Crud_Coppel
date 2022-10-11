using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Coppel.Entity
{
    public class Detallearticulo
    {
        public string nombre { set; get; }
        public int sku { set; get; }
        public string cantidad { set; get; }
    }

    public class InventarioDetalle
    {
        public Detallearticulo Detallearticulo { set; get; }
    }

    public class InventarioDetalleList
    {

        public List<Detallearticulo> Detallearticulo { set; get; }
    }

}
