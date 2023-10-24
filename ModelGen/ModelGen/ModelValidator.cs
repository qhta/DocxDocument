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

  public HashSet<TypeInfo> ValidatedTypes { get; private set; } = new HashSet<TypeInfo>();
  public int ValidatedTypesCount => ValidatedTypes.Count;

  public HashSet<TypeInfo> InvalidTypes { get; private set; } = new HashSet<TypeInfo>();
  public int InvalidTypesCount => InvalidTypes.Count;

  public int ValidTypesCount { get; private set; }

  public HashSet<PropInfo> InvalidProps { get; private set; } = new HashSet<PropInfo>();
  public int InvalidPropsCount => InvalidProps.Count;

  public bool ValidateTypes(IEnumerable<TypeInfo> types, ValidatingTypeEvent? OnValidatingType)
  {
    bool ok = true;
    ValidTypesCount = 0;
    if (PhaseNum == PPS.ConvertTypes)
      types = TypeManager.TypesAcceptedAfter(PhaseNum).Where(item => !item.IsConverted).Where(item=>item.TargetNamespace!=null);
    TotalTypesCount = types.Count();
    foreach (var typeInfo in types)
    {
      OnValidatingType?.Invoke(this, new ValidatingTypeInfo
      {
        TotalTypes = TotalTypesCount,
        CheckedTypes = ValidatedTypesCount,
        InvalidTypes = ValidatedTypesCount - ValidTypesCount,
        Current = typeInfo
      });
      var result = ValidateType(typeInfo);
      if (result == false)
      {
        ok = false;
        InvalidTypes.AddUnique(typeInfo);
      }
      else if (result == true)
        ValidTypesCount++;
    }
    return ok;
  }

  public bool? ValidateType(TypeInfo typeInfo)
  {
    if (!ValidatedTypes.Contains(typeInfo))
    {
      ValidatedTypes.Add(typeInfo);
      return ValidateTypeInPhase(typeInfo);
    }
    return null;
  }

  private bool? ValidateTypeInPhase(TypeInfo typeInfo)
  {
    switch (PhaseNum)
    {
      case PPS.ScanSource:
        return ValidateScan(typeInfo);
      case PPS.AddDocs:
        return ValidateDescription(typeInfo);
      case PPS.Rename:
        return ValidateTargetName(typeInfo);
      case PPS.ConvertTypes:
        return ValidateConversion(typeInfo);
    }
    return null;
  }

  #region Validate scan
  public bool ValidateScan(TypeInfo typeInfo)
  {
    var ok1 = CompareSchemaWithIncludeRelationships(typeInfo);
    var ok2 = ComparePropsWithIncludeRelationships(typeInfo);
    return ok1 && ok2;
  }

  public bool CompareSchemaWithIncludeRelationships(TypeInfo typeInfo)
  {
    var ok = true;
    var typesIncludedInRels = typeInfo.GetOutgoingRelationships(Semantics.Include).Select(item => item.Target).ToList();
    if (typeInfo.Schema == null && typesIncludedInRels.Count > 0)
    {
      typeInfo.AddError(PhaseNum, ErrorCode.MissingSchema);
      return false;
    }
    if (typeInfo.Schema?.Main != null)
    {
      var typesIncludedInSchema = typeInfo.Schema.Main.GetItemTypes();
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
        foreach (var itemType in typesIncludedInRels)
        {
          if (!typesIncludedInSchema.Contains(itemType))
            missingTypesIncludedInSchema.Add(itemType);
        }
        if (missingTypesIncludedInSchema.Count > 0)
        {
          typeInfo.AddError(PhaseNum, ErrorCode.MissingSomeIncludedTypeSchema, missingTypesIncludedInSchema.Select(item => item.Name).ToArray());
          ok = false;
        }

        var missingTypesIncludedInRels = new List<TypeInfo>();
        foreach (var itemType in typesIncludedInSchema)
        {
          if (!typesIncludedInRels.Contains(itemType))
            missingTypesIncludedInRels.Add(itemType);
        }
        if (missingTypesIncludedInRels.Count > 0)
        {
          typeInfo.AddError(PhaseNum, ErrorCode.MissingSomeIncludedTypeRels, missingTypesIncludedInRels.Select(item => item.Name).ToArray());
          ok = false;
        }

      }
    }
    return ok;
  }

  public bool ComparePropsWithIncludeRelationships(TypeInfo typeInfo)
  {
    var ok = true;
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
        foreach (var itemType in typesIncludedInRels)
        {
          if (!typesIncludedInProps.Contains(itemType))
            missingTypesInProperties.Add(itemType);
        }
        if (missingTypesInProperties.Count > 0)
        {
          typeInfo.AddError(PhaseNum, ErrorCode.MissingSomeProperties, missingTypesInProperties.Select(item => item.Name).ToArray());
          ok = false;
        }
      }
    }
    return ok;
  }
  #endregion

  public bool? ValidateDescription(TypeInfo typeInfo)
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
        rest = rest.ReplaceEnd(" Class", "", StringComparison.OrdinalIgnoreCase);
        var restWithoutSpaces = rest.Replace(" ", "");
        if (restWithoutSpaces.ToLower() == typeInfo.Name.ToLower())
          typeInfo.AddError(PhaseNum, ErrorCode.MeaninglessDescription);
        return false;
      }
    }
    return true;
  }

  public bool? ValidateTargetName(TypeInfo typeInfo)
  {
    var targetNamespace = typeInfo.TargetNamespace;
    var targetName = typeInfo.GetFullName(true, false, false);
    var sameNameTypes = TypeManager.AllTypes.Where(item => item.IsAcceptedAfter(PhaseNum) && !item.IsConstructedGenericType)
      .Where(item => item.TargetNamespace == targetNamespace)
      .Where(item => item.GetFullName(true, false, false) == targetName).ToList();
    if (sameNameTypes.Count > 1)
    {
      typeInfo.AddError(PhaseNum, ErrorCode.DuplicateName);
      return false;
    }
    return true;
  }

  public bool ValidateConversion(TypeInfo typeInfo)
  {
    var ok1 = ValidateTargetType(typeInfo);
    var ok2 = ValidateUniqueProperties(typeInfo);
    var ok3 = ValidatePropertiesTargets(typeInfo);
    return ok1 && ok2 && ok3;
  }

  public bool ValidateTargetType(TypeInfo typeInfo)
  {
    var targetType = typeInfo.TargetType;
    if (targetType == null)
    {
      typeInfo.AddError(PhaseNum, ErrorCode.MissingTargetType);
      return false;
    }
    if (targetType.IsConstructedGenericType)
    {
      var argType = targetType.GetGenericArguments().FirstOrDefault();
      if (argType == null)
      {
        typeInfo.AddError(PhaseNum, ErrorCode.MissingGenericArgType);
        return false;
      }
      if (!(ValidateType(argType) ?? !argType.IsInvalid(PhaseNum)))
      {
        typeInfo.AddError(PhaseNum, ErrorCode.InvalidGenericArgType);
        return false;
      }
    }
    return true;
  }

  public bool ValidatePropertiesTargets(TypeInfo typeInfo)
  {
    if (typeInfo.Properties != null)
    {
      var ok = true;
      foreach (var property in typeInfo.Properties.Where(item => item.IsAcceptedAfter(PhaseNum)))
      {
        if (!(ValidatePropertyTargetType(property)))
        {
          InvalidProps.AddUnique(property);
          typeInfo.AddError(PhaseNum, ErrorCode.InvalidProperties);
          ok = false;
        }
      }
      return ok;
    }
    return true;
  }

  public bool ValidateUniqueProperties(TypeInfo typeInfo)
  {
    if (typeInfo.Properties != null)
    {
      var ok = true;
      var props = new HashSet<string>();
      foreach (var propInfo in typeInfo.Properties.Where(item => item.IsAcceptedAfter(PhaseNum)))
      {
        if (!props.Contains(propInfo.Name))
          props.Add(propInfo.Name);
        else
        {
          propInfo.AddError(PhaseNum, ErrorCode.DuplicateName);
          InvalidProps.AddUnique(propInfo);
          ok = false;
        }
      }
      return ok;
    }
    return true;
  }

  public bool ValidatePropertyTargetType(PropInfo propInfo)
  {
    //if (propInfo.PropertyType.Name.StartsWith("EnumValue"))
    //  Debug.Assert(true);
    var targetType = ModelManager.GetTargetPropertyType(propInfo);
    if (targetType == null)
    {
      propInfo.AddError(PhaseNum, ErrorCode.MissingPropertyTargetType);
      return false;
    }
    if (targetType.IsConstructedGenericType)
    {
      var argType = targetType.GetGenericArguments().FirstOrDefault();
      if (argType == null)
      {
        propInfo.AddError(PhaseNum, ErrorCode.MissingGenericArgType);
        return false;
      }
      if (!ValidatedTypes.Contains(argType))
      {
        if (!(ValidateType(argType) ?? !argType.IsInvalid(PhaseNum)))
        {
          propInfo.AddError(PhaseNum, ErrorCode.InvalidGenericArgType);
          return false;
        }
      }
    }
    return true;
  }
}
