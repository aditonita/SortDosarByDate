using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortDosarByDate
{
    internal class Sedinta
    {
        private DateOnly _standardDate;
        private TimeOnly _oraEstimata;
        private String _complet;
        private String _tipSolutie;
        private String _solutiePeScurt;
        private String _document;
        public DateOnly StandardDate
        {
            get
            {
                return _standardDate;
            }
        }
        public Sedinta(String standardDate, String oraEstimata, String complet, String tipSolutie, String solutiePeScurt, String document)
        {
            _standardDate = new DateOnly(Int32.Parse(standardDate.Substring(0, 4)), Int32.Parse(standardDate.Substring(5, 2)), Int32.Parse(standardDate.Substring(8, 2)));
            _oraEstimata = new TimeOnly(Int32.Parse(oraEstimata.Substring(0, 2)), Int32.Parse(oraEstimata.Substring(3, 2)));
            _complet = complet;
            _tipSolutie = tipSolutie;
            _solutiePeScurt = solutiePeScurt;
            _document = document;
        }


    }
}
