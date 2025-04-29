using System;
using System.Collections.Generic;
using System.Linq;
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
            _sedinte.Sort((x.StandardDate, y.StandardDate) => y.OrderDate.CompareTo(x.OrderDate));
        }
    }
}
