using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Interaction
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? EmpId { get; set; }
        public char? IntType { get; set; }
        public DateTime? IntDate { get; set; }
        public string Remarks { get; set; }
        public Clients Client { get; set; }
        public Employees Employee { get; set; }
    }
}
