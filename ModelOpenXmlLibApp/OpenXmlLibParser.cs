using System.Data;
using System.Reflection;

using ModelOpenXmlLib;

namespace ModelOpenXmlLibApp;


/// <summary>
/// Parser that reads XML schema files and stores the schema in a database.
/// </summary>
public class OpenXmlLibParser
{
  public string SourceDllPath { get; set; } = null!;
  public int FilesTotal, FilesAdded;
  public int NamespacesTotal, NamespacesAdded;
  public int FileNamespacesTotal, FileNamespacesAdded;
  public int TypesTotal, TypesAdded, TypesUpdated;
  public int PropertiesTotal, PropertiesAdded, PropertiesUpdated;
  public int EnumValuesTotal, EnumValuesAdded;

  public void ParseLibraries(string sourceDllPath, string dbFilename)
  {
    SourceDllPath = sourceDllPath;
    MetadataLoadContext metadataLoadContext = LoadLibraryFiles();
    using (dbContext = new LibDbContext(dbFilename))
    {
      dbContext.ChangeTracker.LazyLoadingEnabled = false;
      ParseOpenXmlFilesAndNamespaces(metadataLoadContext);
      ParseAssemblies(metadataLoadContext);
      dbContext.DisplayMessageEnabled = false;
      FilesTotal = dbContext.Files.Count();
      NamespacesTotal = dbContext.Namespaces.Count();
      FileNamespacesTotal = dbContext.FileNamespaces.Count();
      TypesTotal = dbContext.Types.Count();
      EnumValuesTotal = dbContext.EnumValues.Count();
      PropertiesTotal = dbContext.Properties.Count();
    }
  }

  internal LibDbContext dbContext = null!;

  internal int SaveChanges()
  {
    try
    {
      var changes = dbContext.SaveChanges();
      return changes;
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      //throw;
      return -1;
    }
  }

  internal void Write(string? message)
  {
    Console.Write(message);
  }

  internal void WriteLine(string? message)
  {
    Console.WriteLine(message);
  }

  internal MetadataLoadContext LoadLibraryFiles()
  {

    var assemblyPaths = Directory.GetFiles(SourceDllPath, "*.dll");
    var resolver = new PathAssemblyResolver(assemblyPaths);
    var metadataLoadContext = new MetadataLoadContext(resolver);
    foreach (var assemblyPath in assemblyPaths)
    {
      var assembly = metadataLoadContext.LoadFromStream(File.Open(assemblyPath, FileMode.Open, FileAccess.Read, FileShare.Read));
      //WriteLine(assembly.GetName().Name);
    }
    return metadataLoadContext;
  }

  internal void ParseOpenXmlFilesAndNamespaces(MetadataLoadContext metadataLoadContext)
  {
    var assemblies = metadataLoadContext.GetAssemblies();
    dbContext.LoadFiles();
    foreach (var assembly in metadataLoadContext.GetAssemblies())
    {
      var filename = Path.GetFileNameWithoutExtension(Path.GetFileName(assembly.GetFiles().First().Name));

      if (!dbContext.FilesDictionary.TryGetValue(filename, out var libFile))
      {
        WriteLine($"Adding file {filename}");
        libFile = new LibFile { FileName = filename };
        dbContext.Files.Add(libFile);
        if (SaveChanges() > 0)
          FilesAdded++;
      }

      foreach (var grouping in assembly.DefinedTypes.AsQueryable().Where(item => !item.Name.StartsWith("<")).GroupBy(item => item.Namespace))
      {
        var ns = grouping.Key;
        if (!string.IsNullOrEmpty(ns) /*&& !ns.StartsWith("System")*/)
        {
          WriteLine($"Checking namespace {ns}");
          if (!dbContext.NamespaceDictionary.TryGetValue(ns, out var libNamespace))
          {
            libNamespace = new Namespace { Name = ns };
            dbContext.Namespaces.Add(libNamespace);
            if (SaveChanges() > 0)
              NamespacesAdded++;
          }

          var fileNamespace = dbContext.FileNamespaces.FirstOrDefault(u => u.NamespaceId == libNamespace.Id && u.FileId == libFile.Id);
          if (fileNamespace == null)
          {
            fileNamespace = new FileNamespace { NamespaceId = libNamespace.Id, FileId = libFile.Id };
            dbContext.FileNamespaces.Add(fileNamespace);
            if (SaveChanges() > 0)
              FileNamespacesAdded++;
          }
        }
      }
    }
  }

