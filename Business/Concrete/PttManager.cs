using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    internal class PttManager:ISupplierService
    {
        private IApplicationService
            public PttManager(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        public void GiveMask(Person person)
        {
            PersonManager personManager = new PersonManager();
            if (_applicationService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " for gived mask");
            }
        }


    }
}
