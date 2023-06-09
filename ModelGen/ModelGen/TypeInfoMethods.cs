namespace ModelGen;
partial class TypeInfo
{

  public TypeRelationship AddRelationship(TypeInfo target, Semantics semantics, int order = 0)
  {
    //lock (RelationshipsLock)
    {
      var rel = new TypeRelationship(this, target, semantics);
      this.OutgoingRelationships.Add(rel);
      target.IncomingRelationships.Add(rel);
      return rel;
    }
  }

  public TypeRelationship[] GetIncomingRelationships()
  {
    //lock (RelationshipsLock)
    return this.IncomingRelationships.ToArray();
  }

  public TypeRelationship[] GetIncomingRelationships(Semantics semantics)
  {
    //lock (RelationshipsLock)
    return this.IncomingRelationships.Where(item => item.Semantics == semantics).ToArray();
  }


  public TypeRelationship[] GetOutgoingRelationships()
  {
    //lock (RelationshipsLock)
    return this.OutgoingRelationships.ToArray();
  }

  public TypeRelationship[] GetOutgoingRelationships(Semantics semantics)
  {
    //lock (RelationshipsLock)
    return this.OutgoingRelationships.Where(item => item.Semantics == semantics).ToArray();
  }

  public TypeInfo[] GetRelatedTypes(Semantics semantics)
  {
    //lock (RelationshipsLock)
    return this.OutgoingRelationships.Where(item => item.Semantics == semantics).Select(item => item.Target).ToArray();
  }

  public TypeInfo[] GetRevRelatedTypes(Semantics semantics)
  {
    //lock (RelationshipsLock)
    return this.IncomingRelationships.Where(item => item.Semantics == semantics).Select(item => item.Source).ToArray();
  }

  public TypeInfo[] GetImplementedInterfaces()
  {
    //if (!this.IsReflected)
    //  TypeReflector.WaitForReflection(this);
    return this.GetRelatedTypes(Semantics.Implementation).ToArray();
  }

  public TypeInfo[] GetIElementsTypes()
  {
    //if (!this.IsReflected)
    //  TypeReflector.WaitForReflection(this);
    return this.GetRelatedTypes(Semantics.Include).ToArray();
  }
  public TypeInfo[] GetGenericTypeArguments()
  {
    //if (!this.IsReflected)
    //  TypeReflector.WaitForReflection(this);
    var args = this.GetRelatedTypes(Semantics.GenericTypeArg).ToArray();
    if (args.Length != 0)
      return args;
    var baseType = this.BaseTypeInfo;
    if (baseType != null)
      return baseType.GetGenericTypeArguments();
    return new TypeInfo[0];
  }

  public TypeInfo[] GetGenericParamTypes()
  {
    //if (!this.IsReflected)
    //  TypeReflector.WaitForReflection(this);
    return this.GetRelatedTypes(Semantics.GenericTypeParam).ToArray();
  }

  public TypeInfo[] GetGenericTypeParamConstraints()
  {
    //if (!this.IsReflected)
    //  TypeReflector.WaitForReflection(this);
    return this.GetRelatedTypes(Semantics.GenericTypeParamConstraint).ToArray();

  }

  public IEnumerable<GenericParamConstraint> GetGenericParamConstraints()
  {
    //if (!this.IsReflected)
    //  TypeReflector.WaitForReflection(this);
    var list = new List<GenericParamConstraint>();
    if (this.IsGenericTypeParameter)
      return list;
    var genericParameterAttributes = this.Type.GenericParameterAttributes;
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

  public string GetNameWithParams()
  {
    var result = this.Name;
    int k = result.IndexOf('`');
    if (k >= 0)
    {
      result = result.Substring(0, k);
      if (this.IsReflected)
      {
        if (this.IsConstructedGenericType)
          result += GetGenericParamsNames(this.GetGenericTypeArguments());
        if (this.IsGenericTypeDefinition)
          result += GetGenericParamsNames(this.GetGenericParamTypes());
      }
      else
      {
        if (this.IsConstructedGenericType)
          result += GetGenericParamsNames(this.Type.GenericTypeArguments);
        if (this.IsGenericTypeDefinition)
          result += GetGenericParamsNames(this.Type.GetTypeInfo().GenericTypeParameters);
      }
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

  public bool IsCollection([NotNullWhen(true)][MaybeNullWhen(false)] out TypeInfo? itemType)
  {
    if (this.Name.StartsWith("Collection`1"))
    {
      itemType = this.GetGenericTypeArguments()[0];
      return true;
    }

    var type = this.GetImplementedInterfaces().FirstOrDefault((TypeInfo item) => item.Name.StartsWith("ICollection`1"));
    if (type != null)
    {
      itemType = type.GetGenericTypeArguments()[0];
      return true;
    }

    itemType = null;
    return false;
  }

  public bool IsEnumerable([NotNullWhen(true)][MaybeNullWhen(false)] out TypeInfo? itemType)
  {
    var type = this.GetImplementedInterfaces().FirstOrDefault((TypeInfo item) => item.Name.StartsWith("IEnumerable`1"));
    if (type != null)
    {
      itemType = type.GetGenericTypeArguments()[0];
      return true;
    }

    itemType = null;
    return false;
  }

  public bool IsSimple()
  {
    return Type.IsSimple() || Type == typeof(Uri) || Type == typeof(HexInt) /*|| Type == typeof(Byte[])*/;
  }

  public bool IsEnumValue([NotNullWhen(true)][MaybeNullWhen(false)] out TypeInfo? enumType)
  {
    if (Type.Name.StartsWith("EnumValue`"))
    {
      enumType = this.GetGenericTypeArguments().FirstOrDefault();
      return (enumType != null);
    }
    enumType = null;
    return false;
  }
}
