using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu_Gi_Oh__Exam_.Modelos
{
    public class CMonstruo : Carta, ICartGlobal, IMonstruo
    {
        public void Invocar()
        {
            Console.WriteLine("Se Invoca en el tablero");
        }
        public void Atacar()
        {
            Console.WriteLine("El Moustruo Ataca");
        }
        public void fusion()
        {
            Console.WriteLine("Las dos Cartas se fusionan");
        }
        public void Ritual()
        {
            Console.WriteLine("2 cartas se van al cementerio y se Invoca otra");
        }
        public string Descrip { get; set; }
        public string Atributo { get; set; }
        public int Nivel { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }

        public override string toString()
        {

            return $"{base.toString()} - Descripcion: {Descrip} - Atributo: {Atributo} - Nivel: {Nivel} - Ataque: {Atk} - Defensa {Def}";
        }

    }
}
