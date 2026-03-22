namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class RadarChart
{
  public bool ShouldSerializeRadarStyle() => RadarStyle is not null;
  public bool ShouldSerializeVaryColors() => VaryColors is not null;
  public bool ShouldSerializeRadarChartSeries() => RadarChartSeries is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeAxisIds() => AxisIds is not null;
  public bool ShouldSerializeRadarChartExtensionList() => RadarChartExtensionList is not null && RadarChartExtensionList.Count > 0;
}
