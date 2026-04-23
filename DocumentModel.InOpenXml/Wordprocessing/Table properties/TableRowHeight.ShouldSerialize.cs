namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableRowHeight
{
  public bool ShouldSerializeValue() => Value is not null && ShouldSerialize(Value);
  public bool ShouldSerializeType() => Type is not null && ShouldSerialize(Type);
}
