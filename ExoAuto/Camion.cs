using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoAuto
{
    public class Camion : Vehicule
    {
        public override string Demarrer()
        {
            return "Je démarre";
        }

        public override string Accelerer()
        {
            return "J'accélère";
        }
    }
}
