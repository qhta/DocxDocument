using System.Data;

namespace ModelGen;

public static class ModelManager
{
  public static event ProgressTypeEvent? OnScanningType;
  public static event ProgressTypeEvent? OnRenamingType;
  public static event ProgressTypeEvent? OnConvertingType;

  public static int CheckedRenameTypesCount { get; private set; }
  public static int RenamedTypesCount { get; private set; }
  public static int DuplicatedNamesCount { get; private set; }
  public static int ConvertedTypesCount { get; private set; }

  public static int CheckedUsageTypesCount { get; private set; }
  public static int UsedTypesCount { get; private set; }

  public static bool CancelRequest { get => TypeManager.CancelRequest; set => TypeManager.CancelRequest = value; }

  #region Type conversion

  public static int ConvertTypes(IEnumerable<TypeInfo> types)
  {
    var n = 0;
    var totalTypes = types.Count();
    foreach (var typeInfo in types)
    {
      if (TryConvertType(typeInfo))
      {
        ConvertedTypesCount++;
        OnConvertingType?.Invoke(new ProgressTypeInfo
        {
          TotalTypes = totalTypes,
          CheckedTypes = CheckedRenameTypesCount,
          ProcessedTypes = ConvertedTypesCount,
          Current = typeInfo
        });
        n++;
      }
    }
    return n;
  }

  public static bool TryConvertType(this TypeInfo typeInfo)
  {
    if (typeInfo.Name=="AttributionTaskUser")
      Debug.Assert(true);
    if (typeInfo.IsConverted)
      return false;
    var converted = false;
    if (TryTableTypeConversion(typeInfo))
      converted = true;
    else
    if (TryBaseTypeConversion(typeInfo))
      converted = true;
    else
    if (TryValTypeConversion(typeInfo))
      converted = true;
    else
    if (TryGenericTypeConversion(typeInfo))
      converted = true;
    else
      TryAddItemsProperty(typeInfo);
    if (converted)
    {
      var targetType = typeInfo.TargetType;
      if (targetType != null)
      {
        if (targetType.TargetNamespace != null)
        {
          var targetNamespace = TypeManager.GetNamespace(targetType.TargetNamespace);
          var targetTypeName = targetType.NewName ?? targetType.Name;
          if (!targetNamespace.TypeNames.ContainsKey(targetTypeName))
            targetNamespace.AddType(targetType);
        }
      }
    }
    else
    {
      var targetType = typeInfo;
      if (targetType != null)
      {
        if (targetType.TargetNamespace != null)
        {
          var targetNamespace = TypeManager.GetNamespace(targetType.TargetNamespace);
          var targetTypeName = targetType.NewName ?? targetType.Name;
          if (!targetNamespace.TypeNames.ContainsKey(targetTypeName))
            targetNamespace.AddType(targetType);
        }
      }
    }
    TryConvertProperties(typeInfo);
    return converted;
  }

  private static bool TryTableTypeConversion(TypeInfo typeInfo)
  {
    if (typeInfo.IsConverted)
      return false;
    if (ModelConfig.Instance.TypeConversion.TryGetValue2(typeInfo.Type.FullName ?? "", out var targetName))
    {
      var targetType = TypeManager.GetType(targetName);
      if (targetType == null) return false;
      //Debug.Assert(targetType != null);
      var targetTypeInfo = TypeManager.RegisterType(targetType, typeInfo, Semantics.TypeChange);
      if (targetTypeInfo != null)
        targetTypeInfo.IsConvertedTo = true;
      typeInfo.IsConverted = true;
      return true;
    }
    return false;
  }

  private static bool TryBaseTypeConversion(TypeInfo typeInfo)
  {
    if (typeInfo.IsConverted)
      return false;
    if (typeInfo.Name.EndsWith("Relationship"))
      return false;
    if (typeInfo.Name == "Byte[]")
      return false;
    if (!typeInfo.AcceptedProperties(PPS.ConvertTypes).Any() && !typeInfo.GetRelatedTypes(Semantics.Include).Any())
    {
      if (typeInfo.BaseTypeInfo != null && !typeInfo.BaseTypeInfo.IsAbstract)
      {
        TypeManager.AddRelationship(typeInfo, typeInfo.BaseTypeInfo, Semantics.TypeChange);
        typeInfo.IsConverted = true;
        return true;
      }
    }
    return false;
  }

