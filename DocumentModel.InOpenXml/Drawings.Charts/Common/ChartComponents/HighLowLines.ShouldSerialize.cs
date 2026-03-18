namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class HighLowLines
{
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
}
