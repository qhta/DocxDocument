namespace ModelGen;

public class ConverterCreator
{
  private ConverterGenerator CodeGenerator = null!;

  public ConverterCreator(string projectName, string outputPath)
  {
    ProjectName = projectName;
    OutputPath = outputPath;
    CodeGenerator = new ConverterGenerator(ProjectName, OutputPath);
  }

  private Assembly SourceAssembly { get; set; } = null!;

  private string ProjectName { get; set; }
  private string OutputPath { get; set; }


  public void RunOn(Assembly assembly)
  {
    SourceAssembly = assembly;
    TimeSpan totalTime = TimeSpan.Zero;
    totalTime += ScanTypes(assembly);

    //ShowNamespaces();

    totalTime += RenameTypes();

    //ShowNamespaces(OTS.Target);

    totalTime += AddTypeConversion();

    totalTime += CheckTypeUsage();

    //ShowNamespaceDetails();

    totalTime += ValidatingTypes();

    totalTime += GenerateCode();

    ModelDisplay.WriteLine($"Total time = {totalTime}");
  }

  public void RunOn(Type type)
  {
    SourceAssembly = type.Assembly;
    TimeSpan totalTime = TimeSpan.Zero;
    totalTime += ScanType(type);

    //ShowNamespaces();

    totalTime += RenameTypes();

    //ShowNamespaces(OTS.Target);

    totalTime += AddTypeConversion();

    totalTime += CheckTypeUsage();

    //ShowNamespaceDetails();

    totalTime += ValidatingTypes();

    totalTime += GenerateCode();

    ModelDisplay.WriteLine($"Total time = {totalTime}");
  }


  private void ShowNamespaceDetails(OTS filter)
  {
    ModelDisplay.WriteLine();
    ModelDisplay.ShowNamespaceDetails(filter, new ShowOptions
    {
      BaseTypes = true,
      Properties = true,
    });
  }

  private void ShowNamespaces(OTS filter)
  {
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine($"Found {TypeManager.GetNamespaces(filter).Count()} namespaces");
    ModelDisplay.ShowNamespaces(filter);
  }

  private TimeSpan ScanTypes(Assembly assembly)
  {
    ModelDisplay.WriteLine("Scanning types");
    DateTime t1 = DateTime.Now;
    var foundTypesCount = 0;
    var approvedTypesCount = 0;
    foreach (var type in assembly.GetTypes())
    {
      if (ModelData.IncludedNamespaces.Count == 0 || ModelData.IncludedNamespaces.Contains(type.Namespace ?? "")
          || ModelData.IncludedTypes.Contains(type.Name))
      {
        foundTypesCount++;
        if (ModelManager.TryAcceptType(type, out var typeInfo))
        {
          approvedTypesCount++;
        }
      }
    }
    TypeReflector.WaitDone();
    ModelDisplay.WriteLine();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelDisplay.WriteLine($"Scanning time is {ts}");
    ModelDisplay.WriteLine($"Directly {foundTypesCount} types found, {approvedTypesCount} approved");
    var allTypesCount = TypeManager.AllTypes.Count();
    var reflectedTypesCount = TypeManager.AllTypes.Where(item => item.IsReflected).ToArray().Count();
    var acceptedTypesCount = TypeManager.AcceptedTypes.Count();
    ModelDisplay.WriteLine($"Finally {allTypesCount} types registered, {reflectedTypesCount} reflected");
    ModelDisplay.WriteLine($"Accepted {acceptedTypesCount} types");
    return ts;
  }

  private TimeSpan ScanType(Type type)
  {
    ModelDisplay.WriteLine("Scanning types");
    DateTime t1 = DateTime.Now;
    var foundTypesCount = 0;
    var approvedTypesCount = 0;
    //if (ModelData.IncludedNamespaces.Count == 0 || ModelData.IncludedNamespaces.Contains(type.Namespace ?? "")
    //                                            || ModelData.IncludedTypes.Contains(type.Name))
    {
      foundTypesCount++;
      if (ModelManager.TryAcceptType(type, out var typeInfo))
      {
        approvedTypesCount++;
      }
    }
    TypeReflector.WaitDone();
    ModelDisplay.WriteLine();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelDisplay.WriteLine($"Scanning time is {ts}");
    ModelDisplay.WriteLine($"Directly {foundTypesCount} types found, {approvedTypesCount} approved");
    var allTypesCount = TypeManager.AllTypes.Count();
    var reflectedTypesCount = TypeManager.AllTypes.Where(item => item.IsReflected).ToArray().Count();
    var acceptedTypesCount = TypeManager.AcceptedTypes.Count();
    ModelDisplay.WriteLine($"Finally {allTypesCount} types registered, {reflectedTypesCount} reflected");
    ModelDisplay.WriteLine($"Accepted {acceptedTypesCount} types");
    return ts;
  }

