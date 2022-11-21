using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

using Namotion.Reflection;

namespace ModelGen;

public class TypeInfo : ModelElement
{
  public string Namespace { get; set; }


  public String FullName => GetFullName(Name, Namespace, true);

  public string OrigNamespace => Type.Namespace ?? "";

  public string OrigName => Type.Name;
  public String OrigFullName => GetFullName(OrigName, OrigNamespace, false);

  public bool IsReflected { get; private set; }
  public bool IsGenericType => Type.IsGenericType;
  public bool IsGenericTypeDefinition => Type.IsGenericTypeDefinition;
  public bool IsConstructedGenericType => Type.IsConstructedGenericType;
  public bool IsGenericTypeBased => (BaseTypeInfo != null) &&
                                    (BaseTypeInfo.IsConstructedGenericType || IsGenericTypeBased);
  public bool IsGenericTypeParameter => Type.IsGenericTypeParameter;

  public TypeKind TypeKind { get; set; }
  public Collection<EnumInfo>? EnumValues { get; set; }
  public Collection<PropInfo>? Properties { get; set; }

  public TypeInfo? BaseTypeInfo { get; set; }

  public Type Type { get; set; }
  public int UsageCount { get; set; }
  public int AcceptedPropsCount { get; set; }

  public TypeInfo(Type type) : base(type.Name)
  {
    Type = type;
    Namespace = type.Namespace ?? "";
  }

