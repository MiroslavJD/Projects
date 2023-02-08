using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebAppProcessGo1.Models;

namespace WebAppProcessGo1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RandomNumberGeneratorService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RandomNumberGeneratorService.svc or RandomNumberGeneratorService.svc.cs at the Solution Explorer and start debugging.
    public class RandomNumberGeneratorService : IRandomNumberGeneratorService
    {     
        public NumberModel GetRandomNumbers()
        {
            var random = new Random();

            var numberobject = new NumberModel
            {
                RandomNumber1 = random.Next(-500, 5000),
                RandomNumber2 = random.Next(-500, 5000),
                RandomNumber3 = random.Next(-500, 5000)
            };

            return numberobject;
        }
    }
}
