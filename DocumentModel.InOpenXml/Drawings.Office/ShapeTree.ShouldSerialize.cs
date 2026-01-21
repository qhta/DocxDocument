namespace DocumentModel.Drawings.Office;

public partial class ShapeTree
{
  public bool ShouldSerializeGroupShapeNonVisualProperties() => GroupShapeNonVisualProperties is not null;
  public bool ShouldSerializeGroupShapeProperties() => GroupShapeProperties is not null;
  public bool ShouldSerializeShape() => Shape is not null;
  public bool ShouldSerializeGroupShape() => GroupShape is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
