namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class Pie3DChartExtension
{
  public bool ShouldSerializeFilteredPieSeries() => FilteredPieSeries is not null;
}
