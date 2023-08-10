namespace ModelGen;

public class Namespace
{
  public string OriginalName { get; private set; }

  public string? TargetName { get; set; }

  public OwnedCollection<TypeInfo> Types { get; private set; }

  public IEnumerable<TypeInfo> AcceptedTypes(PPS phase) => Types.Where(x => x.IsAcceptedTo(phase));

  public Namespace(string name)
  {
    OriginalName = name;
    Types = new OwnedCollection<TypeInfo>(this);
  }

  public void AddType(TypeInfo type)
  {
    if (!Types.Contains(type))
      Types.Add(type);
  }

  public bool TryGetTypesWithSameName(TypeInfo typeInfo, out IEnumerable<TypeInfo> types)
  {
    var name = typeInfo.GetTargetName();
    types = AcceptedTypes(PPS.Rename).ToArray().Where(item => item!=typeInfo && item.GetTargetName() == name).ToList();
    return types.Count() > 0;
  }
}