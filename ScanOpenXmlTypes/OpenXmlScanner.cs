using System.Configuration;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;
using OpenXmlDatabase;

using OpenXmlModels = OpenXmlDatabase.Models;
using OpenXmlType = OpenXmlDatabase.Models.Type;
using Type = System.Type;
using Assembly = System.Reflection.Assembly;
using DocumentFormat.OpenXml.Wordprocessing;

namespace ScanOpenXmlTypes;

public partial class OpenXmlScanner : IDisposable, IAsyncDisposable
{
  public OpenXmlScanner()
  {
    OpenXmlAssembly = typeof(DocumentFormat.OpenXml.Wordprocessing.Document).Assembly;
    OpenXmlFrameworkAssembly = typeof(DocumentFormat.OpenXml.OpenXmlElement).Assembly;
    OpenXmlDatabase = new OpenXmlModels.ModelContext();
    OpenXmlDatabase.Database.EnsureCreated();
  }

  public void ScanAssembly()
  {
    AssembliesIndex = new AssembliesIndex(OpenXmlDatabase.Assemblies.ToList());
    NamespacesIndex = new NamespacesIndex(OpenXmlDatabase.Namespaces.ToList());
    ScanTypes();
  }

  readonly Assembly OpenXmlAssembly;
  readonly Assembly OpenXmlFrameworkAssembly;
  readonly OpenXmlModels.ModelContext OpenXmlDatabase;
  AssembliesIndex AssembliesIndex = null!;
  NamespacesIndex NamespacesIndex = null!;
  public int VerboseLevel { get; set; } = 3;
  int foundTypesCount;
  int modifiedTypesCount;
  int addedTypesCount;
  int foundArgTypesCount;
  int addedArgTypesCount;
  int foundPropsCount;
  int addedPropsCount;
  int modifiedPropsCount;

  private int Indent = 0;
  private string IndentStr => (Indent < 3) ? "\n" : "" +
                              new String(' ', Indent);

  private readonly HashSet<Type> ProcessedTypes = new();

  public void CountTypesInAssembly()
  {
    Dictionary<System.Type, List<System.Type>> allTypes = new();
    HashSet<System.Type> propTypes = new();
    foreach (var type in OpenXmlAssembly.GetTypes())
    {
      if (!type.IsAbstract && type.IsClass && type.Namespace != null && !type.Namespace.StartsWith("System") &&
          !type.FullName!.Contains("+"))
      {
        Console.WriteLine(GetFullName(type));
        allTypes.Add(type, new List<System.Type>());
        foreach (var property in type.GetProperties())
        {
          var propType = property.PropertyType;
          if (!propType.IsAbstract && propType.IsClass && propType.Namespace != null &&
              !propType.Namespace!.StartsWith("System") && !propType.FullName!.Contains("+"))
          {
            Console.WriteLine($"  {property.Name} : {propType.Name}");
            allTypes[type].Add(propType);
            propTypes.Add(propType);
          }
        }
      }
    }
    Console.WriteLine($"All  types {allTypes.Count}");
    Console.WriteLine($"Prop types {propTypes.Count}");
    Console.WriteLine($"Comp types {allTypes.Count - propTypes.Count}");
  }

  public void ListNamespacesInDatabase()
  {
    foreach (var ns in OpenXmlDatabase.Namespaces)
    {
      Console.WriteLine($"{ns.Id} {ns.Name} {ns.Prefix}");
    }
  }

  public void ListTypesInDatabase()
  {
    foreach (var type in OpenXmlDatabase.Types)
    {
      Console.WriteLine($"{type.Id} {type.Name} {type.NamespaceId}");
    }
  }

  public void ScanTypes()
  {
    if (VerboseLevel > 0)
      Console.WriteLine($"Scanning types");
    foreach (var type in OpenXmlAssembly.GetTypes())
    {
      foundTypesCount++;
      if (VerboseLevel == 1)
        if (foundTypesCount % 100 == 0)
          Console.Write(".");
      TryAddType(type);
    }
    if (VerboseLevel > 0)
    {
      Console.WriteLine();
      Console.WriteLine($"Added types {addedTypesCount}");
      Console.WriteLine($"Modified types {modifiedTypesCount}");
      Console.WriteLine($"Added arg types {addedArgTypesCount}");
      Console.WriteLine($"Added properties {addedPropsCount}");
      Console.WriteLine($"Modified properties {modifiedPropsCount}");
    }
  }


