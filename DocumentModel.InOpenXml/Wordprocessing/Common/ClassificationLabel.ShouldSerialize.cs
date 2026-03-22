namespace DocumentModel;
#pragma warning disable CS1591
public partial class ClassificationLabel
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeEnabled() => Enabled is not null;
  public bool ShouldSerializeSetDate() => SetDate is not null;
  public bool ShouldSerializeMethod() => Method is not null;
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeSiteId() => SiteId is not null;
  public bool ShouldSerializeActionId() => ActionId is not null;
  public bool ShouldSerializeContentBits() => ContentBits is not null;
  public bool ShouldSerializeRemoved() => Removed is not null;
}
