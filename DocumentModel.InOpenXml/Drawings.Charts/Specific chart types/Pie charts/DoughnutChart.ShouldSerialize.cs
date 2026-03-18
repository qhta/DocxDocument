namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class DoughnutChart
{
  public bool ShouldSerializeVaryColors() => VaryColors is not null;
  public bool ShouldSerializePieChartSeries() => PieChartSeries is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeFirstSliceAngle() => FirstSliceAngle is not null;
  public bool ShouldSerializeHoleSize() => HoleSize is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
