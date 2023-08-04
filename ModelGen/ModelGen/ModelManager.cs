namespace ModelGen;

public record ScanningTypeInfo
{
  public int? RegisteredNamespaces;
  public int? RegisteredTypes;
  public TypeInfo? Current;
}

public delegate void ScanningTypeEvent(ScanningTypeInfo info);

public record RenamingTypeInfo
{
  public int? CheckedTypes;
  public int? RenamedTypes;
  public TypeInfo? Current;
}

public delegate void RenamingTypeEvent(RenamingTypeInfo info);

public record ConvertingTypeInfo
{
  public int? CheckedTypes;
  public int? ConvertedTypes;
  public TypeInfo? Current;
}

public delegate void ConvertingTypeEvent(ConvertingTypeInfo info);

public record CheckingUsageInfo
{
  public int? CheckedTypes;
  public int? UsedTypes;
  public TypeInfo? Current;
}

public delegate void CheckingUsageEvent(CheckingUsageInfo info);

public static class ModelManager
{
  public static event ScanningTypeEvent? OnScanningType;
  public static event RenamingTypeEvent? OnRenamingType;
  public static event ConvertingTypeEvent? OnConvertingType;

  public static int CheckedRenameTypesCount { get; private set; }
  public static int RenamedTypesCount { get; private set; }
  public static int DuplicateTypeNamesCount { get; private set; }
  public static int ConvertedTypesCount { get; private set; }

  public static int CheckedUsageTypesCount { get; private set; }
  public static int UsedTypesCount { get; private set; }

  #region Type conversion

  public static int ConvertTypes()
  {
    var n = 0;
    foreach (var typeInfo in TypeManager.AllTypes.ToArray())
    {
      if (ModelManager.TryConvertType(typeInfo))
      {
        ConvertedTypesCount++;
        OnConvertingType?.Invoke(new ConvertingTypeInfo { CheckedTypes = CheckedRenameTypesCount, ConvertedTypes = ConvertedTypesCount, Current = typeInfo });
        n++;
      }
    }
    return n;
  }

