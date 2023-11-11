namespace ModelGen;

public static class TypeManager
{

  public static bool UseAsynReflection { [DebuggerStepThrough] get; set; }

  public static event ProgressTypeEvent? OnRegistering;

  public static Dictionary<Type, TypeInfo> KnownTypes { [DebuggerStepThrough] get; private set; } = new();
  public static Dictionary<string, Namespace> KnownNamespaces { [DebuggerStepThrough] get; private set; } = new();

  public static void Clear()
  {
    KnownTypes = new();
    KnownNamespaces = new();
  }
  public static IEnumerable<Namespace> AllNamespaces
  {
    get
    {
      lock (KnownNamespaces)
        return TypeManager.KnownNamespaces.Values.Select(item => item);
    }
  }

  public static int TotalTypesCount => KnownTypes.Count;

  public static IEnumerable<TypeInfo> AllTypes
  {
    get
    {
      lock (KnownNamespaces)
        return TypeManager.KnownTypes.Values.Select(item => item);
    }
  }

  public static IEnumerable<TypeInfo> TypesAcceptedTo(PPS phase)
  {
    lock (KnownNamespaces)
      return TypeManager.KnownTypes.Values.Where(item => item.IsAcceptedTo(phase));
  }

  public static IEnumerable<TypeInfo> TypesAcceptedAfter(PPS phase)
  {
    lock (KnownNamespaces)
      return TypeManager.KnownTypes.Values.Where(item => item.IsAcceptedAfter(phase));
  }

  public static IEnumerable<TypeInfo> TypesRejectedAfter(PPS phase)
  {
    lock (KnownNamespaces)
      return TypeManager.KnownTypes.Values.Where(item => item.IsRejectedAfter(phase));
  }

  public static IEnumerable<TypeInfo> ConvertedTypes
  {
    get
    {
      lock (KnownNamespaces)
        return TypeManager.KnownTypes.Values.Where(item => item.IsConverted == true);
    }
  }

  public static IEnumerable<TypeInfo> UsedTypes
  {
    get
    {
      lock (KnownNamespaces)
        return TypeManager.KnownTypes.Values.Where(item => item.IsUsed == true);
    }
  }

  public static Namespace RegisterNamespace(string ns)
  {
    lock (KnownNamespaces)
    {
      if (!KnownNamespaces.TryGetValue(ns, out var nspace))
      {
        nspace = new Namespace(ns);
        KnownNamespaces.Add(ns, nspace);
        OnRegistering?.Invoke(new ProgressTypeInfo { Namespaces = KnownNamespaces.Count, ProcessedTypes = AllTypes.Count() });
      }
      return nspace;
    }
  }

  public static string TranslateNamespace(string nspace)
  {
    if (ModelConfig.Instance == null)
      throw new System.InvalidOperationException(CommonStrings.Model_configuration_not_defined);
    var newNspace = nspace;
    foreach (var item in ModelConfig.Instance.TranslatedNamespaces)
    {
      if (nspace.StartsWith(item.Item1))
        newNspace = nspace.Replace(item.Item1, item.Item2);
    }
    return newNspace;
  }

  public static string TranslateNamespaceBack(string nspace)
  {
    if (ModelConfig.Instance == null)
      throw new System.InvalidOperationException(CommonStrings.Model_configuration_not_defined);
    var newNspace = nspace;
    foreach (var item in ModelConfig.Instance.TranslatedNamespaces)
    {
      if (nspace.StartsWith(item.Item2))
        newNspace = nspace.Replace(item.Item2, item.Item1);
    }
    return newNspace;
  }

  public static IEnumerable<string> GetNamespaces(NTS filter)
  {
    lock (KnownNamespaces)
    {
      var knownNamespace = KnownNamespaces.ToArray();
      if (filter == 0)
        return KnownNamespaces.Select(item => item.Key);
      var result = new List<string>();
      if (filter.HasFlag(NTS.Target))
        result.AddRange(knownNamespace.Where(item => item.Key.StartsWith("DocumentModel")).Select(item => item.Key));
      if (filter.HasFlag(NTS.Origin))
        result.AddRange(knownNamespace.Where(item => item.Key.StartsWith("DocumentFormat")).Select(item => item.Key));
      if (filter.HasFlag(NTS.System))
        result.AddRange(knownNamespace.Where(item => item.Key.StartsWith("System")).Select(item => item.Key));
      return result;
    }
  }

  //private static object KnownTypesLock = new object();
  //private static object NamespacesLock = new object();
  private static object RelationshipsLock = new object();

  public static bool TryGetTypeInfo(Type type, [NotNullWhen(true)] out TypeInfo? info)
  {
    lock (KnownTypes)
    {
      if (KnownTypes.TryGetValue(type, out info))
        return true;
    }
    return false;
  }

  public static bool TryGetTypeInfo(string fullTypeName, [NotNullWhen(true)] out TypeInfo? info)
  {
    info = null;
    var type = GetType(fullTypeName);
    if (type == null) return false;
    return TryGetTypeInfo(type, out info);
  }

