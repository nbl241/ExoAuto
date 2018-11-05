using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoAuto
{
    public abstract class Vehicule
    {
        private int matricule;
        private string anneeModele;
        private Double prix;

        public int Matricule { get => matricule; set => matricule = value; }

        public string AnneeModele { get => anneeModele; set => anneeModele = value; }

        public double Prix { get => prix; set => prix = value; }

        public override string ToString()
        {
            return "Matricule = " + Matricule + ", Année = " + AnneeModele + ", Prix = " + Prix;
        }

        public abstract string Demarrer();

        public abstract string Accelerer();
    }
}
