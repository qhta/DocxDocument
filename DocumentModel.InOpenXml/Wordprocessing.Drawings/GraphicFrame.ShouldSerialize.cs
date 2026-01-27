namespace DocumentModel.Wordprocessing.Drawings;

#pragma warning disable CS1591

public partial class GraphicFrame
{
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
  public bool ShouldSerializeNonVisualGraphicFrameProperties() => NonVisualGraphicFrameProperties is not null;
  public bool ShouldSerializeTransform2D() => Transform2D is not null;
  public bool ShouldSerializeGraphic() => Graphic is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
