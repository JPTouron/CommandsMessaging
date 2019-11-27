using CommandExecutor.Commands.SampleImplementations;
using System;

namespace CommandExecutorWithDI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var kernel = MyKernel.GetKernel();

            //simulate the clientcode dependency being provided by kernel (through constructor maybe?)
            var client = kernel.GetService(typeof(ClientCode)) as ClientCode;

            var cmd = new CreateUserCommand
            {
                password = "some pass..",
                username = "awesome username!"
            };

            //some client code executes its stuff
            var result = client.DoIt(cmd);

            Console.WriteLine($"Hello World! from user: {result.Value}");


            result = client.FindBy(new GetByCommand { username = "juan" });
            Console.WriteLine($"Search results: {(result.IsSuccess ? result.Value.ToString() : result.ErrorMessage)}");
            
            result = client.FindBy(new GetByCommand { id = 3 });
            Console.WriteLine($"Search results: {(result.IsSuccess ? result.Value.ToString() : result.ErrorMessage)}");
            
            result = client.FindBy(new GetByCommand { username = "kilo" });
            Console.WriteLine($"Search results: {(result.IsSuccess? result.Value.ToString() :result.ErrorMessage )}");
            
            result = client.FindBy(new GetByCommand { id = 60 });
            Console.WriteLine($"Search results: {(result.IsSuccess ? result.Value.ToString() : result.ErrorMessage)}");

            MyKernel.Destroy();
        }
    }
}