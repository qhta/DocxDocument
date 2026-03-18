namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class Surface3DChart
{
  public bool ShouldSerializeWireframe() => Wireframe is not null;
  public bool ShouldSerializeVaryColors() => VaryColors is not null;
  public bool ShouldSerializeSurfaceChartSeries() => SurfaceChartSeries is not null;
  public bool ShouldSerializeBandFormats() => BandFormats is not null;
  public bool ShouldSerializeAxisIds() => AxisIds is not null;
  public bool ShouldSerializeSurface3DChartExtensionList() => Surface3DChartExtensionList is not null && Surface3DChartExtensionList.Count > 0;
}
