namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class TxPrTextBody
{
  public bool ShouldSerializeBodyProperties() => BodyProperties is not null;
  public bool ShouldSerializeListStyle() => ListStyle is not null;
  public bool ShouldSerializeParagraph() => Paragraph is not null;
}
