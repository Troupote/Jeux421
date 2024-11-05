using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux421
{
    public class DeTruque : De
    {
        public DeTruque(string nbFaces = "6") : base(nbFaces)
        {
        }

        public new int Lancer()
        {
            return 6;
        }
    }
}
