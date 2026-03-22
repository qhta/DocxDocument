namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class ScatterChartExtension
{
  public bool ShouldSerializeFilteredScatterSeries() => FilteredScatterSeries is not null;
}
