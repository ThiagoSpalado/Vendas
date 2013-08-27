using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class VendaDTO
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Data { get; set; }
        public string Total { get; set; }
        public string Status { get; set; }
        public string CodReferencia { get; set; }
    }
}
