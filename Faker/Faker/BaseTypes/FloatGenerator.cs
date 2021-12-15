using System;

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
