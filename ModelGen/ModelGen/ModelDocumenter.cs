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
  public ModelDocumenter(NTS namespaceTypeSelector, MSS typeStatusSelector, TDS typeDataSelector)
  {
    NamespaceTypeSelector = namespaceTypeSelector;
    TypeStatusSelector = typeStatusSelector;
    TypeDataSelector = typeDataSelector;
    ModelDoc.Instance.LoadData();
  }

  public NTS NamespaceTypeSelector { get; private set; }
  public MSS TypeStatusSelector { get; private set; }
  public TDS TypeDataSelector { get; private set; }

  public int TotalTypesCount { get; private set; }
  public int CheckedTypesCount { get; private set; }
  public int DocumentedTypesCount { get; private set; }

  public event DocumentingTypeEvent? OnDocumentingType;

  public bool DocumentTypes()
  {
    bool ok = true;
    var nspaces = TypeManager.GetNamespaces(NamespaceTypeSelector);
    List<TypeInfo>  types = new List<TypeInfo>();
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
      if (!DocumentSingleType(typeInfo))
        ok = false;
    }
    return ok;
  }

  public bool DocumentSingleType(TypeInfo typeInfo)
  {
    CheckedTypesCount++;
    OnDocumentingType?.Invoke(this, new DocumentingTypeInfo
    {
      TotalTypes =  TotalTypesCount,
      CheckedTypes = CheckedTypesCount,
      DocumentedTypes = DocumentedTypesCount,
      Current = typeInfo
    });
    var ok = true;
    if (typeInfo.IsConstructedGenericType)
      ok = TryAddTypeDocumentation(typeInfo);
    typeInfo.IsValid = ok;
    if (ok)
      DocumentedTypesCount++;
    return ok;
  }

  public bool TryAddTypeDocumentation(TypeInfo typeInfo)
  {
    //var documentation = typeInfo.Documentation;
    //if (documentation != null)
    //{
    //  bool ok = true;
    //  if (documentation.Summary == null)
    //  {
    //    NoSummaryTypesCount++;
    //    ok = false;
    //  }
    //  return ok;
    //}
    //else
    //{
    //  NoDocsTypesCount++;
    //  return false;
    //}
    return true;
  }

}
