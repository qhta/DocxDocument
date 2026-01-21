namespace DocumentModel.Drawings.Pictures;

public partial class Picture
{
  public bool ShouldSerializeNonVisualPictureProperties() => NonVisualPictureProperties is not null;
  public bool ShouldSerializeBlipFill() => BlipFill is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeShapeStyle() => ShapeStyle is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
