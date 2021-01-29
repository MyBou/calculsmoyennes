using System;
using System.Collections.Generic;
using System.Text;

namespace calculsmoyennes
{
    class Classe
    {
        public string nomClasse { get; private set; }

        public List<Eleve> eleves { get; private set; }
        public List<string> matieres { get; private set; }

        public Classe(string leNomClasse) 
        {
            nomClasse = leNomClasse;
            eleves = new List<Eleve>();
            matieres = new List<string>();
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
            moyennematiereclasse = Math.Truncate((moyennematiereclasse / eleves.Count) * 100) / 100;
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
            moyennegeneraleclasse = Math.Truncate((moyennegeneraleclasse / matieres.Count) * 100) / 100;
            return moyennegeneraleclasse;
        }

    }
}
