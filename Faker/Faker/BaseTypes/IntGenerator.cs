using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    public class IntGenerator : IGenerator
    {
        public Type GeneratorType => typeof(int);
        static Random random = new Random();
        public object Create()
        {
            return random.Next(int.MinValue,int.MaxValue);
        }
    }
}