  private OpenXmlModels.Type? TryAddType(Type type, string? declaringNamespace = null)
  {
    OpenXmlModels.Type? openXmlType = null;
    var typeName = type.Name;
    if (typeName.Contains("<"))
    {
      return openXmlType;
    }
    Indent++;
    var asmName = type.Assembly.GetName().Name!;

    if (!AssembliesIndex.TryGetValue(asmName, out var assembly))
    {
      OpenXmlDatabase.Assemblies.Add(assembly = new OpenXmlModels.Assembly { Name = asmName });
      OpenXmlDatabase.SaveChanges();
      AssembliesIndex.Add(assembly.Name!,
        assembly);
    }
    var assemblyId = assembly.Id;


    var nsName = type.Namespace;
    if (type.IsConstructedGenericType && HasOpenXmlTypeSpecificTypeArg(type))
    {
      if (declaringNamespace == null)
        throw new InvalidOperationException($"Constructed generic type {GetFullName(type)} must have declaring namespace");
      Debug.WriteLine($"TryAddType({GetFullName(type, false)}, {nsName}, {declaringNamespace})");
      nsName = declaringNamespace;
    }
    if (nsName != null)
    {
      if (!NamespacesIndex.TryGetValue(nsName, out var nspace))
      {
        OpenXmlDatabase.Namespaces.Add(nspace = new OpenXmlModels.Namespace { Name = nsName });
        OpenXmlDatabase.SaveChanges();
        NamespacesIndex.Add(nspace.Name!,
          nspace);
      }
      TypeKind kind = type.IsInterface ? TypeKind.Interface : type.IsValueType ? TypeKind.Struct : TypeKind.Class;

      OpenXmlModels.Type? parentType = null;
      var isNested = type.IsNested;
      if (isNested)
      {
        var declaringType = type.DeclaringType;
        if (declaringType != null)
          parentType = TryAddType(declaringType, declaringNamespace);
        if (declaringNamespace == null)
          declaringNamespace = GetFullName(declaringType, false);
      }

      OpenXmlModels.Type? superType = null;
      if (type.BaseType != null && type.BaseType.Namespace?.StartsWith("DocumentFormat.OpenXml") == true)
      {
        superType = TryAddType(type.BaseType, declaringNamespace);
      }
      var superTypeId = superType?.Id;



      var parentTypeId = parentType?.Id;
      var isAbstract = type.IsAbstract;
      var isGeneric = type.IsConstructedGenericType;
      if (isGeneric)
      {
        typeName = GetShortName(type);
      }
      openXmlType = OpenXmlDatabase.Types
        .FirstOrDefault(t => t.Name == typeName && t.Namespace == nspace && t.ParentTypeId == parentTypeId);
      if (openXmlType == null)
      {
        OpenXmlDatabase.Types.Add(openXmlType = new OpenXmlModels.Type
        {
          Name = typeName,
          Namespace = nspace,
          AssemblyId = assemblyId,
          Kind = (byte)kind,
          SuperTypeId = superTypeId,
          IsAbstract = isAbstract,
          IsGeneric = isGeneric,
          IsNested = isNested,
          ParentTypeId = parentTypeId
        });
        OpenXmlDatabase.SaveChanges();
        if (VerboseLevel >= 2)
          Console.WriteLine($"{IndentStr}Type {GetFullName(type)}added");
        addedTypesCount++;
      }
      else if (openXmlType.Kind != (byte)kind ||
               openXmlType.AssemblyId != assemblyId ||
               openXmlType.IsAbstract != isAbstract ||
               openXmlType.IsGeneric != isGeneric ||
               openXmlType.SuperTypeId != superTypeId ||
               openXmlType.IsNested != isNested ||
               openXmlType.ParentTypeId != parentTypeId)
      {
        openXmlType.Kind = (byte)kind;
        openXmlType.AssemblyId = assemblyId;
        openXmlType.IsAbstract = isAbstract;
        openXmlType.IsGeneric = isGeneric;
        openXmlType.SuperTypeId = superTypeId;
        openXmlType.IsNested = isNested;
        openXmlType.ParentTypeId = parentTypeId;
        if (VerboseLevel >= 1)
          Console.WriteLine($"{IndentStr}Type {GetFullName(type)} modified");
        modifiedTypesCount++;
        OpenXmlDatabase.SaveChanges();
      }
      else
      {
        if (VerboseLevel >= 3)
          Console.WriteLine($"{IndentStr}Type {GetFullName(type)} OK");
        else
        if (VerboseLevel == 2)
          if (foundTypesCount % 100 == 0)
            Console.Write(".");
      }
      if (isGeneric)
      {
        byte argIndex = 0;
        foreach (var arg in type.GetGenericArguments())
        {
          argIndex++;
          foundArgTypesCount++;
          var argType = TryAddType(arg, declaringNamespace);
          if (argType != null)
          {
            var genericArgRel = OpenXmlDatabase.GenericTypeArgs.FirstOrDefault(g =>
              g.GenericTypeId == openXmlType.Id && g.ArgNo == argIndex && g.ArgTypeId == argType.Id);
            if (genericArgRel == null)
            {
              OpenXmlDatabase.GenericTypeArgs.Add(genericArgRel = new OpenXmlModels.GenericTypeArg
              {
                ArgNo = argIndex,
                GenericTypeId = openXmlType.Id,
                ArgTypeId = argType.Id
              });
              OpenXmlDatabase.SaveChanges();
              addedArgTypesCount++;
            }
          }
        }
      }
      if (type.Namespace?.StartsWith("DocumentFormat.OpenXml") == true)
        ScanTypeProperties(openXmlType, type, declaringNamespace);
    }
    Indent--;
    return openXmlType;
  }

