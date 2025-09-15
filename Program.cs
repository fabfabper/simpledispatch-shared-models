using NJsonSchema;
using NJsonSchema.CodeGeneration.TypeScript;
using SimpleDispatch.SharedModels.Dtos;
using SimpleDispatch.SharedModels.Commands;
using SimpleDispatch.SharedModels.CommandTypes;

namespace SimpleDispatch.SharedModels
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
                typeof(EventApiResponse),
                typeof(UnitApiResponse),
            };

            // Define Commands to generate
            Type[] commandTypes = new Type[]
            {
                typeof(CommonCommandType),
                typeof(EventCommandType),
                typeof(UnitCommandType),
                typeof(CommonCommand),
                typeof(EventCommand),
                typeof(UnitCommand),
            };

            string outputDir = Path.Combine(Directory.GetCurrentDirectory(), "typescript");
            Directory.CreateDirectory(outputDir);

            // Generate DTOs
            foreach (var dtoType in dtoTypes)
            {
                var schema = JsonSchema.FromType(dtoType);

                var settings = new TypeScriptGeneratorSettings
                {
                    TypeStyle = TypeScriptTypeStyle.Interface,
                    // Note: GenerateOptionalProperties removed as it doesn't exist in newer versions
                };

                var generator = new TypeScriptGenerator(schema, settings);
                var tsCode = generator.GenerateFile();

                string outputPath = Path.Combine(outputDir, dtoType.Name + ".ts");
                File.WriteAllText(outputPath, tsCode);

                Console.WriteLine($"Generated TypeScript interface for {dtoType.Name} at {outputPath}");
            }

            // Generate Commands
            foreach (var commandType in commandTypes)
            {
                var schema = JsonSchema.FromType(commandType);

                var settings = new TypeScriptGeneratorSettings
                {
                    TypeStyle = TypeScriptTypeStyle.Interface,
                };

                var generator = new TypeScriptGenerator(schema, settings);
                var tsCode = generator.GenerateFile();

                string outputPath = Path.Combine(outputDir, commandType.Name + ".ts");
                File.WriteAllText(outputPath, tsCode);

                Console.WriteLine($"Generated TypeScript interface for {commandType.Name} at {outputPath}");
            }

            Console.WriteLine("✅ All DTOs and Commands generated successfully!");
        }
    }
}
