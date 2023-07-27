namespace ModelGen;

public class Namespace
{
  public string OrigName { get; private set; }

  public string? TargetName { get; set; }

  public OwnedCollection<TypeInfo> Types { get; private set; }

  public Namespace(string name)
  {
    OrigName = name;
    Types = new OwnedCollection<TypeInfo>(this);
  }

  public bool TryGetTypesWithSameName(TypeInfo typeInfo, out IEnumerable<TypeInfo> types)
  {
    var name = typeInfo.GetNameWithParams();
    types = Types.Where(item => item.GetNameWithParams() == name).ToList();
    return types.Count() > 0;
  }
}