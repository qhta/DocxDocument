using System.Collections.Immutable;
using System.Runtime.Serialization;
using System.Text.Encodings.Web;
using System.Xml.Linq;

using DocumentFormat.OpenXml.ExtendedProperties;

namespace ModelGenRun;

public class ModelDisplay : IModelMonitor
{
  private TraceWriter Writer { get; set; }
  private int LineLength = 0;

  public ModelDisplay()
  {
    Writer = new TraceWriter();
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
    if (info.PreStr != null)
      sl.Add(info.PreStr);
    if (info.Done != null && info.Total != null)
      sl.Add($"{info.Done}/{info.Total}");
    else if (info.Done != null)
      sl.Add($"{info.Done}");
    if (info.MidStr != null)
      sl.Add(info.MidStr);
    if (info.Summary != null)
      foreach (var item in info.Summary)
      {
        if (item.Key.Contains('{'))
          sl.Add(String.Format(item.Key, item.Value));
        else
          sl.Add($"{item.Key} = {item.Value}");
      }
    if (info.PostStr != null)
      sl.Add(info.PostStr);
    var str = String.Join(" ", sl);
    if (str != "")
      WriteSameLine(str);
  }

  public void ShowPhaseEnd(string phaseName, SummaryInfo info)
  {
    WriteLine();
    WriteLine($"End {phaseName.ToLower()}, time={info.Time}");
    if (info.Summary != null)
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
      Writer.Indent();
      ShowNamespaceTypes(nspace, options);
      Writer.Unindent();
    }
  }

  public void ShowNamespaceTypes(string nspace, DisplayOptions options)
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
          options.TypeStatusSelector.HasFlag(MSS.Accepted) && item.IsAccepted
          || options.TypeStatusSelector.HasFlag(MSS.Rejected) && item.IsRejected).ToList();
      if (options.TypeStatusSelector.HasFlag(MSS.Valid) || options.TypeStatusSelector.HasFlag(MSS.Invalid))
        nSpaceTypes = nSpaceTypes.Where(item =>
          options.TypeStatusSelector.HasFlag(MSS.Valid) && item.IsValid
          || options.TypeStatusSelector.HasFlag(MSS.Invalid) && item.IsInvalid).ToList();
    }
    var originNames = options.NamespaceTypeSelector == NTS.Origin || options.TypeDataSelector.HasFlag(TDS.OriginalNames);
    if (nSpaceTypes.Count() > 0)
    {
      nSpaceTypes.Sort((item1, item2) => item1.GetFullName(originNames).Name.CompareTo(item2.GetFullName(originNames).Name));
      var listCount = 0;
      var listCont = false;
      Writer.WriteLine();
      Writer.WriteLine($"namespace {nspace}");
      Writer.Indent();
      foreach (var typeInfo in nSpaceTypes)
      {
        if (typeInfo.IsGenericTypeParameter)
          continue;
        if (options.TypesLimit > 0 && listCount++ > options.TypesLimit)
        {
          listCont = true;
          break;
        }
        ShowTypeInfo(typeInfo, options);
      }
      if (listCont)
        Writer.WriteLine("...");
      Writer.Unindent();
    }
  }

  public void ShowTypeInfo(TypeInfo typeInfo, DisplayOptions options)
  {
    //if (options.TypeDataSelector.HasFlag(TDS.Documentation))
    //  ShowDocumentation(typeInfo, options);
    if (options.TypeDataSelector.HasFlag(TDS.Metadata))
      ShowMetadata(typeInfo, options);
    string str = AcceptedMark(typeInfo.Acceptance);
    var originNames = options.NamespaceTypeSelector == NTS.Origin || options.TypeDataSelector.HasFlag(TDS.OriginalNames);
    str += $"{typeInfo.TypeKind.ToString().ToLower()} {typeInfo.GetFullName(originNames)}";
    List<string> status = new List<string>();
    if (typeInfo.Validity != null)
      status.Add(ValidStr(typeInfo.Validity));
    if (status.Count > 0)
      str += " { " + string.Join(", ", status) + " }";
    if (options.TypeDataSelector.HasFlag(TDS.ConversionInfo))
    {
      var changedToType = ModelManager.GetConversionTargetOrSelf(typeInfo);
      if (changedToType != null)
        str += $" => {changedToType.GetFullName()}";
    }
    Writer.WriteLine(str);
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
    if (options.TypeDataSelector.HasFlag(TDS.ElementSchema))
      ShowElementSchema(typeInfo, options);
    Writer.Unindent();
    if (options.TypeDataSelector.HasFlag(TDS.EnumValues))
      ShowEnumValues(typeInfo, options);
    if (options.TypeDataSelector.HasFlag(TDS.Properties))
      ShowProperties(typeInfo, options);
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
    var implementedInterfaces = typeInfo.GetImplementedInterfaces().ToList();
    if (implementedInterfaces.Any())
    {
      implementedInterfaces.Sort((item1, item2) => item1.GetFullName(originNames).ToString().CompareTo(item2.GetFullName(originNames)));
      var listCount = 0;
      var listCont = false;
      foreach (var intfType in implementedInterfaces)
      {
        if (options.DetailsLimit > 0 && listCount++ > options.DetailsLimit)
        {
          listCont = true;
          break;
        }
        var str = $"implements {intfType.GetFullName(originNames)}";
        Writer.WriteLine(str);
      }
      if (listCont)
        Writer.WriteLine("...");
    }
  }

  public void ShowElementsTypes(TypeInfo typeInfo, DisplayOptions options)
  {
    var originNames = options.NamespaceTypeSelector == NTS.Origin || options.TypeDataSelector.HasFlag(TDS.OriginalNames);
    var includedTypes = typeInfo.GetIElementsTypes().ToList();
    if (includedTypes.Any())
    {
      includedTypes.Sort((item1, item2) => item1.GetFullName(originNames).ToString().CompareTo(item2.GetFullName(originNames)));
      var listCount = 0;
      var listCont = false;
      foreach (var intfType in includedTypes)
      {
        if (options.DetailsLimit > 0 && listCount++ > options.DetailsLimit)
        {
          listCont = true;
          break;
        }
        var str = $"includes {intfType.GetFullName(originNames)}";
        Writer.WriteLine(str);
      }
      if (listCont)
        Writer.WriteLine("...");
    }
  }

  public void ShowOutgoingRelationships(TypeInfo typeInfo, DisplayOptions options)
  {
    var outgoingRels = TypeManager.GetOutgoingRelationships(typeInfo).ToList();
    if (options.TypeDataSelector.HasFlag(TDS.ExcludeSemantics) && options.SemanticsFilter != null)
      outgoingRels = outgoingRels.Where(item => !options.SemanticsFilter.Contains(item.Semantics)).ToList();
    else
    if (options.TypeDataSelector.HasFlag(TDS.SelectedSemantics) && options.SemanticsFilter != null)
      outgoingRels = outgoingRels.Where(item => options.SemanticsFilter.Contains(item.Semantics)).ToList();
    if (outgoingRels.Any())
    {
      Writer.WriteLine($"has {outgoingRels.Count} outgoing {Multi(outgoingRels.Count, "relationship")}");
      var listCount = 0;
      var listCont = false;
      foreach (var rel in outgoingRels)
      {
        if (options.DetailsLimit > 0 && listCount++ > options.DetailsLimit)
        {
          listCont = true;
          break;
        }
        Writer.Indent();
        Writer.WriteLine($"{rel.Semantics} -> {rel.Target.ToString()}");
        Writer.Unindent();
      }
      if (listCont)
        Writer.WriteLine("...");

    }
  }

  public void ShowIncomingRelationships(TypeInfo typeInfo, DisplayOptions options)
  {
    var incomingRels = TypeManager.GetIncomingRelationships(typeInfo).ToList();
    if (options.TypeDataSelector.HasFlag(TDS.ExcludeSemantics) && options.SemanticsFilter != null)
      incomingRels = incomingRels.Where(item => !options.SemanticsFilter.Contains(item.Semantics)).ToList();
    else
    if (options.TypeDataSelector.HasFlag(TDS.SelectedSemantics) && options.SemanticsFilter != null)
      incomingRels = incomingRels.Where(item => options.SemanticsFilter.Contains(item.Semantics)).ToList();
    if (incomingRels.Any())
    {
      Writer.WriteLine($"has {incomingRels.Count} incoming {Multi(incomingRels.Count, "relationship")}");
      var listCount = 0;
      var listCont = false;
      foreach (var rel in incomingRels)
      {
        if (options.DetailsLimit > 0 && listCount++ > options.DetailsLimit)
        {
          listCont = true;
          break;
        }
        Writer.Indent();
        Writer.WriteLine($"{rel.Semantics} <- {rel.Source.ToString()}");
        Writer.Unindent();
      }
      if (listCont)
        Writer.WriteLine("...");
    }
  }

  public void ShowEnumValues(TypeInfo typeInfo, DisplayOptions options)
  {
    var enumValues = typeInfo.EnumValues?.ToList();
    if (enumValues != null && enumValues.Any())
    {
      Writer.WriteLine("{");
      var listCount = 0;
      var listCont = false;
      Writer.Indent();
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
        Writer.WriteLine(str);
      }
      if (listCont)
        Writer.WriteLine("...");
      Writer.Unindent();
      Writer.WriteLine("}");
    }
  }

  public void ShowProperties(TypeInfo typeInfo, DisplayOptions options)
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
          options.MemberStatusSelector.HasFlag(MSS.Accepted) && item.IsAccepted ||
          options.MemberStatusSelector.HasFlag(MSS.Rejected) && item.IsRejected ||
          options.MemberStatusSelector.HasFlag(MSS.Used) && item.IsUsed ||
          options.MemberStatusSelector.HasFlag(MSS.Unused) && !item.IsUsed ||
          options.MemberStatusSelector.HasFlag(MSS.Valid) && item.IsValid ||
          options.MemberStatusSelector.HasFlag(MSS.Invalid) && !item.IsValid ||
          options.MemberStatusSelector.HasFlag(MSS.Converted) && item.IsConverted ||
          options.MemberStatusSelector.HasFlag(MSS.ConvertedTo) && item.IsConvertedTo
        ).ToList();
      }
      Writer.WriteLine("{");
      Writer.Indent();
      foreach (var property in properties)
      {
        if (options.TypeDataSelector.HasFlag(TDS.Metadata))
          ShowMetadata(property, options);
        var str = $"{property.Name}: {property.PropertyType.GetFullName(originNames)}";
        if (options.TypeDataSelector.HasFlag(TDS.ConversionInfo))
        {
          var changedToType = ModelManager.GetConversionTargetOrSelf(property.PropertyType);
          if (changedToType != null)
            str += $" => {changedToType.GetFullName()}";
        }
        Writer.WriteLine(str);
      }
      if (properties.Count() > 10)
        Writer.WriteLine("...");
      Writer.Unindent();
      Writer.WriteLine("}");
    }
  }

  public void ShowMetadata(ModelElement element, DisplayOptions options)
  {
    var metadata = element.Metadata;
    if (metadata == null)
      return;
    Writer.WriteLine();
    if (metadata.Summary != null)
    {
      var documentationWriter = new DocumentationWriter(Writer, Writer.IndentLevel * Writer.IndentSize, options.LineWidthLimit);
      documentationWriter.Write(metadata.Summary);
    }
    if (metadata.SchemaTag != null)
    {
      var isAttribStr = "";
      if (metadata.SchemaIsAttrib)
        isAttribStr = " isAttrib=\"true\"";
      Writer.WriteLine($"/// <schemaTag{isAttribStr}>{metadata.SchemaTag}</schemaTag>");
    }
    if (metadata.SchemaUrl != null)
      Writer.WriteLine($"/// <schemaUrl>{metadata.SchemaUrl}</schemaUrl>");
    if (metadata.Availability != null)
      Writer.WriteLine($"/// <availability>{metadata.Availability}</availability>");
  }

  //  public void ShowDocumentation(ModelElement element, DisplayOptions options)
  //{
  //  var xElement = element.Documentation;
  //  if (xElement != null)
  //  {
  //    Writer.WriteLine();
  //    foreach (var subElement in xElement.Elements())
  //      ShowDocumentationElement(subElement, options);
  //  }
  //}

  private void ShowDocumentationElement(XElement xElement, DisplayOptions options, int indent = 0)
  {
    var indentStr = new String(' ', indent * 2);
    var header = xElement.Name.ToString();
    foreach (var attribute in xElement.Attributes())
    {
      header += $" {attribute.Name}=\"{attribute.Value}\"";
    }
    string? text = null;
    if (!xElement.HasElements)
    {
      text = xElement.Value.Trim();
      text = Qhta.HtmlUtils.HtmlTextUtils.EncodeHtmlEntities(text);
      if (text == "")
      {
        Writer.WriteLine($"/// {indentStr}<{header}/>");
        return;
      }
      else if (header == "c" || header == "remark")
      {
        Writer.WriteLine($"/// {indentStr}<{header}>{text}</{xElement.Name}>");
        return;
      }
    }

    Writer.WriteLine($"/// {indentStr}<{header}>");
    if (xElement.HasElements)
    {
      foreach (var subElement in xElement.Elements())
        ShowDocumentationElement(subElement, options, indent + 1);
    }
    else if (text != null)
    {
      if (options.LineWidthLimit > 0)
      {
        var wrapLimit = options.LineWidthLimit - 4 - Writer.IndentSize * Writer.IndentLevel;
        List<string> lines = Snork.TextWrap.TextWrapper.Wrap(text, wrapLimit);
        foreach (var line in lines)
          Writer.WriteLine($"/// {indentStr + "  "}{line}");
      }
      else
        Writer.WriteLine($"/// {indentStr + "  "}{text}");
    }
    Writer.WriteLine($"/// {indentStr}</{xElement.Name}>");
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

  public void ShowElementSchema(TypeInfo typeInfo, DisplayOptions options)
  {
    if (typeInfo.Schema!=null)
      WriteSchemaParticle(typeInfo.Schema.Main);
  }

  public void WriteSchemaParticle(SchemaParticle particle)
  {
    if (particle is ItemElementParticle itemElementParticle)
    {
      Writer.WriteLine($"<xsd:element type=\"{itemElementParticle.ItemType.GetFullName(true, true)}\"" +
        $" {ParticleAttribs(particle)}/>");
    }
    else
    if (particle is ItemsParticle itemsParticle)
    {
      var particleType = particle.ParticleType.ToString().ToLower();
      Writer.WriteLine($"<xsd:{particleType} {ParticleAttribs(particle)}>");
      Writer.Indent();
      foreach (var item in itemsParticle.Items)
        WriteSchemaParticle(item);
      Writer.Unindent();
      Writer.WriteLine($"</xsd:{particleType}>");
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
    if (particle.MinOccurs!=null && particle.MinOccurs!=particle.DefMinOccurs)
      attribs.Add($"minOccurs=\"{particle.MinOccurs}\"");
    if (particle.MaxOccurs!=null && particle.MaxOccurs!=particle.DefMaxOccurs)
      attribs.Add($"maxOccurs=\"{particle.MaxOccurs}\"");
    return String.Join(" ", attribs);
  }

  #region Helper functions to format diplay
  protected string AllNone(int n, int cmp) => (n == 0) ? "none" : (n == cmp) ? "all" : n.ToString();
  protected string Multi(int n, string single, string? multi = null) => (n == 1) ? single : (multi ?? (single.EndsWith("s") ? (single + "es") : (single + "s")));
  protected string AcceptedMark(bool? acceptance) => (acceptance == true) ? "+ " : (acceptance == false) ? "- " : "  ";
  protected string ValidStr(bool? validity) => (validity == true) ? "valid" : (validity == false) ? "invalid" : string.Empty;

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

