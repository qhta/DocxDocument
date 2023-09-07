namespace ModelGen;

public record ValidatingTypeInfo
{
  public int? TotalTypes;
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
  public ModelValidator(PPS phase, NTS namespaceTypeSelector, MSS typeStatusSelector, TDS typeDataSelector)
  {
    PhaseNum = phase;
    NamespaceTypeSelector = namespaceTypeSelector;
    TypeStatusSelector = typeStatusSelector;
    TypeDataSelector = typeDataSelector;
  }

  public PPS PhaseNum { get; private set; }
  public NTS NamespaceTypeSelector { get; private set; }
  public MSS TypeStatusSelector { get; private set; }
  public TDS TypeDataSelector { get; private set; }

  public int TotalTypesCount { get; private set; }
  public int CheckedTypesCount { get; private set; }
  public int ValidTypesCount { get; private set; }
  public int InvalidTypesCount { get; private set; }

  public event ValidatingTypeEvent? OnValidatingType;

  public bool ValidateTypes(PPS phase)
  {
    bool ok = true;
    ValidTypesCount = 0;
    InvalidTypesCount = 0;
    var nspaces = TypeManager.GetNamespaces(NamespaceTypeSelector);
    List<TypeInfo> types = new List<TypeInfo>();
    foreach (var nspace in nspaces)
    {
      var nSpaceTypes = TypeManager.GetNamespaceTypes(nspace).ToList();
      nSpaceTypes = nSpaceTypes.Where(item =>
        item.IsAcceptedTo(phase)).ToList();
      types.AddRange(nSpaceTypes);
    }
    TotalTypesCount = types.Count();
    foreach (var typeInfo in types)
    {
      if (!ValidateType(typeInfo))
      {
        ok = false;
        InvalidTypesCount++;
      }
      else
        ValidTypesCount++;
    }
    return ok;
  }

  public bool ValidateType(TypeInfo typeInfo)
  {
    CheckedTypesCount++;
    OnValidatingType?.Invoke(this, new ValidatingTypeInfo
    {
      TotalTypes = TotalTypesCount,
      CheckedTypes = CheckedTypesCount,
      InvalidTypes = CheckedTypesCount - ValidTypesCount,
      Current = typeInfo
    });
    var ok = true;
    switch (PhaseNum)
    {
      case PPS.ScanSource:
        if (!ValidateScan(typeInfo))
          ok = false;
        break;

      case PPS.AddDocs:
        if (!typeInfo.IsConstructedGenericType)
          if (!ValidateDescription(typeInfo))
            ok = false;
        break;
    }
    return ok;
  }

  public bool ValidateScan(TypeInfo typeInfo)
  {
    var ok1 = CompareSchemaWithIncludeRelationships(typeInfo);
    return ok1;
  }

  public bool CompareSchemaWithIncludeRelationships(TypeInfo typeInfo)
  {
    var includedTypesRels = typeInfo.GetOutgoingRelationships(Semantics.Include).Select(item => item.Target).ToList();
    if (typeInfo.Schema == null && includedTypesRels.Count > 0)
    {
      typeInfo.AddError(PhaseNum, ErrorCode.MissingSchema);
      return false;
    }
    if (typeInfo.Schema?.Main != null)
    {
      var includedTypesInSchema = GetItemTypes(typeInfo.Schema.Main);
      if (includedTypesInSchema.Count > 0 && includedTypesRels.Count == 0)
      {
        typeInfo.AddError(PhaseNum, ErrorCode.MissingIncludedTypeRels);
        return false;
      }
      else if (includedTypesInSchema.Count == 0 && includedTypesRels.Count > 0)
      {
        typeInfo.AddError(PhaseNum, ErrorCode.MissingIncludedTypeSchema);
        return false;
      }
      else if (includedTypesInSchema.Count > 0 && includedTypesRels.Count > 0)
      {
        var includedTypesInSchemaMissing = new List<TypeInfo>();
        for (int i = 0; i < includedTypesRels.Count; i++)
        {
          var itemType = includedTypesRels[i];
          if (!includedTypesInSchema.Contains(itemType))
            includedTypesInSchemaMissing.Add(itemType);
        }
        var includedTypesRelsMissing = new List<TypeInfo>();
        for (int i = 0; i < includedTypesInSchema.Count; i++)
        {
          var itemType = includedTypesInSchema[i];
          if (!includedTypesRels.Contains(itemType))
            includedTypesRelsMissing.Add(itemType);
        }
        if (includedTypesRelsMissing.Count > 0)
        {
          typeInfo.AddError(PhaseNum, ErrorCode.MissingSomeIncludedTypeRels, includedTypesRelsMissing.Select(item => item.Name).ToArray());
          return false;
        }
        if (includedTypesInSchemaMissing.Count > 0)
        {
          typeInfo.AddError(PhaseNum, ErrorCode.MissingSomeIncludedTypeSchema, includedTypesInSchemaMissing.Select(item => item.Name).ToArray());
          return false;
        }
      }
    }
    return true;
  }

  /// <summary>
  /// Returns flattened list of item types from schema.
  /// Items in the list are unique.
  /// </summary>
  /// <param name="schema"></param>
  /// <returns></returns>
  private List<TypeInfo> GetItemTypes(SchemaParticle schema)
  {
    var types = new List<TypeInfo>();
    if (schema is ItemElementParticle elementParticle)
    {
      if (elementParticle.ItemType != null)
      {
        if (!types.Contains(elementParticle.ItemType))
          types.Add(elementParticle.ItemType);
      }
    }
    else
    if (schema is ItemsParticle itemsParticle)
    {
      foreach (var particle in itemsParticle.Items)
      {
        foreach (var itemType in GetItemTypes(particle))
          if (!types.Contains(itemType))
            types.Add(itemType);
      }
    }
    return types;
  }

  public bool ValidateDescription(TypeInfo typeInfo)
  {
    var description = typeInfo.GetDescription()?.Trim();
    if (String.IsNullOrEmpty(description))
    {
      typeInfo.AddError(PhaseNum, ErrorCode.MissingDescription);
      return false;
    }
    String str = description;
    if (str.EndsWith("."))
      str = str.Substring(0, str.Length - 1).TrimEnd();
    str = str.Replace(" the ", " ").Replace(" a ", "");
    if (str.StartsWith("Defines "))
    {
      var rest = str.Substring("Defines ".Length).TrimStart();
      var restWithoutSpaces = rest.Replace(" ", "");
      if (restWithoutSpaces.ToLower() == typeInfo.Name.ToLower())
        typeInfo.AddError(PhaseNum, ErrorCode.MeaninglessDescription);
      return false;
    }
    return true;
  }

}
