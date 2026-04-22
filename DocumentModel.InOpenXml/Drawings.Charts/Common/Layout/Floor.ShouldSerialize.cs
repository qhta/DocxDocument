namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class Floor
{
  public bool ShouldSerializeThickness() => Thickness is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializePictureOptions() => PictureOptions is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
