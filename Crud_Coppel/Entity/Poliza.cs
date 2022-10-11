using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Coppel.Entity
{
    public class Poliza
    {
        public int idPolizas { set; get; }
        public int sku { set; get; }
        public string fecha { set; get; }
        public string cantidad { set; get; }
        public int empleadoGenero { set; get; }
    }

    public class PolizaItem
    {
        public Poliza Poliza { set; get; }
    }

    public class PolizaList
    {
        public List<Poliza> Poliza { set; get; }
    }
}
