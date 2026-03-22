namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class Bar3DChartExtension
{
  public bool ShouldSerializeFilteredBarSeries() => FilteredBarSeries is not null;
}
