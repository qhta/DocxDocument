namespace DocumentModel;

public partial class CustomProperty
{
  public bool ShouldSerializePropertyId() => PropertyId is not null;
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeFormatId() => FormatId is not null;
  public bool ShouldSerializeLinkTarget() => LinkTarget is not null;
  public bool ShouldSerializeValue() => Value is not null;
}
