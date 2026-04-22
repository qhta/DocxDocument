namespace DocumentModel.Drawings.ChartDrawing;

#pragma warning disable CS1591

public partial class NonVisualGraphicFrameDrawingProperties
{
  public bool ShouldSerializeGraphicFrameLocks() => GraphicFrameLocks is not null;
}
