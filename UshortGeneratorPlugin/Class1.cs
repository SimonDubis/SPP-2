using System;
using Faker;

namespace UshortGeneratorPlugin
{
    class UshortGeneratorPlugin : IGenerator
    {
        public Type GeneratorType => typeof(ushort);

        static void Main(string[] args)
        {
         
        }

        public object Create()
        {
            return (ushort)(new Random().Next(ushort.MinValue, ushort.MaxValue));
        }
    }
}