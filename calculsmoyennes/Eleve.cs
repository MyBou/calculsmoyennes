using System;
using System.Collections.Generic;
using System.Text;

namespace calculsmoyennes
{
    class Eleve
    {
        public string nom { get; private set; }
        public string prenom { get; private set; }
        public List<Note> notes { get; private set; }

        public Eleve(string nomEleve, string prenomEleve) 
        {
            nom = nomEleve;
            prenom = prenomEleve;
            notes = new List<Note>();
        }

        public void AjouterNote(Note note)
        {
            notes.Add(note);
        }

        public double Moyenne(int matiere)
        {
            double moyennematiere = 0;
            for (int counter = 0; counter < notes.Count; counter++) 
            {
                if (notes[counter].matiere == matiere)
                {
                    moyennematiere += notes[counter].note;
                }
            }
            moyennematiere = Math.Truncate((moyennematiere / 5) * 100) / 100;
            return moyennematiere;
        }

        public double Moyenne()
        {
            double moyennegenerale = 0;

            int nbmatieres = 0;
            double moyennechaquematiere = Moyenne(nbmatieres);
            do
            {
                moyennechaquematiere = Moyenne(nbmatieres);
                moyennegenerale += moyennechaquematiere;
                nbmatieres += 1;
            } while (moyennechaquematiere != 0);
            
             moyennegenerale = Math.Truncate((moyennegenerale / (nbmatieres-1)) * 100) / 100;
            return moyennegenerale;
        }
    }
}
