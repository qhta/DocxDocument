namespace DocumentModel.Drawings.Pictures;

#pragma warning disable CS1591

public partial class NonVisualPictureProperties
{
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
  public bool ShouldSerializeNonVisualPictureDrawingProperties() => NonVisualPictureDrawingProperties is not null;
}
