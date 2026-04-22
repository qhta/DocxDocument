namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class ValueColorPositions
{
  public bool ShouldSerializeCount() => Count is not null;
  public bool ShouldSerializeMinValueColorEndPosition() => MinValueColorEndPosition is not null;
  public bool ShouldSerializeValueColorMiddlePosition() => ValueColorMiddlePosition is not null;
  public bool ShouldSerializeMaxValueColorEndPosition() => MaxValueColorEndPosition is not null;
}
