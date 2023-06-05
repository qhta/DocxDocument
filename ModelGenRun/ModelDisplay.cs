using System.Collections.Immutable;

namespace ModelGenRun;

public class ModelDisplay : IModelMonitor
{
  private TraceWriter Writer { get; set; }
  private int LineLength = 0;

  public ModelDisplay ()
  {
    Writer = new TraceWriter ();
  }

  public void WriteLine(string str)
  {
    Writer.WriteLine(str);
    LineLength = str.Length;
  }
  public void WriteLine()
  {
    Writer.WriteLine();
    LineLength = 0;
  }

  public void WriteSameLine(string str)
  {
    int maxLength = Console.WindowWidth - 1;
    if (str.Length > maxLength)
      str = str.Substring(maxLength);
    var l = str?.Length ?? 0;
    int n = (l < LineLength) ? LineLength - l : 0;
    Console.Write($"\r{str}");
    if (n > 0)
      Console.Write(new String(' ', n));
    LineLength = l;
  }

  public void ShowProcessStart(string line)
  {
    WriteLine();
    WriteLine(line);
  }

  public void ShowPhaseStart(string phaseName)
  {
    WriteLine();
    WriteLine($"Start {phaseName.ToLower()}");
  }

  public void ShowPhaseProgress(string phaseName, ProgressInfo info)
  {
    var sl = new List<string>();
    if (info.PreStr!=null)
      sl.Add(info.PreStr);
    if (info.Done!=null && info.Total!=null)
      sl.Add($"{info.Done}/{info.Total}");
    else if (info.Done!=null)
      sl.Add($"{info.Done}");
    if (info.MidStr!=null)
      sl.Add(info.MidStr);
    if (info.Summary!=null)
      foreach (var item in info.Summary)
      {
        if (item.Key.Contains('{'))
          sl.Add(String.Format(item.Key, item.Value));
        else
          sl.Add($"{item.Key} = {item.Value}");
      }
    if (info.PostStr!=null)
      sl.Add(info.PostStr);
    var str = String.Join(" ",sl);
    if (str!="")
      WriteSameLine(str);
  }

  public void ShowPhaseEnd(string phaseName, SummaryInfo info)
  {
    WriteLine();
    WriteLine($"End {phaseName.ToLower()}, time={info.Time}");
    if (info.Summary!=null)
      foreach (var item in info.Summary)
      {
        if (item.Key.Contains('{'))
          WriteLine(String.Format(item.Key, item.Value));
        else
          WriteLine($"{item.Key} = {item.Value}");
      }

  }

  public void ShowNamespaceSummary(NTS originTargetSelector)
  {
    WriteLine();
    WriteLine("Scanned namespaces:");
    var namespaces = TypeManager.GetNamespaces(originTargetSelector).ToList();
    if (namespaces.Any())
    {
      namespaces.Sort();
      var maxNamespaceLength = namespaces.Max(item => item.Length);
      foreach (var nspace in namespaces)
      {
        var aSpace = nspace;
        if (aSpace.Length < maxNamespaceLength)
          aSpace = aSpace + new string(' ', maxNamespaceLength - aSpace.Length);
        var nSpaceTypes = TypeManager.GetNamespaceTypes(nspace).ToArray();
        var totalTypesCount = nSpaceTypes.Count();
        var acceptedTypesCount = nSpaceTypes.Count(item => item.IsAccepted);
        var rejectedTypesCount = nSpaceTypes.Count(item => item.IsRejected);
        var classTypesCount = nSpaceTypes.Count(item => item.TypeKind == TypeKind.Class);
        var enumTypesCount = nSpaceTypes.Count(item => item.TypeKind == TypeKind.Enum);
        var otherTypesCount = nSpaceTypes.Count(item => item.TypeKind != TypeKind.Class && item.TypeKind != TypeKind.Enum);
        var str = $"{aSpace} Total {totalTypesCount} types";
        str += $", {AllNone(acceptedTypesCount, totalTypesCount)} accepted";
        if (rejectedTypesCount != 0)
          str += $", {AllNone(rejectedTypesCount, totalTypesCount)} rejected";
        if (classTypesCount != 0)
          str += $", {AllNone(classTypesCount, totalTypesCount)} {Multi(classTypesCount, "class")}";
        if (enumTypesCount != 0)
          str += $", {AllNone(enumTypesCount, totalTypesCount)} {Multi(enumTypesCount, "enum")}";
        if (otherTypesCount != 0)
          str += $", {AllNone(otherTypesCount, totalTypesCount)} {Multi(otherTypesCount, "other")}";
        Writer.WriteLine(str);
      }
    }
  }

