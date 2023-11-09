namespace ModelGen;

public static class ModelManager
{
  public static int CheckedRenameTypesCount { [DebuggerStepThrough] get; private set; }
  public static int RenamedTypesCount { [DebuggerStepThrough] get; private set; }
  public static int DuplicatedNamesCount { [DebuggerStepThrough] get; private set; }
  public static int ConvertedTypesCount { [DebuggerStepThrough] get; private set; }
  public static HashSet<TypeInfo> FixedTypes { [DebuggerStepThrough] get; private set; } = new HashSet<TypeInfo>();
  public static int FixedTypesCount => FixedTypes.Count;

  public static HashSet<PropInfo> FixedProps { [DebuggerStepThrough] get; private set; } = new HashSet<PropInfo>();
  public static int FixedPropsCount => FixedProps.Count;

  public static bool CancelRequest { get => TypeManager.CancelRequest; set => TypeManager.CancelRequest = value; }

  #region Scan methods

  public static SummaryInfo ScanTypes(Type startingType, ProgressTypeEvent? OnScanningType)
  {
    TypeManager.UseAsynReflection = false;
    TypeManager.OnRegistering += OnScanningType;
    var typeName = startingType.ToString();
    TypeManager.RegisterType(startingType);
    TypeManager.OnRegistering -= OnScanningType;
    if (TypeManager.UseAsynReflection)
    {
      TypeReflector.WaitDone();
      double tps = TimeSpan.TicksPerSecond;
      Debug.WriteLine($"TypeReflector ThreadsUsed={TypeReflector.ThreadsUsed.Count}, TotalTime={TypeReflector.ThreadsUsed.Values.Sum() / tps:F3} s");
      foreach (var item in TypeReflector.ThreadsUsed)
        Debug.WriteLine($"  Thread {item.Key} = {item.Value / tps:F3} s");
    }
    TypeManager.UseAsynReflection = false;
    var allTypesCount = TypeManager.AllTypes.Count();
    var acceptedTypesCount = TypeManager.TypesAcceptedAfter(PPS.ScanSource).Count();
    var rejectedTypesCount = TypeManager.TypesRejectedAfter(PPS.ScanSource).Count();
    var summaryInfo = new SummaryInfo
    {
      Summary = new Dictionary<SummaryInfoKind, object>{
        {SummaryInfoKind.RegisteredTypes, allTypesCount },
        {SummaryInfoKind.AcceptedTypes, acceptedTypesCount },
        {SummaryInfoKind.RejectedTypes, rejectedTypesCount },
        }
    };
    return summaryInfo;
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
    if (ModelConfig.Instance == null)
      throw new System.InvalidOperationException(CommonStrings.Model_configuration_not_defined);

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

  //public static bool ValidateType(PPS phase, TypeInfo typeInfo)
  //{
  //  var isValid = true;
  //  if (!ValidateProperties(phase, typeInfo))
  //    isValid = false;
  //  return isValid;
  //}

  //public static bool ValidateProperties(PPS phase, TypeInfo typeInfo)
  //{
  //  var isValid = true;
  //  if (typeInfo.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlPartRootElement)))
  //  {
  //    var partProperty = typeInfo.Properties?.FirstOrDefault(item => item.Name.EndsWith("Part"));
  //    if (partProperty != null)
  //    {
  //      partProperty.SetRejected(phase);
  //      isValid = false;
  //    }
  //  }
  //  var baseTypes = typeInfo.GetBaseTypes();
  //  foreach (var baseType in baseTypes)
  //  {
  //    if (!CheckPropertyOverrides(phase, typeInfo, baseType))
  //      isValid = false;
  //  }
  //  return isValid;
  //}

  //public static bool CheckPropertyOverrides(PPS phase, TypeInfo thisTypeInfo, TypeInfo baseTypeInfo)
  //{
  //  //if (thisTypeInfo.Name == "CategoryAxisData")
  //  //  Debug.Assert(true);
  //  if (baseTypeInfo != null && thisTypeInfo.Properties != null && baseTypeInfo.Properties != null)
  //  {
  //    var thisPropNames = thisTypeInfo.Properties.Where(item => item.IsAcceptedTo(phase)).Select(item => item.Name).ToArray();
  //    var basePropNames = baseTypeInfo.Properties.Where(item => item.IsAcceptedTo(phase)).Select(item => item.Name).ToArray();
  //    var commonPropNames = thisPropNames.Intersect(basePropNames).ToArray();
  //    var hasSamePropNames = commonPropNames.Any();
  //    if (hasSamePropNames)
  //    {
  //      foreach (var propName in commonPropNames)
  //      {
  //        var thisProperty = thisTypeInfo.Properties.Where(item => item.Name == propName).First();
  //        var baseProperty = baseTypeInfo.Properties.Where(item => item.Name == propName).First();
  //        if (thisProperty.PropertyType == baseProperty.PropertyType)
  //        {
  //          thisProperty.IsOverriden = true;
  //          if (!baseProperty.IsOverriden && !baseProperty.IsAbstract)
  //            baseProperty.IsVirtual = true;
  //        }
  //        else
  //        {
  //          thisProperty.IsNew = true;
  //        }
  //      }
  //      return false;
  //    }
  //  }
  //  return true;
  //}

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

  #region Rename methods

  /// <summary>
  /// First rename namespaces, then rename types.
  /// </summary>
  /// <returns>Count of renamed types</returns>
  public static int RenameNamespacesAndTypes(IEnumerable<TypeInfo> types, ProgressTypeEvent? OnRenamingType)
  {
    RenameNamespaces();
    var renamedTypes = 0;
    var totalTypes = types.Count();
    RenamedTypesCount = 0;
    DuplicatedNamesCount = 0;
    foreach (var typeInfo in types)
    {
      if (ModelManager.TryRenameType(typeInfo))
        renamedTypes++;
      OnRenamingType?.Invoke(new ProgressTypeInfo
      {
        TotalTypes = totalTypes,
        CheckedTypes = CheckedRenameTypesCount,
        ProcessedTypes = RenamedTypesCount,
        Current = typeInfo
      });
    }

    return RenamedTypesCount;
  }

  public static int RenameNamespaces()
  {
    if (ModelConfig.Instance == null)
      throw new System.InvalidOperationException(CommonStrings.Model_configuration_not_defined);

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
    if (ModelConfig.Instance == null)
      throw new System.InvalidOperationException(CommonStrings.Model_configuration_not_defined);

    CheckedRenameTypesCount++;
    var typeName = typeInfo.OriginalName ?? "";
    var originalNamespace = typeInfo.OriginalNamespace;
    var newNamespace = TypeManager.TranslateNamespace(originalNamespace);
    string? newName;
    bool renamed = false;
    if (typeInfo.TypeKind == TypeKind.@enum)
    {
      newName = NewEnumTypeName(typeInfo.Type);
      if (newName != typeInfo.Name)
      {
        typeInfo.NewName = newName;
        typeInfo.TargetNamespace = newNamespace;
        RenamedTypesCount++;
        renamed = true;
      }
    }

    bool addToNewNamespace = true;
    bool checkDuplicatedName = true;


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
        if (!oldTypeInfo.HasError(PPS.Rename, ErrorCode.DuplicateName))
        {
          oldTypeInfo.AddError(PPS.Rename, ErrorCode.DuplicateName);
          DuplicatedNamesCount++;
        }
        typeInfo.AddError(PPS.Rename, ErrorCode.DuplicateName);
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

  #region Property conversion methods

  public static string GetTargetName(this PropInfo prop)
  {
    if (ModelConfig.Instance == null)
      throw new System.InvalidOperationException(CommonStrings.Model_configuration_not_defined);

    if (prop.DeclaringType != null)
    {
      var fullName = prop.DeclaringType.GetFullName(false, true, true) + "." + prop.Name;
      if (ModelConfig.Instance.PropertyTranslateTable.TryGetValue(fullName, out var newName))
        return newName;
    }
    return prop.Name;
  }

  public static TypeInfo? GetTargetPropertyType(this PropInfo propInfo)
  {
    var result = propInfo.PropertyType;
    if (result != null)
    {
      if (result.IsAcceptedAfter(PPS.CodeGen) || result.IsConversionTarget)
        return result;
      if (result.OriginalNamespace.StartsWith("System"))
        return result;
      if (result.TargetNamespace != null)
      {
        if (result.TargetNamespace.StartsWith("System") || TypeManager.GetNamespace(result.TargetNamespace).IsTarget)
          return result;
      }
      result = result.GetConversionTarget();
    }
    return result;
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

  #region Type conversion methods

  public static int ConvertTypes(ProgressTypeEvent? OnConvertingType)
  {
    var types = TypeManager.AllTypes.Where(typeInfo => typeInfo.IsAcceptedTo(PPS.ConvertTypes)
                                     && typeInfo.OriginalNamespace.StartsWith("DocumentFormat")
                                     ).ToArray();
    if (types.FirstOrDefault(item => item.Name.StartsWith("EnumValue")) == null)
    {
      var enumValueType = TypeManager.AllTypes.FirstOrDefault(item => item.Name.StartsWith("EnumValue"));
    }
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
    return ConvertedTypesCount;
  }

  public static bool TryConvertType(this TypeInfo typeInfo)
  {
    if (typeInfo.IsConverted)
      return false;
    var converted = false;
    if (TryEnumTypeConversion(typeInfo))
      converted = true;
    else
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
      var targetType = typeInfo.ConversionTarget;
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

  public static void SetTargetType(this TypeInfo typeInfo, Type targetType)
  {
    var targetTypeInfo = TypeManager.RegisterType(targetType, typeInfo, Semantics.TypeChange);
    SetTargetType(typeInfo, targetTypeInfo);
  }

  public static void SetTargetType(this TypeInfo typeInfo, TypeInfo targetTypeInfo)
  {
    typeInfo.AddRelationship(targetTypeInfo, Semantics.TypeChange);
    typeInfo.IsConverted = true;
    targetTypeInfo.IsConversionTarget = true;
    targetTypeInfo.SetTargetNamespace(targetTypeInfo.TargetNamespace ?? targetTypeInfo.OriginalNamespace);
    typeInfo.RemoveFromTargetNamespace();
  }

  private static bool TryEnumTypeConversion(TypeInfo typeInfo)
  {
    if (typeInfo.IsConverted)
      return false;
    if (typeInfo.TypeKind == TypeKind.@enum)
    {
      //if (typeInfo.TargetName.EndsWith("Kind"))
      //  Debug.Assert(true);
      return true;
    }
    return false;
  }

  private static bool TryTableTypeConversion(TypeInfo typeInfo)
  {
    if (typeInfo.IsConverted)
      return false;
    if (ModelConfig.Instance == null)
      throw new System.InvalidOperationException(CommonStrings.Model_configuration_not_defined);

    if (ModelConfig.Instance.TypeConversion.TryGetValue2(typeInfo.Type.FullName ?? "", out var targetName))
    {
      var targetType = TypeManager.GetType(targetName);
      if (targetType == null)
      {
        var fullTargetName = new FullTypeName(targetName);
        typeInfo.NewName = fullTargetName.Name;
        if (fullTargetName.Namespace != null && fullTargetName.Namespace != typeInfo.OriginalNamespace)
          typeInfo.SetTargetNamespace(fullTargetName.Namespace);
        return true;
      }
      typeInfo.SetTargetType(targetType);
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
        typeInfo.SetTargetType(typeInfo.BaseTypeInfo);
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
        typeInfo.SetTargetType(firstProp.PropertyType);
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
          typeInfo.SetTargetType(sourceArgType);
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
          typeInfo.SetTargetType(sourceArgType);
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
            typeInfo.SetTargetType(sourceArgType);
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
          typeInfo.SetTargetType(sourceArgType);
          return true;
        }
      }
      else
      if (typeInfo.IsConstructedGenericType && typeInfo.Name.StartsWith("EnumValue"))
      {
        var sourceArgTypes = typeInfo.Type.GetGenericArguments();
        var sourceArgType = sourceArgTypes.FirstOrDefault();
        if (sourceArgType != null)
        {
          typeInfo.SetTargetType(sourceArgType);
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
    if (ModelConfig.Instance == null)
      throw new System.InvalidOperationException(CommonStrings.Model_configuration_not_defined);
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
    if (ModelConfig.Instance == null)
      throw new System.InvalidOperationException(CommonStrings.Model_configuration_not_defined);

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
    return result;
  }

  public static TypeInfo? GetConversionSource(this TypeInfo typeInfo)
  {
    if (typeInfo.IsConversionTarget)
      return typeInfo;
    var result = TypeManager.GetRevRelatedTypes(typeInfo, Semantics.TypeChange).FirstOrDefault();
    return result;
  }
  #endregion

  #region Final fix methods

  /// <summary>
  /// Performs final check of enumerated types.
  /// </summary>
  /// <param name="onCheckingType">Callback method to invoke on each type</param>
  /// <returns>Summary info on checked types</returns>
  public static int FinalFix(ProgressTypeEvent? onCheckingType)
  {
    var types = new List<TypeInfo>();
    foreach (var nspace in TypeManager.AllNamespaces.Where(nspace => nspace.IsTarget))
      types.AddRange(nspace.Types);
    return FinalFix(types, onCheckingType);
  }

  /// <summary>
  /// Performs final check of enumerated types.
  /// </summary>
  /// <param name="types">List of types to check</param>
  /// <param name="onCheckingType">Callback method to invoke on each type</param>
  /// <returns>Count of checked types</returns>
  public static int FinalFix(IEnumerable<TypeInfo> types, ProgressTypeEvent? onCheckingType)
  {
    var totalTypes = types.Count();
    var checkedTypes = 0;
    int fixedTypesCount = 0;
    int removedPropsCount = 0;

    foreach (var type in types)
    {
      onCheckingType?.Invoke(new ProgressTypeInfo { TotalTypes = totalTypes, CheckedTypes = checkedTypes, ProcessedTypes = fixedTypesCount, Current = type });
      //if (type.Name.EndsWith("Value"))
      //{
      //  type.SetRejected(PPS.FinalFix);
      //  fixedTypesCount++;
      //}
      //else
      {
        var removedProperties = RemoveUntargetedProperties(type);
        if (removedProperties != 0)
        {
          type.AddFixage(PPS.FinalFix, ErrorCode.InvalidProperties);
          FixedTypes.AddUnique(type);
          fixedTypesCount++;
          removedPropsCount += removedProperties;
        }
      }
      checkedTypes++;
    }
    return FixedTypesCount;
  }

  /// <summary>
  /// Performs check of properties. 
  /// These properties which have no target property type are rejected.
  /// </summary>
  /// <param name="type">Type info to process</param>
  /// <returns>Number of fixed properties</returns>
  public static int RemoveUntargetedProperties(TypeInfo type)
  {
    int removedPropertiesCount = 0;
    if (type.Properties != null)
    {
      var props = new Dictionary<string, PropInfo>();
      foreach (var propInfo in type.Properties)
      {
        var err = ErrorCode.NoError;
        if (props.ContainsKey(propInfo.Name))
          err = ErrorCode.DuplicateName;
        else
        {
          props.Add(propInfo.Name, propInfo);
          var targetType = propInfo.GetTargetPropertyType();
          if (targetType == null)
            err = ErrorCode.MissingTargetType;
          else
          {
            if (targetType.IsConstructedGenericType)
            {
              var argType = targetType.GetGenericArguments().FirstOrDefault();
              if (argType == null)
                err = ErrorCode.MissingGenericArgType;
              else
              {
                targetType = argType.GetConversionTarget();
                if (targetType == null)
                  err = ErrorCode.InvalidGenericArgType;
              }
            }
          }
        }

        if (err != 0)
        {
          Debug.WriteLine($"Reject property {type.GetFullName(true, true, false)}.{propInfo.Name}: {propInfo.PropertyType}");
          propInfo.SetRejected(PPS.FinalFix);
          propInfo.AddFixage(PPS.FinalFix, err);
          FixedProps.AddUnique(propInfo);
          removedPropertiesCount++;
        }
      }
    }
    return removedPropertiesCount++;
  }

  #endregion
}