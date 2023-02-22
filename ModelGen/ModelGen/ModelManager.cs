using System.Reflection;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.EMMA;

using DocumentModel;

using Qhta.Xml.Reflection;

using Task = System.Threading.Tasks.Task;

namespace ModelGen;

public static class ModelManager
{

  #region Type conversion
  public static bool TryAddTypeConversion(this TypeInfo typeInfo)
  {
    //if (typeInfo.Name == "AttachedTemplate")
    //  Debug.Assert(true);
    if (typeInfo.IsConverted)
      return false;

    if (TryAddTypeTableConversion(typeInfo))
      return true;
    if (TryAddBaseTypeConversion(typeInfo))
      return true;
    if (TryAddValTypeConversion(typeInfo))
      return true;
    if (TryAddValTypeConversion(typeInfo))
      return true;
    if (TryAddGenericTypeConversion(typeInfo))
      return true;
    return false;
  }

  private static bool TryAddTypeTableConversion(TypeInfo typeInfo)
  {
    if (typeInfo.IsConverted)
      return false;
    if (ModelData.TypeConversionTable.TryGetValue(typeInfo.Type, out var target))
    {
      if (target.Rename)
      {
        var targetType = target.Type;
        typeInfo.NewName = new QualifiedName(targetType.Name, targetType.Namespace ?? "");
        return true;
      }
      else
      {
        var targetTypeInfo = TypeManager.RegisterType(target.Type, typeInfo, Semantics.TypeChange);
        targetTypeInfo.IsConvertedTo = true;
        typeInfo.IsConverted = true;
        return true;
      }
    }
    return false;
  }

