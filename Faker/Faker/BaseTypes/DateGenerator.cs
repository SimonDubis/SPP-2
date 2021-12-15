using System;

namespace Faker.BaseTypes
{
    public class DateGenerator : IGenerator
    {
        public Type GeneratorType => typeof(DateTime);
        static Random gen = new Random();
        public object Create()
        {
            DateTime start = new DateTime(2000, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}
