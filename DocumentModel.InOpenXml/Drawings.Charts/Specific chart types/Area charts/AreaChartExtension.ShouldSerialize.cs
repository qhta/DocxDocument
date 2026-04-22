namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class AreaChartExtension
{
  public bool ShouldSerializeFilteredAreaSeries() => FilteredAreaSeries is not null;
}
