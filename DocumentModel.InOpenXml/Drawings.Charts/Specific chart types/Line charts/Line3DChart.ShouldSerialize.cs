namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class Line3DChart
{
  public bool ShouldSerializeGrouping() => Grouping is not null;
  public bool ShouldSerializeVaryColors() => VaryColors is not null;
  public bool ShouldSerializeLineChartSeries() => LineChartSeries is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeDropLines() => DropLines is not null;
  public bool ShouldSerializeGapDepth() => GapDepth is not null;
  public bool ShouldSerializeAxisIds() => AxisIds is not null;
  public bool ShouldSerializeLine3DChartExtensionList() => Line3DChartExtensionList is not null;
}
