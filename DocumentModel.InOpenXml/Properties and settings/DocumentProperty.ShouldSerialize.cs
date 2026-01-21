namespace DocumentModel;

public partial class DocumentProperty
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeValue() => Value is not null;
  public bool ShouldSerializeType() => Type is not null;
}
