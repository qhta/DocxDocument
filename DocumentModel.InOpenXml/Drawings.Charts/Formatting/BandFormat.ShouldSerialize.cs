namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class BandFormat
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
}
