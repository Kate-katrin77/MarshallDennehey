using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarshallDennehey.Framework
{
    public class CodeSnippets
    {
        /// <summary>
        /// Example of a simple LINQ query
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IEnumerable<string>LinqExample(IEnumerable<string>data)
        {
            var result=data.Where(x => x.StartsWith("test")).Take(10).ToList();
            return result;
        }

        public IEnumerable<T> GenericsExample<T>(params T[] animals) where T : BaseAnimal
        {
            foreach (var animal in animals)
            {
                yield return animal;
            }
        }

        public void UseGenericExample()
        {
            var dog = new Dog();
            var groundhog = new Groundhog();
            var result = GenericsExample<BaseAnimal>(dog, groundhog);
        }
    }

    public class Dog : BaseAnimal
    {
        public string Address { get; set; }
    }

    public class Groundhog : BaseAnimal
    {
        public string ForestName { get; set; }
    }

    public class BaseAnimal
    {
        public string Name { get; set; }
    }
}