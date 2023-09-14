namespace ModelGen;


/// <summary>
/// This class manages documentation in types and properties.
/// </summary>
public class ModelDocsManager
{
  public ModelDocsManager(PPS phaseNum, NTS namespaceTypeSelector, MSS typeStatusSelector, string modelDocFilename)
  {
    PhaseNum = phaseNum;
    NamespaceTypeSelector = namespaceTypeSelector;
    TypeStatusSelector = typeStatusSelector;
    ModelDoc.Instance.LoadData(modelDocFilename);
  }

  public PPS PhaseNum { get; private set; }
  public NTS NamespaceTypeSelector { get; private set; }
  public MSS TypeStatusSelector { get; private set; }

  public int TotalTypesCount { get; private set; }
  public int CheckedTypesCount { get; private set; }
  public int DocumentedTypesCount { get; private set; }

  public List<string> NamespacesNotFound { get; private set; } = new List<string>();
  public List<string> TypesNotFound { get; private set; } = new List<string>();
  public List<string> PropertiesNotFound { get; private set; } = new List<string>();

  public event ProgressTypeEvent? OnDocumentingType;

  public int DocumentTypes(IEnumerable<TypeInfo> types)
  {
    foreach (var typeInfo in types)
    {
      DocumentSingleType(typeInfo);
      OnDocumentingType?.Invoke(new ProgressTypeInfo
      {
        TotalTypes = TotalTypesCount,
        CheckedTypes = CheckedTypesCount,
        ProcessedTypes = DocumentedTypesCount,
        Current = typeInfo
      });
    }
    return DocumentedTypesCount;
  }

  public bool DocumentSingleType(TypeInfo typeInfo)
  {
    CheckedTypesCount++;
    var ok = true;
    if (!typeInfo.IsConstructedGenericType)
    {
      ok = TryAddTypeDocumentation(typeInfo);
    }
    if (ok)
      DocumentedTypesCount++;
    return ok;
  }

  public bool TryAddTypeDocumentation(TypeInfo typeInfo)
  {
    if (!ModelDoc.Instance.Namespaces.TryGetValue(typeInfo.OriginalNamespace, out var ns))
    {
      if (!NamespacesNotFound.Contains(typeInfo.OriginalNamespace))
      {
        //Debug.WriteLine($"NamespaceDoc {typeInfo.OriginalNamespace} not found");
        NamespacesNotFound.Add(typeInfo.OriginalNamespace);
      }
    }
    else
    {
      if (!ns.Types.TryFindName(typeInfo.OriginalName, out var typeDoc))
      {
        var tag = typeInfo.Schema?.SchemaTag;
        if (tag == null || !ns.Types.TryFindTag(tag, out typeDoc))
        {
          if (!TypesNotFound.Contains(typeInfo.OriginalName))
          {
            var name = $"{typeInfo.OriginalNamespace}.{typeInfo.OriginalName}";
            TypesNotFound.Add(name);
            //Debug.WriteLine($"TypeDoc not found for {name}");
          }
        }
      }
      if (typeDoc != null)
      {
        var ok = TrySetSummary(typeInfo, typeDoc);
        return ok;
      }
    }
    return false;
  }

  private bool TrySetSummary(TypeInfo typeInfo, TypeDoc typeDoc)
  {
    var ok = false;
    if (typeDoc.Summary != null && typeDoc.Summary.Any())
    {
      if (typeDoc.Summary.Count == 1)
      {
        typeInfo.Description = typeDoc.Summary.First();
        ok = true;
      }
      else
      {
        var documentation = typeInfo.Documentation;
        if (documentation == null)
          typeInfo.Documentation = documentation = new ElementDocs();
        foreach (var str in typeDoc.Summary)
          documentation.Add(new XElement("para", str));
        ok = true;
      }
      if (TrySetPropertiesDocumentation(typeInfo, typeDoc))
        ok = true;
    }
    return ok;
  }

  private bool TrySetPropertiesDocumentation(TypeInfo typeInfo, TypeDoc typeDoc)
  {
    var ok = false;
    if (typeDoc.Properties != null && typeDoc.Properties.Any())
    {
      var properties = typeInfo.Properties;
      if (properties != null)
      {
        foreach (var propInfo in properties)
          if (TrySetPropertyDocumentation(propInfo, typeDoc.Properties))
            ok = true;
      }
    }
    return ok;
  }

