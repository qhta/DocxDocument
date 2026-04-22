namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class MajorGridlines
{
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
}
