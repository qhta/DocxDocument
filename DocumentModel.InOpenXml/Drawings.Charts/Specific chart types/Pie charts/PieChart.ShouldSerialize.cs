namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class PieChart
{
  public bool ShouldSerializeVaryColors() => VaryColors is not null;
  public bool ShouldSerializePieChartSeries() => PieChartSeries is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeFirstSliceAngle() => FirstSliceAngle is not null;
  public bool ShouldSerializePieChartExtensionList() => PieChartExtensionList is not null && PieChartExtensionList.Count > 0;
}