  private static bool TryValTypeConversion(TypeInfo typeInfo)
  {
    if (typeInfo.IsConverted)
      return false;
    if (typeInfo.AcceptedProperties(PPS.ConvertTypes)?.Count() == 1)
    {
      var firstProp = typeInfo.AcceptedProperties(PPS.ConvertTypes)?.FirstOrDefault();
      if (firstProp != null && firstProp.Name == "Val")
      {
        TypeManager.AddRelationship(typeInfo, firstProp.PropertyType, Semantics.TypeChange);
        typeInfo.IsConverted = true;
        return true;
      }
    }
    return false;
  }

  private static bool TryGenericTypeConversion(TypeInfo typeInfo)
  {
    return TryGenericTypeConversion(typeInfo, out _);
  }

  private static bool TryGenericTypeConversion(TypeInfo typeInfo, out TypeInfo? targetType)
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
          genericParamTypeInfo.TryConvertType();
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
          genericParamTypeInfo.TryConvertType();
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
          genericParamTypeInfo.TryConvertType();
          if (genericParamTypeInfo.IsConverted)
            sourceArgType = genericParamTypeInfo.GetConversionTargetOrSelf().Type;
          sourceArgType = typeof(ListOf<>).MakeGenericType(new Type[] { sourceArgType });
          targetType = TypeManager.RegisterType(sourceArgType, typeInfo, Semantics.TypeChange);
          typeInfo.IsConverted = true;
          return true;
        }
      }
      else
      if (typeInfo.IsConstructedGenericType)
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

  private static bool TryAddItemsProperty(TypeInfo typeInfo)
  {
    if (typeInfo.IsConverted)
      return false;
    var itemsProperty = typeInfo.AcceptedProperties(PPS.ConvertTypes)?.FirstOrDefault(item => item.Name == "Items");
    if (itemsProperty != null)
      return false;
    var itemRels = typeInfo.GetOutgoingRelationships(Semantics.Include).Where(rel => rel.IsMultiple);
    if (itemRels.Any())
    {
      var relsCount = itemRels.Count();
      if (relsCount > 1)
        itemsProperty = new PropInfo("Items", typeof(DocumentModel.ElementCollection<IModelElement>));
      else
      {
        var collectionType = typeof(DocumentModel.ElementCollection<>);
        collectionType = collectionType.MakeGenericType(new Type[] { itemRels.First().Target.Type });
        itemsProperty = new PropInfo("Items", collectionType);
      }
      itemsProperty.AddedInPhase = PPS.ConvertTypes;
      typeInfo.Add(itemsProperty);
      return true;
    }
    return false;
  }

  private static bool TryConvertProperties(TypeInfo typeInfo)
  {
    bool ok = false;
    if (typeInfo.Properties != null)
    {
      foreach (var property in typeInfo.Properties)
      {
        var propName = typeInfo.OriginalNamespace + "." + property.Name;
        var typeTranslate = ModelConfig.Instance.PropertyTypeConversion.TryGetValue(propName, out var newTypeName);
        if (!typeTranslate)
          typeTranslate = ModelConfig.Instance.PropertyTypeConversion.TryGetValue(property.Name, out newTypeName);
        if (typeTranslate && newTypeName != null)
        {
          property.TargetPropertyTypeName = newTypeName;
          //if (TypeManager.TryGetTypeInfo(newTypeName, out var targetTypeInfo))
          //{
          //  Debug.Assert(targetTypeInfo != null);
          //  property.TargetPropertyType = targetTypeInfo;
          //}
          ok = true;
        }
      }
    }
    return ok;
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
            if (stringConstraint.FixLength == 2)
              targetType = typeof(HexChar);
            else
            if (stringConstraint.FixLength == 3)
              targetType = typeof(RGB);
            else
            if (stringConstraint.FixLength == 4)
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
    if (kind == TypeKind.@class && typeInfo.TypeKind != TypeKind.@enum)
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
      if (TryGenericTypeConversion(typeInfo, out var targetType))
        result = targetType;
    if (result != null)
    {
      result.TryConvertType();
      if (result.IsConverted)
        result = GetConversionTargetOrSelf(result);
    }
    return result ?? typeInfo;
  }

  public static TypeInfo? GetConversionTarget(this TypeInfo typeInfo)
  {
    var result = TypeManager.GetRelatedTypes(typeInfo, Semantics.TypeChange).FirstOrDefault();
    if (result == null && typeInfo.IsConstructedGenericType)
      if (TryGenericTypeConversion(typeInfo, out var targetType))
        result = targetType;
    if (result != null)
    {
      result.TryConvertType();
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
  #endregion

  #region Scan Source

  public static bool ScanType(Type type)
  {
    TypeManager.UseAsynReflection = false;
    TypeManager.OnRegistering += TypeManager_OnRegistering;
    var typeName = type.ToString();
    TypeManager.RegisterType(type);
    TypeManager.OnRegistering -= TypeManager_OnRegistering;
    if (TypeManager.UseAsynReflection)
      TypeReflector.WaitDone();
    return true;
  }

  private static void TypeManager_OnRegistering(ProgressTypeInfo info)
  {
    OnScanningType?.Invoke(info);
  }

  //public static Task CheckTypeUsageAsync(this TypeInfo typeInfo)
  //{
  //  return Task.Run(() => CheckTypeUsage(typeInfo));
  //}

  //public static bool CheckTypeUsage(this TypeInfo typeInfo)
  //{
  //  if (typeInfo.UsageEvaluated)
  //    return typeInfo.IsUsed;
  //  typeInfo.UsageEvaluated = true;
  //  CheckedUsageTypesCount++;

  //  if (typeInfo.IsAccepted == false)
  //    return false;
  //  if (ModelConfig.Instance.IsExcluded(typeInfo.Type))
  //    return false;
  //  if (ModelConfig.Instance.ExcludedNamespaces.Contains(typeInfo.GetTargetNamespace() ?? ""))
  //    return false;
  //  typeInfo.IsUsed = true;
  //  UsedTypesCount++;
  //  OnCheckingUsage?.Invoke(new CheckingUsageInfo { CheckedTypes = CheckedUsageTypesCount, UsedTypes = UsedTypesCount, Current = typeInfo });


  //  if (typeInfo.BaseTypeInfo != null)
  //  {
  //    var baseType = typeInfo.BaseTypeInfo.GetConversionTargetOrSelf();
  //    CheckTypeUsage(baseType);
  //  }

  //  if (typeInfo.Properties != null)
  //    foreach (var prop in typeInfo.Properties.ToArray())
  //    {
  //      //if (prop.Name == "RsidRoot")
  //      //  Debug.Assert(true);
  //      if (!prop.IsRejected)
  //      {
  //        var propType = prop.PropertyType.GetConversionTargetOrSelf();
  //        if (propType.HasExcludedNamespace())
  //          prop.IsRejected = true;
  //        else if (!propType.IsRejected)
  //        {
  //          CheckTypeUsage(propType);
  //        }
  //      }
  //    }

  //  var interfaces = typeInfo.GetImplementedInterfaces();
  //  if (interfaces.Any())
  //    foreach (var intfType in interfaces.ToArray())
  //    {
  //      if (!intfType.IsRejected)
  //      {
  //        CheckTypeUsage(intfType);
  //      }
  //    }

  //  return typeInfo.IsUsed;
  //}

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

  public static bool ValidateType(PPS phase, TypeInfo typeInfo)
  {
    var isValid = true;
    if (!ValidateProperties(phase, typeInfo))
      isValid = false;
    return isValid;
  }

  public static bool ValidateProperties(PPS phase, TypeInfo typeInfo)
  {
    var isValid = true;
    if (typeInfo.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlPartRootElement)))
    {
      var partProperty = typeInfo.Properties?.FirstOrDefault(item => item.Name.EndsWith("Part"));
      if (partProperty != null)
      {
        partProperty.SetRejected(phase);
        isValid = false;
      }
    }
    var baseTypes = typeInfo.GetBaseTypes();
    foreach (var baseType in baseTypes)
    {
      if (!CheckPropertyOverrides(phase, typeInfo, baseType))
        isValid = false;
    }
    return isValid;
  }

  public static bool CheckPropertyOverrides(PPS phase, TypeInfo thisTypeInfo, TypeInfo baseTypeInfo)
  {
    //if (thisTypeInfo.Name == "CategoryAxisData")
    //  Debug.Assert(true);
    if (baseTypeInfo != null && thisTypeInfo.Properties != null && baseTypeInfo.Properties != null)
    {
      var thisPropNames = thisTypeInfo.Properties.Where(item => item.IsAcceptedTo(phase)).Select(item => item.Name).ToArray();
      var basePropNames = baseTypeInfo.Properties.Where(item => item.IsAcceptedTo(phase)).Select(item => item.Name).ToArray();
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
    var namespaces = TypeManager.GetNamespaces(NTS.Target);
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
          type.NewName = type.Name + cnt.ToString();
          i++;
        }
        duplicatedTypesCount += cnt;
      }
    }
    return duplicatedTypesCount;
  }
  #endregion

  #region Rename types

  /// <summary>
  /// First rename namespaces, then rename types.
  /// </summary>
  /// <returns></returns>
  public static int RenameNamespacesAndTypes(IEnumerable<TypeInfo> types)
  {
    RenameNamespaces();
    var n = 0;
    var totalTypes = types.Count();
    RenamedTypesCount = 0;
    DuplicatedNamesCount = 0;
    foreach (var typeInfo in types)
    {
      if (ModelManager.TryRenameType(typeInfo))
        n++;
      OnRenamingType?.Invoke(new ProgressTypeInfo
      {
        TotalTypes = totalTypes,
        CheckedTypes = CheckedRenameTypesCount,
        ProcessedTypes = RenamedTypesCount,
        Current = typeInfo
      });
    }
    return n;
  }

  public static int RenameNamespaces()
  {
    int n = 0;
    foreach (var ns in TypeManager.AllNamespaces
      .Where(nspace => !ModelConfig.Instance.ExcludedNamespaces.Contains(nspace.OriginalName)).ToList())
    {
      if (ModelConfig.Instance.TranslatedNamespaces.TryGetValue(ns.OriginalName, out var targetName))
      {
        ns.TargetName = targetName;
        var nspace = TypeManager.RegisterNamespace(targetName);
        nspace.TargetName = targetName;
        nspace.Clear();
        n++;
      }
    }
    return n;
  }

  private static bool TryRenameType(TypeInfo typeInfo)
  {
    CheckedRenameTypesCount++;
    var typeName = typeInfo.OriginalName ?? "";
    string newNamespace;
    string? newName;
    bool renamed = false;
    if (typeInfo.TypeKind == TypeKind.@enum)
    {
      newName = NewEnumTypeName(typeInfo.Type);
      if (newName != typeInfo.Name)
      {
        typeInfo.NewName = newName;
        RenamedTypesCount++;
        renamed = true;
      }
    }

    bool addToNewNamespace = true;
    bool checkDuplicatedName = true;

    var originalNamespace = typeInfo.OriginalNamespace;
    newNamespace = TypeManager.TranslateNamespace(originalNamespace);
    var oldName = originalNamespace + "." + typeName;
    if (ModelConfig.Instance.TypeConversion.TryGetValue2(oldName, out newName))
    {
      var k = newName.LastIndexOf(".");
      if (k > 0)
      {
        typeInfo.NewName = newName.Substring(k + 1);
        newNamespace = newName.Substring(0, k);
      }
      else
        typeInfo.NewName = newName;
      renamed = true;
      RenamedTypesCount++;
      checkDuplicatedName = false;
    }

    var targetNamespace = typeInfo.GetTargetNamespace();
    Namespace nspace;
    if (newNamespace != targetNamespace)
    {
      nspace = TypeManager.RegisterNamespace(newNamespace);
    }
    else
      nspace = TypeManager.GetNamespace(newNamespace);

    if (nspace.TypeNames.TryGetValue(typeName, out var oldTypeInfo))
    {
      if (checkDuplicatedName)
      {
        if (!oldTypeInfo.HasError(PPS.Rename, ErrorCode.MultiplicatedName))
        {
          oldTypeInfo.AddError(PPS.Rename, ErrorCode.MultiplicatedName);
          DuplicatedNamesCount++;
        }
        typeInfo.AddError(PPS.Rename, ErrorCode.MultiplicatedName);
        DuplicatedNamesCount++;
        oldTypeInfo.AddRelationship(typeInfo, Semantics.SameName);
        //newName = GetNewNameFromNamespace(typeInfo);
        //if (newName == null)
        //{
        //  newName = GetNewNameFromNamespace(oldTypeInfo);
        //  if (newName != null)
        //  {
        //    nspace.Types.Remove(oldTypeInfo);
        //    oldTypeInfo.NewName = newName;
        //    RenamedTypesCount++;
        //    renamed = true;
        //  }
        //  else
        //    addToNewNamespace = false;
        //}
        //else
        //{
        //  if (!nspace.TypeNames.ContainsKey(newName))
        //  {
        //    typeInfo.NewName = newName;
        //    RenamedTypesCount++;
        //    renamed = true;
        //  }
        //  else
        //    addToNewNamespace = false;
        //}
        addToNewNamespace = false;
      }
      else
        addToNewNamespace = false;
    }
    if (addToNewNamespace)
      nspace.AddType(typeInfo);

    typeInfo.TargetNamespace = newNamespace;

    return renamed;
  }

  private static string? GetNewNameFromNamespace(TypeInfo typeInfo)
  {
    var origNamespace = typeInfo.OriginalNamespace;
    int k = origNamespace.IndexOf("20");
    if (k >= 0 && k <= origNamespace.Length - 4)
    {
      var yearStr = origNamespace.Substring(k, 4);
      if (int.TryParse(yearStr, out var year))
      {
        return typeInfo.Name + year.ToString();
      }
    }
    else if (typeInfo.Name == "Properties" && origNamespace.EndsWith("Properties"))
    {
      k = origNamespace.LastIndexOf('.');
      return origNamespace.Substring(k + 1);
    }
    return null;
  }

  private static string NewEnumTypeName(Type type)
  {
    var typeName = type.Name;
    if (typeName.EndsWith("Values"))
    {
      typeName = typeName.Substring(0, typeName.Length - "Values".Length);
      if (!typeName.EndsWith("Mode")/* && !typeName.EndsWith("Type")*/)
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
      var fullName = prop.DeclaringType.GetFullName(false, true, true) + "." + prop.Name;
      if (ModelConfig.Instance.PropertyTranslateTable.TryGetValue(fullName, out var newName))
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
    return TypeManager.GetNamespaceTypes(type.GetTargetNamespace()).Where(Item => Item.Name == type.Name).Count() > 1;
  }

  public static TypeInfo[] GetDuplicatesInNamespace(this TypeInfo type)
  {
    return TypeManager.GetNamespaceTypes(type.GetTargetNamespace()).Where(Item => Item.Name == type.Name).ToArray();
  }
  #endregion

  #region Documentation methods
  ///// <summary>
  ///// Gets a collection of XElement from <see cref="Description"/> and <see cref="Summary"/>.
  ///// </summary>
  ///// <returns></returns>
  //public static IEnumerable<XElement>? GetDocumentation(this ModelElement element)
  //{
  //  if (element.Description == null && element.Summary == null)
  //    return null;
  //  var documentation = new Collection<XElement>();
  //  XElement? summary = null;
  //  if (element.Description != null)
  //    documentation.Add(summary = new XElement("summary", element.Description));
  //  if (element.Summary != null)
  //  {
  //    if (summary == null)
  //      documentation.Add(summary = new XElement("summary"));
  //    foreach (var item in element.Summary)
  //      summary.Add(new XElement("para", item));
  //  }
  //  return documentation;
  //}

  ///// <summary>
  ///// Xml documentation assigned to this element.
  ///// </summary>
  //public static IEnumerable<XElement>? GetDocumentation(this PropInfo propInfo)
  //{
  //  var result = GetDocumentation((ModelElement)propInfo);
  //  if (result == null)
  //    return propInfo.TargetType?.GetDocumentation();
  //  return result;
  //}
  #endregion
}