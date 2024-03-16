using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace EntityDersler
{
    public class Entityders
    {
        
        private string dersad;
        private int min;
        private int max;
        private int id;
       

        public string Dersad { get => dersad; set => dersad=value; }
        public int Min { get => min; set => min=value; }
        public int Max { get => max; set => max=value; }
        public int Id { get => id; set => id=value; }
    }
}
