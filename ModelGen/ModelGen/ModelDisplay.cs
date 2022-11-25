using DocumentFormat.OpenXml.Wordprocessing;

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;

namespace ModelGen;

public class ModelDisplay
{

  public ModelDisplay()
  {
    Writer = new IndentedTextWriter(Console.Out, "  ");
  }

  public ModelDisplay(TextWriter textWriter)
  {
    Writer = new IndentedTextWriter(textWriter, "  ");
  }
  
  public IndentedTextWriter Writer { get; }

  static String EmptyLine { get; } = new String(' ', Console.BufferWidth);

  public void WriteSameLine(string? str)
  {
    Writer.Write($"\r{EmptyLine}");
    Writer.Write($"\r{str}");
  }

  public static void ConsoleWriteSameLine(string? str)
  {
    Console.Write($"\r{EmptyLine}");
    Console.Write($"\r{str}");
  }

  public void WriteLine(string? str)
  {
    Writer.WriteLine(str);
  }

  public void ShowNamespaces(bool original=false)
  {
    var namespaces = TypeManager.GetNamespaces(original);
    if (namespaces.Any())
    {
      var maxNamespaceLength = namespaces.Max(item => item.Length);
      foreach (var nspace in namespaces)
      {
        var aSpace = nspace;
        if (aSpace.Length < maxNamespaceLength)
          aSpace = aSpace + new string(' ', maxNamespaceLength - aSpace.Length);
        var nSpaceTypes = TypeManager.GetNamespaceTypes(nspace).ToArray();
        var nSpaceTypesCount = nSpaceTypes.Count();
        var nSpaceAcceptedCount = nSpaceTypes.Count(item => item.IsAccepted == true);
        var nSpaceClassesCount = nSpaceTypes.Count(item => item.TypeKind == TypeKind.Class);
        var nSpaceEnumsCount = nSpaceTypes.Count(item => item.TypeKind == TypeKind.Enum);
        var nSpaceOtherCount = nSpaceTypes.Count(item => item.TypeKind == TypeKind.Type);
        var str = $"{aSpace} {nSpaceTypesCount} types";
        str += $", {AllNone(nSpaceAcceptedCount, nSpaceTypesCount)} accepted";
        if (nSpaceClassesCount != 0)
          str += $", {AllNone(nSpaceClassesCount, nSpaceTypesCount)} {Multi(nSpaceClassesCount, "class")}";
        if (nSpaceEnumsCount != 0)
          str += $", {AllNone(nSpaceEnumsCount, nSpaceTypesCount)} {Multi(nSpaceEnumsCount, "enum")}";
        if (nSpaceOtherCount != 0)
          str += $", {AllNone(nSpaceOtherCount, nSpaceTypesCount)} other types";
        Writer.WriteLine(str);
      }
    }
  }

  public void ShowNamespaceDetails(ShowOptions options)
  {
    foreach (var nspace in TypeManager.GetNamespaces(options.OriginalNames).ToList())
    {
      Writer.Indent++;
      ShowNamespaceDetails(nspace, options);
      Writer.Indent--;
    }
  }

  public void ShowNamespaceDetails(string nspace, ShowOptions options, Semantics[]? semanticsFilter = null)
  {
    if (nspace.StartsWith("DocumentFormat.OpenXml.Packaging"))
      Debug.Assert(true);
    var nSpaceTypes = TypeManager.GetNamespaceTypes(nspace).ToList();
    if (options.AcceptedTypesOnly)
      nSpaceTypes = nSpaceTypes.Where(item => item.IsAccepted == true).ToList();
    if (nSpaceTypes.Count > 0)
    {
      Writer.WriteLine();
      Writer.WriteLine($"namespace {nspace}");
      Writer.Indent++;
      foreach (var typeInfo in nSpaceTypes)
      {
        if (typeInfo.IsGenericTypeParameter)
          continue;
        ShowTypeInfo(typeInfo, options, semanticsFilter);
      }
      Writer.Indent--;
    }
  }

  private static string[] constaints = new string[]
  {
    "covariant",
    "contravariant",
    "class",
    "struct",
    "new()"
  };

