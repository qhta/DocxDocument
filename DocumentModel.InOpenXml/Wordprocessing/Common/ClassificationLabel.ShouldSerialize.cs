namespace DocumentModel;

#pragma warning disable CS1591

public partial class ClassificationLabel
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeEnabled() => Enabled is not null;
  public bool ShouldSerializeSetDate() => !String.IsNullOrEmpty(SetDate);
  public bool ShouldSerializeMethod() => !String.IsNullOrEmpty(Method);
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeSiteId() => !String.IsNullOrEmpty(SiteId);
  public bool ShouldSerializeActionId() => !String.IsNullOrEmpty(ActionId);
  public bool ShouldSerializeContentBits() => ContentBits is not null && ShouldSerialize(ContentBits);
  public bool ShouldSerializeRemoved() => Removed is not null;
}
