using Namotion.Reflection;

using System.Reflection;

namespace ModelGen;

public static class TypeReflector
{
  public static void Reflect(this TypeInfo typeInfo)
  {
    if (typeInfo.IsReflected)
      return;
    typeInfo.IsReflected = true;
    var type = typeInfo.Type;
    typeInfo.TypeKind = TypeKind.Type;
    if (type.IsEnum)
    {
      typeInfo.TypeKind = TypeKind.Enum;
      if (typeInfo.EnumValues == null)
        typeInfo.EnumValues = new Collection<EnumInfo>(typeInfo);
      foreach (var item in type.GetFields(BindingFlags.Static | BindingFlags.Public))
        typeInfo.EnumValues.Add(new EnumInfo(item));
    }
    else if ((type.IsClass || type.IsInterface || type.IsValueType) && type != typeof(string) && type != typeof(object))
    {
      typeInfo.TypeKind = (type.IsInterface) ? TypeKind.Interface : (type.IsClass) ? TypeKind.Class : TypeKind.Struct;
      if (typeInfo.Properties == null)
        typeInfo.Properties = new Collection<PropInfo>(typeInfo);
      foreach (var item in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
        typeInfo.Properties.Add(new PropInfo(item));
      if (type.BaseType != null && type.BaseType != typeof(object) && type.BaseType != typeof(ValueType))
      {
        typeInfo.BaseTypeInfo = TypeManager.RegisterType(type.BaseType, typeInfo, Semantics.Inheritance);
      }

      if (type.ContainsGenericParameters)
      {
        var genericTypeParameters = type.GetGenericArguments().ToList();
        if (genericTypeParameters.Any())
        {
          foreach (var argType in genericTypeParameters)
            TypeManager.RegisterType(argType, typeInfo, Semantics.GenericTypeParam);
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
          TypeManager.RegisterType(argType, typeInfo, Semantics.GenericTypeArg);
        }
      }

      var implementedInterfaces = type.GetInterfaces().ToList();
      if (implementedInterfaces.Any())
      {
        foreach (var intf in implementedInterfaces)
        {
          TypeManager.RegisterType(intf, typeInfo, Semantics.Implementation);
        }
      }

    }

    typeInfo.Documentation = type.GetXmlDocsElement();
    if (typeInfo.Documentation != null)
    {
      typeInfo.Summary = DocumentationReader.GetSummaryFirstPara(typeInfo.Documentation);
      var childItemTypes = DocumentationReader.GetChildItemTypes(typeInfo.Documentation, type.Assembly);
      if (childItemTypes != null)
      {
        foreach (var childItemType in childItemTypes)
          TypeManager.RegisterType(childItemType, typeInfo, Semantics.Include);
      }

    }
    foreach (var item in type.CustomAttributes)
      typeInfo.CustomAttributes.Add(new CustomAttribData(item));
  }

  public static IEnumerable<TypeInfo> GetInterfaces(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      Reflect(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.Implementation);
  }

  public static IEnumerable<TypeInfo> GetIncludedTypes(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      Reflect(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.Include);
  }
  public static IEnumerable<TypeInfo> GetGenericArgTypes(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      Reflect(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.GenericTypeArg);
  }

  public static IEnumerable<TypeInfo> GetGenericParamTypes(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      Reflect(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.GenericTypeParam);
  }

  public static IEnumerable<TypeInfo> GetGenericTypeParamConstraints(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      Reflect(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.GenericTypeParamConstraint);

  }

  public static IEnumerable<GenericParamConstraint> GetGenericParamConstraints(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      Reflect(typeInfo);
    var list = new List<GenericParamConstraint>();
    if (typeInfo.IsGenericTypeParameter)
      return list;
    var genericParameterAttributes = typeInfo.Type.GenericParameterAttributes;
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
}