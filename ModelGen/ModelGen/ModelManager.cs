using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

using DocumentFormat.OpenXml;

namespace ModelGen;

public static class ModelManager
{

  public static bool TryAddTypeConversion(this TypeInfo typeInfo)
  {
    //if (typeInfo.OriginalName == "ArrayBaseValues")
    //  Debug.Assert(true);
    if (typeInfo.IsConverted)
      return false;
    if (typeInfo.OriginalName == "ArrayBaseValues")
      Debug.Assert(true);
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
    //if (typeInfo.OriginalName == "ArrayBaseValues")
    //  Debug.Assert(true);
    if (ModelData.TypeConversionTable.TryGetValue(typeInfo.Type, out var targetType))
    {
      var targetTypeInfo = TypeManager.RegisterType(targetType, typeInfo, Semantics.TypeChange);
      targetTypeInfo.IsConvertedTo = true;
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
        //typeInfo.IsAccepted = false;
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
    if (typeInfo.AcceptedProperties?.Count() == 1)
    {
      var firstProp = typeInfo.AcceptedProperties?.FirstOrDefault();
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

  public static CompoundName GetConvertedName(this TypeInfo typeInfo, TypeKind kind)
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
    if (kind == TypeKind.Class && typeInfo.TypeKind != TypeKind.Enum)
    {
      aName += "Impl";
    }
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
          result.ArgNames.Add(GetConvertedName(genericArg, kind));
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

  #region Checking types

  public static bool TryAcceptType(Type type, [NotNullWhen(true)] out TypeInfo? typeInfo)
  {
    typeInfo = null;
    var typeName = type.ToString();
    if (typeName.Contains('<') || typeName.Contains('+') || typeName.Contains('&'))
      return false;
    if (ModelData.IsExcluded(type))
      return false;
    typeInfo = TypeManager.RegisterType(type);
    typeInfo.IsAccepted = true;
    typeInfo.IsUsed = true;
    return true;
  }

  public static bool CheckTypeUsage(TypeInfo typeInfo, Action<TypeInfo>? OnStartChecking = null)
  {
    //if (typeInfo.Name == "VTInt32")
    //  Debug.Assert(true);
    if (typeInfo.UsesEvaluated)
      return typeInfo.IsUsed;
    typeInfo.UsesEvaluated = true;

    if (OnStartChecking != null)
      OnStartChecking(typeInfo);
    if (typeInfo.IsAccepted == false)
      return false;
    if (ModelData.IsExcluded(typeInfo.Type))
      return false;
    if (ModelData.ExcludedNamespaces.Contains(typeInfo.Namespace ?? ""))
      return false;
    typeInfo.IsUsed = true;

    if (typeInfo.BaseTypeInfo != null)
    {
      var baseType = typeInfo.BaseTypeInfo.GetConversionTarget(true);
      CheckTypeUsage(baseType, OnStartChecking);
    }

    if (typeInfo.Properties != null)
      foreach (var prop in typeInfo.Properties.ToArray())
      {
        //if (prop.Name == "RsidRoot")
        //  Debug.Assert(true);
        if (prop.IsAccepted is null or true)
        {
          var propType = prop.PropertyType.GetConversionTarget(true);
          if (propType.IsAccepted is null or true)
          {
            /*prop.IsAccepted = */CheckTypeUsage(propType, OnStartChecking);
          }
          else
            prop.IsAccepted = false;
        }
      }

    var interfaces = typeInfo.GetInterfaces();
    if (interfaces.Any())
      foreach (var intfType in interfaces.ToArray())
      {
        if (intfType.IsAccepted is null or true)
        {
          CheckTypeUsage(intfType, OnStartChecking);
        }
      }

    //var customAttribs = typeInfo.CustomAttributes;
    //if (customAttribs.Any())
    //  foreach (var customAttrib in customAttribs.ToArray())
    //  {
    //    var customAttribType = customAttrib.AttributeType;
    //    if (customAttribType.IsAccepted is null or true)
    //    {
    //      customAttrib.IsAccepted = CheckTypeUsage(customAttribType, OnStartChecking);
    //    }
    //    else
    //      customAttrib.IsAccepted = false;
    //  }

    //var includedTypes = typeInfo.GetIncludedTypes();
    //if (includedTypes.Any())
    //  foreach (var inclType in includedTypes.ToArray())
    //  {
    //    if (inclType.IsAccepted != false)
    //    {
    //      CheckTypeUsage(inclType, OnStartChecking);
    //    }
    //  }
    return typeInfo.IsUsed;
  }

  public static bool CheckPropertyOverride(TypeInfo thisTypeInfo)
  {
    var baseTypeInfo = thisTypeInfo.BaseTypeInfo?.GetConversionTarget(true);
    if (thisTypeInfo.Name == "CategoryAxisData")
      Debug.Assert(true);
    if (baseTypeInfo != null && thisTypeInfo.Properties != null && baseTypeInfo.Properties != null)
    {
      var thisPropNames = thisTypeInfo.Properties.Where(item => item.IsAccepted != false).Select(item => item.Name).ToArray();
      var basePropNames = baseTypeInfo.Properties.Where(item => item.IsAccepted != false).Select(item => item.Name).ToArray();
      var commonPropNames = thisPropNames.Intersect(basePropNames).ToArray();
      var hasSamePropNames = commonPropNames.Any();
      if (hasSamePropNames)
      {
        foreach (var propName in commonPropNames)
        {
          var thisProperty = thisTypeInfo.Properties.Where(item=>item.Name == propName).First();
          var baseProperty = baseTypeInfo.Properties.Where(item => item.Name == propName).First();
          if (thisProperty.PropertyType == baseProperty.PropertyType)
          {
            thisProperty.IsOverriden = true;
            if (!baseProperty.IsOverriden && !baseProperty.IsAbstract)
              baseProperty.IsVirtual = true;
          }
          else
          {
            thisProperty.IsNew = true;
          }
        }
        return false;
      }
    }
    return true;
  }

  public static int CheckNamespaceDuplicatedTypes(string nspace)
  {
    var duplicatedTypesCount = 0;
    var namespaceTypes = TypeManager.GetNamespaceTypes(nspace).OrderBy(item=>item.Name).ToArray();
    for (int i = 0; i < namespaceTypes.Count() - 1; i++)
    {
      var type1 = namespaceTypes[i];
      var type2 = namespaceTypes[i+1];
      if (type1.Name == type2.Name)
      {
        List <TypeInfo> duplicateTypes= new List <TypeInfo>();
        duplicateTypes.Add(type1);
        duplicateTypes.Add(type2);
        for (int j = i + 2; j < namespaceTypes.Count(); j++)
        {
          type2 = namespaceTypes[j];
          if (type1.Name == type2.Name)
            duplicateTypes.Add(type2);
          else
            break;
        }
        int cnt = 0;
        foreach (var type in duplicateTypes)
        {
          cnt++;
          type.Name += cnt.ToString();
          i++;
        }
        duplicatedTypesCount +=cnt;
      }
    }
    return duplicatedTypesCount;
  }


  #endregion

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