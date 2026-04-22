namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class ValueColorMiddlePosition
{
  public bool ShouldSerializeNumberColorPosition() => NumberColorPosition is not null;
  public bool ShouldSerializePercentageColorPosition() => PercentageColorPosition is not null;
}
