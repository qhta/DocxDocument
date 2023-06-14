namespace ModelGen;

public record ValidatingTypeInfo
{
  public int? CheckedTypes;
  public int? InvalidTypes;
  public TypeInfo? Current;
}

public delegate void ValidatingTypeEvent(ModelValidator sender, ValidatingTypeInfo info);

/// <summary>
/// This class evaluates the validity of the model elements.
/// Now only the elements which have no documentation are marked as invalid.
/// </summary>
public class ModelValidator
{
  public ModelValidator(NTS namespaceTypeSelector, MSS typeStatusSelector, TDS typeDataSelector)
  {
    NamespaceTypeSelector = namespaceTypeSelector;
    TypeStatusSelector = typeStatusSelector;
    TypeDataSelector = typeDataSelector;
  }
  public NTS NamespaceTypeSelector { get; private set; }
  public MSS TypeStatusSelector { get; private set; }
  public TDS TypeDataSelector { get; private set; }

  public int CheckedTypesCount { get; private set; }
  public int NoDocsTypesCount { get; private set; }
  public int NoSummaryTypesCount { get; private set; }
  public int NoSchemaTagTypesCount { get; private set; }
  public int NoSchemaUrlTypesCount { get; private set; }
  public int ValidTypesCount { get; private set; }

  public event ValidatingTypeEvent? OnValidatingType;

  public bool ValidateTypes()
  {
    bool ok = true;
    var nspaces = TypeManager.GetNamespaces(NamespaceTypeSelector);
    foreach (var nspace in nspaces)
    {
      var nSpaceTypes = TypeManager.GetNamespaceTypes(nspace).ToList();
      if (TypeStatusSelector.HasFlag(MSS.Accepted) || TypeStatusSelector.HasFlag(MSS.Rejected))
        nSpaceTypes = nSpaceTypes.Where(item =>
          TypeStatusSelector.HasFlag(MSS.Accepted) && item.IsAccepted
          || TypeStatusSelector.HasFlag(MSS.Rejected) && item.IsRejected).ToList();
      foreach (var typeInfo in nSpaceTypes)
      {
        if (!ValidateType(typeInfo))
          ok = false;
      }
    }
    return ok;
  }

  public bool ValidateType(TypeInfo typeInfo)
  {
    CheckedTypesCount++;
    OnValidatingType?.Invoke(this, new ValidatingTypeInfo
    {
      CheckedTypes = CheckedTypesCount,
      InvalidTypes = CheckedTypesCount - ValidTypesCount,
      Current = typeInfo
    });
    var ok = true;
    if (typeInfo.IsConstructedGenericType)
      ok = ValidateDocumentation(typeInfo);
    typeInfo.IsValid = ok;
    if (ok)
      ValidTypesCount++;
    return ok;
  }

  public bool ValidateDocumentation(TypeInfo typeInfo)
  {
    var metadata = typeInfo.Metadata;
    if (metadata != null)
    {
      bool ok = true;
      if (metadata.Summary == null)
      {
        NoSummaryTypesCount++;
        ok = false;
      }
      if (metadata.SchemaTag != null)
      {
        if (metadata.SchemaPrefix != null)
        {
          if (metadata.SchemaUrl == null)
          {
            NoSchemaUrlTypesCount++;
          }
        }
      }
      else
      {
        NoSchemaTagTypesCount++;
      }
      return ok;
    }
    else
    {
      NoDocsTypesCount++;
      return false;
    }
  }

}
