using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Yu_Gi_Oh__Exam_.Modelos
{
    public class CMagica : Carta, ICartGlobal, IMagiAndTramp
    {
        public void Invocar()
        {
            Console.WriteLine("Se invoca en el tablero boca abajo");
        }
        public void DarVuelta()
        {
            Console.WriteLine("La carta se da vuelta");
            
        }
        public void AplicarEfecto()
        {
            Console.WriteLine("Se aplica efecto de la carta");
        }
        public string Efecto { get; set; }
        public string Categoria { get; set; }

        public override string toString()
        {
            return $"{base.toString()}  \nCategoria: {Categoria}  \nEfecto: {Efecto}";
        }

    }
}