  public void ShowTypeInfo(TypeInfo typeInfo, ShowOptions options, Semantics[]? semanticsFilter = null)
  {
    if (!typeInfo.IsReflected)
      typeInfo.WaitForReflection();
    var str = $"{typeInfo.TypeKind.ToString().ToLower()} {typeInfo.GetFullName(options.OriginalNames)}";
    var changedToType = ModelManager.GetConversionTarget(typeInfo, false);
    if (changedToType != null)
      str += $" => {changedToType.GetFullName(options.OriginalNames)}";
    else if (typeInfo.IsAccepted != null)
      str += $" {{{Accepted(typeInfo.IsAccepted)}}}";
    Writer.WriteLine(str);
    if (options.HideUnacceptedTypeDetails && typeInfo.IsAccepted == false)
      return;
    Writer.Indent++;
    if (options.BaseTypes && typeInfo.BaseTypeInfo != null)
    {
      str = $"based on: {typeInfo.BaseTypeInfo.GetFullName(options.OriginalNames)}";
      changedToType = ModelManager.GetConversionTarget(typeInfo.BaseTypeInfo, false);
      if (changedToType != null)
        str += $" => {changedToType.GetFullName(options.OriginalNames)}";
      else if (typeInfo.BaseTypeInfo.IsAccepted != null)
        str += $" {{{Accepted(typeInfo.BaseTypeInfo.IsAccepted)}}}";
      Writer.WriteLine(str);
    }
    if (options.ImplementedInterfaces)
      ShowImplementedInterfaces(typeInfo, options);
    if (options.GenericParamsConstraints)
      ShowGenericParamsConstraints(typeInfo, options);
    if (options.OutgoingRelationships)
      ShowOutgoingRelationships(typeInfo, options, semanticsFilter);
    if (options.IncomingRelationships)
      ShowIncomingRelationships(typeInfo, options, semanticsFilter);
    if (options.IncludedTypes)
      ShowIncludedTypes(typeInfo, options);
    if (options.EnumValues)
      ShowEnumValues(typeInfo, options);
    if (options.Properties)
      ShowProperties(typeInfo, options);
    Writer.Indent--;
  }

  public void ShowGenericParamsConstraints(TypeInfo typeInfo, ShowOptions options)
  {
    var genericTypeParams = typeInfo.GetGenericParamTypes();
    if (genericTypeParams != null)
    {
      foreach (var genericTypeParam in genericTypeParams.ToArray())
      {
        var ls = new List<String>();
        var genericTypeParamsConstraints = genericTypeParam.GetGenericTypeParamConstraints();
        if (genericTypeParamsConstraints != null)
          foreach (var item in genericTypeParamsConstraints.ToArray())
            ls.Add(item.GetFullName(options.OriginalNames));
        var genericParamConstraints = genericTypeParam.GetGenericParamConstraints();
        if (genericParamConstraints != null)
          foreach (var item in genericParamConstraints.ToArray())
            ls.Add(constaints[(int)item]);
        if (ls.Count > 0)
        {
          var str = $"where {genericTypeParam.Name}: " + String.Join(", ", ls);
          Writer.WriteLine(str);
        }
      }
    }
  }

  public void ShowImplementedInterfaces(TypeInfo typeInfo, ShowOptions options)
  {
    var implementedInterfaces = typeInfo.GetInterfaces();
    if (implementedInterfaces.Any())
    {
      foreach (var intfType in implementedInterfaces.Take(10).ToArray())
      {
        var str = $"implements {intfType.GetFullName(options.OriginalNames)}";
        Writer.WriteLine(str);
      }
      if (implementedInterfaces.Count()>10)
        Writer.WriteLine("...");
    }
  }

  public void ShowIncludedTypes(TypeInfo typeInfo, ShowOptions options)
  {
    var includedTypes = typeInfo.GetIncludedTypes();
    if (includedTypes.Any())
    {
      foreach (var intfType in includedTypes.Take(10).ToArray())
      {
        var str = $"includes {intfType.GetFullName(options.OriginalNames)}";
        Writer.WriteLine(str);
      }
      if (includedTypes.Count()>10)
        Writer.WriteLine("...");
    }
  }
  public void ShowOutgoingRelationships(TypeInfo typeInfo, ShowOptions options, Semantics[]? semanticsFilter = null)
  {
    var outgoingRels = TypeManager.GetOutgoingRelationships(typeInfo).ToList();
    if (options.ExcludeSemantics && semanticsFilter != null)
      outgoingRels = outgoingRels.Where(item => !semanticsFilter.Contains(item.Semantics)).ToList();
    else
    if (options.SelectedSemantics && semanticsFilter != null)
      outgoingRels = outgoingRels.Where(item => semanticsFilter.Contains(item.Semantics)).ToList();
    if (outgoingRels.Any())
    {
      Writer.WriteLine($"has {outgoingRels.Count} outgoing {Multi(outgoingRels.Count, "relationship")}");
      foreach (var rel in outgoingRels.Take(10))
      {
        Writer.Indent++;
        Writer.WriteLine($"{rel.Semantics} -> {rel.Target.ToString()}");
        Writer.Indent--;
      }
      if (outgoingRels.Count()>10)
        Writer.WriteLine("...");

    }
  }

