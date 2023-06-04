using System.CodeDom.Compiler;

using Qhta.TextUtils;

namespace ModelGen;

public class ModelDisplay : ModelMonitor
{
  private IndentedTextWriter Writer { get; set; } = new IndentedTextWriter(Console.Out, "  ");
  private int LineLength = 0;

  public void SetOutput(TextWriter textWriter)
  {
    Writer = new IndentedTextWriter(textWriter, "  ");
  }

  public override void WriteLine(string? str)
  {
    Writer.WriteLine(str);
    LineLength = (str?.Length ?? 0);
  }
  public override void WriteLine()
  {
    Writer.WriteLine();
    LineLength = 0;
  }

  public override void WriteSameLine(string str)
  {
    int maxLength = Console.WindowWidth - 1;
    if (str.Length > maxLength)
      str = str.Substring(maxLength);
    var l = str?.Length ?? 0;
    int n = (l < LineLength) ? LineLength - l : 0;
    Writer.Write($"\r{str}");
    if (n > 0)
      Writer.Write(new String(' ', n));
    LineLength = l;
  }

  public override void ShowNamespaceSummary(NTS originTargetSelector = NTS.Any)
  {
    WriteLine();
    WriteLine("Scanned namespaces:");
    var namespaces = TypeManager.GetNamespaces(originTargetSelector);
    if (namespaces.Any())
    {
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

  public override void ShowNamespacesDetails(DisplayOptions options)
  {
    WriteLine();
    WriteLine("Scanned types:");
    var namespaces = TypeManager.GetNamespaces(options.NamespaceTypeSelector).ToList();
    if (options.Namespaces != null)
      namespaces = namespaces.Where(item => options.Namespaces
      .FirstOrDefault(pattern => item == pattern || item.IsLike(pattern)) != null).ToList();
    foreach (var nspace in namespaces)
    {
      Writer.Indent++;
      ShowNamespaceDetails(nspace, options);
      Writer.Indent--;
    }
  }

  public override void ShowNamespaceDetails(string nspace, DisplayOptions options)
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
      Writer.Indent++;
      foreach (var typeInfo in nSpaceTypes)
      {
        if (typeInfo.IsGenericTypeParameter)
          continue;
        ShowTypeInfo(typeInfo, options);
      }
      Writer.Indent--;
    }
  }

  public override void ShowTypes(string nspace, string name)
  {
    var types = TypeManager.GetNamespace(nspace).Types.Where(item => item.Name.StartsWith(name));
    foreach (var type in types)
    {
      ShowTypeInfo(type);
    }
  }

