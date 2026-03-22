namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class Line3DChartExtension
{
  public bool ShouldSerializeFilteredLineSeriesExtension() => FilteredLineSeriesExtension is not null;
}
