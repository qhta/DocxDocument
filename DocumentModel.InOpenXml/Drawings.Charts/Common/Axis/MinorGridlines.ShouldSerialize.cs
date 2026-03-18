namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class MinorGridlines
{
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
}
