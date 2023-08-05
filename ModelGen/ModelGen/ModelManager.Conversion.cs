namespace ModelGen;
public static class TypeInfoUtils
{
  public static List<TypeInfo> GetBaseTypes(this TypeInfo typeInfo)
  {
    var result = new List<TypeInfo>();
    var baseTypeInfo = typeInfo.BaseTypeInfo?.GetConversionTargetOrSelf();
    if (baseTypeInfo != null)
    {
      result.Add(baseTypeInfo);
      result.AddRange(baseTypeInfo.GetBaseTypes());
    }
    return result;
  }

  public static TypeInfo GetTargetType(this PropInfo propInfo)
  {
    if (propInfo.TargetType != null)
      return propInfo.TargetType;
    var typeInfo = propInfo.PropertyType;
    TypeInfo targetTypeInfo = null!;
    Type? targetType = null;
    string propName = "";
    if (propInfo.DeclaringType != null)
      propName = propInfo.DeclaringType.GetTargetNamespace() + "." + propInfo.DeclaringType.Name + ".";
    propName += propInfo.Name;
    if (ModelConfig.Instance.TryGetPropertyType(propName, out targetType))
      targetTypeInfo = TypeManager.RegisterType(targetType, typeInfo, Semantics.TypeChange);
    else
    {
      if (typeInfo.Name == "HexBinaryValue")
      {
        if (propInfo.Constraints != null)
        {
          var stringConstraint = (StringConstraint?)
            propInfo.Constraints.FirstOrDefault(item => item.GetType() == typeof(StringConstraint));
          if (stringConstraint != null)
          {
            if (stringConstraint.Length == 2)
              targetType = typeof(HexChar);
            else
            if (stringConstraint.Length == 3)
              targetType = typeof(RGB);
            else
            if (stringConstraint.Length == 4)
              targetType = typeof(HexInt);
          }
        }
        if (targetType == null)
          targetType = typeof(HexBinary);
        if (targetType != null)
        {
          targetTypeInfo = TypeManager.RegisterType(targetType, typeInfo, Semantics.TypeChange);
        }
      }
    }
    if (targetTypeInfo == null)
      targetTypeInfo = GetConversionTargetOrSelf(typeInfo);
    propInfo.TargetType = targetTypeInfo;
    return targetTypeInfo;
  }

  public static TypeInfo? GetOriginType(this TypeInfo typeInfo)
  {
    var result = GetConversionSource(typeInfo);
    return result;
  }

  public static FullTypeName GetConvertedName(this TypeInfo typeInfo, TypeKind kind)
  {
    if (typeInfo.IsConverted)
      typeInfo = typeInfo.GetConversionTargetOrSelf();
    string aName = typeInfo.Name;
    if (typeInfo.IsGenericTypeParameter)
      return new FullTypeName(aName, null);
    string aNamespace = typeInfo.GetTargetNamespace();

    aNamespace = TypeManager.TranslateNamespace(aNamespace);
    var apos = aName.IndexOf('`');
    if (apos >= 0)
      aName = aName.Substring(0, apos);
    if (kind == TypeKind.Class && typeInfo.TypeKind != TypeKind.Enum)
    {
      aName += "Impl";
    }
    var result = new FullTypeName(aName, (aNamespace != null) ? aNamespace : null);
    if (apos >= 0)
    {
      var genericParams = typeInfo.GetGenericParamTypes();
      var genericArgs = typeInfo.GetGenericArguments();
      if (genericParams.Any())
      {
        result.ArgNames = new();
        foreach (var genericParam in genericParams.ToList())
          result.ArgNames.Add(new FullTypeName(genericParam.Name, null));
      }
      else if (genericArgs.Any())
      {
        result.ArgNames = new();
        foreach (var genericArg in genericArgs.ToList())
          result.ArgNames.Add(GetConvertedName(genericArg, kind));
      }
    }
    return result;
  }

  public static TypeInfo GetConversionTargetOrSelf(this TypeInfo typeInfo)
  {
    var result = TypeManager.GetRelatedTypes(typeInfo, Semantics.TypeChange).FirstOrDefault();
    if (result == null && typeInfo.IsConstructedGenericType)
      if (ModelManager.Instance.TryAddGenericTypeConversion(typeInfo, out var targetType))
        result = targetType;
    if (result != null)
    {
      ModelManager.Instance.TryConvertType(result);
      if (result.IsConverted)
        result = GetConversionTargetOrSelf(result);
    }
    return result ?? typeInfo;
  }

  public static TypeInfo GetTargetType(this TypeInfo typeInfo)
  {
    if (typeInfo.TargetType != null)
      return typeInfo.TargetType;
    var result = GetConversionTargetOrSelf(typeInfo);
    if (result.TargetType != null)
    {
      typeInfo.TargetType = result.TargetType;
      return typeInfo.TargetType;
    }
    typeInfo.TargetType = result;
    return result;
  }

  public static TypeInfo? GetConversionTarget(this TypeInfo typeInfo)
  {
    var result = TypeManager.GetRelatedTypes(typeInfo, Semantics.TypeChange).FirstOrDefault();
    if (result == null && typeInfo.IsConstructedGenericType)
      if (ModelManager.Instance.TryAddGenericTypeConversion(typeInfo, out var targetType))
        result = targetType;
    if (result != null)
    {
      ModelManager.Instance.TryConvertType(result);
      if (result.IsConverted)
        result = GetConversionTarget(result);
    }
    return result;
  }

  public static TypeInfo? GetConversionSource(this TypeInfo typeInfo)
  {
    if (typeInfo.IsConvertedTo)
      return typeInfo;
    var result = TypeManager.GetRevRelatedTypes(typeInfo, Semantics.TypeChange).FirstOrDefault();
    return result;
  }

  #region Namespace methods
  public static bool HasDuplicatesInNamespace(this TypeInfo type)
  {
    if (type.Name.Contains('`'))
      return false;
    return TypeManager.GetNamespaceTypes(type.GetTargetNamespace()).Where(Item => Item.Name == type.Name).Count() > 1;
  }

  public static TypeInfo[] GetDuplicatesInNamespace(this TypeInfo type)
  {
    return TypeManager.GetNamespaceTypes(type.GetTargetNamespace()).Where(Item => Item.Name == type.Name).ToArray();
  }
  private static bool HasExcludedNamespace(this TypeInfo typeInfo)
  {
    if (ModelConfig.Instance.ExcludedNamespaces.Contains(typeInfo.GetTargetNamespace()))
      return true;
    if (typeInfo.IsConstructedGenericType)
    {
      foreach (var arg in typeInfo.GetGenericArguments())
      {
        if (HasExcludedNamespace(arg))
          return true;
      }
    }
    return false;
  }
  #endregion

  public static string GetTargetName(this PropInfo prop)
  {
    if (prop.DeclaringType != null)
    {
      if (prop.Name == "Count")
        Debug.Assert(true);
      var fullName = prop.DeclaringType.GetFullName(false, true, true) + "." + prop.Name;
      if (ModelConfig.Instance.PropertyTranslateTable.TryGetValue(fullName, out var newName))
        return newName;
    }
    return prop.Name;
  }
}
