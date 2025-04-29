using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SortDosarByDate
{
    internal class Sedinte
    {
        private List<Sedinta> _sedinte;
        public Sedinte()
        {
            _sedinte = new List<Sedinta>();
        }
        public void AddSedinta(Sedinta sedinta)
        {
            _sedinte.Add(sedinta);
        }

        public DateOnly MaxDateSession()
        {
            _sedinte.Sort((x, y) => y._standardDate.CompareTo(x._standardDate));
            return _sedinte[0]._standardDate;
        }
        
    }
}
