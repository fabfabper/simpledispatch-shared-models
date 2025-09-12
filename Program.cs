using System;
using System.IO;
using NJsonSchema;
using NJsonSchema.CodeGeneration.TypeScript;
using SimpleDispatchSharedModels.Dtos;

namespace SimpleDispatchSharedModels
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define DTOs to generate
            Type[] dtoTypes = new Type[]
            {
                typeof(Coordinate),
                typeof(Event),
                typeof(Unit),
            };

            string outputDir = Path.Combine(Directory.GetCurrentDirectory(), "typescript");
            Directory.CreateDirectory(outputDir);

            foreach (var dtoType in dtoTypes)
            {
                var schema = JsonSchema.FromType(dtoType);

                var settings = new TypeScriptGeneratorSettings
                {
                    TypeStyle = TypeScriptTypeStyle.Interface,
                    //GenerateOptionalProperties = true
                };

                var generator = new TypeScriptGenerator(schema, settings);
                var tsCode = generator.GenerateFile();

                string outputPath = Path.Combine(outputDir, dtoType.Name + ".ts");
                File.WriteAllText(outputPath, tsCode);

                Console.WriteLine($"Generated TypeScript interface for {dtoType.Name} at {outputPath}");
            }

            Console.WriteLine("✅ All DTOs generated successfully!");
        }
    }
}
