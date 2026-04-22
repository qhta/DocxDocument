namespace DocumentModel.Drawings.ChartDrawing;

#pragma warning disable CS1591

public partial class GroupShape
{
  public bool ShouldSerializeNonVisualGroupShapeProperties() => NonVisualGroupShapeProperties is not null;
  public bool ShouldSerializeGroupShapeProperties() => GroupShapeProperties is not null;
  public bool ShouldSerializeShape() => Shape is not null;
  public bool ShouldSerializeChildGroupShape() => ChildGroupShape is not null;
  public bool ShouldSerializeGraphicFrame() => GraphicFrame is not null;
  public bool ShouldSerializeConnectionShape() => ConnectionShape is not null;
  public bool ShouldSerializePicture() => Picture is not null;
}
