using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace calculsmoyennes
{
    class Classe
    {
        public string nomClasse { get; private set; }

        public List<Eleve> eleves;
        public List<string> matieres;

        public Classe(string leNomClasse) 
        {
            nomClasse = leNomClasse;
        }

        public void AjouterEleve(string prenom, string nom)
        {
            Eleve eleveClasse = new Eleve(prenom, nom);
            eleves.Add(eleveClasse);
        }

        public void AjouterMatiere(string matiere)
        {
            matieres.Add(matiere);
        }

        public double Moyenne(int matiere)
        {
            double moyennematiereclasse = 0;
            for (int i = 0; i < eleves.Count; i++)
            {
                double moyennematiereeleve = eleves[i].Moyenne(matiere);
                moyennematiereclasse += moyennematiereeleve;
            }
            moyennematiereclasse = Math.Truncate((moyennematiereclasse / eleves.Count) * 100) * 0.01;
            return moyennematiereclasse;
        }

        public double Moyenne()
        {
            double moyennegeneraleclasse = 0;
            for (int j = 0; j < matieres.Count; j++)
            {
                double moyennematieregenerale = Moyenne(j);
                moyennegeneraleclasse += moyennematieregenerale;
            }
            moyennegeneraleclasse = Math.Truncate((moyennegeneraleclasse / matieres.Count) * 100) * 0.01;
            return moyennegeneraleclasse;
        }

    }
}
