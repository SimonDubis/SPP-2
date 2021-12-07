using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    public class LongGenerator : IGenerator
    {
        public Type GeneratorType => typeof(long);
        static Random random = new Random();
        public object Create()
        {
            long result = random.Next(int.MinValue, int.MaxValue);
            result = result << 32;
            result |= (long)random.Next(int.MinValue, int.MaxValue) & int.MaxValue;
            return result;
        }
    }
}