using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            int mat = 0;

            Voiture voiture = new Voiture
            {
                Matricule = mat++,
                AnneeModele = "2018",
                Prix = 6000
            };

            Console.WriteLine("Matricule: {0}, Année: {1}, Prix: {2}", voiture.Matricule, voiture.AnneeModele, voiture.Prix);
            Console.WriteLine("{0} et {1} !!", voiture.Demarrer(), voiture.Accelerer());

            Camion camion = new Camion
            {
                Matricule = mat++,
                AnneeModele = "2016",
                Prix = 12000
            };

            Console.WriteLine("Matricule: {0}, Année: {1}, Prix: {2}", camion.Matricule, camion.AnneeModele, camion.Prix);
            Console.WriteLine("{0} et {1} !!", camion.Demarrer(), camion.Accelerer());

            Console.ReadLine();
        }
    }
}
