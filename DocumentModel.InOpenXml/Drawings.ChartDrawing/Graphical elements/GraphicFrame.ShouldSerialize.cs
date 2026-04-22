namespace DocumentModel.Drawings.ChartDrawing;

#pragma warning disable CS1591

public partial class GraphicFrame
{
  public bool ShouldSerializeMacro() => !String.IsNullOrEmpty(Macro);
  public bool ShouldSerializePublished() => Published is not null;
  public bool ShouldSerializeNonVisualGraphicFrameProperties() => NonVisualGraphicFrameProperties is not null;
  public bool ShouldSerializeTransform() => Transform is not null;
  public bool ShouldSerializeGraphic() => Graphic is not null;
}
