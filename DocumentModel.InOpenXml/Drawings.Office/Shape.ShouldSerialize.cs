namespace DocumentModel.Drawings.Office;

public partial class Shape
{
  public bool ShouldSerializeModelId() => ModelId is not null;
  public bool ShouldSerializeShapeNonVisualProperties() => ShapeNonVisualProperties is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeShapeStyle() => ShapeStyle is not null;
  public bool ShouldSerializeTextBody() => TextBody is not null;
  public bool ShouldSerializeTransform2D() => Transform2D is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
