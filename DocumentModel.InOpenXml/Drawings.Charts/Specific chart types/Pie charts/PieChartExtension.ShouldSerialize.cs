namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class PieChartExtension
{
  public bool ShouldSerializeFilteredPieSeries() => FilteredPieSeries is not null;
}
