namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class RunProperties
{
  public bool ShouldSerializeRunStyle() => !String.IsNullOrEmpty(RunStyle);
  public bool ShouldSerializeHighlight() => Highlight is not null && ShouldSerialize(Highlight);
  public bool ShouldSerializeRightToLeftText() => RightToLeftText is not null;
  public bool ShouldSerializeComplexScript() => ComplexScript is not null;
  public bool ShouldSerializeGlow() => Glow is not null && ShouldSerialize(Glow);
  public bool ShouldSerializeShadow() => Shadow is not null && ShouldSerialize(Shadow);
  public bool ShouldSerializeReflection() => Reflection is not null && ShouldSerialize(Reflection);
  public bool ShouldSerializeTextOutlineEffect() => TextOutlineEffect is not null && ShouldSerialize(TextOutlineEffect);
  public bool ShouldSerializeFillTextEffect() => FillTextEffect is not null && ShouldSerialize(FillTextEffect);
  public bool ShouldSerializeScene3D() => Scene3D is not null && ShouldSerialize(Scene3D);
  public bool ShouldSerializeProperties3D() => Properties3D is not null && ShouldSerialize(Properties3D);
  public bool ShouldSerializeLigatures() => Ligatures is not null && ShouldSerialize(Ligatures);
  public bool ShouldSerializeNumberingFormat() => NumberingFormat is not null && ShouldSerialize(NumberingFormat);
  public bool ShouldSerializeNumberSpacing() => NumberSpacing is not null && ShouldSerialize(NumberSpacing);
  public bool ShouldSerializeStylisticSets() => StylisticSets is not null && ShouldSerialize(StylisticSets);
  public bool ShouldSerializeContextualAlternatives() => ContextualAlternatives is not null && ShouldSerialize(ContextualAlternatives);
  public bool ShouldSerializeRunPropertiesChange() => RunPropertiesChange is not null && ShouldSerialize(RunPropertiesChange);
}
