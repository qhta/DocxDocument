using System.IO.Packaging;
using System.Reflection;

using Qhta.Xml;

namespace ModelGen;

/// <summary>
/// Represents information of scanned and generated type.
/// </summary>
[XmlRoot("Type")]
public class TypeInfo : ModelElement
{
  /// <summary>
  /// Type read from source library or declared explicitly on creation.
  /// </summary>
  [XmlIgnore]
  public Type Type { get; private set; } = null!;

  /// <summary>
  /// Original namespace - get from type.
  /// </summary>
  public string OriginalNamespace => Type.Namespace ?? "";

  [XmlIgnore]
  public new string Name { get => base.Name; set => base.Name = value; }

  /// <summary>
  /// Original type name - get from Type.
  /// </summary>
  [SerializationOrder(-1)]
  public string OriginalName
  {
    get => TypeManager.GetOriginalName(this);
    set
    {
      // Do nothing. This accessor is needed only for Serializer.
    }
  }

  /// <summary>
  /// Target type info - used in conversion.
  /// </summary>
  [XmlIgnore]
  public TypeInfo? TargetType => this.GetConversionTarget();

  /// <summary>
  /// Target namespace - when generated.
  /// </summary>
  public string? TargetNamespace
  {
    get;
    set;
  }

  public string GetTargetNamespace()
  {
    if (TargetNamespace != null) return TargetNamespace;
    if (Owner is Namespace nspace)
    {
      if (nspace.TargetName != null) return nspace.TargetName;
      return nspace.OriginalName;
    }
    return OriginalNamespace;
  }
  /// <summary>
  /// Original type name - get from Type.
  /// </summary>
  [XmlIgnore]
  public string TargetName => TypeManager.GetTargetName(this);

  [XmlIgnore]
  public bool IsReflected { get; internal set; }

  public bool IsValueOrStringType => Type.IsValueType || Type == typeof(string) || Type == typeof(System.Uri);

  public bool IsGenericType => Type.IsGenericType;
  public bool IsGenericTypeDefinition => Type.IsGenericTypeDefinition;
  public bool IsConstructedGenericType => Type.IsConstructedGenericType;
  private bool IsGenericTypeBased => (BaseTypeInfo != null) &&
                                    (BaseTypeInfo.IsConstructedGenericType || BaseTypeInfo.IsGenericTypeBased);
  public bool IsGenericTypeParameter => Type.IsGenericTypeParameter;

  [SerializationOrder(-1)]
  public TypeKind TypeKind
  {
    get;
    set;
  }

  [XmlIgnore]
  public bool IsInterface => TypeKind == TypeKind.@interface;
  [XmlIgnore]
  public bool IsClass => TypeKind == TypeKind.@class;

  public bool IsAbstract => Type.IsAbstract;

  public OwnedCollection<EnumInfo>? EnumValues { get; private set; }

  public void Add(EnumInfo enumInfo)
  {
    if (EnumValues == null)
      EnumValues = new OwnedCollection<EnumInfo>(this);
    EnumValues.Add(enumInfo);
  }

  public OwnedCollection<PropInfo>? Properties { get; private set; }

  public void Add(PropInfo propInfo)
  {
    if (Properties == null)
      Properties = new OwnedCollection<PropInfo>(this);
    Properties.Add(propInfo);
  }

  public IEnumerable<PropInfo> GetAllProperties()
  {
    var result = new List<PropInfo>();
    if (Properties!=null)
      foreach (var propInfo in Properties)
        result.Add(propInfo);
    if (BaseTypeInfo!=null)
    {
      var subProps = BaseTypeInfo.GetAllProperties();
      foreach (var subProp in subProps)
      {
        var thisProp = result.FirstOrDefault(item=>item.Name==subProp.Name);
        if (thisProp==null || thisProp.IsNew)
          result.Add(subProp);
      }
    }
    return result;
  }

  [XmlIgnore]
  public Collection<TypeRelationship> OutgoingRelationships { get; set; } = new();
  [XmlIgnore]
  public Collection<TypeRelationship> IncomingRelationships { get; set; } = new();

  public IEnumerable<PropInfo> AcceptedProperties(PPS phase) => Properties?.Where(item => item.IsAcceptedTo(phase)) ?? EmptyPropertiesSet;

  private static IEnumerable<PropInfo> EmptyPropertiesSet = new PropInfo[0];

  [XmlIgnore]
  public TypeInfo? BaseTypeInfo { get; set; }

  public bool IsSimple()
  {
    return Type.IsSimple() || Type == typeof(Uri) || Type == typeof(HexInt) /*|| Type == typeof(Byte[])*/;
  }

