namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class Bar3DChart
{
  public bool ShouldSerializeBarDirection() => BarDirection is not null;
  public bool ShouldSerializeBarGrouping() => BarGrouping is not null;
  public bool ShouldSerializeVaryColors() => VaryColors is not null;
  public bool ShouldSerializeBarChartSeries() => BarChartSeries is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeGapWidth() => GapWidth is not null;
  public bool ShouldSerializeGapDepth() => GapDepth is not null;
  public bool ShouldSerializeShape() => Shape is not null;
  public bool ShouldSerializeAxisIds() => AxisIds is not null;
  public bool ShouldSerializeBar3DChartExtensionList() => Bar3DChartExtensionList is not null && Bar3DChartExtensionList.Count > 0;
}
