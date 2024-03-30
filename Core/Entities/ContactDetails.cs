using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ContactDetails : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
