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
  public bool IsAccepted { get; set; }
  public bool IsGenericType => Type.IsGenericType;
  public bool IsGenericTypeDefinition => Type.IsGenericTypeDefinition;
  public bool IsConstructedGenericType => Type.IsConstructedGenericType;
  public bool IsGenericTypeBased => (BaseTypeInfo != null) &&
                                    (BaseTypeInfo.IsConstructedGenericType || IsGenericTypeBased);

  public TypeKind TypeKind { get; set; }
  public Collection<EnumInfo>? EnumValues { get; set; }
  public Collection<PropInfo>? Properties { get; set; }
  public TypeInfo? BaseTypeInfo { get; set; }

  public Type Type { get; set; }
  public int UsageCount { get; set; }
  public int PropsCount { get; set; }

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
    if ((type.Namespace ?? "").StartsWith("System"))
    {
      TypeKind = TypeKind.System;
    }
    else if (type.IsEnum)
    {
      TypeKind = TypeKind.Enum;
      if (EnumValues == null)
        EnumValues = new Collection<EnumInfo>(this);
      foreach (var item in Type.GetFields(BindingFlags.Static | BindingFlags.Public))
        EnumValues.Add(new EnumInfo(item));
    }
    else if ((type.IsClass || type.IsValueType) && type != typeof(string) && type != typeof(object))
    {
      TypeKind = (type.IsClass) ? TypeKind.Class : TypeKind.Struct;
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
        if (genericTypeParameters != null && genericTypeParameters.Count > 0)
        {
          foreach (var argType in genericTypeParameters)
            TypeManager.RegisterType(argType, this, Semantics.GenericTypeParam);
        }
      }

      if (type.IsGenericTypeParameter)
      {
        var genericTypeParamConstraints = type.GetGenericParameterConstraints().ToList();
        if (genericTypeParamConstraints != null && genericTypeParamConstraints.Count > 0)
        {
          foreach (var constraint in genericTypeParamConstraints)
            TypeManager.RegisterType(type, constraint, Semantics.GenericTypeParamConstraint);
        }
      }

      var genericTypeArguments = type.GenericTypeArguments.ToList();
      if (genericTypeArguments != null && genericTypeArguments.Count > 0)
      {
        foreach (var argType in genericTypeArguments)
        {
          TypeManager.RegisterType(argType, this, Semantics.GenericTypeArg);
        }
      }
    }
    var documentation = type.GetXmlDocsElement();
    if (documentation != null)
      Summary = DocumentationReader.GetSummaryFirstPara(documentation);
    foreach (var item in type.CustomAttributes)
    {
      CustomAttributes.Add(new CustomAttribData(item));
    }
  }

  public IEnumerable<TypeInfo>? GetGenericArgTypes()
  {
    if (!IsReflected)
      Reflect();
    var genericArgsTypes = TypeManager.GetOutgoingRelationships(this)
      .Where(item => item.Semantics == Semantics.GenericTypeArg)
      .Select(item => item.Target);
    if (genericArgsTypes.Any() == true)
    {
      return genericArgsTypes;
    }
    return null;
  }

  public IEnumerable<TypeInfo>? GetGenericParamTypes()
  {
    if (!IsReflected)
      Reflect();
    var genericParamTypes = TypeManager.GetOutgoingRelationships(this)
      .Where(item => item.Semantics == Semantics.GenericTypeParam)
      .Select(item => item.Target);
    if (genericParamTypes.Any() == true)
    {
      return genericParamTypes;
    }
    return null;
  }

  public IEnumerable<TypeInfo>? GetGenericTypeParamConstraints()
  {
    if (!IsReflected)
      Reflect();
    var genericTypeParamConstraints = TypeManager.GetOutgoingRelationships(this)
      .Where(item => item.Semantics == Semantics.GenericTypeParamConstraint)
      .Select(item => item.Target);
    if (genericTypeParamConstraints.Any() == true)
    {
      return genericTypeParamConstraints;
    }
    return null;
  }

  public IEnumerable<GenericParamConstraint>? GetGenericParamConstraints()
  {  
    if (!IsReflected)
      Reflect();
    var genericParameterAttributes = Type.GenericParameterAttributes;
    var list = new List<GenericParamConstraint>();
    if (genericParameterAttributes.HasFlag(GenericParameterAttributes.Covariant))
      list.Add(GenericParamConstraint.Covariant);
    if (genericParameterAttributes.HasFlag(GenericParameterAttributes.Contravariant))
      list.Add(GenericParamConstraint.Contravariant);
    if (genericParameterAttributes.HasFlag(GenericParameterAttributes.NotNullableValueTypeConstraint))
      list.Add(GenericParamConstraint.NotNullable);
    if (genericParameterAttributes.HasFlag(GenericParameterAttributes.ReferenceTypeConstraint))
      list.Add(GenericParamConstraint.ReferenceType);
    if (genericParameterAttributes.HasFlag(GenericParameterAttributes.DefaultConstructorConstraint))
      list.Add(GenericParamConstraint.Newable);
    return (list.Count>0) ? list : null;
  }

  public string GetFullName(string aName, string? aNamespace = null, bool showGenericParams = false)
  {
    if (showGenericParams)
    {
      var apos = aName.IndexOf('`');
      if (apos >= 0)
      {
        var genericParams = GetGenericParamTypes();
        var genericArgs = GetGenericArgTypes();
        var ls = new List<String>();
        if (genericParams != null)
          foreach (var genericParam in genericParams)
          {
            ls.Add(genericParam.Name);
          }
        else if (genericArgs != null)
          foreach (var genericArg in genericArgs)
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

  public override string ToString() => GetFullName(Name, Namespace);
}