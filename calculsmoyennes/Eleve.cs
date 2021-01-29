using System;
using System.Collections.Generic;
using System.Text;

namespace calculsmoyennes
{
    class Eleve
    {
        public string nom { get; private set; }
        public string prenom { get; private set; }

        public Eleve(string nomEleve, string prenomEleve) 
        {
            nom = nomEleve;
            prenom = prenomEleve;
        }

        public List<Note> notes;

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
            moyennematiere = Math.Truncate((moyennematiere / notes.Count) * 100) * 0.01;
            return moyennematiere;
        }

        public double Moyenne()
        {
            double moyennegenerale = 0;
            for (int i = 0; i < 10 ; i++)
            {
                double moyennechaquematiere = Moyenne(i);
                moyennegenerale += moyennechaquematiere;

            }
            moyennegenerale = Math.Truncate((moyennegenerale / 5) * 100) * 0.01;
            return moyennegenerale;
        }
    }
}
