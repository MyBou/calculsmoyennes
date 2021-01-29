﻿using System;
using System.Collections.Generic;
using System.Text;

namespace calculsmoyennes
{
    class Ecole
    {
        public Ecole()
        {
            // Création d'une classe
            Classe sixiemeA = new Classe("6eme A");
            // Ajout des élèves à la classe
            sixiemeA.AjouterEleve("Jean","RAGE");
            sixiemeA.AjouterEleve("Paul","HAAR");
            sixiemeA.AjouterEleve("Sibylle","BOQUET");
            sixiemeA.AjouterEleve("Annie","CROCHE");
            sixiemeA.AjouterEleve("Alain","PROVISTE");
            sixiemeA.AjouterEleve("Justin","TYDERNIER");
            sixiemeA.AjouterEleve("Sacha","TOUILLE");
            sixiemeA.AjouterEleve("Cesar", "TICHO");
            sixiemeA.AjouterEleve("Guy", "DON");

            //Ajout de matières étudiées par la classe
            sixiemeA.AjouterMatiere("Francais"); 
            sixiemeA.AjouterMatiere("Anglais"); 
            sixiemeA.AjouterMatiere("Physique/Chimie"); 
            sixiemeA.AjouterMatiere("Histoire"); 
            Random random = new Random();

            // Ajout de 5 notes à chaque élève et dans chaque matière
            for (int ieleve = 0; ieleve < sixiemeA.eleves.Count; ieleve++)
            {
                for (int matiere = 0; matiere < sixiemeA.matieres.Count; matiere++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        sixiemeA.eleves[ieleve].AjouterNote(new Note(matiere, (float)((6.5 + random.NextDouble() * 34)) / 2.0f));
                        // Note minimale = 3
                    }
                }
            }

            Eleve eleve = sixiemeA.eleves[6];
            
            // Afficher la moyenne d'un élève dans une matière
            Console.Write(eleve.prenom + " " + eleve.nom + ", Moyenne en " + sixiemeA.matieres[1] + " : " + eleve.Moyenne(1)+"\n");
            // Afficher la moyenne générale du même élève
            Console.Write(eleve.prenom + " " + eleve.nom + ", Moyenne Generale : " + eleve.Moyenne() + "\n");
       
            // Afficher la moyenne de la classe dans une matière
            Console.Write("Classe de " + sixiemeA.nomClasse + ", Moyenne en " + sixiemeA.matieres[1] + " : " + sixiemeA.Moyenne(1)+"\n");
            // Afficher la moyenne générale de la classe
            Console.Write("Classe de " + sixiemeA.nomClasse + ", Moyenne Generale : " + sixiemeA.Moyenne()+"\n");
            
            Console.Read();
         }
     }
}
