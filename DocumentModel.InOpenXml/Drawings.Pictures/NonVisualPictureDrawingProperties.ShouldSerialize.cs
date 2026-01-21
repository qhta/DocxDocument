namespace DocumentModel.Drawings.Pictures;

public partial class NonVisualPictureDrawingProperties
{
  public bool ShouldSerializePreferRelativeResize() => PreferRelativeResize is not null;
  public bool ShouldSerializePictureLocks() => PictureLocks is not null;
  public bool ShouldSerializeNonVisualPicturePropertiesExtensionList() => NonVisualPicturePropertiesExtensionList is not null;
}
