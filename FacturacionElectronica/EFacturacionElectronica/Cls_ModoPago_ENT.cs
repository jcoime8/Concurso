using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_FacturacionElectronica
{
    public class Cls_ModoPago_ENT
    {
        private int mpo_codigo;
	    private string mpo_nombre;
	    private string mpo_detalle;

        public int Mpo_codigo { get => mpo_codigo; set => mpo_codigo = value; }
        public string Mpo_nombre { get => mpo_nombre; set => mpo_nombre = value; }
        public string Mpo_detalle { get => mpo_detalle; set => mpo_detalle = value; }
    }
}
