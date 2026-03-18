namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class SurfaceChartExtension
{
  public bool ShouldSerializeFilteredSurfaceSeries() => FilteredSurfaceSeries is not null;
}
