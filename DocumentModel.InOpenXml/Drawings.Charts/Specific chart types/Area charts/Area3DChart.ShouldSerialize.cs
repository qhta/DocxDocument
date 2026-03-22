namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class Area3DChart
{
  public bool ShouldSerializeGrouping() => Grouping is not null;
  public bool ShouldSerializeVaryColors() => VaryColors is not null;
  public bool ShouldSerializeAreaChartSeries() => AreaChartSeries is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeDropLines() => DropLines is not null;
  public bool ShouldSerializeGapDepth() => GapDepth is not null;
  public bool ShouldSerializeAxisIds() => AxisIds is not null;
  public bool ShouldSerializeArea3DChartExtension() => Area3DChartExtension is not null;
}
