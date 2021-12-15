using System;

namespace Faker.BaseTypes
{
    public class ByteGenerator : IGenerator
    { 
        public Type GeneratorType => typeof(byte);
        
        static Random random = new Random();
        
        public object Create()
        {
            return (byte)(random.Next(byte.MinValue,byte.MaxValue));
        }
    }
}
