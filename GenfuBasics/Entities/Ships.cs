using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenfuBasics.Entities
{
    public class Ships
    {

     
        public int Id { get; set; }
        public int ShipNumber { get; set; }
        public int ImoNumber { get; set; }
        public string ShipName { get; set; }
        public decimal RegisteredLength { get; set; }
        public string TypeOf { get; set; }
        public decimal GrossTonnage { get; set; }
        public decimal NetTonnage { get; set; }
      


    }
}
