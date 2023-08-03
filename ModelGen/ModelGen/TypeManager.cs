namespace ModelGen;

public record RegisteringInfo
{
  public int? RegisteredNamespaces;
  public int? RegisteredTypes;
  public TypeInfo? Current;
}

public delegate void RegisteringEvent(RegisteringInfo info);

public static class TypeManager
{
  public static event RegisteringEvent? OnRegistering;

  public static Dictionary<Type, TypeInfo> KnownTypes { get; private set; } = new();
  public static Dictionary<string, Namespace> KnownNamespaces { get; private set; } = new();

  public static void Clear()
  {
    KnownTypes = new();
    KnownNamespaces = new();
  }
  public static IEnumerable<Namespace> AllNamespaces
  {
    get
    {
      lock (NamespacesLock)
        return TypeManager.KnownNamespaces.Values.Select(item => item);
    }
  }

  public static int TotalTypesCount => KnownTypes.Count;

  public static IEnumerable<TypeInfo> AllTypes
  {
    get
    {
      lock (NamespacesLock)
        return TypeManager.KnownTypes.Values.Select(item => item);
    }
  }

  public static IEnumerable<TypeInfo> TypesAcceptedTo(PPS phase)
  {
    lock (NamespacesLock)
      return TypeManager.KnownTypes.Values.Where(item => item.IsAcceptedTo(phase));
  }

  public static IEnumerable<TypeInfo> TypesAcceptedAfter(PPS phase)
  {
    lock (NamespacesLock)
      return TypeManager.KnownTypes.Values.Where(item => item.IsAcceptedAfter(phase));
  }

  public static IEnumerable<TypeInfo> TypesRejectedAfter(PPS phase)
  {
    lock (NamespacesLock)
      return TypeManager.KnownTypes.Values.Where(item => item.IsRejectedAfter(phase));
  }

  public static IEnumerable<TypeInfo> ConvertedTypes
  {
    get
    {
      lock (NamespacesLock)
        return TypeManager.KnownTypes.Values.Where(item => item.IsConverted == true);
    }
  }

  public static IEnumerable<TypeInfo> UsedTypes
  {
    get
    {
      lock (NamespacesLock)
        return TypeManager.KnownTypes.Values.Where(item => item.IsUsed == true);
    }
  }

  public static void RegisterNamespace(string nspace)
  {
    lock (NamespacesLock)
      if (!KnownNamespaces.ContainsKey(nspace))
      {
        KnownNamespaces.Add(nspace, new Namespace(nspace));
        OnRegistering?.Invoke(new RegisteringInfo { RegisteredNamespaces = KnownNamespaces.Count, RegisteredTypes = AllTypes.Count() });
      }
  }

  public static string TranslateNamespace(string nspace)
  {
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
    lock (NamespacesLock)
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

  private static object KnownTypesLock = new object();
  private static object NamespacesLock = new object();
  private static object RelationshipsLock = new object();

  public static bool TryGetTypeInfo(Type type, [NotNullWhen(true)] out TypeInfo? info)
  {
    lock (KnownTypesLock)
    {
      if (KnownTypes.TryGetValue(type, out info))
        return true;
    }
    return false;
  }

  public static TypeInfo RegisterType(Type type, bool? acceptance = null)
  {
    //if (type.Name.StartsWith("OpenXmlComparableSimpleValue") && type.IsConstructedGenericType)
    //  Debug.Assert(true);
    //if (type.Name.StartsWith("OpenXmlSimpleValue"))
    //  Debug.Assert(true);
    lock (KnownTypesLock)
    {

      if (KnownTypes.TryGetValue(type, out var typeInfo))
        return typeInfo;
      //if (type.Name.StartsWith("OpenXmlSimpleValue"))
      //  Debug.Assert(true);
      var nspace = type.Namespace ?? "";
      lock (NamespacesLock)
      {
        if (!KnownNamespaces.ContainsKey(nspace))
          RegisterNamespace(nspace);
        typeInfo = new TypeInfo(type);
        KnownTypes.Add(type, typeInfo);
        var NamespaceDictionary = TypeManager.GetNamespace(nspace);
        NamespaceDictionary.Types.Add(typeInfo);
        OnRegistering?.Invoke(new RegisteringInfo { RegisteredNamespaces = KnownNamespaces.Count + 1, RegisteredTypes = AllTypes.Count(), Current = typeInfo });
      }
      bool accept = acceptance == true || !ModelConfig.Instance.IsExcluded(type);
      if (!accept)
        typeInfo.SetRejected(PPS.ScanTypes);

      if (accept)
        TypeReflector.ReflectType(typeInfo);
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
    lock (KnownTypesLock)
    {
      return KnownNamespaces[nspace];
    }
  }

  public static IEnumerable<TypeInfo> GetNamespaceTypes(string nspace)
  {
    lock (KnownTypesLock)
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
    var result = typeInfo.TargetType?.TargetName;
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
    if (aType.Name.StartsWith("Collection`1"))
    {
      itemType = aType.GetGenericArguments()[0];
      return true;
    }

    var type = aType.GetImplementedInterfaces().FirstOrDefault((TypeInfo item) => item.Name.StartsWith("ICollection`1"));
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