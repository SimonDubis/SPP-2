using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Faker;
using Main;
namespace TestProject1
{
    class CollectionTest
    {
        private Bar bar;
        private Faker.Faker faker;
        private User user;
        private Foo foo;
        [SetUp]
        public void Initialization()
        {
            faker = new Faker.Faker();
            bar = faker.Create<Bar>();
            user = faker.Create<User>();
            foo = faker.Create<Foo>();
        }
        [Test] 
        public void TestGenerateClass()
        {
            Assert.True(bar!=null);
        }
        [Test]
        public void TestGenerateLong()
        {
            Assert.True(bar.Long != 0L);
            Assert.True(user.money is long);
        }
        [Test]
        public void TestGenerateFloat()
        {
            Assert.True(user.money != 0f);
            Assert.True(user.money is float);
        }
        
        [Test]
        public void TestGenerateWithoutConstructor()
        {
            Assert.True(bar._int != 0);
            Assert.True(bar._int is int);
        }
        [Test]
        public void TestGenerateList()
        {
            Assert.True(user.dogs.Length > 0);
            foreach (Dog dog in user.dogs)
            {
                Assert.True(dog!=null);
            }
        }
        [Test]
        public void TestGenerateListInt()
        {
            Assert.True(foo.list.Count > 0);
            foreach (int num in foo.list)
            {
                Assert.True(num != 0);
            }
        }

        [Test]
        public void CollectionCreate()
        {
            faker = new Faker.Faker();
            List<int> list = faker.Create<List<int>>();
            List<List<char>> difficult = faker.Create<List<List<char>>>();
            Assert.AreEqual(list == null, false);
            char b = difficult[0][0]; 
            Assert.AreEqual(b == default(char), false);
        }
    }
}