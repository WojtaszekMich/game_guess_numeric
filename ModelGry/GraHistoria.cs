using System.Collections.Generic;
using System.Text;

namespace ModelGry
{
    public partial class Gra
    {
        // historia gry
        public List<Ruch> Historia;

        public List<Ruch> getHistoria()
        {
            return Historia;
        }
    }
}
