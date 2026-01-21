namespace DocumentModel.Drawings.Office;

public partial class ShapeNonVisualProperties
{
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
  public bool ShouldSerializeNonVisualDrawingShapeProperties() => NonVisualDrawingShapeProperties is not null;
}
