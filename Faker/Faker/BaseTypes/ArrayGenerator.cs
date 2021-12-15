using System;

namespace Faker.BaseTypes
{
    public class ArrayGenerator : IGenerator
    {

        public Type GeneratorType => typeof(Array);

        private IFaker faker;
        private Type arrayType;

        public ArrayGenerator(IFaker faker, Type arrayType)
        {
            this.faker = faker;
            this.arrayType = arrayType;
        }

        public object Create()
        {
            Random random = new Random();

            var elementType = arrayType.GetElementType();

            if (elementType == null)
                return null;

            var length = random.Next(0, 9);
            var result = Array.CreateInstance(elementType, length);

            for (var i = 0; i < length; i++)
            {
                var item = faker.Create(elementType);
                result.SetValue(item, i);
            }
            
            return result;
        }
    }
}
