using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Jeux421
{
    public class De
    {

        public string NbFaces;
        private Random random;
        public int Face { get; private set; }

        public De(string nbFaces = "6")
        {
            NbFaces = nbFaces;
            random = new Random();
            this.Face = random.Next(1, int.Parse(NbFaces) + 1);
        }

        public override string ToString()
        {
            string toString = "+---+\n";
            toString += $"| {this.Face} |\n";
            toString += "+---+\n";
            return toString;
        }

        public int Lancer()
        {
            this.Face = this.random.Next(1, int.Parse(NbFaces) + 1);
            return this.Face;
        }

    }
}
