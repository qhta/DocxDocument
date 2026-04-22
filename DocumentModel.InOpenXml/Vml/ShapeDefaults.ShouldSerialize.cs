namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class ShapeDefaults
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeMaxShapeId() => MaxShapeId is not null;
  public bool ShouldSerializeStyle() => !String.IsNullOrEmpty(Style);
  public bool ShouldSerializeBeFilled() => BeFilled is not null;
  public bool ShouldSerializeFillColor() => !String.IsNullOrEmpty(FillColor);
  public bool ShouldSerializeIsStroke() => IsStroke is not null;
  public bool ShouldSerializeStrokeColor() => !String.IsNullOrEmpty(StrokeColor);
  public bool ShouldSerializeAllowInCell() => AllowInCell is not null;
  public bool ShouldSerializeAllowOverlap() => AllowOverlap is not null;
  public bool ShouldSerializeInsetMode() => InsetMode is not null;
  public bool ShouldSerializeFill() => Fill is not null;
  public bool ShouldSerializeImageData() => ImageData is not null;
  public bool ShouldSerializeStroke() => Stroke is not null;
  public bool ShouldSerializeTextBox() => TextBox is not null;
  public bool ShouldSerializeShadow() => Shadow is not null;
  public bool ShouldSerializeSkew() => Skew is not null;
  public bool ShouldSerializeExtrusion() => Extrusion is not null;
  public bool ShouldSerializeCallout() => Callout is not null;
  public bool ShouldSerializeLock() => Lock is not null;
  public bool ShouldSerializeColorMostRecentlyUsed() => ColorMostRecentlyUsed is not null;
  public bool ShouldSerializeColorMenu() => ColorMenu is not null;
}
