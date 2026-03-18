namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class ScatterChart
{
  public bool ShouldSerializeScatterStyle() => ScatterStyle is not null;
  public bool ShouldSerializeVaryColors() => VaryColors is not null;
  public bool ShouldSerializeScatterChartSeries() => ScatterChartSeries is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeAxisIds() => AxisIds is not null;
  public bool ShouldSerializeScatterChartExtensionList() => ScatterChartExtensionList is not null && ScatterChartExtensionList.Count > 0;
}
