using System;
using Newtonsoft.Json;
using Faker;
using Faker.BaseTypes;
using System.Collections.Generic;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Faker.Faker f = new Faker.Faker();
            User ff = f.Create<User>();
            Console.WriteLine(JsonConvert.SerializeObject(ff,Formatting.Indented));
        }
    }
}