  public static Type? GetType(string fullTypeName)
  {
    string? ns;
    string typeName;
    string? argTypeName;
    (ns, typeName, argTypeName) = SplitTypeName(fullTypeName);
    if (ns == null)
      ns = "System";
    fullTypeName = ns + "." + typeName;
    if (argTypeName != null)
      fullTypeName += "`1";
    Type? result;
    if (ns == "System")
      result = Type.GetType(fullTypeName + ", mscorlib");
    else
      result = Type.GetType(fullTypeName + ", DocumentModel.BaseTypes")
      ?? Type.GetType(fullTypeName + ", DocumentModel.Attributes");
    if (result==null)
      return null;
    //Debug.Assert(result != null);
    if (argTypeName != null)
    {
      Type? argType;
      if (!argTypeName.Contains("."))
        argType = Type.GetType("System." + argTypeName + ", mscorlib");
      else
        argType = Type.GetType(argTypeName + ", DocumentModel.BaseTypes")
        ?? Type.GetType(argTypeName + ", DocumentModel.Attributes");
      Debug.Assert(argType != null);
      result = result.MakeGenericType(new Type[]{ argType });
    }
    return result;
  }

  public static (string? ns, string typeName, string? argTypeName) SplitTypeName(string typeName)
  {
    string? ns = null;
    string? argTypeName = null;
    var k = typeName.IndexOf('<');
    if (k >= 0)
    {
      argTypeName = typeName.Substring(k + 1, typeName.Length - k - 1);
      typeName = typeName.Substring(0, k);
    }
    k = typeName.LastIndexOf(".");
    if (k >= 0)
    {
      ns = typeName.Substring(0,k);
      typeName = typeName.Substring(k + 1);
    }
    return (ns, typeName, argTypeName);
  }

  public static bool CancelRequest { get => TypeReflector.CancelRequest; set => TypeReflector.CancelRequest = value; }

  public static TypeInfo RegisterType(Type type)
  {
    if (ModelConfig.Instance == null)
      throw new System.InvalidOperationException(CommonStrings.Model_configuration_not_defined);
    lock (KnownTypes)
    {
      if (KnownTypes.TryGetValue(type, out var typeInfo))
        return typeInfo;
      //if (type.Name=="FileFormatVersions")
      //  Debug.WriteLine($"RegisterType({type.Name})");
      var ns = type.Namespace ?? "";
      lock (KnownNamespaces)
      {
        if (!KnownNamespaces.TryGetValue(ns, out var nspace))
          nspace = RegisterNamespace(ns);
        typeInfo = new TypeInfo(type);
        KnownTypes.Add(type, typeInfo);
        var NamespaceDictionary = TypeManager.GetNamespace(ns);
        NamespaceDictionary.AddType(typeInfo);
        if (nspace.IsTarget)
          typeInfo.TargetNamespace = ns;
        OnRegistering?.Invoke(new ProgressTypeInfo { Namespaces = KnownNamespaces.Count + 1, ProcessedTypes = AllTypes.Count(), Current = typeInfo });
      }
      var accept = !ModelConfig.Instance.IsExcluded(type);
      if (!accept)
        typeInfo.SetRejected(PPS.ScanSource);

      if (accept && type.Namespace != null && !CancelRequest)
      {
        if (UseAsynReflection)
          TypeReflector.ReflectTypeAsync(typeInfo);

        TypeReflector.ReflectType(typeInfo);
      }
      return typeInfo;
    }
  }

  public static TypeInfo RegisterType(Type type, Type source, Semantics semantics)
  {
    var result = RegisterType(type);
    var sourceTypeInfo = RegisterType(source);
    AddRelationship(sourceTypeInfo, result, semantics);
    return result;
  }

  public static TypeInfo RegisterType(Type type, TypeInfo source, Semantics semantics)
  {
    var result = RegisterType(type);
    AddRelationship(source, result, semantics);
    return result;
  }

  public static TypeRelationship AddRelationship(this TypeInfo source, TypeInfo target, Semantics semantics, int order = 0)
  {
    lock (RelationshipsLock)
    {
      //if (semantics==Semantics.TypeChange && target.Name=="Schema")
      //  Debug.Assert(true);
      var rel = new TypeRelationship(source, target, semantics);
      source.OutgoingRelationships.Add(rel);
      target.IncomingRelationships.Add(rel);
      return rel;
    }
  }

  public static TypeRelationship[] GetIncomingRelationships(this TypeInfo typeInfo)
  {
    lock (RelationshipsLock)
      return typeInfo.IncomingRelationships.ToArray();
  }

  public static TypeRelationship[] GetIncomingRelationships(this TypeInfo typeInfo, Semantics semantics)
  {
    lock (RelationshipsLock)
      return typeInfo.IncomingRelationships.Where(item => item.Semantics == semantics).ToArray();
  }


  public static TypeRelationship[] GetOutgoingRelationships(this TypeInfo typeInfo)
  {
    lock (RelationshipsLock)
      return typeInfo.OutgoingRelationships.ToArray();
  }

