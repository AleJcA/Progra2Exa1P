using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Yu_Gi_Oh__Exam_.Modelos
{
    public class Carta
    {
        public string NombreC { get; set; }

        public virtual string toString()
        {


            return $"Nombre: {NombreC}";

        }
    }

    

}
