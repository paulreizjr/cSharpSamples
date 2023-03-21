// See https://aka.ms/new-console-template for more information

//Top-level statements are executed in the order they appear in the file. Top-level statements can only be used in one source file in your application. 
//The compiler generates an error if you use them in more than one file.

using cSharpSamples.Samples.OverloadOperator;

Console.WriteLine("Starting...");

OverloadOperatorSample sample = new();
sample.SampleRun();

CustonCastOperators cso = new();
Console.WriteLine(cso.SampleDescription());
cso.SampleRun();
