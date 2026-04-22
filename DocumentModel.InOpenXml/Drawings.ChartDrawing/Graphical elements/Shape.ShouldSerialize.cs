namespace DocumentModel.Drawings.ChartDrawing;

#pragma warning disable CS1591

public partial class Shape
{
  public bool ShouldSerializeMacro() => !String.IsNullOrEmpty(Macro);
  public bool ShouldSerializeTextLink() => !String.IsNullOrEmpty(TextLink);
  public bool ShouldSerializeLockText() => LockText is not null;
  public bool ShouldSerializePublished() => Published is not null;
  public bool ShouldSerializeNonVisualShapeProperties() => NonVisualShapeProperties is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeStyle() => Style is not null;
  public bool ShouldSerializeTextBody() => TextBody is not null;
}
