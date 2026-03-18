namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class DropLines
{
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
}
