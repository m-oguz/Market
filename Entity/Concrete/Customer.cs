using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Customer : IEntity
    {
        public string CustomerId { get; set; }
        public string NationalIdNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
