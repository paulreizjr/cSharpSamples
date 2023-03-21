
using cSharpSamples.Domain.Entities;
using cSharpSamples.Shared.Enums;
using cSharpSamples.Shared.Samples;

namespace cSharpSamples.Samples.OverloadOperator
{
    public class OverloadOperatorSample : ISample
    {
        public string SampleDescription()
        {
            return @"
            A simple operator overload sample

            Unary operators:
            + (unary plus)
            - (unary minus)
            ! (logical negation)
            ~ (bitwise complement)
            ++ (increment)
            -- (decrement)
            true (true operator)
            false (false operator)
            
            Binary operators:
            + (addition)
            - (subtraction)
            * (multiplication)
            / (division)
            % (modulus)
            & (bitwise AND)
            | (bitwise OR)
            ^ (bitwise XOR)
            << (left shift)
            >> (right shift)
            == (equality)
            != (inequality)
            < (less than)
            > (greater than)
            <= (less than or equal to)
            >= (greater than or equal to)            
            ";
        }

        public string SampleRun()
        {
            Fruit Orange1 = new Fruit("Orange", FruitType.citrus);
            Fruit Orange2 = new Fruit("Orange", FruitType.citrus);
            Fruit Banana1 = new Fruit("Banana", FruitType.tropical);
            
            Console.WriteLine(Orange1 == Orange2);
            Console.WriteLine(Orange1.GetHashCode());
            Console.WriteLine(Orange2.GetHashCode());
            Console.WriteLine(Orange1.Equals(Orange2));
            Console.WriteLine(Orange2.Equals(Orange1));
            Console.WriteLine(Object.Equals(Orange1, Orange2));
            
            Console.WriteLine(Orange1 == Banana1);
            Console.WriteLine(Banana1.GetHashCode());
            Console.WriteLine(Orange1.Equals(Banana1));

            return "Ok...";
        }

        
    }
}