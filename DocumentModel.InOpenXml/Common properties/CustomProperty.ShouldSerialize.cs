namespace DocumentModel;

#pragma warning disable CS1591

public partial class CustomProperty
{
  public bool ShouldSerializePropertyId() => PropertyId is not null;
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeFormatId() => FormatId is not null;
  public bool ShouldSerializeLinkTarget() => !String.IsNullOrEmpty(LinkTarget);
}