  public override void ShowTypeInfo(TypeInfo typeInfo, DisplayOptions options = null!)
  {
    if (options == null)
      options = new DisplayOptions();
    if (!typeInfo.IsReflected)
      typeInfo.WaitForReflection();
    string str = "";
    if (!options.TypeDataSelector.HasFlag(TDS.AcceptedTypesOnly))
      str += Accepted(typeInfo.Acceptance);
    str += $"{typeInfo.TypeKind.ToString().ToLower()} {typeInfo.GetFullName(options.TypeDataSelector.HasFlag(TDS.OriginalNames))}";
    if (options.TypeDataSelector.HasFlag(TDS.ConversionInfo))
    {
      var changedToType = ModelManager.GetConversionTargetOrSelf(typeInfo);
      if (changedToType != null)
        str += $" => {changedToType.GetFullName(options.TypeDataSelector.HasFlag(TDS.OriginalNames))}";
    }
    Writer.WriteLine(str);
    if (options.TypeDataSelector.HasFlag(TDS.AcceptedTypesOnly) && typeInfo.IsAccepted == false)
      return;
    Writer.Indent++;
    if (options.TypeDataSelector.HasFlag(TDS.BaseTypes) && typeInfo.BaseTypeInfo != null)
    {
      str = $"based on: {typeInfo.BaseTypeInfo.GetFullName(options.TypeDataSelector.HasFlag(TDS.OriginalNames))}";
      if (options.TypeDataSelector.HasFlag(TDS.ConversionInfo))
      {
        var changedToType = ModelManager.GetConversionTargetOrSelf(typeInfo.BaseTypeInfo);
        if (changedToType != null)
          str += $" => {changedToType.GetFullName(options.TypeDataSelector.HasFlag(TDS.OriginalNames))}";
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
    Writer.Indent--;
  }

  public override void ShowGenericParamsConstraints(TypeInfo typeInfo, DisplayOptions options)
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
            ls.Add(item.GetFullName(options.TypeDataSelector.HasFlag(TDS.OriginalNames)));
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

  public override void ShowImplementedInterfaces(TypeInfo typeInfo, DisplayOptions options)
  {
    var implementedInterfaces = typeInfo.GetImplementedInterfaces();
    if (implementedInterfaces.Any())
    {
      foreach (var intfType in implementedInterfaces.Take(options.ListLimit).ToArray())
      {
        var str = $"implements {intfType.GetFullName(options.TypeDataSelector.HasFlag(TDS.OriginalNames))}";
        Writer.WriteLine(str);
      }
      if (implementedInterfaces.Count() > 10)
        Writer.WriteLine("...");
    }
  }

  public override void ShowElementsTypes(TypeInfo typeInfo, DisplayOptions options)
  {
    var includedTypes = typeInfo.GetIElementsTypes();
    if (includedTypes.Any())
    {
      foreach (var intfType in includedTypes.Take(options.ListLimit).ToArray())
      {
        var str = $"includes {intfType.GetFullName(options.TypeDataSelector.HasFlag(TDS.OriginalNames))}";
        Writer.WriteLine(str);
      }
      if (includedTypes.Count() > 10)
        Writer.WriteLine("...");
    }
  }

  public override void ShowOutgoingRelationships(TypeInfo typeInfo, DisplayOptions options)
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
        Writer.Indent++;
        Writer.WriteLine($"{rel.Semantics} -> {rel.Target.ToString()}");
        Writer.Indent--;
      }
      if (outgoingRels.Count() > 10)
        Writer.WriteLine("...");

    }
  }

  public override void ShowIncomingRelationships(TypeInfo typeInfo, DisplayOptions options)
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
        Writer.Indent++;
        Writer.WriteLine($"{rel.Semantics} <- {rel.Source.ToString()}");
        Writer.Indent--;
      }
      if (incomingRels.Count() > 10)
        Writer.WriteLine("...");
    }
  }

  public override void ShowEnumValues(TypeInfo typeInfo, DisplayOptions options)
  {
    var enumValues = typeInfo.EnumValues;
    if (enumValues != null && enumValues.Any())
    {
      Writer.WriteLine("{");
      foreach (var enumValue in enumValues.Take(options.ListLimit).ToArray())
      {
        Writer.Indent++;
        var str = $"{enumValue.Name}";
        Writer.WriteLine(str);
        Writer.Indent--;
      }
      if (enumValues.Count() > 10)
        Writer.WriteLine("...");
      Writer.WriteLine("}");
    }
  }

  public override void ShowProperties(TypeInfo typeInfo, DisplayOptions options)
  {
    if (options.TypeDataSelector.HasFlag(TDS.AcceptedTypesOnly) && typeInfo.IsAccepted == false)
      return;
    var properties = typeInfo.Properties;
    if (properties != null && properties.Any())
    {
      Writer.WriteLine("{");
      foreach (var property in properties.Take(options.ListLimit).ToArray())
      {
        if (options.TypeDataSelector.HasFlag(TDS.AcceptedTypesOnly) && property.IsAccepted == false)
          continue;
        Writer.Indent++;
        var str = $"{property.Name}: {property.PropertyType.GetFullName(options.TypeDataSelector.HasFlag(TDS.AcceptedTypesOnly))}";
        var changedToType = ModelManager.GetConversionTargetOrSelf(property.PropertyType);
        if (changedToType != null)
          str += $" => {changedToType.GetFullName(options.TypeDataSelector.HasFlag(TDS.AcceptedTypesOnly))}";
        //else if (property.PropertyType.IsAccepted != null)
        //  str += $" {{{Accepted(property.PropertyType.IsAccepted)}}}";
        Writer.WriteLine(str);
        Writer.Indent--;
      }
      if (properties.Count() > 10)
        Writer.WriteLine("...");
      Writer.WriteLine("}");
    }
  }

  public override void ShowTypeConversions()
  {
    foreach (var type in TypeManager.AllTypes)
    {
      ShowTypeConversion(type);
    }
  }

  public override void ShowTypeConversion(TypeInfo type)
  {
    if (type.IsConverted)
    {
      var convTarget = ModelManager.GetConversionTargetOrSelf(type);
      if (convTarget != null)
      {
        Writer.WriteLine($"{type} => {convTarget}");
        Writer.Indent++;
        ShowTypeConversion(convTarget);
        Writer.Indent--;
      }
    }
  }

  public override void ShowTypeRenames()
  {
    foreach (var typeInfo in TypeManager.AllTypes)
    {
      if (typeInfo.Name != typeInfo.OriginalName)
      {
        Writer.WriteLine($"{typeInfo.OriginalName} --> {typeInfo.Name}");
      }
    }
  }

  public override void ShowProcessSummary(ProcessInfo info)
  {
    WriteLine();
    WriteLine($"Total time = {info.TotalTime}");
  }

}

