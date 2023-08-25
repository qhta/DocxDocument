namespace ModelGen;


public class ProgressInfo
{
  public string? PreStr { get; set; }
  public int? TotalTypes { get; set; }
  public int? CheckedTypes { get; set; }
  public int? ProcessedTypes { get; set; }
  public int? Namespaces { get; set; }
  public string? PostStr { get; set; }
}

public class SummaryInfo
{
  public TimeSpan Time { get; set; }
  public Dictionary<SummaryInfoKind, object>? Summary {get; set; }
}

public abstract class ModelMonitor
{
  public abstract void WriteLine();
  public abstract void WriteLine(string line);
  public abstract void WriteSameLine(string line);

  public abstract void Indent();
  public abstract void Unindent();

  public abstract DocumentationWriter GetDocumentationWriter(DisplayOptions options);

  public PPS PhaseNum { get; protected set; }

  public string? PhaseName { get; protected set; }

  public virtual void ShowProcessStart(string line)
  {
    WriteLine(line);
  }

  public virtual void ShowPhaseStart(PPS phaseNumber, string phaseName)
  {
    PhaseNum = phaseNumber;
    PhaseName = phaseName;
    WriteLine();
    WriteLine($"Start {phaseName.ToLower()}");
  }

  public virtual void ShowPhaseProgress(PPS phaseNumber, ProgressInfo info)
  {
    var sl = new List<string>();
    if (info.PreStr != null)
      sl.Add(info.PreStr);
    if (info.ProcessedTypes != null && info.TotalTypes != null)
      sl.Add($"{info.ProcessedTypes}/{info.TotalTypes}");
    else if (info.ProcessedTypes != null)
      sl.Add($"{info.ProcessedTypes}");
    sl.Add("types");
    if (info.Namespaces != null)
      sl.Add($"in {info.Namespaces} namespaces");
    if (info.PostStr != null)
    {
      sl.Add("|");
      sl.Add(info.PostStr);
    }
    var str = String.Join(" ", sl);
    if (str != "")
      WriteSameLine(str);
  }

  public virtual void ShowPhaseEnd(PPS phaseNumber, SummaryInfo info)
  {
    WriteSameLine("");
    Debug.Assert(phaseNumber == PhaseNum);
    WriteLine($"End {PhaseName?.ToLower()}, time={info.Time}");
    if (info.Summary != null)
      foreach (var item in info.Summary)
      {
        //if (item.Key.Contains('{'))
        //  WriteLine(String.Format(item.Key, item.Value));
        //else
        WriteLine($"{item.Key.ToString().DeCamelCase()} = {item.Value}");
      }

  }

