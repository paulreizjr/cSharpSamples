using cSharpSamples.Domain.DTO;
using cSharpSamples.Domain.Entities;
using cSharpSamples.Shared.Samples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSamples.Samples.OverloadOperator
{
    public class CustonCastOperators : ISample
    {
        public string SampleDescription()
        {
            return @"
                     -------------------------
                     C# allows user-defined types to control assignment and casting through the use of the explicit and implicit
                     keywords";
        }

        public string SampleRun()
        {
            Fruit orange = new("Orange", Shared.Enums.FruitType.citrus);
            FruitDTO orangeDTO = orange;
            string explicitFruitName = (string)orange;

            Console.WriteLine("orange type - " + orange.GetType());
            Console.WriteLine("orangeDTO type - " + orangeDTO.GetType());
            Console.WriteLine(orangeDTO.FruitName);
            Console.WriteLine(explicitFruitName);
            Console.WriteLine(orange.ToString());

            return "ok";
        }
    }
}
