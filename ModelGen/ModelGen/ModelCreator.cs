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
  ModelDisplay ModelMonitorDisplay = new ModelDisplay();

  public ModelCreator(string projectName, string intfOutputPath, string implOutputPath)
  {
    IntfOutputPath = intfOutputPath;
    IntfProjectName = projectName;
    ImplOutputPath = implOutputPath;
    //if (!Directory.Exists(ImplOutputPath))
    //  Directory.CreateDirectory(ImplOutputPath);
    //var implProjectName = projectName + ".Impl";
    //ModelGenerator.GenProjectFile(implProjectName, Path.Combine(implOutputPath, implProjectName + ".csproj"));
  }

  private Assembly SourceAssembly { get; set; } = null!;

  private string IntfProjectName {get; set;}
  private string IntfOutputPath { get; set; }
  private string ImplOutputPath { get; set; }

  //Dictionary<string, int> TypeNamesCount = new();


  public void RunOn(Assembly assembly)
  {
    SourceAssembly = assembly;
    ModelMonitorDisplay.WriteLine("Scanning types");
    DateTime t1 = DateTime.Now;
    var totalTypesCount = 0;
    var approvedTypesCount = 0;
    foreach (var type in assembly.GetTypes())
    {
      if (ModelData.IncludedNamespaces.Count == 0 || ModelData.IncludedNamespaces.Contains(type.Namespace ?? ""))
      {
        //ModelMonitorDisplay.WriteSameLine(type.FullName);
        totalTypesCount++;
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
    Console.WriteLine($"scanning time {t2-t1}");
    Console.WriteLine($"Found {totalTypesCount} types, {approvedTypesCount} approved");
    var allTypesCount = TypeManager.AllTypes.Count();
    var reflectedTypesCount = TypeManager.AllTypes.Where(item => item.IsReflected).Count();
    var acceptedTypesCount = TypeManager.AcceptedTypes.Count();
    var convertedTypesCount = TypeManager.ConvertedTypes.Count();
    Console.WriteLine($"Finally {allTypesCount} types registered, {reflectedTypesCount} reflected");
    Console.WriteLine($"Accepted {acceptedTypesCount} types, {convertedTypesCount} converted");

    //return;

    Console.WriteLine();
    Console.WriteLine($"Found {TypeManager.GetNamespaces(true).Count()} namespaces");
    ModelMonitorDisplay.ShowNamespaces();
    

    //Console.WriteLine();
    //Console.WriteLine("Converting types");
    //var convertedCount = AddTypeConversion();
    //Console.WriteLine($"Converted {convertedCount} types");
    ////ModelMonitorDisplay.ShowTypeConversions();
    
    Console.WriteLine();
    Console.WriteLine("Checking type usage");
    var usedCount = 0;
    foreach (var type in TypeManager.AcceptedTypes.ToArray())
    {

      usedCount++;
      CheckTypeUsage(type,
        (item) =>
        {
          ModelMonitorDisplay.WriteSameLine($"Checked {usedCount} types. {item.GetFullName()}");
        });
    }
    var acceptedCount = TypeManager.AcceptedTypes.Count();
    Console.WriteLine($"Found {usedCount} used types among {acceptedCount} accepted types");
    //ModelMonitorDisplay.ShowUnusedTypes();

    Console.WriteLine();
    Console.WriteLine("Renaming enums");
    var renamedCount = RenameEnumTypes();
    Console.WriteLine($"Renamed {renamedCount} enum types");
    //ModelMonitorDisplay.ShowTypeRenames();

    //Console.WriteLine();
    //Console.WriteLine("Reflecting remaining types");
    //int reflectedCount;
    //do
    //{
    //  reflectedCount = TypeManager.ReflectRemainingTypes();
    //  Console.WriteLine($"Reflected {reflectedCount} types");
    //} while (reflectedCount > 0);

    //Console.WriteLine();
    //Console.WriteLine("Renaming namespaces");
    //renamedCount = RenameNamespaces();
    //Console.WriteLine($"Renamed {renamedCount} types");

    //TypeManager.GenerationMode = true;

    //Console.WriteLine();
    //ModelMonitorDisplay.ShowNamespaceDetails(new ShowOptions
    //{
    //  //ShowOptions.OriginalNames
    //  BaseTypes = true,
    //  //| ShowOptions.GenericParamsConstraints 
    //  //| ShowOptions.ImplementedInterfaces
    //  //| ShowOptions.OutgoingRelationships
    //  //| ShowOptions.IncomingRelationships
    //  //| ShowOptions.EnumValues
    //  Properties = true,
    //  //| ShowOptions.HideUnacceptedProperties
    //  //| ShowOptions.HideUnacceptedTypeDetails
    //  //| ShowOptions.IncludedTypes
    //});
    //return;
    Console.WriteLine();

    var ok = TypeManager.TryGetTypeInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), out var model);

    if (!Directory.Exists(IntfOutputPath))
      Directory.CreateDirectory(IntfOutputPath);
    ModelGenerator.ClearProjectFolder(IntfOutputPath);
    ModelGenerator.GenProjectFile(IntfProjectName, Path.Combine(IntfOutputPath, IntfProjectName + ".csproj"));

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
      ModelMonitorDisplay.WriteSameLine($"Generated {generatedCount} types. {typeInfo.GetFullName(false, true)}");
      ModelGenerator.GenerateTypeFile(typeInfo, IntfOutputPath, ImplOutputPath);
    }
  }

  #region Check types
  private bool CanGenerateType(Type type, [NotNullWhen(true)] out TypeInfo? typeInfo)
  {
    typeInfo = null;
    var typeName = type.ToString();
    if (typeName.Contains('<') || typeName.Contains('+'))
      return false;
    if (ModelData.IsExcluded(type))
      return false;
    typeInfo = TypeManager.RegisterType(type);
    return true;
  }

  private int CheckTypeUsage()
  {
    var count = 0;
    foreach (var typeInfo in TypeManager.AcceptedTypes.ToArray())
    {
      typeInfo.UsageCount = CheckTypeUsage(typeInfo);
      if (typeInfo.UsageCount > 0)
        count++;
    }
    return count;
  }

  public int CheckTypeUsage(TypeInfo typeInfo, Action<TypeInfo>? OnStartChecking = null)
  {
    if (typeInfo.UsesEvaluated)
      return 0;
    typeInfo.UsesEvaluated = true;

    if (OnStartChecking != null)
      OnStartChecking(typeInfo);
    if (typeInfo.Name == "ColorType")
      Debug.Assert(true);

    if (!typeInfo.IsReflected)
      typeInfo.WaitForReflection();
    if (typeInfo.IsAccepted == null)
      typeInfo.IsAccepted = true;

    var count = 0;
    count++;
    if (typeInfo.BaseTypeInfo != null)
      count += CheckTypeUsage(typeInfo.BaseTypeInfo, OnStartChecking);

    if (typeInfo.Properties != null)
      foreach (var prop in typeInfo.Properties.ToArray())
      {
        if (prop.IsAccepted != false)
        {
          var propType = prop.PropertyType.GetConversionTarget(true);
          if (propType.IsAccepted != false)
          {
            count += CheckTypeUsage(propType, OnStartChecking);
          }
        }
      }

    var interfaces = typeInfo.GetInterfaces();
    if (interfaces.Any())
      foreach (var intfType in interfaces.ToArray())
      {
        if (intfType.IsAccepted != false)
        {
          count += CheckTypeUsage(intfType, OnStartChecking);
        }
      }

    var includedTypes = typeInfo.GetIncludedTypes();
    if (includedTypes.Any())
      foreach (var incType in includedTypes.ToArray())
      {
        if (incType.IsAccepted != false)
        {
          count += CheckTypeUsage(incType, OnStartChecking);
        }
      }
    return count;
  }

  #endregion

  #region Name/Type translation

  //private string NewNamespace(string aNamespace)
  //{
  //  return aNamespace.Replace("DocumentFormat.OpenXml", "DocumentModel");
  //}


  private int RenameEnumTypes()
  {
    int changeCount = 0;
    foreach (var nspace in TypeManager.GetNamespaces())
    {
      var nspaceTypes = TypeManager.GetNamespaceTypes(nspace);
      foreach (var typeInfo in nspaceTypes.Where(item => item.TypeKind == TypeKind.Enum).ToArray())
      {
        var newName = NewEnumTypeName(typeInfo.Type);
        if (!nspaceTypes.Any(item => item != typeInfo && item.Name == newName && item.IsAccepted == true))
        {
          typeInfo.Name = newName;
          changeCount++;
        }
      }
    }
    return changeCount;
  }

  private string NewEnumTypeName(Type type)
  {
    var typeName = type.Name;
    if (typeName.EndsWith("Values"))
    {
      typeName = typeName.Substring(0, typeName.Length - "Values".Length);
      if (typeName.EndsWith("Type"))
      {
        typeName.Substring(0, typeName.Length - "Type".Length);
        typeName = typeName + "Kind";
      }
      else
      if (!typeName.EndsWith("Mode"))
      {
        typeName = typeName + "Kind";
      }
    }
    return typeName;
  }

  //private int RenameNamespaces()
  //{
  //  int count = 0;
  //  foreach (var typeInfo in TypeManager.AllTypes)
  //  {
  //    var nspace = typeInfo.Namespace;
  //    if (nspace.StartsWith("DocumentFormat.OpenXml"))
  //    {
  //      count++;
  //      typeInfo.Namespace = nspace.Replace("DocumentFormat.OpenXml", "DocumentModel");
  //    }
  //  }
  //  return count;
  //}

  //private string NewNamespace(TypeInfo typeInfo)
  //{
  //  var nspace = typeInfo.Namespace;
  //  if (nspace.StartsWith("DocumentFormat.OpenXml"))
  //    return nspace.Replace("DocumentFormat.OpenXml", "DocumentModel");
  //  return nspace;
  //}

  #endregion



}