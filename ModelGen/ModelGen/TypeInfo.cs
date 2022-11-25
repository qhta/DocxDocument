using System.Reflection.Metadata.Ecma335;

namespace ModelGen;

public class TypeInfo : ModelElement
{
  public string Namespace
  {
    get => TypeManager.GetNamespace(NamespaceIndex);
    set
    {
      if (value != Namespace)
        NamespaceIndex = TypeManager.RegisterNamespace(value);
    }
  }
  public int NamespaceIndex { get; private set; }

  public string OrigNamespace => Type.Namespace ?? "";

  public string OrigName => Type.Name;

  public bool IsReflected { get; internal set; }
  public bool IsGenericType => Type.IsGenericType;
  public bool IsGenericTypeDefinition => Type.IsGenericTypeDefinition;
  public bool IsConstructedGenericType => Type.IsConstructedGenericType;
  private bool IsGenericTypeBased => (BaseTypeInfo != null) &&
                                    (BaseTypeInfo.IsConstructedGenericType || BaseTypeInfo.IsGenericTypeBased);
  public bool IsGenericTypeParameter => Type.IsGenericTypeParameter;

  public TypeKind TypeKind { get; set; }
  public Collection<EnumInfo>? EnumValues { get; set; }
  public Collection<PropInfo>? Properties { get; set; }

  public IEnumerable<PropInfo>? AcceptedProperties => Properties?.Where(item => item.IsAccepted != false);

  public TypeInfo? BaseTypeInfo { get; set; }

  public Type Type { get; set; }
  public bool UsesEvaluated { get; set; }
  public int UsageCount { get; set; }
  public int AcceptedPropsCount { get; set; }

  public TypeInfo(Type type) : base(type.Name)
  {
    Type = type;
    Namespace = type.Namespace ?? "";
    var isAccepted = true;
    if (ModelData.ExcludedNamespaces.Contains(type.Namespace ?? ""))
      isAccepted = false;
    if (ModelData.ExcludedTypes.Contains(type.Name))
      isAccepted = false;
    if (ModelData.IncludedTypes.Contains(type.Name))
      isAccepted = true;
    if (ModelData.TypeConversionTable.ContainsKey(type))
      isAccepted = false;
    IsAccepted = isAccepted;
  }

  public string GetNamespace(bool original = false)
  {
    string aNamespace;
    if (original)
    {
      aNamespace = this.OrigNamespace;
    }
    else
    {
      aNamespace = this.Namespace;
      var nSpace = aNamespace;
      foreach (var item in ModelData.NamespaceRedirectionTable)
      {
        if (aNamespace.StartsWith(item.Item1))
          nSpace = item.Item2;
      }
      aNamespace = nSpace;
    }
    return aNamespace;
  }

  public string GetFullName(bool original = false, bool asInterface = false, bool withNamespace = true)
  {
    string aName;
    string aNamespace;
    if (original)
    {
      aName = this.OrigName;
      aNamespace = this.OrigNamespace;
    }
    else
    {
      aName = this.Name;
      aNamespace = this.Namespace;
      if (asInterface && TypeKind == TypeKind.Class && !aName.StartsWith("I"))
      {
        aName = "I" + aName;
      }
      aNamespace = TypeManager.TranslateNamespace(aNamespace);
    }
    if (IsGenericTypeParameter)
      return Name;
    var apos = aName.IndexOf('`');
    if (apos >= 0)
    {
      var genericParams = this.GetGenericParamTypes();
      var genericArgs = this.GetGenericArgTypes();
      var ls = new List<String>();
      if (genericParams.Any())
        foreach (var genericParam in genericParams.ToList())
        {
          ls.Add(genericParam.Name);
        }
      else if (genericArgs.Any())
        foreach (var genericArg in genericArgs.ToList())
        {
          ls.Add(genericArg.GetFullName(true, false, asInterface));
        }
      if (ls.Count > 0)
      {
        aName = aName.Substring(0, apos);
        aName += $"<{String.Join(",", ls)}>";
      }
    }

    if (withNamespace && aNamespace != null)
      return aNamespace + "." + aName;
    return aName;
  }

  public override string ToString() => $"{Namespace}.{Name}";
}