  internal void ParseAssemblies(MetadataLoadContext metadataLoadContext)
  {
    dbContext.LoadNamespaces();
    dbContext.DisplayMessageEnabled = false;
    var assemblies = metadataLoadContext.GetAssemblies();

    foreach (var assembly in metadataLoadContext.GetAssemblies())
    {
      foreach (var typeDefinition in assembly.ExportedTypes)
      {
        var ns = typeDefinition.Namespace;
        var name = typeDefinition.Name;
        if (!String.IsNullOrEmpty(ns) && !ns.StartsWith("System") && !String.IsNullOrEmpty(name) && !name.StartsWith("<") && !typeDefinition.IsGenericMethodParameter)
        {

          if (!dbContext.NamespaceDictionary.TryGetValue(ns, out var libNamespace))
            throw new InvalidDataException($"Namespace {ns} not found");
          ParseType(libNamespace, typeDefinition);
        }
      }
    };
  }

  internal bool ParseType(Namespace ns, Type assType)
  {
    var added = false;
    var updated = false;
    var typeName = assType.Name;
    Write($"Checking type {ns.Name}.{typeName} ... ");

    //var libType = ns.Types?.FirstOrDefault(t => t.Name == typeName);
    //if (libType == null)
    if (!ns.TypesDictionary.TryGetValue(typeName, out var libType))
    {
      WriteLine($"added");
      libType = new TypeDef { Name = typeName, OwnerNamespaceId = ns.Id };
      dbContext.Types.Add(libType);
      ParseTypeDetails(libType, assType);
      if (SaveChanges() > 0)
        TypesAdded++;
      else
        throw new InvalidDataException($"Type {ns.Name}.{typeName} not added");

      ParseBaseType(libType, assType);
      added = true;
    }
    else
    {
      updated = ParseTypeDetails(libType, assType);
      if (ParseBaseType(libType, assType)) 
        updated = true;
    }
    if (!added)
      if (updated)
      {
        WriteLine("updated");
        TypesUpdated++;
      }
      else
        WriteLine("ok");
    ParseTypeMembers(libType, assType);
    return added || updated;
  }

  internal bool ParseTypeDetails(TypeDef libType, Type assType)
  {
    if (assType.IsEnum)
      return ParseEnumTypeDetails(libType, assType);
    else if (assType.IsClass || assType.IsInterface)
      return ParseClassTypeDetails(libType, assType);
    else if (assType.IsValueType)
      return ParseValueTypeDetails(libType, assType);
    else
      throw new InvalidDataException($"Type {libType.Name} kind must be enum, value or class");
  }

  internal bool ParseValueTypeDetails(TypeDef libType, Type assType)
  {
    if (assType.IsGenericTypeParameter)
      return false;
    var interfaces = assType.GetInterfaces();
    if (interfaces.FirstOrDefault(item => item.Name == "IEnumValueFactory`1") != null)
    {
      var changed = false;
      if (libType.Kind != TypeKind.Enum)
      {
        libType.Kind = TypeKind.Enum;
        changed = true;
      }
      return changed;
    }
    return ParseStructTypeDetails(libType, assType);
  }

  internal bool ParseEnumTypeDetails(TypeDef libType, Type assType)
  {
    var changed = false;
    if (libType.Kind != TypeKind.Enum)
    {
      libType.Kind = TypeKind.Enum;
      changed = true;
    }
    return changed;
  }

  public bool ParseStructTypeDetails(TypeDef libType, Type assType)
  {
    if (assType.IsGenericTypeParameter)
      return false;
    var changed = false;
    if (libType.Kind != TypeKind.Struct)
    {
      libType.Kind = TypeKind.Struct;
      changed = true;
    }
    if (libType.IsAbstract != assType.IsAbstract)
    {
      libType.IsAbstract = assType.IsAbstract;
      changed = true;
    }
    return changed;
  }

  public bool ParseClassTypeDetails(TypeDef libType, Type assType)
  {
    if (assType.IsGenericTypeParameter)
      return false;
    var changed = false;
    var kind = assType.IsInterface ? TypeKind.Interface : TypeKind.Class;
    if (libType.Kind != kind)
    {
      libType.Kind = kind;
      changed = true;
    }
    if (libType.IsAbstract != assType.IsAbstract)
    {
      libType.IsAbstract = assType.IsAbstract;
      changed = true;
    }
    return changed;
  }

  internal int ParseTypeMembers(TypeDef libType, Type assType)
  {
    if (assType.IsEnum)
      return ParseEnumValues(libType, assType);
    else if (assType.IsClass || assType.IsInterface)
      return ParseProperties(libType, assType);
    else if (assType.IsValueType)
    {
      if (libType.Kind == TypeKind.Enum)
        return ParseStaticProperties(libType, assType);
      return ParseProperties(libType, assType);
    }
    return 0;
  }

