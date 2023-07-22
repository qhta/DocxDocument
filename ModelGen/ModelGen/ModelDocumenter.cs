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
        Debug.WriteLine($"NamespaceDoc {typeInfo.OriginalNamespace} not found");
        NamespacesNotFound.Add(typeInfo.OriginalNamespace);
      }
    }
    else
    {
      if (!ns.Types.TryFindName(typeInfo.OriginalName, out var typeDoc))
      {
        var tag = typeInfo.Schema?.SchemaTag;
        //if (tag=="Application")
        //  Debug.Assert(true);
        if (tag == null || !ns.Types.TryFindTag(tag, out typeDoc))
        {
          if (!TypesNotFound.Contains(typeInfo.OriginalName))
          {
            TypesNotFound.Add(typeInfo.OriginalName);
            Debug.WriteLine($"TypeDoc not found for {typeInfo.OriginalNamespace}.{typeInfo.OriginalName}");
          }
        }
      }
      if (typeDoc != null)
      {
        var ok = false;
        if (typeDoc.Summary != null && typeDoc.Summary.Any())
        {
          var documentation = typeInfo.Documentation;
          if (documentation == null)
            typeInfo.Documentation = documentation = new ElementDocs();
          if (typeDoc.Summary.Count == 1)
            documentation.Summary = new XElement("summary", typeDoc.Summary.First());
          else
          {
            documentation.Summary = new XElement("summary");
            foreach (var str in typeDoc.Summary)
              documentation.Summary.Add(new XElement("para", str));
          }
          ok = true;
        }
        return ok;
      }
    }
    return false;
  }

}
