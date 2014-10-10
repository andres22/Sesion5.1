using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcular
{
    class numero
    {
        //Atributos
        int numeroMayor;
        int numeroMenor;

        //Constructor con parametros
        public numero(int numeroMenor, int numeroMayor)
        {
            this.numeroMenor = numeroMenor;
            this.numeroMayor = numeroMayor;
        }
        //Metodos get y set

        public int NumeroMenor
        {
            get { return numeroMenor; }
            set { numeroMenor = value; }
        }
        public int NumeroMayor
        {
            get { return NumeroMayor; }
            set { NumeroMayor = value; }
        }
        //Metodo transaccional = operaciones

        public List<int> MostrarRango()
        {
            List<int> rango = new List<int>();
            for (int contador = numeroMenor; contador <= numeroMayor; contador++)
            {
                rango.Add(contador);
            }
            return rango;
        }
    }
}