  public static TypeRelationship[] GetOutgoingRelationships(this TypeInfo typeInfo, Semantics semantics)
  {
    lock (RelationshipsLock)
      return typeInfo.OutgoingRelationships.Where(item => item.Semantics == semantics).ToArray();
  }

  public static TypeInfo[] GetRelatedTypes(this TypeInfo typeInfo, Semantics semantics)
  {
    lock (RelationshipsLock)
      return typeInfo.OutgoingRelationships.Where(item => item.Semantics == semantics).Select(item => item.Target).ToArray();
  }

  public static TypeInfo[] GetRevRelatedTypes(this TypeInfo typeInfo, Semantics semantics)
  {
    lock (RelationshipsLock)
      return typeInfo.IncomingRelationships.Where(item => item.Semantics == semantics).Select(item => item.Source).ToArray();
  }

  public static Namespace GetNamespace(string nspace)
  {
    lock (KnownTypes)
    {
      return KnownNamespaces[nspace];
    }
  }

  public static IEnumerable<TypeInfo> GetNamespaceTypes(string nspace)
  {
    lock (KnownTypes)
    {
      return KnownNamespaces[nspace].Types;
    }
  }

  public static TypeInfo[] GetImplementedInterfaces(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.Implementation).ToArray();
  }

  public static TypeInfo[] GetIElementsTypes(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.Include).ToArray();
  }
  public static TypeInfo[] GetGenericArguments(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    var args = TypeManager.GetRelatedTypes(typeInfo, Semantics.GenericTypeArg).ToArray();
    if (args.Length != 0)
      return args;
    var baseType = typeInfo.BaseTypeInfo;
    if (baseType != null)
      return GetGenericArguments(baseType);
    return new TypeInfo[0];
  }

  public static TypeInfo[] GetGenericParamTypes(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.GenericTypeParam).ToArray();
  }

  public static TypeInfo[] GetGenericTypeParamConstraints(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.GenericTypeParamConstraint).ToArray();

  }

  public static IEnumerable<GenericParamConstraint> GetGenericParamConstraints(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
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

  public static string GetOriginalName(this TypeInfo typeInfo)
  {
    var result = typeInfo.Type.Name;
    var k = result.IndexOf('`');
    if (k >= 0)
      result = result.Substring(0, k);
    Type[] genericArguments = typeInfo.Type.GetGenericArguments();
    if (genericArguments.Length > 0)
    {
      result = result + "<" + string.Join(", ", genericArguments.Select(x => x.Name)) + ">";
    }
    return result;
  }

  public static string GetTargetName(this TypeInfo typeInfo)
  {
    var result = typeInfo.ConversionTarget?.TargetName;
    if (result != null)
      return result;
    result = typeInfo.NewName ?? typeInfo.Name;
    var k = result.IndexOf('`');
    if (k >= 0)
      result = result.Substring(0, k);
    TypeInfo[] genericArguments = GetGenericArguments(typeInfo);
    if (genericArguments.Length > 0)
    {
      result = result + "<" + string.Join(", ", genericArguments.Select(x => x.TargetName)) + ">";
    }
    return result;
  }

  private static string GetGenericParamsNames(IEnumerable<TypeInfo> typeInfos)
  {
    var namesList = new List<string>();
    foreach (var type in typeInfos)
    {
      namesList.Add(type.Name);
    }
    return '<' + String.Join(", ", namesList) + '>';
  }

  private static string GetGenericParamsNames(IEnumerable<Type> types)
  {
    var namesList = new List<string>();
    foreach (var type in types)
    {
      namesList.Add(type.Name);
    }
    return '<' + String.Join(", ", namesList) + '>';
  }

  public static bool IsCollection(this TypeInfo aType, [NotNullWhen(true)][MaybeNullWhen(false)] out TypeInfo? itemType)
  {
    if (aType.Name.StartsWith("Collection`"))
    {
      itemType = aType.GetGenericArguments()[0];
      return true;
    }
     
    var type = aType.GetImplementedInterfaces().FirstOrDefault((TypeInfo item) => item.Name.StartsWith("ICollection`"));
    if (type != null)
    {
      itemType = type.GetGenericArguments()[0];
      return true;
    }

    itemType = null;
    return false;
  }

  public static bool IsEnumerable(this TypeInfo aType, [NotNullWhen(true)][MaybeNullWhen(false)] out TypeInfo? itemType)
  {
    var type = aType.GetImplementedInterfaces().FirstOrDefault((TypeInfo item) => item.Name.StartsWith("IEnumerable`1"));
    if (type != null)
    {
      itemType = type.GetGenericArguments()[0];
      return true;
    }

    itemType = null;
    return false;
  }

  public static void SaveData(string filename)
  {
    using (var xmlWriter = XmlWriter.Create(filename, new XmlWriterSettings { Indent = true }))
    {
      var namespaces = new Namespaces(TypeManager.AllNamespaces);
      var xmlSerializer = new QXmlSerializer(typeof(Namespaces));
      //xmlSerializer.Options.AllowUnregisteredTypes = true;
      xmlSerializer.Serialize(xmlWriter, namespaces);
    }
  }
}