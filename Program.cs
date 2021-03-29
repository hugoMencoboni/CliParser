using CommandLine;
using System;

namespace CliParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CommandeLineArgumentsModel>(args)
                      .WithParsed(model =>
                      {
                          Console.WriteLine($"Nombre: -n {model.Nombre}");
                          Console.WriteLine($"String: -s {model.String}");
                      });
        }

        public class CommandeLineArgumentsModel
        {
            [Option('n', "numberTest", Required = false)]
            public int Nombre { get; set; }

            [Option('s', "stringTest", Required = true, HelpText = "stringTest (-s) argument must be provided")]
            public string String { get; set; }
        }
    }
}
