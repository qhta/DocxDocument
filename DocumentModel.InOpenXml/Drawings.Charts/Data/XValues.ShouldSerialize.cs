namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class XValues
{
  public bool ShouldSerializeMultiLevelStringReference() => MultiLevelStringReference is not null;
  public bool ShouldSerializeNumberReference() => NumberReference is not null;
  public bool ShouldSerializeNumberLiteral() => NumberLiteral is not null;
  public bool ShouldSerializeStringReference() => StringReference is not null;
  public bool ShouldSerializeStringLiteral() => StringLiteral is not null;
}
