namespace ModelGen;

/// <summary>
/// Generator for model types.
/// </summary>
public class ModelCreator : BaseCreator
{

  public ModelCreator(string projectName, string outputPath, string? configPath) : base(projectName, outputPath)
  {
    CodeGenerator = new ModelGenerator(projectName, outputPath, configPath);
  }

  //public override TimeSpan GenerateCode(IEnumerable<Namespace> nspaces)
  //{
  //  //ModelGenerator.PrepareProjects();
  //  int generatedCount = 0;
  //  ModelMonitor?.ShowPhaseStart(PPS.CodeGeneration, "Generating model types");
  //  DateTime t1 = DateTime.Now;
  //  foreach (var typeInfo in TypeManager.TypesAcceptedTo(PPS.CodeGeneration).ToArray())
  //  {
  //    if (typeInfo.GetTargetNamespace().StartsWith("System"))
  //      continue;
  //    if (typeInfo.Name.Contains('`'))
  //      continue;
  //    if (!typeInfo.IsUsed)
  //      continue;
  //    //ModelMonitor.WriteSameLine($"Generated {generatedCount} types. {typeInfo.GetFullName(false)}");
  //    if (ModelGenerator.GenerateTypeFile(typeInfo))
  //      generatedCount++;
  //  }
  //  //ModelGenerator.GenerateGlobalUsings();
  //  DateTime t2 = DateTime.Now;
  //  var ts = t2 - t1;
  //  //ModelMonitor?.ShowPhaseEnd(PPS.CodeGeneration, new SummaryInfo{ Time = ts, 
  //  //  Summary = new Dictionary<string, object>{ 
  //  //    {"Generated interfaces", ModelGenerator.GeneratedInterfacesCount }, 
  //  //    {"Generated classes", ModelGenerator.GeneratedClassesCount }, 
  //  //    {"Generated structs", ModelGenerator.GeneratedStructsCount }, 
  //  //    {"Generated enum types", ModelGenerator.GeneratedEnumTypesCount }, 
  //  //    {"Total properties", ModelGenerator.GeneratedPropertiesCount }, 
  //  //    {"Total enum values", ModelGenerator.GeneratedEnumValuesCount }, 
  //  //    }});
  //  return ts;
  //}

}