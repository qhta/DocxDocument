namespace DocumentModel.Drawings;

public partial class ShapePropertiesExtension
{
  public bool ShouldSerializeHiddenFillProperties() => HiddenFillProperties is not null;
  public bool ShouldSerializeHiddenLineProperties() => HiddenLineProperties is not null;
  public bool ShouldSerializeHiddenEffectsProperties() => HiddenEffectsProperties is not null;
  public bool ShouldSerializeHiddenScene3D() => HiddenScene3D is not null;
  public bool ShouldSerializeHiddenShape3D() => HiddenShape3D is not null;
  public bool ShouldSerializeShadowObscured() => ShadowObscured is not null;
  public bool ShouldSerializeUriString() => UriString is not null;
}