  public void ShowIncomingRelationships(TypeInfo typeInfo, ShowOptions options, Semantics[]? semanticsFilter = null)
  {
    var incomingRels = TypeManager.GetIncomingRelationships(typeInfo).ToList();
    if (options.ExcludeSemantics && semanticsFilter != null)
      incomingRels = incomingRels.Where(item => !semanticsFilter.Contains(item.Semantics)).ToList();
    else
    if (options.SelectedSemantics && semanticsFilter != null)
      incomingRels = incomingRels.Where(item => semanticsFilter.Contains(item.Semantics)).ToList();
    if (incomingRels.Any())
    {
      Writer.WriteLine($"has {incomingRels.Count} incoming {Multi(incomingRels.Count, "relationship")}");
      foreach (var rel in incomingRels.Take(10))
      {
        Writer.Indent++;
        Writer.WriteLine($"{rel.Semantics} <- {rel.Source.ToString()}");
        Writer.Indent--;
      }
      if (incomingRels.Count()>10)
        Writer.WriteLine("...");
    }
  }

  public void ShowEnumValues(TypeInfo typeInfo, ShowOptions options)
  {
    var enumValues = typeInfo.EnumValues;
    if (enumValues != null && enumValues.Any())
    {
      Writer.WriteLine("{");
      foreach (var enumValue in enumValues.Take(10).ToArray())
      {
        Writer.Indent++;
        var str = $"{enumValue.Name}";
        Writer.WriteLine(str);
        Writer.Indent--;
      }
      if (enumValues.Count()>10)
        Writer.WriteLine("...");
      Writer.WriteLine("}");
    }
  }

  public void ShowProperties(TypeInfo typeInfo, ShowOptions options)
  {
    if (options.HideUnacceptedProperties && typeInfo.IsAccepted == false)
      return;
    var properties = typeInfo.Properties;
    if (properties != null && properties.Any())
    {
      Writer.WriteLine("{");
      foreach (var property in properties.Take(1).ToArray())
      {
        if (options.HideUnacceptedProperties && property.IsAccepted == false)
          continue;
        Writer.Indent++;
        var str = $"{property.Name}: {property.PropertyType.GetFullName(options.OriginalNames)}";
        var changedToType = ModelManager.GetConversionTarget(property.PropertyType, false);
        if (changedToType != null)
          str += $" => {changedToType.GetFullName(options.OriginalNames)}";
        else if (property.PropertyType.IsAccepted != null)
          str += $" {{{Accepted(property.PropertyType.IsAccepted)}}}";
        Writer.WriteLine(str);
        Writer.Indent--;
      }
      if (properties.Count()>10)
        Writer.WriteLine("...");
      Writer.WriteLine("}");
    }
  }

  public void ShowTypeConversions()
  {
    foreach (var type in TypeManager.AllTypes)
    {
      ShowTypeConversion(type);
    }
  }

  public void ShowTypeConversion(TypeInfo type)
  {
    var convTarget = ModelManager.GetConversionTarget(type, true);
    if (convTarget != null)
    {
      Writer.WriteLine($"{type} => {convTarget}");
      Writer.Indent++;
      ShowTypeConversion(convTarget);
      Writer.Indent--;
    }
  }
  

  public void ShowTypeUsage()
  {
    foreach (var typeInfo in TypeManager.AcceptedTypes)
    {
      Writer.WriteLine($"{typeInfo} used {typeInfo.UsageCount} {Multi(typeInfo.UsageCount,"time")}");
    }
  }

  public void ShowUnusedTypes()
  {
    foreach (var typeInfo in TypeManager.AcceptedTypes.Where(item => item.UsageCount == 0))
    {
      Writer.WriteLine($"{typeInfo} used {typeInfo.UsageCount} {Multi(typeInfo.UsageCount,"time")}");
    }
  }

  public void ShowTypeRenames()
  {
    foreach (var typeInfo in TypeManager.AllTypes)
    {
      if (typeInfo.Name != typeInfo.OrigName)
      {
        Writer.WriteLine($"{typeInfo.OrigName} --> {typeInfo.Name}");
      }
    }
  }

  private string AllNone(int n, int cmp) => (n == 0) ? "none" : (n == cmp) ? "all" : n.ToString();

  private string Multi(int n, string single, string? multi = null) => (n == 1) ? single : (multi ?? (single.EndsWith("s") ? (single + "es") : (single + "s")));

  private string Accepted(bool? isAccepted) => isAccepted == true ? "accepted" : (isAccepted == false) ? "unaccepted" : string.Empty;
}

