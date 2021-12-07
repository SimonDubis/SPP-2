using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    public class FloatGenerator : IGenerator
    {
        public Type GeneratorType => typeof(float);
        static Random random = new Random();
        public object Create()
        {
            return (float)(random.NextDouble());
        }
    }
}