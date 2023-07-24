namespace ModelGen;

public record DocumentingTypeInfo
{
  public int? TotalTypes;
  public int? CheckedTypes;
  public int? DocumentedTypes;
  public TypeInfo? Current;
}

public delegate void DocumentingTypeEvent(ModelDocumenter sender, DocumentingTypeInfo info);

/// <summary>
/// This class adds documentation from model documentation type to types and properties.
/// </summary>
public class ModelDocumenter
{
  public ModelDocumenter(NTS namespaceTypeSelector, MSS typeStatusSelector, string modelDocFilename)
  {
    NamespaceTypeSelector = namespaceTypeSelector;
    TypeStatusSelector = typeStatusSelector;
    ModelDoc.Instance.LoadData(modelDocFilename);
  }

  public NTS NamespaceTypeSelector { get; private set; }
  public MSS TypeStatusSelector { get; private set; }

  public int TotalTypesCount { get; private set; }
  public int CheckedTypesCount { get; private set; }
  public int DocumentedTypesCount { get; private set; }

  public List<string> NamespacesNotFound { get; private set; } = new List<string>();
  public List<string> TypesNotFound { get; private set; } = new List<string>();
  public List<string> PropertiesNotFound { get; private set; } = new List<string>();

  public event DocumentingTypeEvent? OnDocumentingType;

  public int DocumentTypes()
  {
    var nspaces = TypeManager.GetNamespaces(NamespaceTypeSelector);
    List<TypeInfo> types = new List<TypeInfo>();
    foreach (var nspace in nspaces)
    {
      var nSpaceTypes = TypeManager.GetNamespaceTypes(nspace).ToList();
      if (TypeStatusSelector.HasFlag(MSS.Accepted) || TypeStatusSelector.HasFlag(MSS.Rejected))
        nSpaceTypes = nSpaceTypes.Where(item =>
          TypeStatusSelector.HasFlag(MSS.Accepted) && item.IsAccepted
          || TypeStatusSelector.HasFlag(MSS.Rejected) && item.IsRejected).ToList();
      types.AddRange(nSpaceTypes);
    }
    TotalTypesCount = types.Count();
    foreach (var typeInfo in types)
    {
      DocumentSingleType(typeInfo);
    }
    SaveErrors();
    return DocumentedTypesCount;
  }

  public bool DocumentSingleType(TypeInfo typeInfo)
  {
    CheckedTypesCount++;
    OnDocumentingType?.Invoke(this, new DocumentingTypeInfo
    {
      TotalTypes = TotalTypesCount,
      CheckedTypes = CheckedTypesCount,
      DocumentedTypes = DocumentedTypesCount,
      Current = typeInfo
    });
    var ok = true;
    if (!typeInfo.IsConstructedGenericType)
      ok = TryAddTypeDocumentation(typeInfo);
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
      var documentation = typeInfo.Documentation;
      if (documentation == null)
        typeInfo.Documentation = documentation = new ElementDocs();
      if (typeDoc.Summary.Count == 1)
      {
        documentation.Summary = new XElement("summary", typeDoc.Summary.First());
        ok = true;
      }
      else
      {
        documentation.Summary = new XElement("summary");
        foreach (var str in typeDoc.Summary)
          documentation.Summary.Add(new XElement("para", str));
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
      var documentation = propInfo.Documentation;
      if (documentation == null)
        propInfo.Documentation = documentation = new ElementDocs();
      if (propDoc.Summary.Count == 1)
      {
        documentation.Summary = new XElement("summary", propDoc.Summary.First());
        ok = true;
      }
      else
      {
        documentation.Summary = new XElement("summary");
        foreach (var str in propDoc.Summary)
          documentation.Summary.Add(new XElement("para", str));
        ok = true;
      }
    }
    return ok;
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
