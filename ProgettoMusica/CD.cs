using System;
using System.Collections.Generic;
using System.Text;

namespace ProgettoMusica
{
    class CD
    { string titolo, autore;
        List<class1> elenco=new List<class1>;
        public CD (string t, string a)
        {
            titolo = t;
            autore = a;
            Class1 c1 = new Class1("Papero", "Zelig", 130);
            elenco.Add(c1);
        }

        public string getTitolo()
        {
            return titolo;
        }

        public string getAutore()
        {
            return autore;
        }

        public void setTitolo(string t)
        {
            titolo=t;
        }

        public void setAutore(string a)
        {
            autore=a;
        }
    }
}
