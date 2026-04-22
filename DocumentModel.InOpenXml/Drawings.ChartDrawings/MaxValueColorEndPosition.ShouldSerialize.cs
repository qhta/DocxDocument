namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class MaxValueColorEndPosition
{
  public bool ShouldSerializeExtremeValueColorPosition() => ExtremeValueColorPosition is not null;
  public bool ShouldSerializeNumberColorPosition() => NumberColorPosition is not null;
  public bool ShouldSerializePercentageColorPosition() => PercentageColorPosition is not null;
}
