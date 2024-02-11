using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    internal interface IApplicationService
    {
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> List => null;
        bool checkPerson(Person person)
        {
            return true;
        }
    }
}
