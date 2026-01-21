namespace DocumentModel;

public partial class ObjectProperty
{
  public bool ShouldSerializeName() => Name is not null;
}
