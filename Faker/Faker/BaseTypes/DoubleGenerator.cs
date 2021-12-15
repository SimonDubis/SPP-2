using System;

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
