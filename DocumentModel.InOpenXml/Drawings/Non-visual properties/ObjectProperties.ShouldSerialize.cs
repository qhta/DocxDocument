namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class ObjectProperties
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeIsActiveX() => IsActiveX is not null;
  public bool ShouldSerializeLinkType() => !String.IsNullOrEmpty(LinkType);
}
