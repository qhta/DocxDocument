namespace ModelGen;

/// <summary>
/// Represents information of scanned and generated type.
/// </summary>
public class TypeInfo : ModelElement
{
  /// <summary>
  /// Type read from source library or declared explicitly on creation.
  /// </summary>
  public Type Type { get; private set; }

  /// <summary>
  /// Original namespace - get from type.
  /// </summary>
  public string OriginalNamespace => Type.Namespace ?? "";

  /// <summary>
  /// Original type name - get from Type.
  /// </summary>
  public string OriginalName => Type.Name;

  /// <summary>
  /// Target type info - used in conversion.
  /// </summary>
  public TypeInfo? TargetType { get; set; }

  /// <summary>
  /// Target namespace - when generated.
  /// </summary>
  public string TargetNamespace { get => _TargetNamespace ?? OriginalNamespace; set { _TargetNamespace = value; } }

  private string? _TargetNamespace;


  public bool IsReflected { get; internal set; }

  public bool IsValueOrStringType => Type.IsValueType || Type == typeof(string) || Type == typeof(System.Uri);

  public bool IsGenericType => Type.IsGenericType;
  public bool IsGenericTypeDefinition => Type.IsGenericTypeDefinition;
  public bool IsConstructedGenericType => Type.IsConstructedGenericType;
  private bool IsGenericTypeBased => (BaseTypeInfo != null) &&
                                    (BaseTypeInfo.IsConstructedGenericType || BaseTypeInfo.IsGenericTypeBased);
  public bool IsGenericTypeParameter => Type.IsGenericTypeParameter;

  public TypeKind TypeKind
  {
    get;
    set;
  }

  public bool IsInterface => TypeKind == TypeKind.Interface;
  public bool IsClass => TypeKind == TypeKind.Class;

  public OwnedCollection<EnumInfo>? EnumValues { get; set; }
  public OwnedCollection<PropInfo>? Properties { get; set; }
  public Collection<TypeRelationship> OutgoingRelationships { get; set; } = new();
  public Collection<TypeRelationship> IncomingRelationships { get; set; } = new();

  public IEnumerable<PropInfo>? AcceptedProperties => Properties?.Where(item => item.IsAccepted != false);

  public TypeInfo? BaseTypeInfo { get; set; }

  public bool IsSimple()
  {
    return Type.IsSimple() || Type == typeof(Uri) || Type == typeof(HexInt) /*|| Type == typeof(Byte[])*/;
  }

  public bool IsEnumValue([NotNullWhen(true)][MaybeNullWhen(false)] out TypeInfo? enumType)
  {
    if (Type.Name.StartsWith("EnumValue`"))
    {
      enumType = TypeManager.GetGenericTypeArguments(this).FirstOrDefault();
      return (enumType != null);
    }
    enumType = null;
    return false;
  }

  public bool UsesEvaluated { get; set; }
  public int AcceptedPropsCount { get; set; }

  public TypeInfo(Type type) : base(type.Name)
  {
    Type = type;
    TargetNamespace = type.Namespace ?? "";
    TypeKind = (type.IsEnum) ? TypeKind.Enum
               : (type.IsInterface) ? TypeKind.Interface
               : (type.IsClass) ? TypeKind.Class
               : (type.IsStruct() ? TypeKind.Struct
               : TypeKind.Type);
    //if (Acceptance == null)
    //{
    //  var isAccepted = true;
    //  if (ModelData.ExcludedNamespaces.Contains(type.Namespace ?? ""))
    //    isAccepted = false;
    //  if (ModelData.ExcludedTypes.Contains(type.Name))
    //    isAccepted = false;
    //  if (ModelData.IncludedTypes.Contains(type.Name))
    //    isAccepted = true;
    //  if (ModelData.TypeConversionTable.ContainsKey(type))
    //    isAccepted = false;
    //  IsAccepted = isAccepted;
    //}
  }

  public string GetNamespace(bool original = false, bool shortcut = true)
  {
    string aNamespace;
    if (original)
    {
      aNamespace = this.OriginalNamespace;
    }
    else
    {
      aNamespace = this.TargetNamespace;
      aNamespace = TypeManager.TranslateNamespace(aNamespace);
    }
    if (shortcut)
      aNamespace = NamespaceShortcut(aNamespace);
    return aNamespace;
  }

  public FullTypeName GetFullName(bool original = false, bool shortcut = true)
  {
    string aName;
    string aNamespace;
    if (original)
    {
      aName = this.OriginalName;
      aNamespace = this.OriginalNamespace;
    }
    else
    {
      aName = this.Name;
      aNamespace = this.TargetNamespace;
      aNamespace = TypeManager.TranslateNamespace(aNamespace);
    }
    if (shortcut)
      aNamespace = NamespaceShortcut(aNamespace);
    if (IsGenericTypeParameter)
      return new FullTypeName(Name, null);
    var result = new FullTypeName(aName, aNamespace);
    var apos = aName.IndexOf('`');
    if (apos >= 0)
    {

      var genericParams = this.GetGenericParamTypes();
      var genericArgs = this.GetGenericTypeArguments();
      var argNames = new List<FullTypeName>();
      if (genericParams.Any())
        foreach (var genericParam in genericParams.ToList())
        {
          argNames.Add(new FullTypeName(genericParam.Name, null));
        }
      else if (genericArgs.Any())
        foreach (var genericArg in genericArgs.ToList())
        {
          argNames.Add(genericArg.GetFullName(original));
        }
      if (argNames.Count > 0)
      {
        result.Name = aName.Substring(0, apos);
        result.ArgNames = argNames;
      }
    }
    return result;
  }

  public static string NamespaceShortcut(string ns)
  {
    return ModelConfig.NamespaceShortcut(ns);
  }

  public override string ToString() => $"{TargetNamespace}.{Name}";

  public bool IsTypeKindSelected(TKS tks)
  {
    if (tks==TKS.Any) return true;
    if (tks.HasFlag(TKS.Class) && TypeKind==TypeKind.Class) return true;
    if (tks.HasFlag(TKS.Enum) && TypeKind==TypeKind.Enum) return true;
    if (tks.HasFlag(TKS.Interface) && TypeKind==TypeKind.Interface) return true;
    if (tks.HasFlag(TKS.Struct) && TypeKind==TypeKind.Struct) return true;
    if (tks.HasFlag(TKS.Other) && TypeKind==TypeKind.Type) return true;
    return false;
  }
}