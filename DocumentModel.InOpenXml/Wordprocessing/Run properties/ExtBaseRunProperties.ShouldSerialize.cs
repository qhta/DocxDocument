namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class ExtBaseRunProperties<T> 
{
  public bool ShouldSerializeRunStyle() => !String.IsNullOrEmpty(RunStyle);
  public bool ShouldSerializeComplexScript() => ComplexScript is not null;
  public bool ShouldSerializeRightToLeftText() => RightToLeftText is not null;
  public bool ShouldSerializeHighlight() => Highlight is not null && ShouldSerialize(Highlight);
  public bool ShouldSerializeContextualAlternates() => ContextualAlternates is not null && ShouldSerialize(ContextualAlternates);
  public bool ShouldSerializeGlow() => Glow is not null && ShouldSerialize(Glow);
  public bool ShouldSerializeShadow14() => Shadow14 is not null && ShouldSerialize(Shadow14);
  public bool ShouldSerializeReflection() => Reflection is not null && ShouldSerialize(Reflection);
  public bool ShouldSerializeTextOutlineEffect() => TextOutlineEffect is not null && ShouldSerialize(TextOutlineEffect);
  public bool ShouldSerializeFillTextEffect() => FillTextEffect is not null && ShouldSerialize(FillTextEffect);
  public bool ShouldSerializeScene3D() => Scene3D is not null && ShouldSerialize(Scene3D);
  public bool ShouldSerializeProperties3D() => Properties3D is not null && ShouldSerialize(Properties3D);
  public bool ShouldSerializeLigatures() => Ligatures is not null && ShouldSerialize(Ligatures);
  public bool ShouldSerializeNumberingFormat() => NumberingFormat is not null && ShouldSerialize(NumberingFormat);
  public bool ShouldSerializeNumberSpacing() => NumberSpacing is not null && ShouldSerialize(NumberSpacing);
  public bool ShouldSerializeStylisticSets() => StylisticSets is not null && ShouldSerialize(StylisticSets);
}
