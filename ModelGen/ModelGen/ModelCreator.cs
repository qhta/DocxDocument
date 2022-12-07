using System.Diagnostics;
using System.Reflection;

namespace ModelGen;

public class ModelCreator
{
  private ModelGenerator ModelGenerator = null!;

  public ModelCreator(string projectName, string outputPath)
  {
    ProjectName = projectName;
    OutputPath = outputPath;
    ModelGenerator = new ModelGenerator(ProjectName, OutputPath);
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

    totalTime += AddTypeConversion();

    totalTime += CheckTypeUsage();

    //ShowNamespaceDetails();

    totalTime += CheckTypeDefinition();

    totalTime += GenerateCode();

    ModelDisplay.WriteLine($"Total time = {totalTime}");
  }

  private void ShowNamespaceDetails()
  {
    ModelDisplay.WriteLine();
    ModelDisplay.ShowNamespaceDetails(new ShowOptions
    {
      BaseTypes = true,
      Properties = true,
    });
  }

  private void ShowNamespaces()
  {
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine($"Found {TypeManager.GetNamespaces(true).Count()} namespaces");
    ModelDisplay.ShowNamespaces();
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
    var reflectedTypesCount = TypeManager.AllTypes.Where(item => item.IsReflected).Count();
    var acceptedTypesCount = TypeManager.AcceptedTypes.Count();
    ModelDisplay.WriteLine($"Finally {allTypesCount} types registered, {reflectedTypesCount} reflected");
    ModelDisplay.WriteLine($"Accepted {acceptedTypesCount} types");
    return ts;
  }

  private TimeSpan CheckTypeDefinition()
  {
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine("Checking types");
    DateTime t1 = DateTime.Now;
    var checkedTypesCount = 0;
    var checkedNamespacesCount = 0;
    var invalidTypesCount = 0;
    foreach (var typeInfo in TypeManager.AllTypes.ToArray())
    {
      ModelDisplay.WriteSameLine($"Checked {++checkedTypesCount} types. {typeInfo.GetFullName()}");
      if (!ModelManager.CheckPropertyOverride(typeInfo))
        invalidTypesCount++;
    }
    foreach (var nspace in TypeManager.GetNamespaces())
    {
      ModelDisplay.WriteSameLine($"Checked {++checkedNamespacesCount} namespaces. {nspace}");
      int n = ModelManager.CheckNamespaceDuplicatedTypes(nspace);
      if (n>0)
        invalidTypesCount+=n;
    }
    ModelDisplay.WriteLine();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelDisplay.WriteLine($"Checking time is {ts}");
    ModelDisplay.WriteLine($"Invalid {invalidTypesCount} types found and repaired");
    //ModelDisplay.ShowTypeRenames();
    return ts;
  }

  private TimeSpan RenameTypes()
  {
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine("Renaming types");
    DateTime t1 = DateTime.Now;
    var checkedCount = 0;
    var renamedCount = 0;
    foreach (var type in TypeManager.AllTypes. ToArray())
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
    foreach (var type in TypeManager.AcceptedTypes.ToArray())
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
    ModelGenerator.PrepareProjects();
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
      ModelDisplay.WriteSameLine($"Generated {generatedCount} types. {typeInfo.GetFullName(false, true)}");
      if (ModelGenerator.GenerateTypeFile(typeInfo))
        generatedCount++;
    }
    ModelGenerator.GenerateGlobalUsings();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    ModelDisplay.WriteLine();
    ModelDisplay.WriteLine($"Generating time is {ts}");
    ModelDisplay.WriteLine($"Generated {ModelGenerator.GeneratedInterfacesCount} interfaces, {ModelGenerator.GeneratedClassesCount} classes" +
                      $", {ModelGenerator.GeneratedStructsCount} structs, {ModelGenerator.GeneratedEnumTypesCount} enums");
    ModelDisplay.WriteLine($"Total {ModelGenerator.GeneratedPropertiesCount} properties, {ModelGenerator.GeneratedEnumValuesCount} enumValues");
    return ts;
  }





}