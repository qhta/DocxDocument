using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using OpenXmlDatabase;

using OpenXmlModels = OpenXmlDatabase.Models;
using Type = System.Type;

namespace ScanOpenXmlTypes;
public class OpenXmlScanner : IDisposable, IAsyncDisposable
{
  public OpenXmlScanner()
  {
    OpenXmlDatabase = new OpenXmlModels.ModelContext();
    OpenXmlDatabase.Database.EnsureCreated();
  }

  public void Scan()
  {
    NamespacesIndex = new NamespacesIndex(OpenXmlDatabase.Namespaces.ToList());
    ScanTypesToDatabase(); 
    //ScanPropertiesToDatabase();
  }

  readonly Assembly OpenXmlAssembly = typeof(DocumentFormat.OpenXml.Wordprocessing.Document).Assembly;
  readonly OpenXmlModels.ModelContext OpenXmlDatabase;
  NamespacesIndex NamespacesIndex = null!;
  readonly int VerboseLevel = 2;
  int foundTypesCount;
  int modifiedTypesCount;
  int addedTypesCount;
  int foundPropsCount;
  int addedPropsCount;
  int modifiedPropsCount;

  public void CountTypesInAssembly()
  {
    Dictionary<System.Type, List<System.Type>> allTypes = new();
    HashSet<System.Type> propTypes = new();
    foreach (var type in OpenXmlAssembly.GetTypes())
    {
      if (!type.IsAbstract && type.IsClass && type.Namespace != null && !type.Namespace.StartsWith("System") &&
          !type.FullName!.Contains("+"))
      {
        Console.WriteLine(type.FullName);
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

  public void ScanTypesToDatabase()
  {
    if (VerboseLevel > 0)
      Console.WriteLine($"Scanning types to database");
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
    }
  }

  public void ScanPropertiesToDatabase()
  {
    if (VerboseLevel > 0)
      Console.WriteLine($"Scanning properties to database");
    foreach (var type in OpenXmlAssembly.GetTypes())
    {
      foundTypesCount++;
      if (VerboseLevel == 1)
        if (foundTypesCount % 100 == 0)
          Console.Write(".");
      var openXmlType = TryAddType(type);
      if (openXmlType == null)
        continue;
      foreach (var property in type.GetProperties
                 (BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
      {
        foundPropsCount++;
        TryAddProperty(openXmlType, property);
      }
    }
    if (VerboseLevel > 0)
    {
      Console.WriteLine();
      Console.WriteLine($"Added properties {addedPropsCount}");
      Console.WriteLine($"Modified properties {modifiedPropsCount}");
    }
  }

  private OpenXmlModels.Type? TryAddType(Type type)
  {
    OpenXmlModels.Type? openXmlType = null;
    var typeName = type.Name;
    if (typeName.Contains("<"))
    {
      return openXmlType;
    }
    var nsName = type.Namespace;
    if (nsName != null)
    {
      if (!NamespacesIndex.TryGetValue(nsName, out var nspace))
      {
        OpenXmlDatabase.Namespaces.Add(nspace = new OpenXmlModels.Namespace { Name = nsName });
        OpenXmlDatabase.SaveChanges();
        NamespacesIndex.Add(nspace.Name!, nspace);// = OpenXmlDatabase.Namespaces.ToList().ToDictionary(ns => ns.Name!, ns => ns);
      }
      TypeKind kind = type.IsInterface ? TypeKind.Interface : type.IsValueType ? TypeKind.Struct : TypeKind.Class;

      OpenXmlModels.Type? superType = null;
      if (type.BaseType != null && type.BaseType.Namespace?.StartsWith("DocumentFormat.OpenXml")==true)
      {
        superType = TryAddType(type.BaseType);
      }
      var superTypeId = superType?.Id;
      OpenXmlModels.Type? parentType = null;
      var isNested = type.IsNested;
      if (isNested)
      {
        var aTypeName = type.FullName!.Substring(type.Namespace!.Length + 1);
        var parentTypeName = aTypeName.Substring(0, aTypeName.IndexOf("+"));
        parentType = OpenXmlDatabase.Types.FirstOrDefault(t => t.Name == parentTypeName && t.Namespace == nspace);
      }
      var parentTypeId = parentType?.Id;
      openXmlType = OpenXmlDatabase.Types
        .FirstOrDefault(t => t.Name == typeName && t.Namespace == nspace && t.ParentTypeId == parentTypeId);
      if (openXmlType == null)
      {
        OpenXmlDatabase.Types.Add(openXmlType=new OpenXmlModels.Type
        {
          Name = type.Name,
          Namespace = nspace,
          Kind = (byte)kind,
          SuperTypeId = superTypeId,
          IsAbstract = type.IsAbstract,
          IsGeneric = type.IsConstructedGenericType,
          IsNested = isNested,
          ParentTypeId = parentTypeId
        });
        OpenXmlDatabase.SaveChanges();
        if (VerboseLevel > 1)
          Console.WriteLine($"{type.FullName} {kind} added");
        addedTypesCount++;
      }
      {
        if (openXmlType.Kind != (byte)kind || openXmlType.IsAbstract != type.IsAbstract
                                                || openXmlType.IsGeneric != type.IsConstructedGenericType ||
                                                openXmlType.SuperTypeId != superTypeId ||
                                                openXmlType.IsNested != isNested ||
                                                openXmlType.ParentTypeId != parentTypeId)
        {
          openXmlType.Kind = (byte)kind;
          openXmlType.IsAbstract = type.IsAbstract;
          openXmlType.IsGeneric = type.IsConstructedGenericType;
          openXmlType.SuperTypeId = superTypeId;
          openXmlType.IsNested = isNested;
          openXmlType.ParentTypeId = parentTypeId;
          if (VerboseLevel > 1)
            Console.WriteLine($"{type.FullName} modified");
          modifiedTypesCount++;
          OpenXmlDatabase.SaveChanges();
        }
        else
        {
          if (VerboseLevel > 1)
            Console.WriteLine($"{type.FullName} already exists");
        }
      }
    }
    return openXmlType;
  }

  private OpenXmlModels.Property? TryAddProperty(OpenXmlModels.Type openXmlType, PropertyInfo prop)
  {
    OpenXmlModels.Property? openXmlProp = null;
    var propName = prop.Name;
    var type = prop.DeclaringType;
    var nspace = type?.Namespace;
    if (type != null)
    {
      openXmlProp = openXmlType.Properties
        .FirstOrDefault(p => p.Name == propName);
      if (openXmlProp == null)
      {
        openXmlType.Properties.Add(openXmlProp = new OpenXmlModels.Property
        {
          Name = prop.Name,

        });
        OpenXmlDatabase.SaveChanges();
        if (VerboseLevel > 1)
          Console.WriteLine($"\t{prop.Name} added");
        addedPropsCount++;
      }
      //else if (openXmlprop.IsNested != isNested || openXmlprop.Parentprop?.Id != parentpropId)
      //{
      //  openXmlprop.IsNested = isNested;
      //  openXmlprop.Parentprop = parentprop;
      //  if (VerboseLevel > 1)
      //    Console.WriteLine($"{prop.Name} modified");
      //  modifiedpropsCount++;
      //  OpenXmlDatabase.SaveChanges();
      //}
      else
      {
        if (VerboseLevel > 1)
          Console.WriteLine($"\t{prop.Name} already exists");
      }
    }
    return openXmlProp;
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
