using System;

namespace Faker
{
    class BoolGenerator : IGenerator
    {
        static Random random = new Random();
        public Type GeneratorType => typeof(bool);

        public object Create()
        {
            return random.Next(0,2)==1;
        }
    }
}
