namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class Pie3DChart
{
  public bool ShouldSerializeVaryColors() => VaryColors is not null;
  public bool ShouldSerializePieChartSeries() => PieChartSeries is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializePie3DChartExtensionList() => Pie3DChartExtensionList is not null;
}
