using System;
using System.Collections.Generic;
using System.Text;

namespace calculsmoyennes
{
    class Note
    {
        public int matiere { get; private set; }
        public float note { get; private set; }
        public Note(int m, float n) 
        { 
            matiere = m; note = n; 
        }
    }
}
