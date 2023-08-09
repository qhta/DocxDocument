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
        ok = false;
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
    if (PhaseNum == PPS.ScanTypes)
    {
      if (!typeInfo.IsConstructedGenericType)
        if (!ValidateDescription(typeInfo))
          ok = false;
    }
    if (ok)
      ValidTypesCount++;
    else
      InvalidTypesCount++;
    return ok;
  }

  public bool ValidateDescription(TypeInfo typeInfo)
  {

    var description = typeInfo.GetDescription()?.Trim();
    if (String.IsNullOrEmpty(description))
    {
      typeInfo.AddErrorMsg(PhaseNum, "Description missing");
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
        typeInfo.AddErrorMsg(PhaseNum, "Meaningless description");
      return false;
    }
    return true;
  }

}