  private bool TrySetPropertyDocumentation(PropInfo propInfo, Properties properties)
  {
    if (!properties.TryFindName(propInfo.Name, out var propDoc))
    {
      var tag = propInfo.Schema?.SchemaTag;
      if (tag == null || !properties.TryFindTag(tag, out propDoc))
      {
        var name = $"{propInfo.DeclaringType?.OriginalName}.{propInfo.Name}";
        if (!PropertiesNotFound.Contains(name))
        {
          PropertiesNotFound.Add(name);
          //Debug.WriteLine($"PropDoc not found for {name}");
        }
      }
    }
    if (propDoc != null)
    {
      var ok = TrySetSummary(propInfo, propDoc);
      return ok;
    }
    return false;
  }

  private bool TrySetSummary(PropInfo propInfo, PropDoc propDoc)
  {
    var ok = false;
    if (propDoc.Summary != null && propDoc.Summary.Any())
    {
      if (propDoc.Summary.Count == 1)
      {
        propInfo.Description = propDoc.Summary.First();
        ok = true;
      }
      else
      {
        var documentation = propInfo.Documentation;
        if (documentation == null)
          propInfo.Documentation = documentation = new ElementDocs();
        foreach (var str in propDoc.Summary)
          documentation.Add(new XElement("para", str));
        ok = true;
      }

    }
    return ok;
  }

  public static string? GetDescription(ModelElement element)
  {
    if (!String.IsNullOrEmpty(element.Description))
    {
      return element.Description;
    }
    if (element.Documentation != null && !element.Documentation.IsEmpty)
    {
      var summary = element.Documentation.FirstOrDefault(item => item.Name == "summary");
      if (summary != null)
        return GetDescription(summary);
      var remarks = element.Documentation.FirstOrDefault(item => item.Name == "remarks");
      if (remarks != null)
        return GetDescription(remarks);
    }
    return null;
  }

  public static string? GetDescription(XElement element)
  {
    if (element.HasElements)
    {
      var firstParas = new List<XElement>();
      foreach (var item in element.Elements())
      {
        if (item.Name == "para")
          firstParas.Add(item);
        else
          break;
      }
      return string.Join("", firstParas.Select(item => item.Value));
    }
    else
    {
      var str = element.Value.Trim();
      if (!string.IsNullOrEmpty(str))
        return str;
      return null;
    }
  }

  public static IEnumerable<XElement>? GetDocumentation(ModelElement element)
  {
    if (!String.IsNullOrEmpty(element.Description) && element.Documentation != null && !element.Documentation.IsEmpty)
    {
      XElement summary;
      var oldSummary = element.Documentation.FirstOrDefault(item => item.Name == "summary");
      if (oldSummary != null)
      {
        summary = new XElement("summary");
        summary.Add(new XElement("para", element.Description));
        if (oldSummary.HasElements)
          foreach (var subItem in oldSummary.Elements())
            summary.Add(subItem);
        else
        {
          var text = oldSummary.Value.Trim();
          if (!String.IsNullOrEmpty(text))
            summary.Add(new XElement("para", text));
        }
      }
      else
        summary = new XElement("summary", element.Description);
      var documentation = new List<XElement>();
      documentation.Add(summary);
      foreach (var item in element.Documentation)
        if (item != oldSummary)
          documentation.Add(item);
      return documentation;
    }
    if (!String.IsNullOrEmpty(element.Description))
    {
      var documentation = new List<XElement>();
      documentation.Add(new XElement("summary", element.Description));
      return documentation;
    }
    if (element.Documentation != null && !element.Documentation.IsEmpty)
      return element.Documentation;
    return null;
  }

  public void SaveErrors()
  {
    SaveErrors(GetFilename());
  }

  private string GetFilename()
  {
    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    path = Path.Combine(path, "ModelGen");
    if (!Directory.Exists(path))
      Directory.CreateDirectory(path);
    path = Path.Combine(path, "MissingDocs.txt");
    return path;
  }

  public void SaveErrors(string filename)
  {
    using (var textWriter = File.CreateText(filename))
    {
      WriteStrings(textWriter, "NamespacesNotFound", NamespacesNotFound);
      WriteStrings(textWriter, "TypesNotFound", TypesNotFound);
      WriteStrings(textWriter, "PropertiesNotFound", PropertiesNotFound);
    }
  }

  private void WriteStrings(TextWriter textWriter, string caption, ICollection<string> data)
  {
    textWriter.WriteLine("[" + caption + "]");
    foreach (var item in data)
      textWriter.WriteLine(item);
    textWriter.WriteLine();
  }

}
