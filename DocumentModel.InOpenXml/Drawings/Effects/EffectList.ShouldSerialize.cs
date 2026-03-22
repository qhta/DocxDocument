namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class EffectList
{
  public bool ShouldSerializeBlur() => Blur is not null;
  public bool ShouldSerializeFillOverlay() => FillOverlay is not null;
  public bool ShouldSerializeGlow() => Glow is not null;
  public bool ShouldSerializeInnerShadow() => InnerShadow is not null;
  public bool ShouldSerializeOuterShadow() => OuterShadow is not null;
  public bool ShouldSerializePresetShadow() => PresetShadow is not null;
  public bool ShouldSerializeReflection() => Reflection is not null;
  public bool ShouldSerializeSoftEdge() => SoftEdge is not null;
}
