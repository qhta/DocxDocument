namespace DocumentModel.Drawings.ChartDrawing;

#pragma warning disable CS1591

public partial class NonVisualGraphicFrameProperties
{
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
  public bool ShouldSerializeNonVisualGraphicFrameDrawingProperties() => NonVisualGraphicFrameDrawingProperties is not null;
}
