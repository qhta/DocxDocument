namespace ModelGen;

public class ConverterCreator: BaseCreator
{
  private ConverterGenerator CodeGenerator = null!;

  public ConverterCreator(string projectName, string outputPath): base(projectName, outputPath)
  {
    CodeGenerator = new ConverterGenerator(ProjectName, OutputPath);
  }

  //private TimeSpan ValidatingTypes()
  //{
  //  ModelDisplay.WriteLine();
  //  ModelDisplay.WriteLine("Validating types & namespaces");
  //  DateTime t1 = DateTime.Now;
  //  var checkedTypesCount = 0;
  //  var checkedNamespacesCount = 0;
  //  var invalidTypesCount = 0;
  //  foreach (var typeInfo in TypeManager.AllTypes.ToArray())
  //  {
  //    ModelDisplay.WriteSameLine($"Checked {++checkedTypesCount} types. {typeInfo.GetFullName()}");
  //    if (!ModelManager.ValidateType(typeInfo))
  //      invalidTypesCount++;
  //  }
  //  //invalidTypesCount += ModelManager.CheckNamespacesDuplicatedTypesAsync((int repaired, int waiting)
  //  //  =>
  //  //  ModelDisplay.WriteSameLine($"Repaired {repaired} types. Waiting for {waiting} namespaces ")
  //  //  );
  //  foreach (var nspace in TypeManager.GetNamespaces(OTS.Target))
  //  {
  //    ModelDisplay.WriteSameLine($"Checked {++checkedNamespacesCount} namespaces for duplicate type names. {nspace}");
  //    int n = ModelManager.CheckNamespaceDuplicatedTypes(nspace);
  //    if (n > 0)
  //      invalidTypesCount += n;
  //  }
  //  ModelDisplay.WriteLine();
  //  DateTime t2 = DateTime.Now;
  //  var ts = t2 - t1;
  //  ModelDisplay.WriteLine($"Validation time is {ts}");
  //  ModelDisplay.WriteLine($"{invalidTypesCount} types checked");
  //  return ts;
  //}

  //private TimeSpan RenameTypes()
  //{
  //  ModelDisplay.WriteLine();
  //  ModelDisplay.WriteLine("Renaming types");
  //  DateTime t1 = DateTime.Now;
  //  var checkedCount = 0;
  //  var renamedCount = ModelManager.RenameSpecificTypes();
  //  foreach (var type in TypeManager.AllTypes.ToArray())
  //  {
  //    ModelDisplay.WriteSameLine($"Checked {++checkedCount} types. {type.GetFullName()}");
  //    if (ModelManager.RenameType(type))
  //      renamedCount++;
  //  }
  //  ModelDisplay.WriteLine();
  //  DateTime t2 = DateTime.Now;
  //  var ts = t2 - t1;
  //  ModelDisplay.WriteLine($"Renaming time is {ts}");
  //  ModelDisplay.WriteLine($"Renamed {renamedCount} types");
  //  //ModelDisplay.ShowTypeRenames();
  //  return ts;
  //}

  //private TimeSpan AddTypeConversion()
  //{
  //  ModelDisplay.WriteLine();
  //  ModelDisplay.WriteLine("Converting types");
  //  DateTime t1 = DateTime.Now;
  //  var checkedCount = 0;
  //  foreach (var type in TypeManager.AllTypes.ToArray())
  //  {
  //    checkedCount++;
  //    ModelDisplay.WriteSameLine($"Checked {checkedCount} types. {type.GetFullName()}");
  //    ModelManager.TryAddTypeConversion(type);
  //  }
  //  DateTime t2 = DateTime.Now;
  //  var ts = t2 - t1;
  //  ModelDisplay.WriteLine();
  //  ModelDisplay.WriteLine($"Converting time is {ts}");
  //  var convertedTypesCount = TypeManager.ConvertedTypes.Count();
  //  ModelDisplay.WriteLine($"Converted {convertedTypesCount} types");
  //  //ModelDisplay.ShowTypeConversions();
  //  return ts;
  //}


  //private TimeSpan CheckTypeUsage()
  //{
  //  ModelDisplay.WriteLine();
  //  ModelDisplay.WriteLine("Checking type usage");
  //  DateTime t1 = DateTime.Now;
  //  var checkCount = 0;
  //  var acceptedTypes = TypeManager.AcceptedTypes.ToArray();
  //  foreach (var type in acceptedTypes)
  //  {
  //    ModelManager.CheckTypeUsage(type,
  //      (item) => { ModelDisplay.WriteSameLine($"Checked {++checkCount} types. {item.GetFullName()}"); });
  //  }
  //  DateTime t2 = DateTime.Now;
  //  var ts = t2 - t1;
  //  var usedCount = TypeManager.UsedTypes.Count();
  //  var acceptedCount = TypeManager.AcceptedTypes.Count();
  //  ModelDisplay.WriteLine();
  //  ModelDisplay.WriteLine($"Checking time is {ts}");
  //  ModelDisplay.WriteLine($"Found {usedCount} used types, {acceptedCount} accepted types");
  //  //ModelMonitorDisplay.ShowUnusedTypes();
  //  return ts;
  //}

  protected override TimeSpan GenerateCode()
  {
    //CodeGenerator.PrepareProjects();
    int generatedCount = 0;
    ModelMonitor?.ShowPhaseStart(PPS.CodeGeneration,"Generating converters");
    DateTime t1 = DateTime.Now;
    foreach (var typeInfo in TypeManager.AcceptedTypes.ToArray())
    {
      if (typeInfo.GetTargetNamespace().StartsWith("System"))
        continue;
      if (typeInfo.Name.Contains('`'))
        continue;
      if (!typeInfo.IsUsed)
        continue;
      //ModelMonitor?.WriteSameLine($"Generated {generatedCount} types. {typeInfo.GetFullName(false)}");
      if (CodeGenerator.GenerateConverterFile(typeInfo))
        generatedCount++;
    }
    //CodeGenerator.GenerateGlobalUsings();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    //ModelMonitor?.ShowPhaseEnd(PPS.CodeGeneration, new SummaryInfo{ Time = ts, 
    //  Summary = new Dictionary<string, object>{ 
    //    {"Generated interfaces", CodeGenerator.GeneratedInterfacesCount }, 
    //    {"Generated classes", CodeGenerator.GeneratedClassesCount }, 
    //    {"Skipped types", CodeGenerator.SkippedTypesCount }, 
    //    {"Total properties", CodeGenerator.GeneratedPropertiesCount }, 
    //    {"Total enum values", CodeGenerator.GeneratedEnumValuesCount }, 
    //    }});
    return ts;
  }

}