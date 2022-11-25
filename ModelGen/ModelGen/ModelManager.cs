using System.Diagnostics;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text.Json.Serialization;

using DocumentFormat.OpenXml;

using Namotion.Reflection;

using Qhta.Collections;
using DocumentFormat.OpenXml.Spreadsheet;

namespace ModelGen;

public static class ModelManager
{

  public static bool TryAddTypeConversion(TypeInfo typeInfo)
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
    //if (typeInfo.Name == "EnumValue`1")
    //{
    //  ModelDisplay.ConsoleWriteSameLine($"{typeInfo}[{typeInfo.Type.GetGenericArguments().FirstOrDefault()?.Name}]\n");
    //  if (typeInfo.Type.GetGenericArguments().FirstOrDefault()?.Name == "MultiLevelValues") 
    //    Debug.Assert(true);
    //}
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
          //var genericParamTypeInfo = TypeManager.RegisterType(sourceArgType);
          //TypeReflector.WaitForReflection(genericParamTypeInfo);
          //if (genericParamTypeInfo.IsConverted)
          //  sourceArgType = genericParamTypeInfo.GetConversionTarget(true).Type;
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

  public static string GetConvertedName(this TypeInfo typeInfo, bool asInterface, bool withNamespace)
  {
    if (typeInfo.IsConverted)
      typeInfo = typeInfo.GetConversionTarget(true);
    string aName = typeInfo.Name;
    if (typeInfo.IsGenericTypeParameter)
      return aName;
    string aNamespace = typeInfo.Namespace;
    if (asInterface && typeInfo.TypeKind == TypeKind.Class 
        && !aNamespace.StartsWith("System") && !aNamespace.StartsWith("DocumentModel.BaseTypes"))
    {
      aName = "I" + aName;
    }
    aNamespace = TypeManager.TranslateNamespace(aNamespace);

    var apos = aName.IndexOf('`');
    if (apos >= 0)
    {
      var genericParams = typeInfo.GetGenericParamTypes();
      var genericArgs = typeInfo.GetGenericArgTypes();
      var ls = new List<String>();
      if (genericParams.Any())
        foreach (var genericParam in genericParams.ToList())
        {
          ls.Add(genericParam.Name);
        }
      else if (genericArgs.Any())
        foreach (var genericArg in genericArgs.ToList())
        {
          ls.Add(GetConvertedName(genericArg, asInterface, withNamespace));
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

  public static TypeInfo GetConversionTarget(this TypeInfo typeInfo, bool finalTarget)
  {
    //DocumentFormat.OpenXml.OpenXmlSimpleValue<
    if (!typeInfo.IsConverted)
      return typeInfo;
    var result = TypeManager.GetRelatedTypes(typeInfo, Semantics.TypeChange).FirstOrDefault();
    if (result == null && typeInfo.IsConstructedGenericType)
      if (TryAddGenericTypeConversion(typeInfo, out var targetType))
        result = targetType;
    if (finalTarget && result != null && result.IsConverted)
    {
      result = GetConversionTarget(result, finalTarget);
    }
    return result ?? typeInfo;
  }

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