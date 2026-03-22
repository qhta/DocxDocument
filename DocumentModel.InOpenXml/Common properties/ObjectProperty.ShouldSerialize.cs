namespace DocumentModel;
#pragma warning disable CS1591
public partial class ObjectProperty
{
  public bool ShouldSerializeName() => Name is not null;
}
