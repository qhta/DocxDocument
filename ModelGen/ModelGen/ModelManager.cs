using System.Diagnostics;

using DocumentFormat.OpenXml;

namespace ModelGen;

public static class ModelManager
{

  public static bool TryAddTypeConversion(this TypeInfo typeInfo)
  {
    if (typeInfo.IsConverted)
      return false;
    if (!TryAddTypeTableConversion(typeInfo))
      if (!TryAddBaseTypeConversion(typeInfo))
        if (!TryAddValTypeConversion(typeInfo))
          if (!TryAddValTypeConversion(typeInfo))
            if (!TryAddGenericTypeConversion(typeInfo))
              return false;
    return true;
  }

  private static bool TryAddTypeTableConversion(TypeInfo typeInfo)
  {
    if (typeInfo.IsConverted)
      return false;
    if (ModelData.TypeConversionTable.TryGetValue(typeInfo.Type, out var targetType))
    {
      TypeManager.RegisterType(targetType, typeInfo, Semantics.TypeChange);
      typeInfo.IsAccepted = false;
      typeInfo.IsConverted = true;
      return true;
    }
    return false;
  }

  private static bool TryAddBaseTypeConversion(TypeInfo typeInfo)
  {
    if (typeInfo.IsConverted)
      return false;
    if (typeInfo.AcceptedProperties?.Any() != true)
    {
      if (typeInfo.BaseTypeInfo != null)
      {
        TypeManager.AddRelationship(typeInfo, typeInfo.BaseTypeInfo, Semantics.TypeChange);
        typeInfo.IsAccepted = false;
        typeInfo.IsConverted = true;
        return true;
      }
    }
    return false;
  }

  private static bool TryAddValTypeConversion(TypeInfo typeInfo)
  {
    if (typeInfo.IsConverted)
      return false;
    if (typeInfo.TypeKind == TypeKind.Class && typeInfo.Properties?.Count == 1)
    {
      var firstProp = typeInfo.Properties?.FirstOrDefault();
      if (firstProp != null && firstProp.Name == "Val")
      {
        TypeManager.AddRelationship(typeInfo, firstProp.PropertyType, Semantics.TypeChange);
        typeInfo.IsAccepted = false;
        typeInfo.IsConverted = true;
        return true;
      }
    }
    return false;
  }

  private static bool TryAddGenericTypeConversion(TypeInfo typeInfo)
  {
    return TryAddGenericTypeConversion(typeInfo, out _);
  }

  private static bool TryAddGenericTypeConversion(TypeInfo typeInfo, out TypeInfo? targetType)
  {
    if (typeInfo.Name == "EnumValue`1")
    {
      //  ModelDisplay.ConsoleWriteSameLine($"{typeInfo}[{typeInfo.Type.GetGenericArguments().FirstOrDefault()?.Name}]\n");
      //  if (typeInfo.Type.GetGenericArguments().FirstOrDefault()?.Name == "MultiLevelValues") 
      //    Debug.Assert(true);
    }
    targetType = null;
    if (typeInfo.IsConverted)
      return false;

    if (typeInfo.Type.Name.Contains('`'))
    {
      if (typeInfo.Name.Contains("Enum"))
      {
        var sourceArgTypes = typeInfo.Type.GetGenericArguments();
        var sourceArgType = sourceArgTypes.FirstOrDefault();
        if (sourceArgType != null)
        {
          targetType = TypeManager.RegisterType(sourceArgType, typeInfo, Semantics.TypeChange);
          typeInfo.IsAccepted = false;
          typeInfo.IsConverted = true;
          return true;
        }
      }
      else
      if (typeInfo.Name == "ListValue`1")
      {
        var sourceArgTypes = typeInfo.Type.GetGenericArguments();
        var sourceArgType = sourceArgTypes.FirstOrDefault();
        if (sourceArgType != null)
        {
          var genericParamTypeInfo = TypeManager.RegisterType(sourceArgType);
          genericParamTypeInfo.TryAddTypeConversion();
          if (genericParamTypeInfo.IsConverted)
            sourceArgType = genericParamTypeInfo.GetConversionTarget(true).Type;
          sourceArgType = typeof(List<>).MakeGenericType(new Type[] { sourceArgType });
          targetType = TypeManager.RegisterType(sourceArgType, typeInfo, Semantics.TypeChange);
          typeInfo.IsAccepted = false;
          typeInfo.IsConverted = true;
          return true;
        }
      }
      else
      if (typeInfo.Name == "OpenXmlSimpleValue`1")
      {
        var sourceArgTypes = typeInfo.Type.GetGenericArguments();
        var sourceArgType = sourceArgTypes.FirstOrDefault();
        if (sourceArgType != null)
        {
          targetType = TypeManager.RegisterType(sourceArgType, typeInfo, Semantics.TypeChange);
          typeInfo.IsAccepted = false;
          typeInfo.IsConverted = true;
          return true;
        }
      }
    }
    return false;
  }

