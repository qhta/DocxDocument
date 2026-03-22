namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class Surface3DChartExtension
{
  public bool ShouldSerializeFilteredSurfaceSeries() => FilteredSurfaceSeries is not null;
}
