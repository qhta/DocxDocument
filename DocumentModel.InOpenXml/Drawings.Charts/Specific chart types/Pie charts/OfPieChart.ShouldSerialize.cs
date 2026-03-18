namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class OfPieChart
{
  public bool ShouldSerializeOfPieType() => OfPieType is not null;
  public bool ShouldSerializeVaryColors() => VaryColors is not null;
  public bool ShouldSerializePieChartSeries() => PieChartSeries is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeGapWidth() => GapWidth is not null;
  public bool ShouldSerializeSplitType() => SplitType is not null;
  public bool ShouldSerializeSplitPosition() => SplitPosition is not null;
  public bool ShouldSerializeCustomSplit() => CustomSplit is not null;
  public bool ShouldSerializeSecondPieSize() => SecondPieSize is not null;
  public bool ShouldSerializeSeriesLines() => SeriesLines is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