  public bool IsEnumValue([NotNullWhen(true)][MaybeNullWhen(false)] out TypeInfo? enumType)
  {
    if (Type.Name.StartsWith("EnumValue`"))
    {
      enumType = TypeManager.GetGenericArguments(this).FirstOrDefault();
      return (enumType != null);
    }
    enumType = null;
    return false;
  }

  [XmlIgnore]
  public bool UsageEvaluated { get; set; }

  [XmlIgnore]
  public int AcceptedPropsCount { get; set; }

  public TypeInfo() { }

  public TypeInfo(Type type) : base(type.Name)
  {
    Type = type;
    TypeKind = (type.IsEnum) ? TypeKind.@enum
               : (type.IsInterface) ? TypeKind.@interface
               : (type.IsClass) ? TypeKind.@class
               : (type.IsStruct() ? TypeKind.@struct
               : TypeKind.type);
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

  public string GetNamespace(bool target, bool shortcut)
  {
    string aNamespace;
    if (target)
      aNamespace = this.GetTargetNamespace();
    else
      aNamespace = this.OriginalNamespace;
    if (shortcut)
      aNamespace = NamespaceShortcut(aNamespace);
    return aNamespace;
  }

  public FullTypeName GetFullName(bool target, bool withNamespace, bool nsShortcut)
    => GetFullName(new TNS(target, withNamespace, nsShortcut));

  public static FullTypeName GetFullName(Type aType, TNS nameKindSelector)
  {
    string aName;
    string? aNamespace = null;
    aName = aType.Name;
    if (nameKindSelector.Namespace)
      aNamespace = aType.Namespace;
    if (aNamespace != null && nameKindSelector.NsShortcut)
      aNamespace = NamespaceShortcut(aNamespace);
    if (aType.IsGenericTypeParameter)
      return new FullTypeName(aName, null);
    var result = new FullTypeName(aName, aNamespace);
    var apos = aName.IndexOf('`');
    if (apos >= 0)
    {
      var genericParams = aType.GetGenericArguments();
      var genericArgs = aType.GenericTypeArguments;
      var argNames = new List<FullTypeName>();
      if (genericParams.Any())
        foreach (var genericParam in genericParams.ToList())
        {
          argNames.Add(new FullTypeName(genericParam.Name, null));
        }
      else if (genericArgs.Any())
        foreach (var genericArg in genericArgs.ToList())
        {
          argNames.Add(GetFullName(genericArg, nameKindSelector));
        }
      if (argNames.Count > 0)
      {
        result.Name = aName.Substring(0, apos);
        result.ArgNames = argNames;
      }
    }
    return result;
  }

  public FullTypeName GetFullName(TNS nameKindSelector)
  {
    string aName;
    string? aNamespace = null;
    if (!nameKindSelector.Target)
      return GetFullName(Type, nameKindSelector);
    else
    {
      if (nameKindSelector.Target)
        aName = this.TargetName ?? this.Name;
      else
        aName = this.Name;
      if (nameKindSelector.Namespace)
        aNamespace = this.GetTargetNamespace();

      if (nameKindSelector.Namespace)
      {
        if (aNamespace != null && nameKindSelector.NsShortcut)
          aNamespace = NamespaceShortcut(aNamespace);
      }
      if (IsGenericTypeParameter)
        return new FullTypeName(Name, null);
      var result = new FullTypeName(aName, aNamespace);

      var apos = aName.IndexOf('`');
      if (apos >= 0)
      {
        var genericParams = this.GetGenericParamTypes();
        var genericArgs = this.GetGenericArguments();
        var argNames = new List<FullTypeName>();
        if (genericParams.Any())
          foreach (var genericParam in genericParams.ToList())
          {
            argNames.Add(new FullTypeName(genericParam.Name, null));
          }
        else if (genericArgs.Any())
          foreach (var genericArg in genericArgs.ToList())
          {
            argNames.Add(genericArg.GetFullName(nameKindSelector));
          }
        if (argNames.Count > 0)
        {
          result.Name = aName.Substring(0, apos);
          result.ArgNames = argNames;
        }
      }
      return result;
    }
  }

  public static string NamespaceShortcut(string ns)
  {
    return ModelConfig.NamespaceShortcut(ns);
  }

  public override string ToString() => $"{OriginalNamespace}.{OriginalName}";

  public bool IsTypeKindSelected(TKS tks)
  {
    if (tks == TKS.Any) return true;
    if (tks.HasFlag(TKS.Class) && TypeKind == TypeKind.@class) return true;
    if (tks.HasFlag(TKS.Enum) && TypeKind == TypeKind.@enum) return true;
    if (tks.HasFlag(TKS.Interface) && TypeKind == TypeKind.@interface) return true;
    if (tks.HasFlag(TKS.Struct) && TypeKind == TypeKind.@struct) return true;
    if (tks.HasFlag(TKS.Other) && TypeKind == TypeKind.type) return true;
    return false;
  }

}