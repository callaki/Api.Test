using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Test
{
    public partial class OGRENCILER
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public DateTime? BIRTH_DAY { get; set; }
        public string EMAIL { get; set; }
        public string GSM { get; set; }
        public string BIO { get; set; }
        public string PASSWORD { get; set; }
    }
}
