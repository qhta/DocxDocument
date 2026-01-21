namespace DocumentModel.Drawings.Pictures;

public partial class NonVisualPictureProperties
{
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
  public bool ShouldSerializeNonVisualPictureDrawingProperties() => NonVisualPictureDrawingProperties is not null;
}
