using System.Data;
using System.Reflection;

using Microsoft.EntityFrameworkCore.ChangeTracking;

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

  public void ParseSchemaFiles(string sourceDllPath, string dbFilename)
  {
    SourceDllPath = sourceDllPath;
    MetadataLoadContext metadataLoadContext = LoadLibraryFiles();
    using (dbContext = new LibDbContext(dbFilename))
    {
      dbContext.ChangeTracker.LazyLoadingEnabled = false;
      ParseOpenXmlFilesAndNamespaces(metadataLoadContext);
      //SetNamespacePrefixes();
      ParseAssemblies(metadataLoadContext);
      FilesTotal = dbContext.Files.Count();
      NamespacesTotal = dbContext.Namespaces.Count();
      FileNamespacesTotal = dbContext.FileNamespaces.Count();
      TypesTotal = dbContext.Types.Count();
      EnumValuesTotal = dbContext.EnumValues.Count();
      PropertiesTotal = dbContext.Properties.Count();
    }
  }

  internal int AnonSimpleTypes = 0;
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

    foreach (var assembly in metadataLoadContext.GetAssemblies())
    {
      var filename = Path.GetFileNameWithoutExtension(Path.GetFileName(assembly.GetFiles().First().Name));

      var libFile = dbContext.Files.FirstOrDefault(f => f.FileName == filename);
      if (libFile == null)
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
          WriteLine($"Checking namespace {ns} is null or empty = {!String.IsNullOrEmpty(ns) && !ns.StartsWith("System")}");
          var libNamespace = dbContext.Namespaces.FirstOrDefault(n => n.Name == ns);
          if (libNamespace == null)
          {
            WriteLine($"Adding namespace {ns}");
            libNamespace = new Namespace { Name = ns };
            dbContext.Namespaces.Add(libNamespace);
            if (SaveChanges() > 0)
              NamespacesAdded++;
          }

          var fileNamespace = dbContext.FileNamespaces.FirstOrDefault(u => u.NamespaceId == libNamespace.Id && u.FileId == libFile.Id);
          if (fileNamespace == null)
          {
            WriteLine($"Adding File namespace {ns} to file {filename}");
            fileNamespace = new FileNamespace { NamespaceId = libNamespace.Id, FileId = libFile.Id };
            dbContext.FileNamespaces.Add(fileNamespace);
            if (SaveChanges() > 0)
              FileNamespacesAdded++;
          }
        }
      }
    };
  }

  internal void ParseAssemblies(MetadataLoadContext metadataLoadContext)
  {
    var assemblies = metadataLoadContext.GetAssemblies();

    foreach (var assembly in metadataLoadContext.GetAssemblies())
    {
      foreach (var typeDefinition in assembly.ExportedTypes)
      {
        var ns = typeDefinition.Namespace;
        var name = typeDefinition.Name;
        if (!String.IsNullOrEmpty(ns) && !ns.StartsWith("System") && !String.IsNullOrEmpty(name) && !name.StartsWith("<"))
        {
          var libNamespace = dbContext.Namespaces.FirstOrDefault(n => n.Name == ns);
          if (libNamespace == null)
            throw new InvalidDataException($"Namespace {ns} not found");
          ParseType(libNamespace, typeDefinition);
        }
      }
    };
  }

  internal void ParseType(Namespace ns, Type assType)
  {
    var typeName = assType.Name;
    Write($"Checking type {ns.Name}.{typeName} ... ");

    var libType = dbContext.Types.FirstOrDefault(t => t.Name == typeName && t.NamespaceId == ns.Id);
    if (libType == null)
    {
      WriteLine($"added");
      libType = new TypeDef { Name = typeName, NamespaceId = ns.Id };
      dbContext.Types.Add(libType);
      if (SaveChanges() > 0)
        TypesAdded++;
      else
        throw new InvalidDataException($"Type {ns.Name}.{typeName} not added");
      ParseTypeDetails(libType, assType);
      ParseTypeMembers(libType, assType);
      if (ParseBaseType(libType, assType))
        WriteLine($"Base type updated");
    }
    else
    {
      bool updated = false;
      if (ParseTypeDetails(libType, assType))
      {
        WriteLine($"updated");
        updated = true;
        TypesUpdated++;
      }
      else
        WriteLine($"ok");
      ParseTypeMembers(libType, assType);
      if (ParseBaseType(libType, assType) && !updated)
      {
        WriteLine($"Base type of {ns.Name}.{typeName} updated");
        TypesUpdated++;
      }
    }
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
    var interfaces = assType.GetInterfaces();
    if (interfaces.FirstOrDefault(item => item.Name == "IEnumValueFactory`1") != null)
    {
      libType.Kind = TypeKind.Enum;
      return dbContext.SaveChanges() > 0;
    }
    return ParseStructTypeDetails(libType, assType);
  }

  internal bool ParseEnumTypeDetails(TypeDef libType, Type assType)
  {
    libType.Kind = TypeKind.Enum;
    return (SaveChanges() > 0);
  }

  public bool ParseStructTypeDetails(TypeDef libType, Type assType)
  {
    ParseProperties(libType, assType);
    libType.Kind = TypeKind.Struct;
    libType.IsAbstract = assType.IsAbstract;
    return (SaveChanges() > 0);
  }

  public bool ParseClassTypeDetails(TypeDef libType, Type assType)
  {
    libType.Kind = assType.IsInterface ? TypeKind.Interface : TypeKind.Class;
    libType.IsAbstract = assType.IsAbstract;
    return (SaveChanges() > 0);
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
    else
      throw new InvalidDataException($"Type {libType.Name} kind must be enum, value or class");
  }

  internal int ParseEnumValues(TypeDef libType, Type typeDefinition)
  {
    int added = 0;
    int ordNum = 0;
    foreach (FieldInfo field in typeDefinition.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
    {
      if (field.IsLiteral && !field.IsInitOnly)
      {
        Write($"Checking enum value {libType.Name}.{field.Name} ... ");
        var enumValue = dbContext.EnumValues.FirstOrDefault(e => e.OwnerTypeId == libType.Id && e.Name == field.Name && e.OrdNum == ordNum);
        if (enumValue == null)
        {

          enumValue = new EnumValue { OwnerTypeId = libType.Id, Name = field.Name, OrdNum = ordNum };
          dbContext.EnumValues.Add(enumValue);
          if (SaveChanges() > 0)
          {
            EnumValuesAdded++;
            added++;
          }
        }
        else
          WriteLine($"ok");
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
      Write($"Checking enum value {libType.Name}.{property.Name} ...");

      var enumValue = dbContext.EnumValues.FirstOrDefault(e => e.OwnerTypeId == libType.Id && e.Name == property.Name && e.OrdNum == ordNum);
      if (enumValue == null)
      {
        enumValue = new EnumValue { OwnerTypeId = libType.Id, Name = property.Name, OrdNum = ordNum };
        dbContext.EnumValues.Add(enumValue);
        if (SaveChanges() > 0)
        {
          EnumValuesAdded++;
          WriteLine($"added");
          added++;
        }
      }
      else
        WriteLine($"ok");
      ordNum++;
    }
    return added;
  }

  public int ParseProperties(TypeDef libType, Type typeDefinition)
  {
    int added = 0;
    int updated = 0;
    int ordNum = 0;
    foreach (PropertyInfo property in typeDefinition.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
    {
      if (property.CanWrite)
      {
        Write($"Checking property {libType.Name}.{property.Name} ... ");

        var libProperty = dbContext.Properties.FirstOrDefault(e => e.OwnerTypeId == libType.Id && e.Name == property.Name);
        if (libProperty == null)
        {
          libProperty = new Property { OwnerTypeId = libType.Id, Name = property.Name, OrdNum = ordNum };
          dbContext.Properties.Add(libProperty);
          if (SaveChanges() > 0)
          {
            WriteLine($"added");
            PropertiesAdded++;
            added++;
          }
          else
            throw new InvalidDataException($"Property {libType.Name}.{property.Name} not added");
          ParsePropertyDetails(libProperty, property, ordNum);
          ParsePropertyValueType(libProperty, property);
        }
        else
        {
          if (ParsePropertyDetails(libProperty, property, ordNum))
          {
            WriteLine($"updated");
            PropertiesUpdated++;
            updated++;
          }
          else
            WriteLine($"ok");
          ParsePropertyValueType(libProperty, property);
        }
        ordNum++;
      }
    }
    return added + updated;
  }

  internal bool ParsePropertyDetails(Property libProperty, PropertyInfo property, int ordNum)
  {
    libProperty.OrdNum = ordNum;
    return dbContext.SaveChanges() > 0 || libProperty.ValueTypeId == null;
  }

  internal bool ParsePropertyValueType(Property libProperty, PropertyInfo property)
  {
    var valueTypeDef = ParseValueType(property.PropertyType);
    libProperty.ValueTypeId = valueTypeDef.Id;
    return dbContext.SaveChanges() > 0;
  }

  internal TypeDef ParseValueType(Type assType)
  {
    var ns = dbContext.Namespaces.FirstOrDefault(item=>item.Name==assType.Namespace);
    if (ns == null)
      throw new InvalidDataException($"Namespace {assType.Namespace} not found");
    var typeName = assType.Name;
    Write($"Checking type {ns.Name}.{typeName} ... ");

    var libType = dbContext.Types.FirstOrDefault(t => t.Name == typeName && t.NamespaceId == ns.Id);
    if (libType == null)
    {
      WriteLine($"added");
      libType = new TypeDef { Name = typeName, NamespaceId = ns.Id };
      dbContext.Types.Add(libType);
      if (SaveChanges() > 0)
        TypesAdded++;
      else
        throw new InvalidDataException($"Type {ns.Name}.{typeName} not added");
      ParseTypeDetails(libType, assType);
      //ParseTypeMembers(libType, assType);
    }
    else
    {
      if (ParseTypeDetails(libType, assType))
      {
        WriteLine($"updated");
        TypesUpdated++;
      }
      else
        WriteLine($"ok");
      //ParseTypeMembers(libType, assType);
    };
    return libType;
  }

  internal bool ParseBaseType(TypeDef libType, Type assType)
  {
    if (libType.Kind == TypeKind.Enum || assType.BaseType == null)
      return false;

    var baseTypeDef = ParseBaseType(assType.BaseType);
    libType.BaseTypeId = baseTypeDef.Id;
    return dbContext.SaveChanges() > 0;
  }

  internal TypeDef ParseBaseType(Type assType)
  {
    var ns = dbContext.Namespaces.FirstOrDefault(item => item.Name == assType.Namespace);
    if (ns == null)
      throw new InvalidDataException($"Namespace {assType.Namespace} not found");
    var typeName = assType.Name;
    Write($"Checking type {ns.Name}.{typeName} ... ");

    var libType = dbContext.Types.FirstOrDefault(t => t.Name == typeName && t.NamespaceId == ns.Id);
    if (libType == null)
    {
      WriteLine($"added");
      libType = new TypeDef { Name = typeName, NamespaceId = ns.Id };
      dbContext.Types.Add(libType);
      if (SaveChanges() > 0)
        TypesAdded++;
      else
        throw new InvalidDataException($"Type {ns.Name}.{typeName} not added");
      ParseTypeDetails(libType, assType);
      //ParseTypeMembers(libType, assType);
    }
    else
    {
      if (ParseTypeDetails(libType, assType))
      {
        WriteLine($"updated");
        TypesUpdated++;
      }
      else
        WriteLine($"ok");
      //ParseTypeMembers(libType, assType);
    };
    return libType;
  }

}
