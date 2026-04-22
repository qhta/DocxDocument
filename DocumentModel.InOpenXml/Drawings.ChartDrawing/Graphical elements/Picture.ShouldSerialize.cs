namespace DocumentModel.Drawings.ChartDrawing;

#pragma warning disable CS1591

public partial class Picture
{
  public bool ShouldSerializeMacro() => !String.IsNullOrEmpty(Macro);
  public bool ShouldSerializePublished() => Published is not null;
  public bool ShouldSerializeStyle() => Style is not null;
  public bool ShouldSerializeNonVisualPictureProperties() => NonVisualPictureProperties is not null;
  public bool ShouldSerializeBlipFill() => BlipFill is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
}
