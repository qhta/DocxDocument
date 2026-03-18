namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class LeaderLines
{
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
}
