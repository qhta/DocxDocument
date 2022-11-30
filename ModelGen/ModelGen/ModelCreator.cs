using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
//using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;

using DocumentFormat.OpenXml;

using Namotion.Reflection;

namespace ModelGen;

public class ModelCreator
{
  ModelDisplay ModelDisplay = new ModelDisplay();
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

    //CheckTypeUsage();

    ////ShowNamespaceDetails();

    GenerateCode();

    ModelDisplay.WriteLine($"Total time = {totalTime}");
  }

  private void ShowNamespaceDetails()
  {
    Console.WriteLine();
    ModelDisplay.ShowNamespaceDetails(new ShowOptions
    {
      //ShowOptions.OriginalNames
      BaseTypes = true,
      //| ShowOptions.GenericParamsConstraints 
      //| ShowOptions.ImplementedInterfaces
      //| ShowOptions.OutgoingRelationships
      //| ShowOptions.IncomingRelationships
      //| ShowOptions.EnumValues
      Properties = true,
      //| ShowOptions.HideUnacceptedProperties
      //| ShowOptions.HideUnacceptedTypeDetails
      //| ShowOptions.IncludedTypes
    });
  }

  private void ShowNamespaces()
  {
    Console.WriteLine();
    Console.WriteLine($"Found {TypeManager.GetNamespaces(true).Count()} namespaces");
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
      if (ModelData.IncludedNamespaces.Count == 0 || ModelData.IncludedNamespaces.Contains(type.Namespace ?? ""))
      {
        //ModelMonitorDisplay.WriteSameLine(type.FullName);
        foundTypesCount++;
        var nspace = type.Namespace ?? "";
        if (nspace == "DocumentFormat.OpenXml.Packaging")
          Debug.Assert(true);
        if (CanGenerateType(type, out var typeInfo))
        {
          approvedTypesCount++;
        }
      }
    }
    TypeReflector.WaitDone();
    Console.WriteLine();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    Console.WriteLine($"Scanning time {ts}");
    Console.WriteLine($"Directly {foundTypesCount} types found, {approvedTypesCount} approved");
    var allTypesCount = TypeManager.AllTypes.Count();
    var reflectedTypesCount = TypeManager.AllTypes.Where(item => item.IsReflected).Count();
    var acceptedTypesCount = TypeManager.AcceptedTypes.Count();
    Console.WriteLine($"Finally {allTypesCount} types registered, {reflectedTypesCount} reflected");
    Console.WriteLine($"Accepted {acceptedTypesCount} types");
    return ts;
  }


  private TimeSpan RenameTypes()
  {
    Console.WriteLine();
    Console.WriteLine("Renaming types");
    DateTime t1 = DateTime.Now;
    var checkedCount = 0;
    var renamedCount = 0;
    foreach (var type in TypeManager.AllTypes. ToArray())
    {
      ModelDisplay.WriteSameLine($"Checked {++checkedCount} types. {type.GetFullName()}");
      if (ModelManager.RenameType(type))
        renamedCount++;
    }
    Console.WriteLine();
    DateTime t2 = DateTime.Now;
    var ts = t2 - t1;
    Console.WriteLine($"Renaming time {ts}");
    Console.WriteLine($"Renamed {renamedCount} types");
    //ModelDisplay.ShowTypeRenames();
    return ts;
  }

  private TimeSpan AddTypeConversion()
  {
    Console.WriteLine();
    Console.WriteLine("Converting types");
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
    Console.WriteLine();
    Console.WriteLine($"Converting time {ts}");
    var convertedTypesCount = TypeManager.ConvertedTypes.Count();
    Console.WriteLine($"Converted {convertedTypesCount} types");
    //ModelDisplay.ShowTypeConversions();
    return ts;
  }


  private void CheckTypeUsage()
  {
    Console.WriteLine();
    Console.WriteLine("Checking type usage");
    var checkCount = 0;
    foreach (var type in TypeManager.AcceptedTypes.ToArray())
    {
      CheckTypeUsage(type,
        (item) => { ModelDisplay.WriteSameLine($"Checked {++checkCount} types. {item.GetFullName()}"); });
    }
    var usedCount = TypeManager.UsedTypes.Count();
    var acceptedCount = TypeManager.AcceptedTypes.Count();
    Console.WriteLine($"Found {usedCount} used types, {acceptedCount} accepted types");
    //ModelMonitorDisplay.ShowUnusedTypes();
  }

  private void GenerateCode()
  {
    Console.WriteLine();
    ModelGenerator.PrepareProjects();
    int generatedCount = 0;
    Console.WriteLine($"Generating {TypeManager.AcceptedTypes.Count()} types");
    foreach (var typeInfo in TypeManager.AcceptedTypes.ToArray())
    {
      if (typeInfo.Name == "RgbColorModelPercentage")
        Debug.Assert(true);
      if (typeInfo.Namespace.StartsWith("System"))
        continue;
      if (typeInfo.Name.Contains('`'))
        continue;
      generatedCount++;
      ModelDisplay.WriteSameLine($"Generated {generatedCount} types. {typeInfo.GetFullName(false, true)}");
      ModelGenerator.GenerateTypeFile(typeInfo);
    }
    Console.WriteLine();
    Console.WriteLine($"Generated {ModelGenerator.GeneratedInterfacesCount} interfaces, {ModelGenerator.GeneratedClassesCount} classes" +
                      $", {ModelGenerator.GeneratedStructsCount} structs, {ModelGenerator.GeneratedEnumTypesCount} enums");
    Console.WriteLine($"Total {ModelGenerator.GeneratedPropertiesCount} properties, {ModelGenerator.GeneratedEnumValuesCount} enumValues");
  }

  #region Check types
  private bool CanGenerateType(Type type, [NotNullWhen(true)] out TypeInfo? typeInfo)
  {
    typeInfo = null;
    var typeName = type.ToString();
    if (typeName.Contains('<') || typeName.Contains('+') || typeName.Contains('&'))
      return false;
    if (ModelData.IsExcluded(type))
      return false;
    typeInfo = TypeManager.RegisterType(type);
    return true;
  }

  public void CheckTypeUsage(TypeInfo typeInfo, Action<TypeInfo>? OnStartChecking = null)
  {
    if (typeInfo.UsesEvaluated)
      return;
    typeInfo.UsesEvaluated = true;
    //Debug.WriteLine(typeInfo);
    if (OnStartChecking != null)
      OnStartChecking(typeInfo);
    if (typeInfo.Name == "ModelElement")
      Debug.Assert(true);

    if (typeInfo.BaseTypeInfo != null)
    {
      var baseType = typeInfo.BaseTypeInfo.GetConversionTarget(true);
      baseType.IsUsed = true;
      CheckTypeUsage(baseType, OnStartChecking);
    }

    if (typeInfo.Properties != null)
      foreach (var prop in typeInfo.Properties.ToArray())
      {
        if (prop.IsAccepted != false)
        {
          var propType = prop.PropertyType.GetConversionTarget(true);
          if (propType.IsAccepted != false)
          {
            propType.IsUsed = true;
            CheckTypeUsage(propType, OnStartChecking);
          }
        }
      }

    var interfaces = typeInfo.GetInterfaces();
    if (interfaces.Any())
      foreach (var intfType in interfaces.ToArray())
      {
        if (intfType.IsAccepted != false)
        {
          intfType.IsUsed = true;
          CheckTypeUsage(intfType, OnStartChecking);
        }
      }

    var includedTypes = typeInfo.GetIncludedTypes();
    if (includedTypes.Any())
      foreach (var inclType in includedTypes.ToArray())
      {
        if (inclType.IsAccepted != false)
        {
          inclType.IsUsed = true;
          CheckTypeUsage(inclType, OnStartChecking);
        }
      }
  }

  #endregion




}