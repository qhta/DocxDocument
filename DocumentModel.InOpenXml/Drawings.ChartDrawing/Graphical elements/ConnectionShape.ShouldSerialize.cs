namespace DocumentModel.Drawings.ChartDrawing;

#pragma warning disable CS1591

public partial class ConnectionShape
{
  public bool ShouldSerializeMacro() => !String.IsNullOrEmpty(Macro);
  public bool ShouldSerializePublished() => Published is not null;
  public bool ShouldSerializeNonVisualConnectorShapeDrawingProperties() => NonVisualConnectorShapeDrawingProperties is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeStyle() => Style is not null;
}
