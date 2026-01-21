namespace DocumentModel.Drawings;

public partial class ObjectProperties
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeIsActiveX() => IsActiveX is not null;
  public bool ShouldSerializeLinkType() => LinkType is not null;
}