  public void ScanTypeProperties(OpenXmlModels.Type openXmlType, System.Type type, string? declaringNamespace = null)
  {
    if (!ProcessedTypes.Add(type)) return;

    if (type.Name.EndsWith("Values"))
    {
      var properties = type.GetProperties
        (BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Static);
      foreach (var prop in properties)
      {
        foundPropsCount++;
        TryAddProperty(openXmlType, prop, declaringNamespace);
      }
    }
    else
    {
      var properties = type.GetProperties
        (BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
      foreach (var prop in properties)
      {
        if (prop.SetMethod == null || prop.GetMethod == null) continue;
        foundPropsCount++;
        TryAddProperty(openXmlType, prop, declaringNamespace);
      }
    }
  }

  private OpenXmlModels.Property? TryAddProperty(OpenXmlModels.Type openXmlType, PropertyInfo prop, string? declaringNamespace = null)
  {

    Debug.WriteLine($"TryAddProperty({GetFullName(openXmlType, false)},{prop.Name},{declaringNamespace})");
    if (declaringNamespace == null)
      declaringNamespace = prop.DeclaringType?.Namespace;
    Indent++;
    OpenXmlModels.Property? openXmlProp = null;
    var parentTypeId = openXmlType.Id;
    var propName = prop.Name;
    var type = prop.DeclaringType;
    OpenXmlType? valueType;
    if (prop.PropertyType == prop.DeclaringType)
      valueType = openXmlType;
    else
    {
      valueType = TryAddType(prop.PropertyType, declaringNamespace);
    }
    if (valueType == null)
      throw new InvalidOperationException($"Property {GetFullName(type)}{prop.Name} can register type {prop.PropertyType}");
    var valueTypeId = valueType?.Id;
    var isPublic = prop.GetMethod?.IsPublic == true;
    var isStatic = prop.GetMethod?.IsStatic == true;
    var isAbstract = prop.GetMethod?.IsAbstract == true;
    var isVirtual = prop.GetMethod?.IsVirtual == true;
    var isOverride = prop.GetMethod?.IsVirtual == true && prop.DeclaringType?.BaseType?.GetProperty(prop.Name) != null;
    if (type != null)
    {
      openXmlProp = OpenXmlDatabase.Properties
        .FirstOrDefault(p => p.ParentTypeId == parentTypeId && p.Name == propName);
      if (openXmlProp == null)
      {
        OpenXmlDatabase.Properties.Add(openXmlProp = new OpenXmlModels.Property
        {
          ParentTypeId = parentTypeId,
          Name = prop.Name,
          ValueTypeId = valueTypeId,
          IsPublic = isPublic,
          IsStatic = isStatic,
          IsAbstract = isAbstract,
          IsVirtual = isVirtual,
          IsOverride = isOverride,
        });
        OpenXmlDatabase.SaveChanges();
        if (VerboseLevel >= 2)
          Console.WriteLine($"{IndentStr}Property {prop.Name} added");
        addedPropsCount++;
      }
      else if (openXmlProp.ValueTypeId != valueTypeId ||
               openXmlProp.IsPublic != isPublic ||
               openXmlProp.IsStatic != isStatic ||
               openXmlProp.IsAbstract != isAbstract ||
               openXmlProp.IsVirtual != isVirtual ||
               openXmlProp.IsOverride != isOverride)
      {
        var oldValueTypeId = openXmlProp.ValueTypeId;
        var newValueTypeId = valueTypeId;
        openXmlProp.ValueTypeId = valueTypeId;
        openXmlProp.IsPublic = isPublic;
        openXmlProp.IsStatic = isStatic;
        openXmlProp.IsAbstract = isAbstract;
        openXmlProp.IsVirtual = isVirtual;
        openXmlProp.IsOverride = isOverride;
        if (VerboseLevel >= 1)
          Console.WriteLine($"{IndentStr}Property {GetFullName(prop.DeclaringType)}.{prop.Name} ValueTypeId modified from {oldValueTypeId} to {newValueTypeId}");
        modifiedPropsCount++;
        OpenXmlDatabase.SaveChanges();
      }
      else
      {
        if (VerboseLevel >= 3)
          Console.WriteLine($"{IndentStr}Property {prop.Name} OK");
      }

    }
    Indent--;
    return openXmlProp;
  }

  private string? GetShortName(Type? type)
  {
    if (type == null)
      return null;
    string fullName = "";
    fullName += type.Name;
    if (type.IsGenericType)
    {
      fullName = fullName.Substring(0, fullName.IndexOf("`"));
      fullName += "<";
      var argIndex = 0;
      foreach (var arg in type.GetGenericArguments())
      {
        if (argIndex++ > 0)
          fullName += ",";
        fullName += GetFullName(arg, true, type.Namespace);
      }
      fullName += ">";
    }
    return fullName;
  }

  private string? GetFullName(Type? type, bool simplifyNamespaces = true, string? omitNamespace = null)
  {
    if (type == null)
      return null;
    string fullName = "";
    var ns = type.Namespace;
    if (ns != null && (!simplifyNamespaces || !(ns.StartsWith("System") || (omitNamespace != null && ns.StartsWith(omitNamespace)))))
      fullName = ns + ".";
    fullName += type.Name;
    if (type.IsGenericType)
    {
      fullName = fullName.Substring(0, fullName.IndexOf("`"));
      fullName += "<";
      var argIndex = 0;
      foreach (var arg in type.GetGenericArguments())
      {
        if (argIndex++ > 0)
          fullName += ",";
        fullName += GetFullName(arg, simplifyNamespaces);
      }
      fullName += ">";
    }
    return fullName;
  }

  private string? GetFullName(OpenXmlType? type, bool simplifyNamespaces = true, string? omitNamespace = null)
  {
    if (type == null)
      return null;
    string fullName = "";
    var ns = type.Namespace?.Name;
    if (ns != null && (!simplifyNamespaces || !(ns.StartsWith("System") || (omitNamespace != null && ns.StartsWith(omitNamespace)))))
      fullName = ns + ".";
    fullName += type.Name;
    if (type.IsGeneric == true && fullName.Contains('\''))
    {
      fullName = fullName.Substring(0, fullName.IndexOf("`"));
      fullName += "<";
      var argIndex = 0;
      foreach (var arg in GetGenericArguments(type))
      {
        if (argIndex++ > 0)
          fullName += ",";
        fullName += GetFullName(arg, simplifyNamespaces);
      }
      fullName += ">";
    }
    return fullName;
  }

  private IEnumerable<OpenXmlType> GetGenericArguments(OpenXmlType type)
  {
    return OpenXmlDatabase.GenericTypeArgs
       .Where(g => g.GenericTypeId == type.Id)
       .Select(g => OpenXmlDatabase.Types.First(t => t.Id == g.ArgTypeId));
  }

  private bool HasOpenXmlTypeSpecificTypeArg(Type type)
  {
    if (type.IsConstructedGenericType)
    {
      foreach (var arg in type.GetGenericArguments())
      {
        if (HasOpenXmlTypeSpecificTypeArg(arg))
          return true;
      }
    }
    var ns = type.Namespace;
    if (ns == null)
      return false;
    return ns.StartsWith("DocumentFormat.OpenXml") && ns.Length > "DocumentFormat.OpenXml".Length;
  }

  public void Dispose()
  {
    OpenXmlDatabase.Dispose();
  }

  public async ValueTask DisposeAsync()
  {
    await OpenXmlDatabase.DisposeAsync();
  }
}
