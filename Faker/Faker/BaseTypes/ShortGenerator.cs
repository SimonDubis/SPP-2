using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    public class ShortGenerator : IGenerator
    {
        public Type GeneratorType => typeof(short);
        static Random random = new Random();
        public object Create()
        {
            return (short)(random.Next(short.MinValue,short.MaxValue));
        }
    }
}