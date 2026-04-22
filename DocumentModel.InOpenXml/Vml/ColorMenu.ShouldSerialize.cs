namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class ColorMenu
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeStrokeColor() => !String.IsNullOrEmpty(StrokeColor);
  public bool ShouldSerializeFillColor() => !String.IsNullOrEmpty(FillColor);
  public bool ShouldSerializeShadowColor() => !String.IsNullOrEmpty(ShadowColor);
  public bool ShouldSerializeExtrusionColor() => !String.IsNullOrEmpty(ExtrusionColor);
}
