namespace DocumentModel.Drawings.ChartDrawing;

#pragma warning disable CS1591

public partial class NonVisualConnectorShapeDrawingProperties
{
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
  public bool ShouldSerializeNonVisualConnectionShapeProperties() => NonVisualConnectionShapeProperties is not null;
}
