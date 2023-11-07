using System;
using ChempionsCar.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChempionsCar.Repositories
{
     interface IcarRepo
    {
         public List<Car> QueryCar(string Query);
    }
}
