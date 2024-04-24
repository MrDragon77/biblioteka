using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblaoteka
{
    internal class Reader
    {
        public int index;
        public string fam;
        public string name;
        public string ot;
        public DateTime birthDate;
        public int amountTakenBooks;
        public Reader(int index, string fam, string name, string ot, DateTime birthDate, int amountTakenBooks)
        {
            this.index = index;
            this.fam = fam;
            this.name = name;
            this.ot = ot;
            this.birthDate = birthDate;
            this.amountTakenBooks = amountTakenBooks;
        }

    }
}
