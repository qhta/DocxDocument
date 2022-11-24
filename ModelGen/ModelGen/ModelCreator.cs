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
  ModelMonitorDisplay ModelMonitorDisplay = new ModelMonitorDisplay();

  public ModelCreator(string projectName, string intfOutputPath, string implOutputPath)
  {
    IntfOutputPath = intfOutputPath;
    if (!Directory.Exists(IntfOutputPath))
      Directory.CreateDirectory(IntfOutputPath);
    var intfProjectName = projectName;
    GenProjectFile(intfProjectName, Path.Combine(IntfOutputPath, intfProjectName + ".csproj"));
    ImplOutputPath = implOutputPath;
    if (!Directory.Exists(ImplOutputPath))
      Directory.CreateDirectory(ImplOutputPath);
    var implProjectName = projectName + ".Impl";
    GenProjectFile(implProjectName, Path.Combine(implOutputPath, implProjectName + ".csproj"));
  }

  private Assembly SourceAssembly { get; set; } = null!;

  private string IntfOutputPath { get; set; }
  private string ImplOutputPath { get; set; }

  //Dictionary<string, int> TypeNamesCount = new();

  SortedSet<string> GlobalUsings { get; } = new();


  String EmptyLine { get; } = new String(' ', Console.BufferWidth);

  public void RunOn(Assembly assembly)
  {
    SourceAssembly = assembly;
    Console.WriteLine("Scanning types");
    var totalTypesCount = 0;
    var acceptedTypesCount = 0;
    foreach (var type in assembly.GetTypes())
    {
      if (ModelData.IncludedNamespaces.Count == 0 || ModelData.IncludedNamespaces.Contains(type.Namespace ?? ""))
      {
        Console.Write($"\r{EmptyLine}");
        Console.Write($"\r{type.FullName}");
        totalTypesCount++;
        var nspace = type.Namespace ?? "";
        if (nspace == "DocumentFormat.OpenXml.Packaging")
          Debug.Assert(true);
        if (CanGenerateType(type, out var typeInfo))
        {
          if (typeInfo.IsAccepted == true)
            acceptedTypesCount++;
          //var typeName = typeInfo.Name;
          //if (!TypeNamesCount.ContainsKey(typeName))
          //  TypeNamesCount.Add(typeName, 1);
          //else
          //  TypeNamesCount[typeName] += 1;
        }
      }
    }
    Console.WriteLine();
    Console.WriteLine($"Found {totalTypesCount} types, {TypeManager.KnownTypes.Count} registered, {acceptedTypesCount} accepted");

    Console.WriteLine();
    Console.WriteLine($"Found {TypeManager.GetNamespaces(true).Count()} namespaces");
    //ModelMonitorDisplay.ShowNamespaces();

    Console.WriteLine();
    Console.WriteLine("Converting types");
    var convertedCount = AddTypeConversion();
    Console.WriteLine($"Converted {convertedCount} types");
    //ModelMonitorDisplay.ShowTypeConversions();
    
    Console.WriteLine();
    Console.WriteLine("Checking type usage");
    var usedCount = 0;
    foreach (var type in TypeManager.AcceptedTypes.ToArray())
    {

      usedCount += CheckTypeUsage(type,
        (item) =>
        {
          Console.Write($"\r{EmptyLine}");
          Console.Write($"\r{item.GetFullName()}");
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
    Console.WriteLine("Generating");

    foreach (var typeInfo in TypeManager.AcceptedTypes.ToArray())
    {
      //if (typeInfo.Name == "ChartSpace")
      //  Debug.Assert(true);
      if (typeInfo.Namespace.StartsWith("System"))
        continue;
      if (typeInfo.Name.Contains('`'))
        continue;
      Console.Write($"\r{EmptyLine}");
      Console.Write($"\r{typeInfo.GetFullName(false, true)}");
      if (typeInfo.TypeKind == TypeKind.Class)
        GenClassType(typeInfo);
      else if (typeInfo.TypeKind == TypeKind.Enum)
        GenEnumType(typeInfo);
    }

    if (GlobalUsings.Count > 0)
    {
      //GenGlobalUsings(Path.Combine(IntfOutputPath, "GlobalUsings.cs"));
      //GenGlobalUsings(Path.Combine(ImplOutputPath, "GlobalUsings.cs"));
    }
  }

  private void GenProjectFile(string projectName, string filename)
  {
    AssurePathExists(filename);
    using (var writer = File.CreateText(filename))
    using (var reader = File.OpenText(projectName + ".csproj.xml"))
    {
      writer.Write(reader.ReadToEnd());
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
    typeInfo.Reflect();
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
    if (typeInfo.IsAccepted == false)
      return 0;

    if (typeInfo.UsesEvaluated)
      return 0;
    typeInfo.UsesEvaluated = true;

    if (OnStartChecking != null)
      OnStartChecking(typeInfo);
    if (typeInfo.Name == "Accent")
      Debug.Assert(true);

    if (!typeInfo.IsReflected)
      typeInfo.Reflect();
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
          var propType = prop.PropertyType;
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

  #region Manage type conversion
  private int AddTypeConversion()
  {
    var count = 0;
    foreach (var item in ModelData.TypeConversionTable)
    {
      var sourceType = item.Key;
      var targetType = item.Value;
      var sourceTypeInfo = TypeManager.RegisterType(sourceType);
      TypeManager.RegisterType(targetType, sourceTypeInfo, Semantics.TypeChange);
      sourceTypeInfo.IsAccepted = false;
      count++;
    }
    count += AddValTypesConversions();
    return count;
  }

  //private static int AddGenericTypeConversion(Type sourceType, Type targetType)
  //{
  //  var count = 0;
  //  foreach (var item in TypeManager.KnownTypes.ToArray())
  //  {
  //    var sourceType2 = item.Key;
  //    if (/*sourceType2.IsConstructedGenericType && */sourceType2.Name == sourceType.Name)
  //    {
  //      var sourceTypeInfo = item.Value;
  //      var sourceArgTypes = sourceType2.GenericTypeArguments;
  //      var targetType2 = targetType;
  //      if (targetType2 == typeof(Enum))
  //      {
  //        targetType2 = sourceArgTypes.FirstOrDefault();
  //        if (targetType2 != null)
  //        {
  //          var targetTypeInfo = TypeManager.RegisterType(targetType2, sourceTypeInfo, Semantics.TypeChange);
  //          sourceTypeInfo.IsAccepted = false;
  //          count++;
  //        }
  //      }
  //    }
  //  }
  //  return count;
  //}

  private int AddValTypesConversions()
  {
    var count = 0;
    foreach (var item in TypeManager.KnownTypes)
    {
      var sourceTypeInfo = item.Value;
      if (sourceTypeInfo.TypeKind == TypeKind.Class && sourceTypeInfo.Properties?.Count == 1)
      {
        var firstProp = sourceTypeInfo.Properties?.FirstOrDefault();
        if (firstProp != null && firstProp.Name == "Val")
        {
          TypeManager.Relationships.Add(new TypeRelationship(sourceTypeInfo, firstProp.PropertyType, Semantics.TypeChange));
          sourceTypeInfo.IsAccepted = false;
          count++;
        }
      }
    }
    return count;
  }
  #endregion

  #region Class type generation


  private void GenClassType(TypeInfo type)
  {
    var typeName = type.Name;
    var aNamespace = type.Namespace;
    var intfOutputPath = Path.Combine(IntfOutputPath, aNamespace);
    GenClassOrInterface(type, typeName, Path.Combine(intfOutputPath, "Interfaces", "I" + typeName + ".cs"), true);
    //var implOutputPath = Path.Combine(ImplOutputPath, aNamespace);
    //GenClassOrInterface(type, typeName, Path.Combine(implOutputPath, typeName + ".cs"), false);
  }

  private void GenClassOrInterface(TypeInfo type, string typeName, string filename, bool toInterface)
  {
    AssurePathExists(filename);
    using (var textWriter = File.CreateText(filename))
    using (var writer = new IndentedTextWriter(textWriter, "  "))
    {
      GenClassOrInterface(type, typeName, writer, toInterface);
    }
  }

  private void GenClassOrInterface(TypeInfo type, string typeName, IndentedTextWriter writer, bool toInterface)
  {
    Console.Write($"\r{new string(' ', Console.BufferWidth)}");
    Console.Write($"\r{type.GetFullName(false, true)}");

    var aNamespace = type.Namespace;
    if (aNamespace != null)
    {
      writer.WriteLine($"namespace {aNamespace};");
      writer.WriteLine();
    }

    GenDocumentationComments(type, writer);
    GenCustomAttributes(type.CustomAttributes, writer);
    if (toInterface)
      writer.WriteLine($"public interface I{typeName} // : {type.BaseTypeInfo?.GetFullName(false, true)}");
    else
      writer.WriteLine($"public class {typeName}: I{typeName}");
    writer.WriteLine("{");
    writer.Indent++;
    if (type.Name == "AbstractNum")
      Debug.Assert(true);
    if (type.Properties != null)
      foreach (var prop in type.Properties)
        //if (!(ModelFilter.ExcludedProperties.Contains(prop.Name)) && !(ModelFilter.ExcludedTypes.Contains(prop.PropertyType.Namespace ?? "")))
        GenProperty(prop, writer, toInterface);
    writer.Indent--;
    writer.WriteLine("}");
  }

  private void GenProperty(PropInfo prop, IndentedTextWriter writer, bool toInterface)
  {
    //if (prop.Name == "Val")
    //  Debug.Assert(true);
    var propertyType = prop.PropertyType;
    var targetPropertyType = TypeManager.GetConversionTarget(propertyType);
    if (targetPropertyType != null)
      propertyType = targetPropertyType;
    string propertyTypeName = propertyType.GetFullName(false, true, false);
    string aNamespace = propertyType.GetNamespace(false);
    if (propertyType.HasDuplicatesInName())
    {
      propertyTypeName = aNamespace + "." + propertyTypeName;
    }
    GenDocumentationComments(prop, writer);
    GenCustomAttributes(prop.CustomAttributes, writer);
    if (toInterface)
      writer.WriteLine($"public {propertyTypeName}? {prop.Name} {{ get ; set; }}");
    else
    {
      writer.WriteLine($"public {propertyTypeName}? {prop.Name}");
      writer.WriteLine($"{{");
      writer.WriteLine($"  get;");
      writer.WriteLine($"  set;");
      writer.WriteLine($"}}");
    }
    writer.WriteLine();
    AddGlobalUsing(aNamespace ?? "");
  }
  #endregion

  #region Enum types generation
  private void GenEnumType(TypeInfo type)
  {
    var outputPath = IntfOutputPath;
    var aNamespace = type.Namespace;
    outputPath = Path.Combine(outputPath, aNamespace);
    var typeName = type.Name;
    var fileName = ValidateFilename(typeName);
    GenEnumType(type, typeName, Path.Combine(outputPath, "Enums", fileName + ".cs"));
  }

  private void GenEnumType(TypeInfo type, string typeName, string filename)
  {
    AssurePathExists(filename);
    using (var textWriter = File.CreateText(filename))
    using (var writer = new IndentedTextWriter(textWriter, "  "))
    {
      GenEnumType(type, typeName, writer);
    }
  }

  private void GenEnumType(TypeInfo type, string typeName, IndentedTextWriter writer)
  {
    Console.Write($"\r{new string(' ', Console.BufferWidth)}");
    Console.Write($"\r{type.GetFullName(false, true)}");
    var aNamespace = type.GetNamespace();
    if (aNamespace != null)
    {
      writer.WriteLine($"namespace {aNamespace};");
      writer.WriteLine();
    }
    GenDocumentationComments(type, writer);
    GenCustomAttributes(type.CustomAttributes, writer);
    writer.WriteLine($"public enum {typeName}");
    writer.WriteLine("{");
    writer.Indent++;
    if (type.EnumValues != null)
      foreach (var field in type.EnumValues)
        GenEnum(field, writer);
    writer.Indent--;
    writer.WriteLine("}");
  }

  private void GenEnum(EnumInfo field, IndentedTextWriter writer)
  {
    bool addEmptyLine = GenDocumentationComments(field, writer);
    if (field.CustomAttributes != null)
    {
      GenCustomAttributes(field.CustomAttributes, writer);
      addEmptyLine = true;
    }
    writer.WriteLine($"{field.Name},");
    if (addEmptyLine)
      writer.WriteLine();
  }
  #endregion

  #region CustomAttributes generation

  private bool GenCustomAttributes(IEnumerable<CustomAttribData>? attributes, IndentedTextWriter writer)
  {
    //if (attributes?.Any() == true)
    //{
    //  foreach (var customAttrib in attributes)
    //    GenCustomAttribute(customAttrib, writer);
    //  AddGlobalUsing("DocumentModel.Attributes");
    //  return true;
    //}
    return false;
  }

  private void GenCustomAttribute(CustomAttribData attrData, IndentedTextWriter writer)
  {
    var attributeType = attrData.AttributeType;
    //if (ModelFilter.AttributeConversionTable.TryGetValue(attributeType, out var altAttrType))
    //  attributeType = altAttrType;
    var attrTypeName = attributeType.Name;
    if (attrTypeName.EndsWith("Attribute"))
      attrTypeName = attrTypeName.Substring(0, attrTypeName.Length - "Attribute".Length);
    if (ModelData.ExcludedAttributes.Contains(attrTypeName))
      return;
    var attrString = attrTypeName;
    if (attrData.ConstructorArguments?.Count + attrData.NamedArguments?.Count > 0)
    {
      var strList = new List<string>();
      if (attrData.ConstructorArguments != null)
        foreach (var arg in attrData.ConstructorArguments)
          strList.Add(TypedValueLiteral(arg.ArgumentType, arg.Value));
      if (attrData.NamedArguments != null)
        foreach (var arg in attrData.NamedArguments)
          strList.Add($"{arg.MemberName?.ToString() ?? String.Empty} =  {TypedValueLiteral(arg.TypedValue.ArgumentType, arg.TypedValue.Value)}");
      attrString += "(" + String.Join(", ", strList) + ")";
    }
    writer.WriteLine($"[{attrString}]");
    AddGlobalUsing(attributeType.Namespace);
  }
  #endregion

  #region Documentation comments generation

  private bool GenDocumentationComments(TypeInfo type, IndentedTextWriter writer)
  {
    var documentation = type.Type.GetXmlDocsElement();
    if (documentation != null)
    {
      var summary = DocumentationReader.GetSummaryFirstPara(documentation);
      if (summary != null)
      {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// {summary}");
        writer.WriteLine("/// </summary>");
      }
      var childItemTypes = DocumentationReader.GetChildItemTypes(documentation, this.SourceAssembly);
      if (childItemTypes != null)
      {
        foreach (var childItemType in childItemTypes)
        {
          if (type.CustomAttributes == null)
          {
            var childItemTypeInfo = TypeManager.RegisterType(childItemType, this, Semantics.Include);
            var myCustomAttribute = new CustomAttribData(typeof(DocumentModel.Attributes.ChildElementInfoAttribute));
            myCustomAttribute.ConstructorArguments.Add(new CustomAttribTypedArgument(childItemTypeInfo));
            GenCustomAttribute(myCustomAttribute, writer);
          }
        }
      }
      return true;
    }
    return false;
  }

  private bool GenDocumentationComments(EnumInfo aField, IndentedTextWriter writer)
  {
    var summary = aField.Summary;
    if (summary != null)
    {
      writer.WriteLine("/// <summary>");
      writer.WriteLine($"/// {summary}");
      writer.WriteLine("/// </summary>");
      return true;
    }
    return false;
  }

  private bool GenDocumentationComments(PropInfo aProp, IndentedTextWriter writer)
  {
    var summary = aProp.Summary;
    if (summary != null)
    {
      writer.WriteLine("/// <summary>");
      writer.WriteLine($"/// {summary}");
      writer.WriteLine("/// </summary>");
      return true;
    }
    return false;
  }
  #endregion

  #region Global usings generation
  private void AddGlobalUsing(string aNamespace)
  {
    if (aNamespace == "System.IO.Packaging")
      return;
    if (aNamespace.StartsWith("DocumentFormat.OpenXml"))
      return;
    if (aNamespace != String.Empty)
      if (!GlobalUsings.Contains(aNamespace))
        GlobalUsings.Add(aNamespace);

  }

  private void GenGlobalUsings(string filename)
  {
    AssurePathExists(filename);
    using (var writer = File.CreateText(filename))
    {
      foreach (var item in GlobalUsings)
        writer.WriteLine($"global using {item};");
    }
  }
  #endregion

  #region Literals generation
  private string TypedValueLiteral(Type type, object? value)
  {
    if (type == typeof(string))
    {
      if (value is string str)
        return $"\"{str}\"";
      return "\"\"";
    }
    else if (value is TypeInfo aType)
    {
      var aTypeName = "I" + aType.Name;
      var aNamespace = aType.Namespace;
      return ($"typeof({aNamespace}.{aTypeName})");

    }
    else if (value is bool bv)
      return bv.ToString().ToLower();
    else if (value != null)
    {
      if (type.IsEnum)
      {
        var enumName = Enum.GetName(type, value);
        enumName = type.Name + "." + enumName;
        return enumName;
      }
      else
      {
        return value.ToString() ?? "";
      }
    }
    return "";
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
      var nspaceTypes = TypeManager.KnownTypes.Where(item => item.Value.Namespace == nspace).Select(item => item.Value).ToList();
      foreach (var typeInfo in nspaceTypes.Where(item => item.TypeKind == TypeKind.Enum))
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

  #region Filename/Path methods
  private string ValidateFilename(string filename)
  {
    foreach (var ch in Path.GetInvalidFileNameChars())
      filename = filename.Replace(new string(ch, 1), "");
    return filename;
  }

  private void AssurePathExists(string filename)
  {
    var filePath = Path.GetDirectoryName(filename);
    if (filePath != null)
      if (!Directory.Exists(filePath))
        Directory.CreateDirectory(filePath);
  }
  #endregion

}