  public void Reflect()
  {
    if (IsReflected)
      return;
    IsReflected = true;
    var type = Type;
    TypeKind = TypeKind.Type;
    IsAccepted = true;
    if (ModelFilter.ExcludedNamespaces.Contains(type.Namespace??""))
      IsAccepted = false;
    if (ModelFilter.ExcludedTypes.Contains(Type.Name)) 
      IsAccepted = false;
    if (ModelFilter.IncludedTypes.Contains(Type.Name)) 
      IsAccepted = true;
    if (ModelFilter.TypeConversionTable.ContainsKey(Type))
      IsAccepted = false;
    if (type.IsEnum)
    {
      TypeKind = TypeKind.Enum;
      if (EnumValues == null)
        EnumValues = new Collection<EnumInfo>(this);
      foreach (var item in Type.GetFields(BindingFlags.Static | BindingFlags.Public))
        EnumValues.Add(new EnumInfo(item));
    }
    else if ((type.IsClass || type.IsInterface ||type.IsValueType) && type != typeof(string) && type != typeof(object))
    {
      TypeKind = (type.IsInterface) ? TypeKind.Interface : (type.IsClass) ? TypeKind.Class : TypeKind.Struct;
      if (Properties == null)
        Properties = new Collection<PropInfo>(this);
      foreach (var item in Type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
        Properties.Add(new PropInfo(item));
      if (type.BaseType != null && type.BaseType != typeof(object) && type.BaseType != typeof(ValueType))
      {
        BaseTypeInfo = TypeManager.RegisterType(type.BaseType, this, Semantics.Inheritance);
      }

      if (type.ContainsGenericParameters)
      {
        var genericTypeParameters = type.GetGenericArguments().ToList();
        if (genericTypeParameters.Any())
        {
          foreach (var argType in genericTypeParameters)
            TypeManager.RegisterType(argType, this, Semantics.GenericTypeParam);
        }
      }

      if (type.IsGenericTypeParameter)
      {
        var genericTypeParamConstraints = type.GetGenericParameterConstraints().ToList();
        if (genericTypeParamConstraints.Any())
        {
          foreach (var constraint in genericTypeParamConstraints)
            TypeManager.RegisterType(constraint, type, Semantics.GenericTypeParamConstraint);
        }
      }

      var genericTypeArguments = type.GenericTypeArguments.ToList();
      if (genericTypeArguments.Any())
      {
        foreach (var argType in genericTypeArguments)
        {
          TypeManager.RegisterType(argType, this, Semantics.GenericTypeArg);
        }
      }

      var implementedInterfaces = type.GetInterfaces().ToList();
      if (implementedInterfaces.Any())
      {
        foreach (var intf in implementedInterfaces)
        {
          TypeManager.RegisterType(intf, this, Semantics.Implementation);
        }
      }

    }
    //if (Name == "Body")
    //  Debug.Assert(true);
    Documentation = type.GetXmlDocsElement();
    if (Documentation != null)
    {
      Summary = DocumentationReader.GetSummaryFirstPara(Documentation);
      var childItemTypes = DocumentationReader.GetChildItemTypes(Documentation, type.Assembly);
      if (childItemTypes != null)
      {
        foreach (var childItemType in childItemTypes)
          TypeManager.RegisterType(childItemType, this, Semantics.Include);
      }

    }
    foreach (var item in type.CustomAttributes)
      CustomAttributes.Add(new CustomAttribData(item));
  }

  public IEnumerable<TypeInfo> GetInterfaces()
  {
    if (!IsReflected)
      Reflect();
    return TypeManager.GetRelatedTypes(this, Semantics.Implementation);
  }

  public IEnumerable<TypeInfo> GetIncludedTypes()
  {
    if (!IsReflected)
      Reflect();
    return TypeManager.GetRelatedTypes(this,Semantics.Include);
  }
  public IEnumerable<TypeInfo> GetGenericArgTypes()
  {
    if (!IsReflected)
      Reflect();
    return TypeManager.GetRelatedTypes(this, Semantics.GenericTypeArg);
  }

  public IEnumerable<TypeInfo> GetGenericParamTypes()
  {
    if (!IsReflected)
      Reflect();
    return TypeManager.GetRelatedTypes(this, Semantics.GenericTypeParam);
  }

  public IEnumerable<TypeInfo> GetGenericTypeParamConstraints()
  {
    if (!IsReflected)
      Reflect();
    return TypeManager.GetRelatedTypes(this, Semantics.GenericTypeParamConstraint);

  }

  public IEnumerable<GenericParamConstraint> GetGenericParamConstraints()
  {  
    if (!IsReflected)
      Reflect();
    var list = new List<GenericParamConstraint>();
    if (IsGenericTypeParameter)
      return list;
    var genericParameterAttributes = Type.GenericParameterAttributes;
    if (genericParameterAttributes.HasFlag(GenericParameterAttributes.Covariant))
      list.Add(GenericParamConstraint.Covariant);
    if (genericParameterAttributes.HasFlag(GenericParameterAttributes.Contravariant))
      list.Add(GenericParamConstraint.Contravariant);
    if (genericParameterAttributes.HasFlag(GenericParameterAttributes.NotNullableValueTypeConstraint))
      list.Add(GenericParamConstraint.NotNullableValueType);
    if (genericParameterAttributes.HasFlag(GenericParameterAttributes.ReferenceTypeConstraint))
      list.Add(GenericParamConstraint.ReferenceType);
    if (genericParameterAttributes.HasFlag(GenericParameterAttributes.DefaultConstructorConstraint))
      list.Add(GenericParamConstraint.Newable);
    return list;
  }

  public string GetFullName(string aName, string? aNamespace = null, bool showGenericParams = false)
  {
    //if (Name=="EnumValue`1")
    //  Debug.Assert(true);
    if (IsGenericTypeParameter)
      return Name;
    if (showGenericParams)
    {
      var apos = aName.IndexOf('`');
      if (apos >= 0)
      {
        var genericParams = GetGenericParamTypes();
        var genericArgs = GetGenericArgTypes();
        var ls = new List<String>();
        if (genericParams.Any())
          foreach (var genericParam in genericParams.ToList())
          {
            ls.Add(genericParam.Name);
          }
        else if (genericArgs.Any())
          foreach (var genericArg in genericArgs.ToList())
          {
            ls.Add(genericArg.FullName);
          }
        if (ls.Count > 0)
        {
          aName = aName.Substring(0, apos);
          aName += $"<{String.Join(",", ls)}>";
        }
      }
    }
    if (aNamespace!=null)
      return aNamespace + "." + aName;
    return aName;
  }

  public override string ToString() => GetFullName(Name, Namespace, true);
}