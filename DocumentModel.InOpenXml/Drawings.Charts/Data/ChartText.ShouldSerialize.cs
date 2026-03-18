namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class ChartText
{
  public bool ShouldSerializeStringReference() => StringReference is not null;
  public bool ShouldSerializeRichText() => RichText is not null;
  public bool ShouldSerializeStringLiteral() => StringLiteral is not null;
}