  internal int ParseEnumValues(TypeDef libType, Type typeDefinition)
  {
    int added = 0;
    int ordNum = 0;
    foreach (FieldInfo field in typeDefinition.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
    {
      if (field.IsLiteral && !field.IsInitOnly)
      {
        if (!libType.EnumValuesDictionary.TryGetValue(field.Name, out var enumValue))
        {
          enumValue = new EnumValue { OwnerTypeId = libType.Id, Name = field.Name, OrdNum = ordNum };
          dbContext.EnumValues.Add(enumValue);
          if (SaveChanges() > 0)
          {
            EnumValuesAdded++;
            added++;
          }
        }
        ordNum++;
      }
    }
    return added;
  }

  internal int ParseStaticProperties(TypeDef libType, Type typeDefinition)
  {
    int added = 0;
    int ordNum = 0;
    foreach (PropertyInfo property in typeDefinition.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
    {
      added++;
      if (!libType.EnumValuesDictionary.TryGetValue(property.Name, out var enumValue))
      {
        enumValue = new EnumValue { OwnerTypeId = libType.Id, Name = property.Name, OrdNum = ordNum };
        dbContext.EnumValues.Add(enumValue);
        if (SaveChanges() > 0)
        {
          EnumValuesAdded++;
        }
      }
      ordNum++;
    }
    return added;
  }

  public int ParseProperties(TypeDef libType, Type typeDefinition)
  {
    int changed = 0;
    int ordNum = 0;
    foreach (PropertyInfo property in typeDefinition.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
    {
      if (property.CanWrite)
      {
        if (ParseProperty(libType, property, ordNum)) 
          changed++;
        ordNum++;
      }
    }
    return changed;
  }

  internal bool ParseProperty(TypeDef libType, PropertyInfo property, int ordNum)
  {
    bool added = false;
    bool updated = false;
    if (!libType.PropertiesDictionary.TryGetValue(property.Name, out var libProperty))
    {
      libProperty = new Property { OwnerTypeId = libType.Id, Name = property.Name, OrdNum = ordNum };
      dbContext.Properties.Add(libProperty);
      if (SaveChanges() > 0)
      {
        PropertiesAdded++;
        added = true;
      }
      else
        throw new InvalidDataException($"Property {libType.Name}.{property.Name} not added");
      ParsePropertyValueType(libProperty, property);
    }
    else
    {
      if (ParsePropertyDetails(libProperty, property, ordNum))
      {
        PropertiesUpdated++;
        updated = true;;
      }
      if (ParsePropertyValueType(libProperty, property))
      {
        if (!updated)
          PropertiesUpdated++;
        updated = true;
      }
    }
    return added || updated;
  }

  internal bool ParsePropertyDetails(Property libProperty, PropertyInfo property, int ordNum)
  {
    var changed = false;
    if (libProperty.OrdNum != ordNum)
    {
      libProperty.OrdNum = ordNum;
      changed = true;
    }
    return changed;
  }

  internal bool ParsePropertyValueType(Property libProperty, PropertyInfo property)
  {
    var changed = false;
    var valueTypeDef = CheckType(property.PropertyType);
    if (libProperty.ValueTypeId != valueTypeDef.Id)
    {
      SaveChanges();
      libProperty.ValueTypeId = valueTypeDef.Id;
      changed = true;
    }
    if (changed)
      SaveChanges();
    return changed;
  }

  internal bool ParseBaseType(TypeDef libType, Type assType)
  {
    if (assType.BaseType == null)
      return false;

    var baseTypeDef = CheckType(assType.BaseType);
    var changed = false;
    if (libType.BaseTypeId != baseTypeDef.Id)
    {
      SaveChanges();
      libType.BaseTypeId = baseTypeDef.Id;
      changed = true;
    }
    if (changed)
      SaveChanges();
    return changed;
  }

  internal TypeDef CheckType(Type assType)
  {
    if (assType.Namespace == null)
      throw new InvalidDataException($"Namespace of {assType} is null");
    if (!dbContext.NamespaceDictionary.TryGetValue(assType.Namespace, out var ns))
      throw new InvalidDataException($"Namespace {assType.Namespace} not found");
    var typeName = assType.Name;
    if (!ns.TypesDictionary.TryGetValue(typeName, out var libType))
    {
      libType = new TypeDef { Name = typeName, OwnerNamespaceId = ns.Id };
      ParseTypeDetails(libType, assType);
      dbContext.Types.Add(libType);
      if (SaveChanges() > 0)
        TypesAdded++;
    }
    else
    {
      if (ParseTypeDetails(libType, assType))
        if (SaveChanges() > 0)
          TypesUpdated++;
    };
    return libType;
  }

}
