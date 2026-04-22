namespace DocumentModel.Drawings.Office;

#pragma warning disable CS1591

public partial class ShapeNonVisualProperties
{
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
  public bool ShouldSerializeNonVisualDrawingShapeProperties() => NonVisualDrawingShapeProperties is not null;
}
