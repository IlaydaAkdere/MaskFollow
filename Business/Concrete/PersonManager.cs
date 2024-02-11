using Entities.Concrete;
using MernisServiceReference1;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager
    {
        public void ApplyForMask(Person person)
        { 
        
        }   
        public List<Person> GetList()
        {
            return null;
        }
        Person bool checkPerson(Person person)
        {
            if(person.NationalIdentity !=0)
            {
                //mersis kontrolü yapılacak
                return true;
            }

            //else if(person.NationalIdentity == 0) 
            //{
            //    return false;
            //} 
        }

        internal bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguraiton.KPSPublicSoapClient);

            return client.TcKimlikDogrulaAsync(new TCKimlikNoDogrulaRequest
                (Result.Body.TCKimlikdogrulaResult(person.NationalIdentity,person.FirstName,Person.LastName,Person.DateOfBirth))).Result.Body.TCKimlikdogrulaResult;
        }
    }
}
