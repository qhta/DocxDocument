namespace DocumentModel;
#pragma warning disable CS1591
public partial class BuiltInDocumentProperty
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeValue() => Value is not null;
  public bool ShouldSerializeType() => Type is not null;
}
