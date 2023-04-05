using cSharpSamples.Domain.Entities;
using cSharpSamples.Domain.Factories;
using cSharpSamples.Shared.Enums;
using cSharpSamples.Shared.Samples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSamples.Samples.OverloadOperator
{
    internal class TempSample : ISample
    {
        public string SampleDescription()
        {
            return "Temporary Samples";
        }

        public string SampleRun()
        {
            var temp1 = new {Foo = 1, Bar = 10};
            var temp2 = new {Foo = 2, Bar = 20};

            var list1 = CreateList(temp1, temp2);

            string? tempStr = list1.Where(l => l.Foo == 11).FirstOrDefault()?.Bar.ToString();
            Console.WriteLine(tempStr == null);
            Console.WriteLine(tempStr);

            Console.WriteLine("---------");
            Console.WriteLine(testeGeneric("1").ToString());

            Fruit orange = IngredientFactory.MakeProduct<Fruit>("Orange", FruitType.citrus);

            Console.WriteLine(orange.ToString());   

            Console.WriteLine(IsTypeNullable<int?>());

            return "ok...";
        }

        public bool IsTypeNullable<T>()
        {
            return Nullable.GetUnderlyingType(typeof(T)) != null;
        }

        List<T> CreateList<T>(params T[] items)
        {
            return new List<T>(items);
        }

        bool testeGeneric<T>(T teste)
        {
            bool ret = teste is int ? true : false;
            return ret;
        }
    }
}
