using Mono.Cecil;
using System;

namespace CoreTestProject
{
	class Program
	{
		string testString = "See this field in reflection!";
		int testNumber = 69;

		static void Main(string[] _)
		{
			Console.WriteLine("Hello World!");

			var path = @"./CoreTestProject.dll";

			var module = ModuleDefinition.ReadModule(path);
			var program = module.GetType("CoreTestProject.Program");

			foreach (var field in program.Fields)
			{
				Console.WriteLine($"{field.Name}: {field.FieldType.Name}");
			}
		}
	}
}