  public virtual void ShowNamespaceSummary(PPS phase, NTS originTargetSelector)
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
        var acceptedTypesCount = nSpaceTypes.Count(item => !item.IsAcceptedAfter(phase));
        var rejectedTypesCount = nSpaceTypes.Count(item => item.IsRejectedAfter(phase));
        var classTypesCount = nSpaceTypes.Count(item => item.TypeKind == TypeKind.@class);
        var enumTypesCount = nSpaceTypes.Count(item => item.TypeKind == TypeKind.@enum);
        var otherTypesCount = nSpaceTypes.Count(item => item.TypeKind != TypeKind.@class && item.TypeKind != TypeKind.@enum);
        var str = $"{aSpace} Total {totalTypesCount} types";
        str += $", {AllOrNoneOrValueStr(acceptedTypesCount, totalTypesCount)} accepted";
        if (rejectedTypesCount != 0)
          str += $", {AllOrNoneOrValueStr(rejectedTypesCount, totalTypesCount)} rejected";
        if (classTypesCount != 0)
          str += $", {AllOrNoneOrValueStr(classTypesCount, totalTypesCount)} {MultiStr(classTypesCount, "class")}";
        if (enumTypesCount != 0)
          str += $", {AllOrNoneOrValueStr(enumTypesCount, totalTypesCount)} {MultiStr(enumTypesCount, "enum")}";
        if (otherTypesCount != 0)
          str += $", {AllOrNoneOrValueStr(otherTypesCount, totalTypesCount)} {MultiStr(otherTypesCount, "other")}";
        WriteLine(str);
      }
    }
  }

  public virtual void ShowNamespacesDetails(PPS phase, DisplayOptions options)
  {
    WriteLine();
    string? filter = null;
    if (options.TypeStatusSelector != MSS.Any)
      filter = " " + options.TypeStatusSelector.ToString().ToLower();
    WriteLine($"Scanned{filter} types:");
    var namespaces = TypeManager.GetNamespaces(options.NamespaceTypeSelector).ToList();
    if (options.Namespaces != null)
      namespaces = namespaces.Where(item => options.Namespaces
      .FirstOrDefault(pattern => item == pattern || item.IsLike(pattern)) != null).ToList();
    namespaces.Sort();
    foreach (var nspace in namespaces)
    {
      Indent();
      ShowNamespaceTypes(phase, nspace, options);
      Unindent();
    }
  }

  public virtual void ShowNamespaceTypes(PPS phase, string nspace, DisplayOptions options)
  {
    var nSpaceTypes = TypeManager.GetNamespaceTypes(nspace).ToList();
    if (options.Typenames != null)
      nSpaceTypes = nSpaceTypes.Where(item => options.Typenames
      .FirstOrDefault(pattern => item.Name == pattern || item.Name.IsLike(pattern)) != null).ToList();
    if (options.TypeKindSelector != TKS.Any)
      nSpaceTypes = nSpaceTypes.Where(item => IsTypeKind(item.TypeKind, options.TypeKindSelector)).ToList();
    if (options.TypeStatusSelector != MSS.Any)
    {
      if (options.TypeStatusSelector.HasFlag(MSS.Accepted) || options.TypeStatusSelector.HasFlag(MSS.Rejected))
        nSpaceTypes = nSpaceTypes.Where(item =>
          options.TypeStatusSelector.HasFlag(MSS.Accepted) && item.IsAcceptedAfter(phase)
          || options.TypeStatusSelector.HasFlag(MSS.Rejected) && item.IsRejectedAfter(phase)).ToList();
      if (options.TypeStatusSelector.HasFlag(MSS.Valid) || options.TypeStatusSelector.HasFlag(MSS.Invalid))
        nSpaceTypes = nSpaceTypes.Where(item =>
          options.TypeStatusSelector.HasFlag(MSS.Valid) && !item.HasProblems(PhaseNum)
          || options.TypeStatusSelector.HasFlag(MSS.Invalid) && item.HasProblems(PhaseNum)).ToList();
    }
    var originNames = options.NamespaceTypeSelector == NTS.Origin || options.TypeDataSelector.HasFlag(TDS.OriginalNames);
    if (nSpaceTypes.Count() > 0)
    {
      nSpaceTypes.Sort((item1, item2) => item1.GetFullName(originNames, true, true).Name.CompareTo(item2.GetFullName(originNames, true, true).Name));
      var listCount = 0;
      var listCont = false;
      WriteLine();
      WriteLine($"namespace {nspace}");
      Indent();
      foreach (var typeInfo in nSpaceTypes)
      {
        if (typeInfo.IsGenericTypeParameter)
          continue;
        if (options.TypesLimit > 0 && listCount++ > options.TypesLimit)
        {
          listCont = true;
          break;
        }
        ShowTypeInfo(phase, typeInfo, options);
      }
      if (listCont)
        WriteLine("...");
      Unindent();
    }
  }

  public virtual void ShowTypeInfo(PPS phase, TypeInfo typeInfo, DisplayOptions options)
  {
    //if (options.TypeDataSelector.HasFlag(TDS.Documentation))
    //  ShowDocumentation(typeInfo, options);
    if (options.TypeDataSelector.HasFlag(TDS.Metadata))
      ShowMetadata(typeInfo, options);
    string str = AcceptedMark(typeInfo.IsAcceptedAfter(phase));
    var originNames = options.NamespaceTypeSelector == NTS.Origin || options.TypeDataSelector.HasFlag(TDS.OriginalNames);
    str += $"{typeInfo.TypeKind.ToString().ToLower()} {typeInfo.GetFullName(!originNames, true, true)}";
    List<string> status = new List<string>();
    if (typeInfo.HasProblems(PhaseNum))
      status.Add(ValidStr(false));
    if (status.Count > 0)
      str += " { " + string.Join(", ", status) + " }";
    if (options.TypeDataSelector.HasFlag(TDS.ConversionInfo))
    {
      var changedToType = ModelManager.GetConversionTargetOrSelf(typeInfo);
      if (changedToType != null)
        str += $" => {changedToType.GetFullName(true, true, true)}";
    }
    WriteLine(str);
    Indent();
    if (options.TypeDataSelector.HasFlag(TDS.BaseTypes) && typeInfo.BaseTypeInfo != null)
    {
      str = $"based on: {typeInfo.BaseTypeInfo.GetFullName(!originNames, true, true)}";
      if (options.TypeDataSelector.HasFlag(TDS.ConversionInfo))
      {
        var changedToType = ModelManager.GetConversionTargetOrSelf(typeInfo.BaseTypeInfo);
        if (changedToType != null)
          str += $" => {changedToType.GetFullName(true, true, true)}";
      }
      WriteLine(str);
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
    if (options.TypeDataSelector.HasFlag(TDS.ElementSchema))
      ShowElementSchema(typeInfo, options);
    Unindent();
    if (options.TypeDataSelector.HasFlag(TDS.EnumValues))
      ShowEnumValues(typeInfo, options);
    if (options.TypeDataSelector.HasFlag(TDS.Properties))
      ShowProperties(phase,typeInfo, options);
  }

  public virtual void ShowGenericParamsConstraints(TypeInfo typeInfo, DisplayOptions options)
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
            ls.Add(item.GetFullName(!originNames, true, true));
        var genericParamConstraints = genericTypeParam.GetGenericParamConstraints();
        if (genericParamConstraints != null)
          foreach (var item in genericParamConstraints.ToArray())
            ls.Add(constraints[(int)item]);
        if (ls.Count > 0)
        {
          var str = $"where {genericTypeParam.Name}: " + String.Join(", ", ls);
          WriteLine(str);
        }
      }
    }
  }

  public virtual void ShowImplementedInterfaces(TypeInfo typeInfo, DisplayOptions options)
  {
    var originNames = options.NamespaceTypeSelector == NTS.Origin || options.TypeDataSelector.HasFlag(TDS.OriginalNames);
    var implementedInterfaces = typeInfo.GetImplementedInterfaces().ToList();
    if (implementedInterfaces.Any())
    {
      implementedInterfaces.Sort((item1, item2) => item1.GetFullName(!originNames, true, true).ToString().CompareTo(item2.GetFullName(!originNames, true, true)));
      var listCount = 0;
      var listCont = false;
      foreach (var intfType in implementedInterfaces)
      {
        if (options.DetailsLimit > 0 && listCount++ > options.DetailsLimit)
        {
          listCont = true;
          break;
        }
        var str = $"implements {intfType.GetFullName(!originNames, true, true)}";
        WriteLine(str);
      }
      if (listCont)
        WriteLine("...");
    }
  }

  public virtual void ShowElementsTypes(TypeInfo typeInfo, DisplayOptions options)
  {
    var originNames = options.NamespaceTypeSelector == NTS.Origin || options.TypeDataSelector.HasFlag(TDS.OriginalNames);
    var includedTypes = typeInfo.GetIElementsTypes().ToList();
    if (includedTypes.Any())
    {
      includedTypes.Sort((item1, item2) => item1.GetFullName(!originNames, true, true).ToString().CompareTo(item2.GetFullName(!originNames, true, true)));
      var listCount = 0;
      var listCont = false;
      foreach (var intfType in includedTypes)
      {
        if (options.DetailsLimit > 0 && listCount++ > options.DetailsLimit)
        {
          listCont = true;
          break;
        }
        var str = $"includes {intfType.GetFullName(!originNames, true, true)}";
        WriteLine(str);
      }
      if (listCont)
        WriteLine("...");
    }
  }

  public virtual void ShowOutgoingRelationships(TypeInfo typeInfo, DisplayOptions options)
  {
    var outgoingRels = TypeManager.GetOutgoingRelationships(typeInfo).ToList();
    if (options.TypeDataSelector.HasFlag(TDS.ExcludeSemantics) && options.SemanticsFilter != null)
      outgoingRels = outgoingRels.Where(item => !options.SemanticsFilter.Contains(item.Semantics)).ToList();
    else
    if (options.TypeDataSelector.HasFlag(TDS.SelectedSemantics) && options.SemanticsFilter != null)
      outgoingRels = outgoingRels.Where(item => options.SemanticsFilter.Contains(item.Semantics)).ToList();
    if (outgoingRels.Any())
    {
      WriteLine($"has {outgoingRels.Count} outgoing {MultiStr(outgoingRels.Count, "relationship")}");
      var listCount = 0;
      var listCont = false;
      foreach (var rel in outgoingRels)
      {
        if (options.DetailsLimit > 0 && listCount++ > options.DetailsLimit)
        {
          listCont = true;
          break;
        }
        Indent();
        WriteLine($"{rel.Semantics} -> {rel.Target.ToString()}{RelationshipConstraints(rel)}");
        Unindent();
      }
      if (listCont)
        WriteLine("...");

    }
  }

  public virtual void ShowIncomingRelationships(TypeInfo typeInfo, DisplayOptions options)
  {
    var incomingRels = TypeManager.GetIncomingRelationships(typeInfo).ToList();
    if (options.TypeDataSelector.HasFlag(TDS.ExcludeSemantics) && options.SemanticsFilter != null)
      incomingRels = incomingRels.Where(item => !options.SemanticsFilter.Contains(item.Semantics)).ToList();
    else
    if (options.TypeDataSelector.HasFlag(TDS.SelectedSemantics) && options.SemanticsFilter != null)
      incomingRels = incomingRels.Where(item => options.SemanticsFilter.Contains(item.Semantics)).ToList();
    if (incomingRels.Any())
    {
      WriteLine($"has {incomingRels.Count} incoming {MultiStr(incomingRels.Count, "relationship")}");
      var listCount = 0;
      var listCont = false;
      foreach (var rel in incomingRels)
      {
        if (options.DetailsLimit > 0 && listCount++ > options.DetailsLimit)
        {
          listCont = true;
          break;
        }
        Indent();
        WriteLine($"{rel.Semantics} <- {rel.Source.ToString()}");
        Unindent();
      }
      if (listCont)
        WriteLine("...");
    }
  }

  public virtual void ShowEnumValues(TypeInfo typeInfo, DisplayOptions options)
  {
    var enumValues = typeInfo.EnumValues?.ToList();
    if (enumValues != null && enumValues.Any())
    {
      WriteLine("{");
      var listCount = 0;
      var listCont = false;
      Indent();
      foreach (var enumValue in enumValues)
      {
        if (options.DetailsLimit > 0 && listCount++ > options.DetailsLimit)
        {
          listCont = true;
          break;
        }
        //if (options.TypeDataSelector.HasFlag(TDS.Documentation))
        //  ShowDocumentation(enumValue, options);
        if (options.TypeDataSelector.HasFlag(TDS.Metadata))
          ShowMetadata(enumValue, options);
        var str = $"{enumValue.Name}={enumValue.Value}";
        WriteLine(str);
      }
      if (listCont)
        WriteLine("...");
      Unindent();
      WriteLine("}");
    }
  }

  public virtual void ShowProperties(PPS phase, TypeInfo typeInfo, DisplayOptions options)
  {
    if (typeInfo.Properties == null)
      return;
    var originNames = options.NamespaceTypeSelector == NTS.Origin || options.TypeDataSelector.HasFlag(TDS.OriginalNames);
    var properties = typeInfo.Properties.ToList();
    if (properties.Any())
    {
      if (options.MemberStatusSelector != MSS.Any)
      {
        properties = properties.Where(item =>
          options.MemberStatusSelector.HasFlag(MSS.Accepted) && item.IsAcceptedAfter(phase) ||
          options.MemberStatusSelector.HasFlag(MSS.Rejected) && item.IsRejectedAfter(phase) ||
          options.MemberStatusSelector.HasFlag(MSS.Used) && item.IsUsed ||
          options.MemberStatusSelector.HasFlag(MSS.Unused) && !item.IsUsed ||
          options.MemberStatusSelector.HasFlag(MSS.Valid) && !item.HasProblems(PhaseNum) ||
          options.MemberStatusSelector.HasFlag(MSS.Invalid) && !item.HasProblems(PhaseNum) ||
          options.MemberStatusSelector.HasFlag(MSS.Converted) && item.IsConverted ||
          options.MemberStatusSelector.HasFlag(MSS.ConvertedTo) && item.IsConvertedTo
        ).ToList();
      }
      WriteLine("{");
      Indent();
      foreach (var property in properties)
      {
        if (options.TypeDataSelector.HasFlag(TDS.Metadata))
          ShowMetadata(property, options);
        var str = $"{property.Name}: {property.PropertyType.GetFullName(originNames, true, true)}";
        if (options.TypeDataSelector.HasFlag(TDS.ConversionInfo))
        {
          var changedToType = ModelManager.GetConversionTargetOrSelf(property.PropertyType);
          if (changedToType != null)
            str += $" => {changedToType.GetFullName(true, true, true  )}";
        }
        WriteLine(str);
      }
      if (properties.Count() > 10)
        WriteLine("...");
      Unindent();
      WriteLine("}");
    }
  }

  public virtual void ShowMetadata(ModelElement element, DisplayOptions options)
  {
    var documentation = element.GetDocumentation();
    if (documentation != null)
    {
      WriteLine();
      foreach (var item in documentation)
      {
        var documentationWriter = GetDocumentationWriter(options);
        documentationWriter.Write(item);
      }
    }
    var schema = element.Schema;
    if (schema != null)
    {
      if (schema.SchemaTag != null)
      {
        var isAttribStr = "";
        if (schema.SchemaIsAttrib)
          isAttribStr = " isAttrib=\"true\"";
        WriteLine($"/// <schemaTag{isAttribStr}>{schema.SchemaTag}</schemaTag>");
      }
      if (schema.SchemaUrl != null)
        WriteLine($"/// <schemaUrl>{schema.SchemaUrl}</schemaUrl>");
    }
    if (element.OfficeVersion != null)
      WriteLine($"/// <availability>{element.OfficeVersion}</availability>");
    if (element is PropInfo propInfo)
    {
      if (propInfo.IsRequired)
        WriteLine($"/// <isRequired>True</isRequired>");
      if (propInfo.IsEnum)
        WriteLine($"/// <isEnum>True</isEnum>");
      if (propInfo.IsList)
        WriteLine($"/// <isList>True</isList>");
      if (propInfo.RealTypeName != null)
        WriteLine($"/// <realTypeName>{propInfo.RealTypeName}</realTypeName>");
      if (propInfo.IsConstrained)
        WriteLine($"/// <isConstrained>True</isConstrained>");
      if (propInfo.Constraints!=null)
        foreach (var constraint in propInfo.Constraints)
        {
          if (constraint is StringConstraint stringConstraint)
            ShowStringConstraint(stringConstraint);
          else
          if (constraint is NumberConstraint numberConstraint)
            ShowNumberConstraint(numberConstraint);
        }
    }
  }

  private void ShowStringConstraint(StringConstraint stringConstraint)
  {
    var attribs = new List<string>();
    if (stringConstraint.MinLength != null)
      attribs.Add($" minLength=\"{stringConstraint.MinLength}\"");
    if (stringConstraint.MaxLength != null)
      attribs.Add($" minLength=\"{stringConstraint.MaxLength}\"");
    if (stringConstraint.FixLength != null)
      attribs.Add($" length=\"{stringConstraint.FixLength}\"");
    if (stringConstraint.Regex != null)
      attribs.Add($" regex=\"{stringConstraint.Regex}\"");
    if (stringConstraint.XsdType != null)
      attribs.Add($" xsdType=\"{stringConstraint.XsdType}\"");
    WriteLine($"/// <stringConstraint{string.Join("",attribs)}/>");
  }

    private void ShowNumberConstraint(NumberConstraint number)
  {
    var attribs = new List<string>();
    if (number.MinInclusive != null)
      attribs.Add($" minInclusive=\"{number.MinInclusive}\"");
    if (number.MaxInclusive != null)
      attribs.Add($" minInclusive=\"{number.MaxInclusive}\"");
    if (number.MinExclusive != null)
      attribs.Add($" minExclusive=\"{number.MinExclusive}\"");
    if (number.MaxExclusive != null)
      attribs.Add($" minExclusive=\"{number.MaxExclusive}\"");
    WriteLine($"/// <stringConstraint{string.Join("",attribs)}/>");
  }
  public virtual void ShowTypeConversions()
  {
    foreach (var type in TypeManager.AllTypes)
    {
      ShowTypeConversion(type);
    }
  }

  public virtual void ShowTypeConversion(TypeInfo type)
  {
    if (type.IsConverted)
    {
      var convTarget = ModelManager.GetConversionTargetOrSelf(type);
      if (convTarget != null)
      {
        WriteLine($"{type} => {convTarget}");
        Indent();
        ShowTypeConversion(convTarget);
        Unindent();
      }
    }
  }

  public virtual void ShowTypeRenames()
  {
    foreach (var typeInfo in TypeManager.AllTypes)
    {
      if (typeInfo.Name != typeInfo.OriginalName)
      {
        WriteLine($"{typeInfo.OriginalName} --> {typeInfo.Name}");
      }
    }
  }

  public virtual void ShowProcessSummary(SummaryInfo info)
  {
    WriteLine();
    WriteLine($"Total time = {info.Time}");
  }

  public virtual void ShowElementSchema(TypeInfo typeInfo, DisplayOptions options)
  {
    if (typeInfo.Schema != null)
    {
      typeInfo.Schema.Rename();
      if (typeInfo.Schema?.Main != null)
        WriteSchemaParticle(typeInfo.Schema.Main);
    }
  }

  public virtual void WriteSchemaParticle(SchemaParticle particle)
  {
    if (particle is ItemElementParticle itemElementParticle)
    {
      WriteLine($"<xsd:element type=\"{itemElementParticle.ItemType.GetFullName(true, true, true)}\"" +
        $" {ParticleAttribs(particle)}/>");
    }
    else
    if (particle is ItemsParticle itemsParticle)
    {
      var particleType = particle.ParticleType.ToString().ToLower();
      WriteLine($"<xsd:{particleType} {ParticleAttribs(particle)}>");
      Indent();
      foreach (var item in itemsParticle.Items)
        WriteSchemaParticle(item);
      Unindent();
      WriteLine($"</xsd:{particleType}>");
    }
  }

  protected string ParticleAttribs(SchemaParticle particle)
  {
    List<string> attribs = new List<string>();
    if (particle.Name != null)
      attribs.Add($"name=\"{particle.Name}\"");
    attribs.Add($"required=\"{particle.IsRequired}\"");
    if (particle.IsMultiple)
      attribs.Add($"multiple=\"{particle.IsMultiple}\"");
    if (particle.MinOccurs != null && particle.MinOccurs != particle.DefMinOccurs)
      attribs.Add($"minOccurs=\"{particle.MinOccurs}\"");
    if (particle.MaxOccurs != null && particle.MaxOccurs != particle.DefMaxOccurs)
      attribs.Add($"maxOccurs=\"{particle.MaxOccurs}\"");
    return String.Join(" ", attribs);
  }

  #region Helper functions to format diplay
  protected string AllOrNoneOrValueStr(int n, int cmp) => (n == 0) ? "none" : (n == cmp) ? "all" : n.ToString();
  protected string MultiStr(int n, string single, string? multi = null) => (n == 1) ? single : (multi ?? (single.EndsWith("s") ? (single + "es") : (single + "s")));
  protected string AcceptedMark(bool? acceptance) => (acceptance == true) ? "+ " : (acceptance == false) ? "- " : "  ";
  protected string ValidStr(bool? validity) => (validity == true) ? "valid" : (validity == false) ? "invalid" : string.Empty;
  protected string RelationshipConstraints(TypeRelationship rel) => (rel.IsMultiple) ? "{multiple}" : string.Empty;

  #endregion

  protected bool IsTypeKind(TypeKind typeKind, TKS selector)
  {
    switch (typeKind)
    {
      case TypeKind.type:
        return selector == TKS.Any;
      case TypeKind.@struct:
        return selector.HasFlag(TKS.Struct);
      case TypeKind.@class:
        return selector.HasFlag(TKS.Class);
      case TypeKind.@enum:
        return selector.HasFlag(TKS.Enum);
      case TypeKind.@interface:
        return selector.HasFlag(TKS.Interface);
    }
    return false;
  }

  protected string[] constraints = new string[]
  {
    "covariant",
    "contravariant",
    "class",
    "struct",
    "new()"
  };



}
