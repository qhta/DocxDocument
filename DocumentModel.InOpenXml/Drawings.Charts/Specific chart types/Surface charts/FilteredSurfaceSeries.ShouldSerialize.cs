namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class FilteredSurfaceSeries
{
  public bool ShouldSerializeSurfaceChartSeries() => SurfaceChartSeries is not null;
}