  public static CompoundName GetConvertedName(this TypeInfo typeInfo)
  {
    if (typeInfo.IsConverted)
      typeInfo = typeInfo.GetConversionTarget(true);
    string aName = typeInfo.Name;
    if (typeInfo.IsGenericTypeParameter)
      return new CompoundName(aName);
    string aNamespace = typeInfo.Namespace;

    aNamespace = TypeManager.TranslateNamespace(aNamespace);
    var apos = aName.IndexOf('`');
    if (apos >= 0)
      aName = aName.Substring(0, apos);

    var result = new CompoundName(aName, (aNamespace != null) ? aNamespace : null);
    if (apos >= 0)
    {
      var genericParams = typeInfo.GetGenericParamTypes();
      var genericArgs = typeInfo.GetGenericArgTypes();
      if (genericParams.Any())
      {
        result.ArgNames = new();
        foreach (var genericParam in genericParams.ToList())
          result.ArgNames.Add(new CompoundName(genericParam.Name));
      }
      else if (genericArgs.Any())
      {
        result.ArgNames = new();
        foreach (var genericArg in genericArgs.ToList())
          result.ArgNames.Add(GetConvertedName(genericArg));
      }
    }
    return result;
  }

  public static TypeInfo GetConversionTarget(this TypeInfo typeInfo, bool finalTarget)
  {
    //DocumentFormat.OpenXml.OpenXmlSimpleValue<
    if (!typeInfo.IsConverted)
      return typeInfo;
    var result = TypeManager.GetRelatedTypes(typeInfo, Semantics.TypeChange).FirstOrDefault();
    if (result == null && typeInfo.IsConstructedGenericType)
      if (TryAddGenericTypeConversion(typeInfo, out var targetType))
        result = targetType;
    if (finalTarget && result != null)
    {
      result.TryAddTypeConversion();
      if (result.IsConverted)
        result = GetConversionTarget(result, finalTarget);
    }
    return result ?? typeInfo;
  }

  #region Rename types
  public static bool RenameType(TypeInfo typeInfo)
  {
    if (typeInfo.TypeKind == TypeKind.Enum)
    {
      var newName = NewEnumTypeName(typeInfo.Type);
      if (newName != typeInfo.Name)
      {
        typeInfo.Name = newName;
        return true;
      }
    }
    return false;
  }

  private static string NewEnumTypeName(Type type)
  {
    var typeName = type.Name;
    if (typeName.EndsWith("Values"))
    {
      typeName = typeName.Substring(0, typeName.Length - "Values".Length);
      if (typeName.EndsWith("Type"))
      {
        typeName = typeName.Substring(0, typeName.Length - "Type".Length);
        typeName = typeName + "Kind";
      }
      else
      if (!typeName.EndsWith("Mode"))
      {
        typeName = typeName + "Kind";
      }
    }
    return typeName;
  }
  #endregion

  public static bool HasDuplicatesInName(this TypeInfo type)
  {
    if (type.Name.Contains('`'))
      return false;
    return TypeManager.GetNamespaceTypes(type.Namespace).Where(Item => Item.Name == type.Name).Any();
  }

  public static int ReflectRemainingTypes()
  {
    int count = 0;
    foreach (var type in TypeManager.AcceptedTypes.Where(item => !item.IsReflected).ToArray())
    {
      count++;
      type.WaitForReflection();
    }
    return count;
  }

}