  private TimeSpan ValidatingTypes()
  {
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine("Validating types & namespaces");
    DateTime t1 = DateTime.Now;
    var checkedTypesCount = 0;
    var checkedNamespacesCount = 0;
    var invalidTypesCount = 0;
    foreach (var typeInfo in TypeManager.AllTypes.ToArray())
    {
      ModelDisplay.WriteSameLine($"Checked {++checkedTypesCount} types. {typeInfo.GetFullName()}");
      if (!ModelManager.ValidateType(typeInfo))
        invalidTypesCount++;
    }
    //invalidTypesCount += ModelManager.CheckNamespacesDuplicatedTypesAsync((int repaired, int waiting)
    //  =>
    //  ModelDisplay.WriteSameLine($"Repaired {repaired} types. Waiting for {waiting} namespaces ")
    //  );
    foreach (var nspace in TypeManager.GetNamespaces(OTS.Target))
    {
      ModelDisplay.WriteSameLine($"Checked {++checkedNamespacesCount} namespaces for duplicate type names. {nspace}");
      int n = ModelManager.CheckNamespaceDuplicatedTypes(nspace);
      if (n > 0)
        invalidTypesCount += n;
    }
    ModelDisplay.WriteLine();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelDisplay.WriteLine($"Validation time is {ts}");
    ModelDisplay.WriteLine($"{invalidTypesCount} types checked");
    return ts;
  }

  private TimeSpan RenameTypes()
  {
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine("Renaming types");
    DateTime t1 = DateTime.Now;
    var checkedCount = 0;
    var renamedCount = ModelManager.RenameSpecificTypes();
    foreach (var type in TypeManager.AllTypes.ToArray())
    {
      ModelDisplay.WriteSameLine($"Checked {++checkedCount} types. {type.GetFullName()}");
      if (ModelManager.RenameType(type))
        renamedCount++;
    }
    ModelDisplay.WriteLine();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelDisplay.WriteLine($"Renaming time is {ts}");
    ModelDisplay.WriteLine($"Renamed {renamedCount} types");
    //ModelDisplay.ShowTypeRenames();
    return ts;
  }

  private TimeSpan AddTypeConversion()
  {
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine("Converting types");
    DateTime t1 = DateTime.Now;
    var checkedCount = 0;
    foreach (var type in TypeManager.AllTypes.ToArray())
    {
      checkedCount++;
      ModelDisplay.WriteSameLine($"Checked {checkedCount} types. {type.GetFullName()}");
      ModelManager.TryAddTypeConversion(type);
    }
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine($"Converting time is {ts}");
    var convertedTypesCount = TypeManager.ConvertedTypes.Count();
    ModelDisplay.WriteLine($"Converted {convertedTypesCount} types");
    //ModelDisplay.ShowTypeConversions();
    return ts;
  }


  private TimeSpan CheckTypeUsage()
  {
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine("Checking type usage");
    DateTime t1 = DateTime.Now;
    var checkCount = 0;
    var acceptedTypes = TypeManager.AcceptedTypes.ToArray();
    foreach (var type in acceptedTypes)
    {
      ModelManager.CheckTypeUsage(type,
        (item) => { ModelDisplay.WriteSameLine($"Checked {++checkCount} types. {item.GetFullName()}"); });
    }
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    var usedCount = TypeManager.UsedTypes.Count();
    var acceptedCount = TypeManager.AcceptedTypes.Count();
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine($"Checking time is {ts}");
    ModelDisplay.WriteLine($"Found {usedCount} used types, {acceptedCount} accepted types");
    //ModelMonitorDisplay.ShowUnusedTypes();
    return ts;
  }

  private TimeSpan GenerateCode()
  {
    ModelDisplay.WriteLine();
    //CodeGenerator.PrepareProjects();
    int generatedCount = 0;
    ModelDisplay.WriteLine($"Generating {TypeManager.AcceptedTypes.Count()} types");
    DateTime t1 = DateTime.Now;
    foreach (var typeInfo in TypeManager.AcceptedTypes.ToArray())
    {
      if (typeInfo.Namespace.StartsWith("System"))
        continue;
      if (typeInfo.Name.Contains('`'))
        continue;
      if (!typeInfo.IsUsed)
        continue;
      ModelDisplay.WriteSameLine($"Generated {generatedCount} types. {typeInfo.GetFullName(false)}");
      if (CodeGenerator.GenerateConverterFile(typeInfo))
        generatedCount++;
    }
    //CodeGenerator.GenerateGlobalUsings();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine($"Generating time is {ts}");
    ModelDisplay.WriteLine($"Generated {CodeGenerator.GeneratedInterfacesCount} interfaces, {CodeGenerator.GeneratedClassesCount} classes" +
                      $", {CodeGenerator.GeneratedStructsCount} structs, {CodeGenerator.GeneratedEnumTypesCount} enums");
    ModelDisplay.WriteLine($"Skipped {CodeGenerator.SkippedTypesCount} converters");
    ModelDisplay.WriteLine($"Total {CodeGenerator.GeneratedPropertiesCount} properties, {CodeGenerator.GeneratedEnumValuesCount} enumValues");
    return ts;
  }

}