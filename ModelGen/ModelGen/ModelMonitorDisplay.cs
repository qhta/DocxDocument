using DocumentFormat.OpenXml.Wordprocessing;

using System.CodeDom.Compiler;
using System.Reflection;

namespace ModelGen;

[Flags]
public enum ShowOptions
{
  AcceptedTypesOnly = 1,
  OriginalNames = 2,
  ImplementedInterfaces = 4,
  GenericParamsConstraints = 8,
  OutgoingRelationships = 16,
  IncomingRelationships = 32,
  SelectedSemantics = 64,
  ExcludeSemantics = 128,
  EnumValues = 0x100,
  Properties = 0x200,
  HideUnacceptedProperties = 0x400,
  HideUnacceptedTypeDetails = 0x800,
  IncludedTypes = 0x1000,
}

public class ModelMonitorDisplay
{
  public ModelMonitorDisplay()
  {
    Writer = new IndentedTextWriter(Console.Out, "  ");
  }

  public IndentedTextWriter Writer { get; }


  public void ShowNamespaces()
  {
    if (TypeManager.Namespaces.Count > 0)
    {
      var maxNamespaceLength = TypeManager.Namespaces.Max(item => item.Length);
      foreach (var nspace in TypeManager.Namespaces)
      {
        var aSpace = nspace;
        if (aSpace.Length < maxNamespaceLength)
          aSpace = aSpace + new string(' ', maxNamespaceLength - aSpace.Length);
        var nSpaceTypes = TypeManager.KnownTypes.Where(item => item.Value.Namespace == nspace).Select(item => item.Value).ToList();
        var nSpaceTypesCount = nSpaceTypes.Count;
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

  public void ShowNamespaceDetails(ShowOptions options = 0)
  {
    int count = 0;
    foreach (var nspace in TypeManager.Namespaces.ToList())
    {
      if (count++ != 0)
        Writer.WriteLine();
      Writer.Indent++;
      ShowNamespaceDetails(nspace, options);
      Writer.Indent--;
    }
  }

  public void ShowNamespaceDetails(string nspace, ShowOptions options = 0, Semantics[]? semanticsFilter = null)
  {
    var nSpaceTypes = TypeManager.KnownTypes.Where(item => item.Value.Namespace == nspace).Select(item => item.Value).ToList();
    if (options.HasFlag(ShowOptions.AcceptedTypesOnly))
      nSpaceTypes = nSpaceTypes.Where(item => item.IsAccepted == true).ToList();
    if (nSpaceTypes.Count > 0)
    {
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

  public void ShowTypeInfo(TypeInfo typeInfo, ShowOptions options = 0, Semantics[]? semanticsFilter = null)
  {
    if (!typeInfo.IsReflected)
      typeInfo.Reflect();
    var str = $"{typeInfo.TypeKind.ToString().ToLower()} {typeInfo.FullName}";
    var changedToType = TypeManager.GetConversionTarget(typeInfo);
    if (changedToType != null)
      str += $" => {changedToType.FullName}";
    else if (typeInfo.IsAccepted != null)
      str += $" {{{Accepted(typeInfo.IsAccepted)}}}";
    Writer.WriteLine(str);
    if (options.HasFlag(ShowOptions.HideUnacceptedTypeDetails) && typeInfo.IsAccepted == false)
      return;
    Writer.Indent++;
    if (options.HasFlag(ShowOptions.OriginalNames))
      if (typeInfo.Name != typeInfo.OrigName)
        Writer.WriteLine($"original name: {typeInfo.OrigFullName}");
    if (typeInfo.BaseTypeInfo != null)
    {
      str = $"based on: {typeInfo.BaseTypeInfo.FullName}";
      changedToType = TypeManager.GetConversionTarget(typeInfo.BaseTypeInfo);
      if (changedToType != null)
      {
        str += $" => {changedToType.FullName}";
      }
      Writer.WriteLine(str);
    }
    if (options.HasFlag(ShowOptions.ImplementedInterfaces))
      ShowImplementedInterfaces(typeInfo, options);
    if (options.HasFlag(ShowOptions.GenericParamsConstraints))
      ShowGenericParamsConstraints(typeInfo, options);
    if (options.HasFlag(ShowOptions.OutgoingRelationships))
      ShowOutgoingRelationships(typeInfo, options, semanticsFilter);
    if (options.HasFlag(ShowOptions.IncomingRelationships))
      ShowIncomingRelationships(typeInfo, options, semanticsFilter);
    if (options.HasFlag(ShowOptions.IncludedTypes))
      ShowIncludedTypes(typeInfo, options);
    if (options.HasFlag(ShowOptions.EnumValues))
      ShowEnumValues(typeInfo, options);
    if (options.HasFlag(ShowOptions.Properties))
      ShowProperties(typeInfo, options);
    Writer.Indent--;
  }

  public void ShowGenericParamsConstraints(TypeInfo typeInfo, ShowOptions options = 0)
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
            ls.Add(item.FullName);
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

  public void ShowImplementedInterfaces(TypeInfo typeInfo, ShowOptions options = 0)
  {
    var implementedInterfaces = typeInfo.GetInterfaces();
    if (implementedInterfaces.Any())
    {
      foreach (var intfType in implementedInterfaces.Take(10).ToArray())
      {
        var str = $"implements {intfType.FullName}";
        Writer.WriteLine(str);
      }
      if (implementedInterfaces.Count()>10)
        Writer.WriteLine("...");
    }
  }

  public void ShowIncludedTypes(TypeInfo typeInfo, ShowOptions options = 0)
  {
    var includedTypes = typeInfo.GetIncludedTypes();
    if (includedTypes.Any())
    {
      foreach (var intfType in includedTypes.Take(10).ToArray())
      {
        var str = $"includes {intfType.FullName}";
        Writer.WriteLine(str);
      }
      if (includedTypes.Count()>10)
        Writer.WriteLine("...");
    }
  }
  public void ShowOutgoingRelationships(TypeInfo typeInfo, ShowOptions options, Semantics[]? semanticsFilter = null)
  {
    var outgoingRels = TypeManager.GetOutgoingRelationships(typeInfo).ToList();
    if (options.HasFlag(ShowOptions.ExcludeSemantics) && semanticsFilter != null)
      outgoingRels = outgoingRels.Where(item => !semanticsFilter.Contains(item.Semantics)).ToList();
    else
    if (options.HasFlag(ShowOptions.SelectedSemantics) && semanticsFilter != null)
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
    if (options.HasFlag(ShowOptions.ExcludeSemantics) && semanticsFilter != null)
      incomingRels = incomingRels.Where(item => !semanticsFilter.Contains(item.Semantics)).ToList();
    else
    if (options.HasFlag(ShowOptions.SelectedSemantics) && semanticsFilter != null)
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

  public void ShowEnumValues(TypeInfo typeInfo, ShowOptions options = 0)
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

  public void ShowProperties(TypeInfo typeInfo, ShowOptions options = 0)
  {
    if (options.HasFlag(ShowOptions.HideUnacceptedProperties) && typeInfo.IsAccepted == false)
      return;
    var properties = typeInfo.Properties;
    if (properties != null && properties.Any())
    {
      Writer.WriteLine("{");
      foreach (var property in properties.Take(1).ToArray())
      {
        if (options.HasFlag(ShowOptions.HideUnacceptedProperties) && property.IsAccepted == false)
          continue;
        Writer.Indent++;
        var str = $"{property.Name}: {property.PropertyType.FullName}";
        var changedToType = TypeManager.GetConversionTarget(property.PropertyType);
        if (changedToType != null)
          str += $" => {changedToType.FullName}";
        if (property.IsAccepted != null)
          str += $" {{{Accepted(property.IsAccepted)}}}";
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
    foreach (var conv in TypeManager.Relationships.Where(item => item.Semantics == Semantics.TypeChange).ToArray())
    {
      if (conv.Source is TypeInfo sourceTypeInfo)
      {
        Writer.WriteLine($"{sourceTypeInfo} => {conv.Target}");
        Writer.Indent++;
        ShowTypeConversions(conv.Target);
        Writer.Indent--;
      }
    }
  }

  public void ShowTypeConversions(TypeInfo sourceTypeInfo)
  {
    foreach (var conv in TypeManager.Relationships.Where(item => item.Source == sourceTypeInfo && item.Semantics == Semantics.TypeChange))
    {
      Writer.WriteLine($"{conv.Source} => {conv.Target}");
      Writer.Indent++;
      ShowTypeConversions(conv.Target);
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
    foreach (var typeInfo in TypeManager.KnownTypes.Select(item => item.Value))
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

