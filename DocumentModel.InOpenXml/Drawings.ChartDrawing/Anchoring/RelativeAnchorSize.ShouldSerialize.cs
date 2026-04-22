namespace DocumentModel.Drawings.ChartDrawing;

#pragma warning disable CS1591

public partial class RelativeAnchorSize
{
  public bool ShouldSerializeFromAnchor() => FromAnchor is not null;
  public bool ShouldSerializeToAnchor() => ToAnchor is not null;
  public bool ShouldSerializeShape() => Shape is not null;
  public bool ShouldSerializeGroupShape() => GroupShape is not null;
  public bool ShouldSerializeGraphicFrame() => GraphicFrame is not null;
  public bool ShouldSerializeConnectionShape() => ConnectionShape is not null;
  public bool ShouldSerializePicture() => Picture is not null;
}
