namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class EffectContainer
{
  public bool ShouldSerializeChildEffectContainer() => ChildEffectContainer is not null;
  public bool ShouldSerializeEffect() => Effect is not null;
  public bool ShouldSerializeAlphaBiLevel() => AlphaBiLevel is not null;
  public bool ShouldSerializeAlphaCeiling() => AlphaCeiling is not null;
  public bool ShouldSerializeAlphaFloor() => AlphaFloor is not null;
  public bool ShouldSerializeAlphaInverse() => AlphaInverse is not null;
  public bool ShouldSerializeAlphaModulationEffect() => AlphaModulationEffect is not null;
  public bool ShouldSerializeAlphaModulationFixed() => AlphaModulationFixed is not null;
  public bool ShouldSerializeAlphaOutset() => AlphaOutset is not null;
  public bool ShouldSerializeAlphaReplace() => AlphaReplace is not null;
  public bool ShouldSerializeBiLevel() => BiLevel is not null;
  public bool ShouldSerializeBlend() => Blend is not null;
  public bool ShouldSerializeBlur() => Blur is not null;
  public bool ShouldSerializeColorChange() => ColorChange is not null;
  public bool ShouldSerializeColorReplacement() => ColorReplacement is not null;
  public bool ShouldSerializeDuotone() => Duotone is not null;
  public bool ShouldSerializeFill() => Fill is not null;
  public bool ShouldSerializeFillOverlay() => FillOverlay is not null;
  public bool ShouldSerializeGlow() => Glow is not null;
  public bool ShouldSerializeHsl() => Hsl is not null;
  public bool ShouldSerializeInnerShadow() => InnerShadow is not null;
  public bool ShouldSerializeLuminanceEffect() => LuminanceEffect is not null;
  public bool ShouldSerializeOuterShadow() => OuterShadow is not null;
  public bool ShouldSerializePresetShadow() => PresetShadow is not null;
  public bool ShouldSerializeReflection() => Reflection is not null;
  public bool ShouldSerializeRelativeOffset() => RelativeOffset is not null;
  public bool ShouldSerializeSoftEdge() => SoftEdge is not null;
  public bool ShouldSerializeTintEffect() => TintEffect is not null;
  public bool ShouldSerializeTransformEffect() => TransformEffect is not null;
}
