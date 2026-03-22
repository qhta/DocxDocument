namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class PivotFormat
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeMarker() => Marker is not null;
  public bool ShouldSerializeDataLabel() => DataLabel is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
