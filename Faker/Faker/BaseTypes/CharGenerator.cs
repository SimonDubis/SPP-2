using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    class CharGenerator : IGenerator
    { 
       static Random random = new Random();
        static string Symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        public Type GeneratorType => typeof(Char);

        public object Create()
        {
            char b = Symbols[random.Next(Symbols.Length)];
            return b;
        }
    }
}