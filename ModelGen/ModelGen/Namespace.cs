namespace ModelGen;

public class Namespace
{
  public string OriginalName { get; private set; }

  public string? TargetName { get; set; }

  public OwnedCollection<TypeInfo> Types { get; private set; }

  public Dictionary<string, TypeInfo> TypeNames { get; private set; }

  public IEnumerable<TypeInfo> AcceptedTypes(PPS phase) => Types.Where(x => x.IsAcceptedTo(phase));

  public Namespace(string name)
  {
    OriginalName = name;
    Types = new OwnedCollection<TypeInfo>(this);
    Types.CollectionChanged += Types_CollectionChanged;
    TypeNames = new Dictionary<string, TypeInfo>();
  }

  public bool IsTarget { get; set; }

  private void Types_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (args.Action == NotifyCollectionChangedAction.Add)
    {
      if (args.NewItems != null)
        foreach (var item in args.NewItems)
        {
          if (item is TypeInfo typeInfo)
          {
            if (!typeInfo.IsConstructedGenericType)
            {
              var name = IsTarget ? (typeInfo.NewName ?? typeInfo.Name) : typeInfo.Name;
              if (name != null && !TypeNames.ContainsKey(name))
                TypeNames.Add(name, typeInfo);
            }
          }
        }
    }
    else
    if (args.Action == NotifyCollectionChangedAction.Remove)
    {
      if (args.OldItems != null)
        foreach (var item in args.OldItems)
        {
          if (item is TypeInfo typeInfo)
          {
            if (!typeInfo.IsConstructedGenericType)
            {
              var name = IsTarget ? (typeInfo.NewName ?? typeInfo.Name) : typeInfo.Name;
              if (name != null && TypeNames.ContainsKey(name))
                TypeNames.Remove(name);
            }
          }
        }
    }
  }

  public void AddType(TypeInfo type)
  {
    lock (Types)
    {
      if (!Types.Contains(type))
        Types.Add(type);
    }
  }

  public bool TryGetTypesWithSameName(TypeInfo typeInfo, out IEnumerable<TypeInfo> types)
  {
    var name = typeInfo.GetTargetName();
    types = AcceptedTypes(PPS.Rename).ToArray().Where(item => item != typeInfo && item.GetTargetName() == name).ToList();
    return types.Count() > 0;
  }

  public void Clear()
  {
    Types.Clear();
    TypeNames.Clear();
  }
}