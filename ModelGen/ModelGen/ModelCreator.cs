namespace ModelGen;

/// <summary>
/// Generator for model types.
/// </summary>
public class ModelCreator: BaseCreator
{
  private ModelGenerator ModelGenerator = null!;

  public ModelCreator(string projectName, string outputPath): base(projectName, outputPath)
  {
    ModelGenerator = new ModelGenerator(ProjectName, OutputPath);
  }

  //public void RunOn(Type type)
  //{
  //  SourceAssembly = type.Assembly;
  //  TimeSpan totalTime = TimeSpan.Zero;
  //  totalTime += ScanTypes(SourceAssembly);

  //  //ShowNamespaces();

  //  totalTime += RenameTypes();

  //  //ShowNamespaces(OTS.Target);

  //  totalTime += AddTypeConversion();

  //  totalTime += CheckTypeUsage();

  //  //ShowNamespaceDetails();

  //  totalTime += ValidatingTypes();

  //  totalTime += GenerateCode();

  //  ModelDisplay.WriteLine($"Total time = {totalTime}");
  //}

  //private void ShowNamespaceDetails(OTS filter)
  //{
  //  ModelDisplay.WriteLine();
  //  ModelDisplay.ShowNamespaceDetails(filter, new ShowOptions
  //  {
  //    BaseTypes = true,
  //    Properties = true,
  //  });
  //}

  //private void ShowNamespaces(OTS filter)
  //{
  //  ModelDisplay.WriteLine();
  //  ModelDisplay.WriteLine($"Found {TypeManager.GetNamespaces(filter).Count()} namespaces");
  //  ModelDisplay.ShowNamespaces(filter);
  //}

  //private TimeSpan ScanTypes(Assembly assembly)
  //{
  //  ModelDisplay.WriteLine("Scanning types");
  //  DateTime t1 = DateTime.Now;
  //  var foundTypesCount = 0;
  //  var approvedTypesCount = 0;
  //  foreach (var type in assembly.GetTypes())
  //  {
  //    if (ModelData.IncludedNamespaces.Count == 0 || ModelData.IncludedNamespaces.Contains(type.Namespace ?? "")
  //        || ModelData.IncludedTypes.Contains(type.Name))
  //    {
  //      foundTypesCount++;
  //      if (ModelManager.TryAcceptType(type, out var typeInfo))
  //      {
  //        approvedTypesCount++;
  //      }
  //    }
  //  }
  //  TypeReflector.WaitDone();
  //  ModelDisplay.WriteLine();
  //  DateTime t2 = DateTime.Now;
  //  var ts = t2 - t1;
  //  ModelDisplay.WriteLine($"Scanning time is {ts}");
  //  ModelDisplay.WriteLine($"Directly {foundTypesCount} types found, {approvedTypesCount} approved");
  //  var allTypesCount = TypeManager.AllTypes.Count();
  //  var reflectedTypesCount = TypeManager.AllTypes.Where(item => item.IsReflected).ToArray().Count();
  //  var acceptedTypesCount = TypeManager.AcceptedTypes.Count();
  //  ModelDisplay.WriteLine($"Finally {allTypesCount} types registered, {reflectedTypesCount} reflected");
  //  ModelDisplay.WriteLine($"Accepted {acceptedTypesCount} types");
  //  return ts;
  //}


  protected override TimeSpan GenerateCode()
  {
    //ModelGenerator.PrepareProjects();
    int generatedCount = 0;
    ModelMonitor?.ShowPhaseStart(PPS.CodeGeneration,"Generating model types");
    DateTime t1 = DateTime.Now;
    foreach (var typeInfo in TypeManager.AcceptedTypes.ToArray())
    {
      if (typeInfo.GetTargetNamespace().StartsWith("System"))
        continue;
      if (typeInfo.Name.Contains('`'))
        continue;
      if (!typeInfo.IsUsed)
        continue;
      //ModelMonitor.WriteSameLine($"Generated {generatedCount} types. {typeInfo.GetFullName(false)}");
      if (ModelGenerator.GenerateTypeFile(typeInfo))
        generatedCount++;
    }
    //ModelGenerator.GenerateGlobalUsings();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    //ModelMonitor?.ShowPhaseEnd(PPS.CodeGeneration, new SummaryInfo{ Time = ts, 
    //  Summary = new Dictionary<string, object>{ 
    //    {"Generated interfaces", ModelGenerator.GeneratedInterfacesCount }, 
    //    {"Generated classes", ModelGenerator.GeneratedClassesCount }, 
    //    {"Generated structs", ModelGenerator.GeneratedStructsCount }, 
    //    {"Generated enum types", ModelGenerator.GeneratedEnumTypesCount }, 
    //    {"Total properties", ModelGenerator.GeneratedPropertiesCount }, 
    //    {"Total enum values", ModelGenerator.GeneratedEnumValuesCount }, 
    //    }});
    return ts;
  }

}