namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class SurfaceChartSeries
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeOrder() => Order is not null;
  public bool ShouldSerializeSeriesText() => SeriesText is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializePictureOptions() => PictureOptions is not null;
  public bool ShouldSerializeCategoryAxisData() => CategoryAxisData is not null;
  public bool ShouldSerializeValues() => Values is not null;
  public bool ShouldSerializeBubble3D() => Bubble3D is not null;
  public bool ShouldSerializeSurfaceSerExtensionList() => SurfaceSerExtensionList is not null && SurfaceSerExtensionList.Count > 0;
}
