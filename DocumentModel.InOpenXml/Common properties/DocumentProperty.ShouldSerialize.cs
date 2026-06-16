namespace DocumentModel;

#pragma warning disable CS1591

public partial class DocumentProperty
{
  public bool ShouldSerializeValue() => Value is not null;
  public bool ShouldSerializeType() => ValueType != null;
}
