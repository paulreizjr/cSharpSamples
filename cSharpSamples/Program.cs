
// S - Single - responsiblity Principle
//     - A class should have one and only one reason to change, meaning that a class should have only one job.
//     - No secrets. Broke down entities in a way to garantee single responsability on each one
// O - Open-closed Principle
//     - Objects or entities should be open for extension but closed for modification.
//     - Open to extention, closed to modification
//     - Always depend on abstractions (interfaces), not on concretions/implementatios
// L - Liskov Substitution Principle
//     - Let q(x) be a property provable about objects of x of type T. Then q(y) should be provable for objects y of type S where S is a subtype of T.
//     - This means that every subclass or derived class should be substitutable for their base or parent class.
// I - Interface Segregation Principle
//     - A client should never be forced to implement an interface that it doesn’t use, or clients shouldn’t be forced to depend on methods they do not use.
// D - Dependency Inversion Principle
//     - Entities must depend on abstractions, not on concretions. It states that the high-level module must not depend on the low-level module, but they should depend on abstractions.

using cSharpSamples.Samples.OverloadOperator;

Console.WriteLine("Starting...");

// OverloadOperatorSample sample = new();
// sample.SampleRun();

// CustonCastOperators cso = new();
// Console.WriteLine(cso.SampleDescription());
// cso.SampleRun();

var temp = new TempSample();
temp.SampleRun();
