namespace DocumentModel.Drawings.ChartDrawing;

#pragma warning disable CS1591

public partial class NonVisualShapeDrawingProperties
{
  public bool ShouldSerializeTextBox() => TextBox is not null;
  public bool ShouldSerializeShapeLocks() => ShapeLocks is not null;
}