  public void ShowNamespacesDetails(DisplayOptions options)
  {
    WriteLine();
    WriteLine("Scanned types:");
    var namespaces = TypeManager.GetNamespaces(options.NamespaceTypeSelector).ToList();
    if (options.Namespaces != null)
      namespaces = namespaces.Where(item => options.Namespaces
      .FirstOrDefault(pattern => item == pattern || item.IsLike(pattern)) != null).ToList();
    namespaces.Sort();
    foreach (var nspace in namespaces)
    {
      Writer.Indent();
      ShowNamespaceDetails(nspace, options);
      Writer.Unindent();
    }
  }

  public void ShowNamespaceDetails(string nspace, DisplayOptions options)
  {
    var nSpaceTypes = TypeManager.GetNamespaceTypes(nspace).ToList();
    if (options.Typenames != null)
      nSpaceTypes = nSpaceTypes.Where(item => options.Typenames
      .FirstOrDefault(pattern => item.Name == pattern || item.Name.IsLike(pattern)) != null).ToList();
    if (options.TypeKindSelector != TKS.Any)
      nSpaceTypes = nSpaceTypes.Where(item => IsTypeKind(item.TypeKind, options.TypeKindSelector)).ToList();
    if (options.TypeDataSelector.HasFlag(TDS.AcceptedTypesOnly))
      nSpaceTypes = nSpaceTypes.Where(item => item.IsAccepted).ToList();
    if (nSpaceTypes.Count() > 0)
    {
      Writer.WriteLine();
      Writer.WriteLine($"namespace {nspace}");
      Writer.Indent();
      nSpaceTypes.Sort((info1, info2) => info1.Name.CompareTo(info2.Name));
      foreach (var typeInfo in nSpaceTypes)
      {
        if (typeInfo.IsGenericTypeParameter)
          continue;
        ShowTypeInfo(typeInfo, options);
      }
      Writer.Unindent();
    }
  }

  public void ShowTypes(string nspace, string name)
  {
    var types = TypeManager.GetNamespace(nspace).Types.Where(item => item.Name.StartsWith(name));
    foreach (var type in types)
    {
      ShowTypeInfo(type);
    }
  }

  public void ShowTypeInfo(TypeInfo typeInfo, DisplayOptions options = null!)
  {
    if (options == null)
      options = new DisplayOptions();
    string str = "";
    if (!options.TypeDataSelector.HasFlag(TDS.AcceptedTypesOnly))
      str += Accepted(typeInfo.Acceptance);
    var originNames = options.NamespaceTypeSelector == NTS.Origin || options.TypeDataSelector.HasFlag(TDS.OriginalNames);
    str += $"{typeInfo.TypeKind.ToString().ToLower()} {typeInfo.GetFullName(originNames)}";
    if (options.TypeDataSelector.HasFlag(TDS.ConversionInfo))
    {
      var changedToType = ModelManager.GetConversionTargetOrSelf(typeInfo);
      if (changedToType != null)
        str += $" => {changedToType.GetFullName()}";
    }
    Writer.WriteLine(str);
    if (options.TypeDataSelector.HasFlag(TDS.AcceptedTypesOnly) && typeInfo.IsAccepted == false)
      return;
    Writer.Indent();
    if (options.TypeDataSelector.HasFlag(TDS.BaseTypes) && typeInfo.BaseTypeInfo != null)
    {
      str = $"based on: {typeInfo.BaseTypeInfo.GetFullName(originNames)}";
      if (options.TypeDataSelector.HasFlag(TDS.ConversionInfo))
      {
        var changedToType = ModelManager.GetConversionTargetOrSelf(typeInfo.BaseTypeInfo);
        if (changedToType != null)
          str += $" => {changedToType.GetFullName()}";
      }
      Writer.WriteLine(str);
    }
    if (options.TypeDataSelector.HasFlag(TDS.ImplementedInterfaces))
      ShowImplementedInterfaces(typeInfo, options);
    if (options.TypeDataSelector.HasFlag(TDS.GenericParamsConstraints))
      ShowGenericParamsConstraints(typeInfo, options);
    if (options.TypeDataSelector.HasFlag(TDS.OutgoingRelationships))
      ShowOutgoingRelationships(typeInfo, options);
    if (options.TypeDataSelector.HasFlag(TDS.IncomingRelationships))
      ShowIncomingRelationships(typeInfo, options);
    if (options.TypeDataSelector.HasFlag(TDS.ElementsTypes))
      ShowElementsTypes(typeInfo, options);
    if (options.TypeDataSelector.HasFlag(TDS.EnumValues))
      ShowEnumValues(typeInfo, options);
    if (options.TypeDataSelector.HasFlag(TDS.Properties))
      ShowProperties(typeInfo, options);
    Writer.Unindent();
  }

