namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class AreaChart
{
  public bool ShouldSerializeGrouping() => Grouping is not null;
  public bool ShouldSerializeVaryColors() => VaryColors is not null;
  public bool ShouldSerializeAreaChartSeries() => AreaChartSeries is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeDropLines() => DropLines is not null;
  public bool ShouldSerializeAxisIds() => AxisIds is not null;
  public bool ShouldSerializeAreaChartExtension() => AreaChartExtension is not null;
}