  public static bool TryConvertType(this TypeInfo typeInfo)
  {
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
    if (ModelConfig.Instance.TypeConversion.TryGetValue2(typeInfo.Type.FullName ?? "", out var targetName))
    {
      var targetType = Type.GetType(targetName);
      if (targetType == null) return false;
      var targetTypeInfo = TypeManager.RegisterType(targetType, typeInfo, Semantics.TypeChange);
      if (targetTypeInfo != null)
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
    if (typeInfo.Name.EndsWith("Relationship"))
      return false;
    if (typeInfo.Name == "Byte[]")
      return false;
    if (typeInfo.AcceptedProperties(PPS.ConvertTypes).Any() != true && !typeInfo.GetRelatedTypes(Semantics.Include).Any())
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
    if (result.TargetType != null)
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
      if (TryAddGenericTypeConversion(typeInfo, out var targetType))
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
      if (TryAddGenericTypeConversion(typeInfo, out var targetType))
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

  #region Checking types

  public static bool ScanType(Type type)
  {
    TypeManager.OnRegistering += TypeManager_OnRegistering;
    var typeName = type.ToString();
    TypeManager.RegisterType(type);
    TypeManager.OnRegistering -= TypeManager_OnRegistering;
    return true;
  }

  private static void TypeManager_OnRegistering(RegisteringInfo info)
  {
    OnScanningType?.Invoke(new ScanningTypeInfo
    {
      RegisteredNamespaces = info.RegisteredNamespaces,
      RegisteredTypes = info.RegisteredTypes,
      Current = info.Current,
    });
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
  public static int RenameNamespacesAndTypes()
  {
    RenameNamespaces();
    var n = 0;
    DuplicateTypeNamesCount = 0;
    foreach (var type in TypeManager.TypesAcceptedTo(PPS.RenameTypes).ToArray())
    {
      if (ModelManager.TryRenameType(type))
        n++;
    }
    return n;
  }

  public static int RenameNamespaces()
  {
    int n = 0;
    foreach (var ns in TypeManager.AllNamespaces.ToList())
    {
      if (ModelConfig.Instance.TranslatedNamespaces.TryGetValue(ns.OriginalName, out var targetName))
      {
        ns.TargetName = targetName;
        TypeManager.RegisterNamespace(targetName);
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
    //if (ModelConfig.Instance.TypeConversion.TryGetValue2(typeName, out newName))
    //{
    //  var k = newName.LastIndexOf(".");
    //  typeInfo.NewName = newName.Substring(k + 1);
    //  newNamespace = newName.Substring(0, k);
    //  typeInfo.TargetNamespace = newNamespace;
    //  RenamedTypesCount++;
    //  OnRenamingType?.Invoke(new RenamingTypeInfo { CheckedTypes = CheckedRenameTypesCount, RenamedTypes = RenamedTypesCount, Current = typeInfo });
    //  return true;
    //}
    var originalNamespace = typeInfo.OriginalNamespace;
    newNamespace = TypeManager.TranslateNamespace(originalNamespace);
    var targetNamespace = typeInfo.GetTargetNamespace();
    if (newNamespace != targetNamespace)
    {
      TypeManager.RegisterNamespace(newNamespace);
      typeInfo.TargetNamespace = newNamespace;
    }
    var nspace = TypeManager.GetNamespace(newNamespace);
    if (!typeInfo.IsConstructedGenericType)
    {
      if (nspace.TryGetTypesWithSameName(typeInfo, out var otherTypes))
      {
        var sameNameTypes = otherTypes.ToList();
        sameNameTypes.Add(typeInfo);
        //foreach (var sameNameType in sameNameTypes.ToArray())
        //  if (RenameTypeWithNamespace(sameNameType))
        //    sameNameTypes.Remove(sameNameType);
        if (sameNameTypes.Count > 1)
          foreach (var sameNameType in sameNameTypes)
          {
            //sameNameType.IsInvalid = true;
            sameNameType.AddErrorMsg(PPS.RenameTypes, "Target namespace has multiple types with the same name");
            DuplicateTypeNamesCount++;
          }
      }
    }
    nspace.AddType(typeInfo);

    if (typeInfo.TypeKind == TypeKind.Enum)
    {
      newName = NewEnumTypeName(typeInfo.Type);
      if (newName != typeInfo.Name)
      {
        typeInfo.NewName = newName;
        RenamedTypesCount++;
        OnRenamingType?.Invoke(new RenamingTypeInfo { CheckedTypes = CheckedRenameTypesCount, RenamedTypes = RenamedTypesCount, Current = typeInfo });
        return true;
      }
    }
    return false;
  }


  private static bool RenameTypeWithNamespace(TypeInfo typeInfo)
  {
    var origNamespace = typeInfo.OriginalNamespace;
    int k = origNamespace.IndexOf("20");
    if (k >= 0 && k <= origNamespace.Length - 4)
    {
      var yearStr = origNamespace.Substring(k, 4);
      if (int.TryParse(yearStr, out var year))
      {
        typeInfo.NewName = typeInfo.Name + year.ToString();
        RenamedTypesCount++;
        OnRenamingType?.Invoke(new RenamingTypeInfo { CheckedTypes = CheckedRenameTypesCount, RenamedTypes = RenamedTypesCount, Current = typeInfo });
        return true;
      }
    }
    else if (typeInfo.Name=="Properties" && origNamespace.EndsWith("Properties"))
    {
      k = origNamespace.LastIndexOf('.');
      typeInfo.NewName = origNamespace.Substring(k+1);
      RenamedTypesCount++;
      OnRenamingType?.Invoke(new RenamingTypeInfo { CheckedTypes = CheckedRenameTypesCount, RenamedTypes = RenamedTypesCount, Current = typeInfo });
      return true;
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

  //#region Documentation methods
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
  //#endregion
}