using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using DocumentFormat.OpenXml.Framework.Metadata;
using System.Runtime.CompilerServices;
using DocumentModel;
using Qhta.TypeUtils;

namespace ModelGen;

public class TypeInfo : ModelElement
{
  public string Namespace { get; set; } = String.Empty;
  //{
  //  get => _Namespace;
  //  set
  //  {
  //    if (value != _Namespace)
  //    {
  //      TypeManager.RegisterNamespace(value);
  //      _Namespace = value;
  //    }
  //  }
  //}

  private string _Namespace = string.Empty;

  public string OriginalNamespace => Type.Namespace ?? "";

  public string OriginalName => Type.Name;

  public bool IsReflected { get; internal set; }

  public new bool? IsAccepted
  {
    get; 
    set;
  }

  public bool IsValueOrStringType => Type.IsValueType || Type == typeof(string) || Type == typeof(System.Uri);

  public bool IsGenericType => Type.IsGenericType;
  public bool IsGenericTypeDefinition => Type.IsGenericTypeDefinition;
  public bool IsConstructedGenericType => Type.IsConstructedGenericType;
  private bool IsGenericTypeBased => (BaseTypeInfo != null) &&
                                    (BaseTypeInfo.IsConstructedGenericType || BaseTypeInfo.IsGenericTypeBased);
  public bool IsGenericTypeParameter => Type.IsGenericTypeParameter;

  public TypeKind TypeKind { get; set; }

  public bool IsInterface => TypeKind.HasFlag(TypeKind.Interface);
  public bool IsClass => TypeKind.HasFlag(TypeKind.Class);

  public OwnedCollection<EnumInfo>? EnumValues { get; set; }
  public OwnedCollection<PropInfo>? Properties { get; set; }
  public Collection<TypeRelationship> OutgoingRelationships { get; set; } = new();
  public Collection<TypeRelationship> IncomingRelationships { get; set; } = new();

  public IEnumerable<PropInfo>? AcceptedProperties => Properties?.Where(item => item.IsAccepted != false);

  public TypeInfo? BaseTypeInfo { get; set; }

  public Type Type { get; set; }

  public bool IsSimple()
  {
    return Type.IsSimple() || Type == typeof(Byte[]) || Type == typeof(HexWord);
  }

  public bool IsEnum([NotNullWhen(true)] out TypeInfo? enumType)
  {
    if (Type.Name.StartsWith("EnumValue`"))
    {
      enumType = TypeManager.GetGenericArgTypes(this).FirstOrDefault();
      return (enumType != null);
    }
    enumType = null;
    return false;
  }

  internal IElementMetadata? Metadata { get; set;}

  public ItemsConstraint? ItemsConstraint { get; set; }

  public bool UsesEvaluated { get; set; }
  public int AcceptedPropsCount { get; set; }

  public TypeInfo(Type type) : base(type.Name)
  {
    Type = type;
    Namespace = type.Namespace ?? "";
    if (IsAccepted == null)
    {
      var isAccepted = true;
      //if (Name.StartsWith("Collection"))
      //  Debug.Assert(true);
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
  }

  public string GetNamespace(bool original = false)
  {
    string aNamespace;
    if (original)
    {
      aNamespace = this.OriginalNamespace;
    }
    else
    {
      aNamespace = this.Namespace;
      var nSpace = aNamespace;
      foreach (var item in ModelData.NamespaceTranslationTable)
      {
        if (aNamespace.StartsWith(item.Item1))
          nSpace = item.Item2;
      }
      aNamespace = nSpace;
    }
    if (aNamespace == "System")
      aNamespace = "";
    return aNamespace;
  }

  public FullTypeName GetFullName(bool original = false)
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
      aNamespace = this.Namespace;
      aNamespace = TypeManager.TranslateNamespace(aNamespace);
    }
    if (aNamespace == "System")
      aNamespace = "";
    if (IsGenericTypeParameter)
      return new FullTypeName(Name, null);
    var result = new FullTypeName(aName, aNamespace);
    var apos = aName.IndexOf('`');
    if (apos >= 0)
    {

      var genericParams = this.GetGenericParamTypes();
      var genericArgs = this.GetGenericArgTypes();
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

  public override string ToString() => $"{Namespace}.{Name}";
}