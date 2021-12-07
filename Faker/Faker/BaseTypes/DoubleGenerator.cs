using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    public class DoubleGenerator : IGenerator
    {
        public Type GeneratorType => typeof(Double);
        static Random random = new Random();
        public object Create()
        {
            return new Random().NextDouble();
        }
    }
}