  private static bool TryAddBaseTypeConversion(TypeInfo typeInfo)
  {
    if (typeInfo.IsConverted)
      return false;
    if (typeInfo.Name.EndsWith("Relationship"))
      return false;
    if (typeInfo.Name == "Byte[]")
      return false;
    if (typeInfo.AcceptedProperties?.Any() != true && !typeInfo.GetRelatedTypes(Semantics.Include).Any())
    {
      if (typeInfo.BaseTypeInfo != null)
      {
        TypeManager.AddRelationship(typeInfo, typeInfo.BaseTypeInfo, Semantics.TypeChange);
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
      if (typeInfo.Name == "Nullable`1")
      {
        var sourceArgTypes = typeInfo.Type.GetGenericArguments();
        var sourceArgType = sourceArgTypes.FirstOrDefault();
        if (sourceArgType != null)
        {
          targetType = TypeManager.RegisterType(sourceArgType, typeInfo, Semantics.TypeChange);
          typeInfo.IsConverted = true;
          return true;
        }
      }
      else
      if (typeInfo.Name == "IEnumerable`1")
      {
        var sourceArgTypes = typeInfo.Type.GetGenericArguments();
        var sourceArgType = sourceArgTypes.FirstOrDefault();
        if (sourceArgType != null)
        {
          var genericParamTypeInfo = TypeManager.RegisterType(sourceArgType);
          genericParamTypeInfo.TryAddTypeConversion();
          if (genericParamTypeInfo.IsConverted)
            sourceArgType = genericParamTypeInfo.GetConversionTargetOrSelf().Type;
          sourceArgType = typeof(Collection<>).MakeGenericType(new Type[] { sourceArgType });
          targetType = TypeManager.RegisterType(sourceArgType, typeInfo, Semantics.TypeChange);
          typeInfo.IsConverted = true;
          return true;
        }
      }
      else
      if (typeInfo.Name == "Collection`1")
      {
        var sourceArgTypes = typeInfo.Type.GetGenericArguments();
        var sourceArgType = sourceArgTypes.FirstOrDefault();
        if (sourceArgType != null)
        {
          var genericParamTypeInfo = TypeManager.RegisterType(sourceArgType);
          genericParamTypeInfo.TryAddTypeConversion();
          if (genericParamTypeInfo.IsConverted)
          {
            sourceArgType = genericParamTypeInfo.GetConversionTargetOrSelf().Type;
            sourceArgType = typeof(Collection<>).MakeGenericType(new Type[] { sourceArgType });
            targetType = TypeManager.RegisterType(sourceArgType, typeInfo, Semantics.TypeChange);
            typeInfo.IsConverted = true;
            return true;
          }
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
            sourceArgType = genericParamTypeInfo.GetConversionTargetOrSelf().Type;
          sourceArgType = typeof(DocumentModel.ListOf<>).MakeGenericType(new Type[] { sourceArgType });
          targetType = TypeManager.RegisterType(sourceArgType, typeInfo, Semantics.TypeChange);
          typeInfo.IsConverted = true;
          return true;
        }
      }
      else
      if (typeInfo.Name.Contains("Enum"))
      {
        var sourceArgTypes = typeInfo.Type.GetGenericArguments();
        var sourceArgType = sourceArgTypes.FirstOrDefault();
        if (sourceArgType != null)
        {
          targetType = TypeManager.RegisterType(sourceArgType, typeInfo, Semantics.TypeChange);
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
          typeInfo.IsConverted = true;
          return true;
        }
      }
    }
    return false;
  }

  public static TypeInfo GetTargetType(this TypeInfo typeInfo)
  {
    if (typeInfo.TargetType != null)
      return typeInfo.TargetType;
    var result = GetConversionTargetOrSelf(typeInfo);
    if (result.TargetType!=null)
    {
      typeInfo.TargetType = result.TargetType;
      return typeInfo.TargetType;
    }
    //var targetTypeName = result.GetFullName(false, false);
    //var type = Type.GetType(targetTypeName);
    //if (type==null)
    //{
    //  if (ModelData.ModelTypes.Count==0)
    //    ModelData.LoadModelTypes(Assembly.Load("DocumentModel"));
    //  ModelData.ModelTypes.TryGetValue(targetTypeName, out type);
    //}
    //if (type != null)
    //{
    //  result = TypeManager.RegisterTargetType(type);
    //}
    typeInfo.TargetType = result;
    return result;
  }

  //public static TypeInfo GetTargetType(this PropInfo propInfo, bool getFromDeclaringType = true)
  //{
  //  if (propInfo.Name == "DocumentId")
  //    TestTools.Stop();
  //  if (propInfo.TargetType != null)
  //    return propInfo.TargetType;
  //  if (getFromDeclaringType)
  //    propInfo.TargetType = GetTargetTypeFromDeclaringType(propInfo);
  //  if (propInfo.TargetType !=null)
  //    return propInfo.TargetType;
  //  else
  //    return propInfo.TargetType = GetTargetTypeFromMetadata(propInfo);
  //}

  //public static TypeInfo? GetTargetTypeFromDeclaringType(this PropInfo propInfo)
  //{
  //  if (propInfo.DeclaringType != null)
  //  {
  //    Type? modelType = null;
  //    if (propInfo.DeclaringType.TargetType == null)
  //    {
  //      var targetTypeName = propInfo.DeclaringType.Namespace + "." + propInfo.DeclaringType.Name;
  //      modelType = Type.GetType(targetTypeName);
  //      if (modelType == null)
  //      {
  //        var assembly = Assembly.Load("DocumentModel");
  //        modelType = assembly?.GetType(targetTypeName);
  //      }
  //      if (modelType == null)
  //        TestTools.Stop();
  //      propInfo.DeclaringType.TargetType = modelType;
  //    }
  //    var targetType = modelType?.GetProperty(propInfo.Name)?.PropertyType;
  //    if (targetType != null && targetType.Name.StartsWith("Nullable`"))
  //      targetType = targetType.GenericTypeArguments.FirstOrDefault();
  //    if (targetType != null)
  //    {
  //      if (TypeManager.TryGetTypeInfo(targetType, out var targetTypeInfo))
  //        return targetTypeInfo;
  //    }
  //  }
  //  return null;
  //}

  public static TypeInfo GetTargetType(this PropInfo propInfo)
  {
    if (propInfo.Name == "DocumentId")
      TestTools.Stop();
    if (propInfo.TargetType != null)
      return propInfo.TargetType;
    var typeInfo = propInfo.PropertyType;
    TypeInfo targetTypeInfo = null!;
    Type? targetType = null;
    var propName = propInfo.DeclaringType?.Namespace+"."+propInfo.DeclaringType?.Name+"."+propInfo.Name; 
    if (ModelData.TryGetPropertyType(propName, out targetType))
      targetTypeInfo = TypeManager.RegisterType(targetType, typeInfo, Semantics.TypeChange);
    else
    {
      if (typeInfo.Name == "HexBinaryValue")
      {
        if (propInfo.Validators != null)
        {
          var validator = (DocumentFormat.OpenXml.Framework.StringValidator?)
            propInfo.Validators.FirstOrDefault(item => item.GetType() == typeof(DocumentFormat.OpenXml.Framework.StringValidator));
          if (validator != null)
          {
            if (validator.Length == 2)
              targetType = typeof(HexChar);
            else
            if (validator.Length == 3)
              targetType = typeof(RGB);
            else
            if (validator.Length == 4)
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

  public static TypeInfo GetOriginType(this TypeInfo typeInfo)
  {
    if (typeInfo.Name == "Settings")
      TestTools.Stop();
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
    string aNamespace = typeInfo.Namespace;

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
      var genericArgs = typeInfo.GetGenericTypeArguments();
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
      if (TryAddGenericTypeConversion(typeInfo, out var targetType))
        result = targetType;
    if (result != null)
    {
      result.TryAddTypeConversion();
      if (result.IsConverted)
        result = GetConversionTargetOrSelf(result);
    }
    return result ?? typeInfo;
  }

  public static TypeInfo GetConversionSource(this TypeInfo typeInfo)
  {
    if (typeInfo.IsConvertedTo)
      return typeInfo;
    var result = TypeManager.GetRevRelatedTypes(typeInfo, Semantics.TypeChange).FirstOrDefault();
    return result ?? typeInfo;
  }

  public static TypeInfo GetRenameTarget(this TypeInfo typeInfo)
  {
    var result = TypeManager.GetRelatedTypes(typeInfo, Semantics.Rename).FirstOrDefault();
    return result ?? typeInfo;
  }

  #endregion

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

  public static Task CheckTypeUsageAsync(this TypeInfo typeInfo, Action<TypeInfo>? OnStartChecking = null)
  {
    return Task.Run(() => CheckTypeUsage(typeInfo, OnStartChecking));
  }

  public static bool CheckTypeUsage(this TypeInfo typeInfo, Action<TypeInfo>? OnStartChecking = null)
  {
    if (typeInfo.Name == "AttachedTemplate")
      Debug.Assert(true);
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
      var baseType = typeInfo.BaseTypeInfo.GetConversionTargetOrSelf();
      CheckTypeUsage(baseType, OnStartChecking);
    }

    if (typeInfo.Properties != null)
      foreach (var prop in typeInfo.Properties.ToArray())
      {
        //if (prop.Name == "RsidRoot")
        //  Debug.Assert(true);
        if (prop.IsAccepted is null or true)
        {
          if (prop.Name == "NotesMaster")
            Debug.Assert(true);
          var propType = prop.PropertyType.GetConversionTargetOrSelf();
          if (propType.HasExcludedNamespace())
            prop.IsAccepted = false;
          else if (propType.IsAccepted is null or true)
          {
            CheckTypeUsage(propType, OnStartChecking);
          }
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

    return typeInfo.IsUsed;
  }

  private static bool HasExcludedNamespace(this TypeInfo typeInfo)
  {
    if (ModelData.ExcludedNamespaces.Contains(typeInfo.Namespace))
      return true;
    if (typeInfo.IsConstructedGenericType)
    {
      foreach (var arg in typeInfo.GetGenericTypeArguments())
      {
        if (HasExcludedNamespace(arg))
          return true;
      }
    }
    return false;
  }

  public static bool ValidateType(this TypeInfo typeInfo)
  {
    var isValid = true;
    //if (typeInfo.Name.StartsWith("Nullable`"))
    //{
    //  var arg = typeInfo.GetGenericArgTypes().FirstOrDefault();
    //  if (arg != null)
    //  {

    //  }
    //}
    if (!ValidateProperties(typeInfo))
      isValid = false;
    return isValid;
  }

  public static bool ValidateProperties(this TypeInfo typeInfo)
  {
    var isValid = true;
    if (typeInfo.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlPartRootElement)))
    {
      var partProperty = typeInfo.Properties?.FirstOrDefault(item => item.Name.EndsWith("Part"));
      if (partProperty != null)
      {
        partProperty.IsAccepted = false;
        isValid = false;
      }
    }
    var baseTypes = typeInfo.GetBaseTypes();
    foreach (var baseType in baseTypes)
    {
      if (!CheckPropertyOverrides(typeInfo, baseType))
        isValid = false;
    }
    return isValid;
  }

  public static bool CheckPropertyOverrides(this TypeInfo thisTypeInfo, TypeInfo baseTypeInfo)
  {
    //if (thisTypeInfo.Name == "CategoryAxisData")
    //  Debug.Assert(true);
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
          var thisProperty = thisTypeInfo.Properties.Where(item => item.Name == propName).First();
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

  public static int CheckNamespacesDuplicatedTypesAsync(Action<int, int> OnDone)
  {
    var namespaces = TypeManager.GetNamespaces(OTS.Target);
    Task<int>[] tasks = new Task<int>[namespaces.Count()];
    int i = 0;
    foreach (var nspace in namespaces)
    {
      tasks[i] = new Task<int>(() =>
      {
        var repaired = ModelManager.CheckNamespaceDuplicatedTypes(nspace);
        OnDone(repaired, tasks.Count(item => item?.Status == TaskStatus.Running));
        return repaired;
      });
      tasks[i].Start();
      i++;
    }
    Task.WaitAll(tasks);
    return tasks.Sum(item => item.Result);
  }

  public static int CheckNamespaceDuplicatedTypes(string nspace)
  {
    var duplicatedTypesCount = 0;
    var namespaceTypes = TypeManager.GetNamespaceTypes(nspace).ToList();
    for (int i = 0; i < namespaceTypes.Count() - 1; i++)
    {
      var type1 = namespaceTypes[i];
      var type2 = namespaceTypes[i + 1];
      if (type1.Name == type2.Name)
      {
        List<TypeInfo> duplicateTypes = new List<TypeInfo>();
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
        duplicatedTypesCount += cnt;
      }
    }
    return duplicatedTypesCount;
  }


  #endregion

  #region Rename types

  public static bool RenameType(TypeInfo typeInfo)
  {
    var typeName = typeInfo.Type.FullName ?? "";
    if (ModelData.TypeNameConversion.TryGetValue(typeName, out var newName))
    {
      var k = newName.LastIndexOf(".");
      typeInfo.Name = newName.Substring(k + 1);
      typeInfo.Namespace = newName.Substring(0, k);
      return true;
    }
    var aNamespace = TypeManager.TranslateNamespace(typeInfo.Namespace);
    if (aNamespace != typeInfo.Namespace)
    {
      TypeManager.RegisterNamespace(aNamespace);
      typeInfo.Namespace = aNamespace;
      var namespaces = TypeManager.GetNamespaceDictionary(aNamespace);
      if (namespaces.TryGetTypesWithSameName(typeInfo, out var otherTypes))
      {
        foreach (var sameNameType in otherTypes)
          RenameTypeWithNamespace(sameNameType);
        RenameTypeWithNamespace(typeInfo);
      }
      namespaces.Add(typeInfo);
    }
    if (typeInfo.TypeKind == TypeKind.Enum)
    {
      newName = NewEnumTypeName(typeInfo.Type);
      if (newName != typeInfo.Name)
      {
        typeInfo.Name = newName;
        return true;
      }
    }
    //else
    //{
    //  if (ModelData.TypeNameConversion.TryGetValue(typeInfo.GetFullName(false), out var newName))
    //  {
    //    var qualifiedName = new FullTypeName(newName);
    //    typeInfo.Name = qualifiedName.Name;
    //  }
    //}
    return false;
  }

  public static int RenameSpecificTypes()
  {
    var count = 0;
    if (TypeManager.TryGetTypeInfo(typeof(System.IO.Packaging.PackageProperties), out var corePropertiesTypeInfo))
    {
      corePropertiesTypeInfo.Name = "CoreProperties";
      corePropertiesTypeInfo.Namespace = "DocumentModel.Properties";
      count++;
    }
    if (TypeManager.TryGetTypeInfo(typeof(DocumentFormat.OpenXml.ExtendedProperties.Properties), out var extendedPropertiesTypeInfo))
    {
      extendedPropertiesTypeInfo.Name = "ExtendedProperties";
      extendedPropertiesTypeInfo.Namespace = "DocumentModel.Properties";
      count++;
    }
    if (TypeManager.TryGetTypeInfo(typeof(DocumentFormat.OpenXml.CustomProperties.Properties), out var customPropertiesTypeInfo))
    {
      customPropertiesTypeInfo.Name = "CustomProperties";
      customPropertiesTypeInfo.Namespace = "DocumentModel.Properties";
      count++;
    }
    return count;
  }

  private static void RenameTypeWithNamespace(TypeInfo typeInfo)
  {
    var origNamespace = typeInfo.OriginalNamespace;
    if (origNamespace.Contains("2010"))
      typeInfo.Name += "2";
    else
    if (origNamespace.Contains("2013"))
      typeInfo.Name += "3";
    else
    if (origNamespace.Contains("2016"))
      typeInfo.Name += "4";
    else
    if (origNamespace.Contains("2019"))
      typeInfo.Name += "5";
    else
    if (origNamespace.Contains("2021"))
      typeInfo.Name += "6";
    else
    if (origNamespace.Contains("2022"))
      typeInfo.Name += "7";
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

  #region Property conversion

  public static string GetTargetName(this PropInfo prop)
  {
    if (prop.DeclaringType != null)
    {
      if (prop.Name == "Count")
        Debug.Assert(true);
      var fullName = prop.DeclaringType.GetFullName(true) + "." + prop.Name;
      if (ModelData.PropertyTranslateTable.TryGetValue(fullName, out var newName))
        return newName;
    }
    return prop.Name;
  }
  #endregion

  #region Namespace methods
  public static bool HasDuplicatesInNamespace(this TypeInfo type)
  {
    if (type.Name.Contains('`'))
      return false;
    return TypeManager.GetNamespaceTypes(type.Namespace).Where(Item => Item.Name == type.Name).Count() > 1;
  }

  public static TypeInfo[] GetDuplicatesInNamespace(this TypeInfo type)
  {
    return TypeManager.GetNamespaceTypes(type.Namespace).Where(Item => Item.Name == type.Name).ToArray();
  }
  #endregion

}