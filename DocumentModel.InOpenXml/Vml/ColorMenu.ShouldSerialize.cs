namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class ColorMenu
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeStrokeColor() => StrokeColor is not null;
  public bool ShouldSerializeFillColor() => FillColor is not null;
  public bool ShouldSerializeShadowColor() => ShadowColor is not null;
  public bool ShouldSerializeExtrusionColor() => ExtrusionColor is not null;
}
