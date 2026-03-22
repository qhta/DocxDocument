namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class SurfaceChart
{
  public bool ShouldSerializeWireframe() => Wireframe is not null;
  public bool ShouldSerializeSurfaceChartSeries() => SurfaceChartSeries is not null;
  public bool ShouldSerializeBandFormats() => BandFormats is not null;
  public bool ShouldSerializeAxisIds() => AxisIds is not null;
  public bool ShouldSerializeSurfaceChartExtensionList() => SurfaceChartExtensionList is not null && SurfaceChartExtensionList.Count > 0;
}
