namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class BarChart
{
  public bool ShouldSerializeBarDirection() => BarDirection is not null;
  public bool ShouldSerializeBarGrouping() => BarGrouping is not null;
  public bool ShouldSerializeVaryColors() => VaryColors is not null;
  public bool ShouldSerializeBarChartSeries() => BarChartSeries is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeGapWidth() => GapWidth is not null;
  public bool ShouldSerializeOverlap() => Overlap is not null;
  public bool ShouldSerializeSeriesLines() => SeriesLines is not null;
  public bool ShouldSerializeAxisIds() => AxisIds is not null;
  public bool ShouldSerializeBarChartExtensionList() => BarChartExtensionList is not null && BarChartExtensionList.Count > 0;
}
