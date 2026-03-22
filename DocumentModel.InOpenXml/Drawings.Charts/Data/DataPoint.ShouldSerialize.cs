namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class DataPoint
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeInvertIfNegative() => InvertIfNegative is not null;
  public bool ShouldSerializeMarker() => Marker is not null;
  public bool ShouldSerializeBubble3D() => Bubble3D is not null;
  public bool ShouldSerializeExplosion() => Explosion is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializePictureOptions() => PictureOptions is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
