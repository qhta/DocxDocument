using DocumentFormat.OpenXml.Drawing;

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
        if (!ValidateDescription(typeInfo))
          ok = false;
        break;

      case PPS.Rename:
        if (!ValidateTargetName(typeInfo))
          ok = false;
        break;

    }
    return ok;
  }

  public bool ValidateScan(TypeInfo typeInfo)
  {
    var ok1 = CompareSchemaWithIncludeRelationships(typeInfo);
    var ok2 = ComparePropsWithIncludeRelationships(typeInfo);
    return ok1 && ok2;
  }

  public bool CompareSchemaWithIncludeRelationships(TypeInfo typeInfo)
  {
    var typesIncludedInRels = typeInfo.GetOutgoingRelationships(Semantics.Include).Select(item => item.Target).ToList();
    if (typeInfo.Schema == null && typesIncludedInRels.Count > 0)
    {
      typeInfo.AddError(PhaseNum, ErrorCode.MissingSchema);
      return false;
    }
    if (typeInfo.Schema?.Main != null)
    {
      var typesIncludedInSchema = GetItemTypes(typeInfo.Schema.Main);
      if (typesIncludedInSchema.Count > 0 && typesIncludedInRels.Count == 0)
      {
        typeInfo.AddError(PhaseNum, ErrorCode.MissingIncludedTypeRels);
        return false;
      }
      else if (typesIncludedInSchema.Count == 0 && typesIncludedInRels.Count > 0)
      {
        typeInfo.AddError(PhaseNum, ErrorCode.MissingIncludedTypeSchema);
        return false;
      }
      else if (typesIncludedInSchema.Count > 0 && typesIncludedInRels.Count > 0)
      {
        var missingTypesIncludedInSchema = new List<TypeInfo>();
        for (int i = 0; i < typesIncludedInRels.Count; i++)
        {
          var itemType = typesIncludedInRels[i];
          if (!typesIncludedInSchema.Contains(itemType))
            missingTypesIncludedInSchema.Add(itemType);
        }
        var missingTypesIncludedInRels = new List<TypeInfo>();
        for (int i = 0; i < typesIncludedInSchema.Count; i++)
        {
          var itemType = typesIncludedInSchema[i];
          if (!typesIncludedInRels.Contains(itemType))
            missingTypesIncludedInRels.Add(itemType);
        }
        if (missingTypesIncludedInRels.Count > 0)
        {
          typeInfo.AddError(PhaseNum, ErrorCode.MissingSomeIncludedTypeRels, missingTypesIncludedInRels.Select(item => item.Name).ToArray());
          return false;
        }
        if (missingTypesIncludedInSchema.Count > 0)
        {
          typeInfo.AddError(PhaseNum, ErrorCode.MissingSomeIncludedTypeSchema, missingTypesIncludedInSchema.Select(item => item.Name).ToArray());
          return false;
        }
      }
    }
    return true;
  }

  public bool ComparePropsWithIncludeRelationships(TypeInfo typeInfo)
  {
    var typesIncludedInRels = typeInfo.GetOutgoingRelationships(Semantics.Include)
      .Where(item => !item.IsMultiple)
      .Select(item => item.Target).ToList();
    if (typeInfo.Properties == null && typesIncludedInRels.Count > 0)
    {
      typeInfo.AddError(PhaseNum, ErrorCode.MissingProperties);
      return false;
    }
    if (typeInfo.Properties != null)
    {
      var typesIncludedInProps = typeInfo.Properties.Select(item => item.PropertyType).ToList();
      if (typesIncludedInProps.Count == 0 && typesIncludedInRels.Count > 0)
      {
        typeInfo.AddError(PhaseNum, ErrorCode.MissingProperties);
        return false;
      }
      else if (typesIncludedInProps.Count > 0 && typesIncludedInRels.Count > 0)
      {
        var missingTypesInProperties = new List<TypeInfo>();
        for (int i = 0; i < typesIncludedInRels.Count; i++)
        {
          var itemType = typesIncludedInRels[i];
          if (!typesIncludedInProps.Contains(itemType))
            missingTypesInProperties.Add(itemType);
        }
        if (missingTypesInProperties.Count > 0)
        {
          typeInfo.AddError(PhaseNum, ErrorCode.MissingSomeProperties, missingTypesInProperties.Select(item => item.Name).ToArray());
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
    if (!typeInfo.IsConstructedGenericType)
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
    }
    return true;
  }

  public bool ValidateTargetName(TypeInfo typeInfo)
  {
    if (typeInfo.IsAcceptedAfter(PPS.Rename) && !typeInfo.IsConstructedGenericType && !typeInfo.OriginalNamespace.StartsWith("System"))
    {
      var targetNamespace = typeInfo.TargetNamespace;
      var targetName = typeInfo.TargetName;
      var sameNameTypes = TypeManager.AllTypes.Where(item => item.IsAcceptedAfter(PhaseNum) && !item.IsConstructedGenericType)
        .Where(item => item.TargetNamespace == targetNamespace)
        .Where(item => item.GetFullName(true, false, false) == targetName).ToList();
      if (sameNameTypes.Count>1)
      {
        typeInfo.AddError(PhaseNum, ErrorCode.MultiplicatedName);
        return false;
      }
    }
    return true;
  }
}
