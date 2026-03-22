namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class Area3DChartExtension
{
  public bool ShouldSerializeFilteredAreaSeries() => FilteredAreaSeries is not null;
}
