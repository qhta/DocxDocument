namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class LineChart
{
  public bool ShouldSerializeGrouping() => Grouping is not null;
  public bool ShouldSerializeVaryColors() => VaryColors is not null;
  public bool ShouldSerializeLineChartSeries() => LineChartSeries is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeDropLines() => DropLines is not null;
  public bool ShouldSerializeHighLowLines() => HighLowLines is not null;
  public bool ShouldSerializeUpDownBars() => UpDownBars is not null;
  public bool ShouldSerializeShowMarker() => ShowMarker is not null;
  public bool ShouldSerializeSmooth() => Smooth is not null;
  public bool ShouldSerializeAxisIds() => AxisIds is not null;
  public bool ShouldSerializeLineChartExtensionList() => LineChartExtensionList is not null && LineChartExtensionList.Count > 0;
}