  public void ShowGenericParamsConstraints(TypeInfo typeInfo, DisplayOptions options)
  {
    var originNames = options.NamespaceTypeSelector == NTS.Origin || options.TypeDataSelector.HasFlag(TDS.OriginalNames);
    var genericTypeParams = typeInfo.GetGenericParamTypes();
    if (genericTypeParams != null)
    {
      foreach (var genericTypeParam in genericTypeParams.ToArray())
      {
        var ls = new List<String>();
        var genericTypeParamsConstraints = genericTypeParam.GetGenericTypeParamConstraints();
        if (genericTypeParamsConstraints != null)
          foreach (var item in genericTypeParamsConstraints.ToArray())
            ls.Add(item.GetFullName(originNames));
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

  public void ShowImplementedInterfaces(TypeInfo typeInfo, DisplayOptions options)
  {
    var originNames = options.NamespaceTypeSelector == NTS.Origin || options.TypeDataSelector.HasFlag(TDS.OriginalNames);
    var implementedInterfaces = typeInfo.GetImplementedInterfaces();
    if (implementedInterfaces.Any())
    {
      foreach (var intfType in implementedInterfaces.Take(options.ListLimit).ToArray())
      {
        var str = $"implements {intfType.GetFullName(originNames)}";
        Writer.WriteLine(str);
      }
      if (implementedInterfaces.Count() > 10)
        Writer.WriteLine("...");
    }
  }

  public void ShowElementsTypes(TypeInfo typeInfo, DisplayOptions options)
  {
    var originNames = options.NamespaceTypeSelector == NTS.Origin || options.TypeDataSelector.HasFlag(TDS.OriginalNames);
    var includedTypes = typeInfo.GetIElementsTypes();
    if (includedTypes.Any())
    {
      foreach (var intfType in includedTypes.Take(options.ListLimit).ToArray())
      {
        var str = $"includes {intfType.GetFullName(originNames)}";
        Writer.WriteLine(str);
      }
      if (includedTypes.Count() > 10)
        Writer.WriteLine("...");
    }
  }

  public void ShowOutgoingRelationships(TypeInfo typeInfo, DisplayOptions options)
  {
    var outgoingRels = TypeManager.GetOutgoingRelationships(typeInfo).ToList();
    if (options.TypeDataSelector.HasFlag(TDS.ExcludeSemantics) && options.SemanticsFilter != null)
      outgoingRels = outgoingRels.Where(item => !options.SemanticsFilter.Contains(item.Semantics)).Take(options.ListLimit).ToList();
    else
    if (options.TypeDataSelector.HasFlag(TDS.SelectedSemantics) && options.SemanticsFilter != null)
      outgoingRels = outgoingRels.Where(item => options.SemanticsFilter.Contains(item.Semantics)).Take(options.ListLimit).ToList();
    if (outgoingRels.Any())
    {
      Writer.WriteLine($"has {outgoingRels.Count} outgoing {Multi(outgoingRels.Count, "relationship")}");
      foreach (var rel in outgoingRels.Take(options.ListLimit))
      {
        Writer.Indent();
        Writer.WriteLine($"{rel.Semantics} -> {rel.Target.ToString()}");
        Writer.Unindent();
      }
      if (outgoingRels.Count() > 10)
        Writer.WriteLine("...");

    }
  }

  public void ShowIncomingRelationships(TypeInfo typeInfo, DisplayOptions options)
  {
    var incomingRels = TypeManager.GetIncomingRelationships(typeInfo).ToList();
    if (options.TypeDataSelector.HasFlag(TDS.ExcludeSemantics) && options.SemanticsFilter != null)
      incomingRels = incomingRels.Where(item => !options.SemanticsFilter.Contains(item.Semantics)).Take(options.ListLimit).ToList();
    else
    if (options.TypeDataSelector.HasFlag(TDS.SelectedSemantics) && options.SemanticsFilter != null)
      incomingRels = incomingRels.Where(item => options.SemanticsFilter.Contains(item.Semantics)).Take(options.ListLimit).ToList();
    if (incomingRels.Any())
    {
      Writer.WriteLine($"has {incomingRels.Count} incoming {Multi(incomingRels.Count, "relationship")}");
      foreach (var rel in incomingRels.Take(options.ListLimit))
      {
        Writer.Indent();
        Writer.WriteLine($"{rel.Semantics} <- {rel.Source.ToString()}");
        Writer.Unindent();
      }
      if (incomingRels.Count() > 10)
        Writer.WriteLine("...");
    }
  }

  public void ShowEnumValues(TypeInfo typeInfo, DisplayOptions options)
  {
    var enumValues = typeInfo.EnumValues;
    if (enumValues != null && enumValues.Any())
    {
      Writer.WriteLine("{");
      foreach (var enumValue in enumValues.Take(options.ListLimit).ToArray())
      {
        Writer.Indent();
        var str = $"{enumValue.Name}";
        Writer.WriteLine(str);
        Writer.Unindent();
      }
      if (enumValues.Count() > 10)
        Writer.WriteLine("...");
      Writer.WriteLine("}");
    }
  }

  public void ShowProperties(TypeInfo typeInfo, DisplayOptions options)
  {
    if (options.TypeDataSelector.HasFlag(TDS.AcceptedTypesOnly) && typeInfo.IsAccepted == false)
      return;
    var originNames = options.NamespaceTypeSelector == NTS.Origin || options.TypeDataSelector.HasFlag(TDS.OriginalNames);
    var properties = typeInfo.Properties;
    if (properties != null && properties.Any())
    {
      Writer.WriteLine("{");
      foreach (var property in properties.Take(options.ListLimit).ToArray())
      {
        if (options.TypeDataSelector.HasFlag(TDS.AcceptedTypesOnly) && property.IsAccepted == false)
          continue;
        Writer.Indent();
        var str = $"{property.Name}: {property.PropertyType.GetFullName(originNames)}";
        var changedToType = ModelManager.GetConversionTargetOrSelf(property.PropertyType);
        if (changedToType != null)
          str += $" => {changedToType.GetFullName(options.TypeDataSelector.HasFlag(TDS.AcceptedTypesOnly))}";
        //else if (property.PropertyType.IsAccepted != null)
        //  str += $" {{{Accepted(property.PropertyType.IsAccepted)}}}";
        Writer.WriteLine(str);
        Writer.Unindent();
      }
      if (properties.Count() > 10)
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
    if (type.IsConverted)
    {
      var convTarget = ModelManager.GetConversionTargetOrSelf(type);
      if (convTarget != null)
      {
        Writer.WriteLine($"{type} => {convTarget}");
        Writer.Indent();
        ShowTypeConversion(convTarget);
        Writer.Unindent();
      }
    }
  }

  public void ShowTypeRenames()
  {
    foreach (var typeInfo in TypeManager.AllTypes)
    {
      if (typeInfo.Name != typeInfo.OriginalName)
      {
        Writer.WriteLine($"{typeInfo.OriginalName} --> {typeInfo.Name}");
      }
    }
  }

  public void ShowProcessSummary(SummaryInfo info)
  {
    WriteLine();
    WriteLine($"Total time = {info.Time}");
  }

  #region Helper functions to format diplay
  protected string AllNone(int n, int cmp) => (n == 0) ? "none" : (n == cmp) ? "all" : n.ToString();
  protected string Multi(int n, string single, string? multi = null) => (n == 1) ? single : (multi ?? (single.EndsWith("s") ? (single + "es") : (single + "s")));
  protected string Accepted(bool? acceptance) => (acceptance == true) ? "+ " : (acceptance == false) ? "- " : "? ";
  #endregion

  protected bool IsTypeKind(TypeKind typeKind, TKS selector)
  {
    switch (typeKind)
    {
      case TypeKind.Type:
        return selector == TKS.Any;
      case TypeKind.Struct:
        return selector.HasFlag(TKS.Struct);
      case TypeKind.Class:
        return selector.HasFlag(TKS.Class);
      case TypeKind.Enum:
        return selector.HasFlag(TKS.Enum);
      case TypeKind.Interface:
        return selector.HasFlag(TKS.Interface);
    }
    return false;
  }

  protected string[] constaints = new string[]
  {
    "covariant",
    "contravariant",
    "class",
    "struct",
    "new()"
  };


}

