namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class ExtBaseRunProperties<T>
{
  public bool ShouldSerializeRunStyle() => RunStyle is not null;
  public bool ShouldSerializeComplexScript() => ComplexScript is not null;
  public bool ShouldSerializeRightToLeftText() => RightToLeftText is not null;
  public bool ShouldSerializeHighlight() => Highlight is not null;
  public bool ShouldSerializeContextualAlternates() => ContextualAlternates is not null;
  public bool ShouldSerializeGlow() => Glow is not null;
  public bool ShouldSerializeShadow14() => Shadow14 is not null;
  public bool ShouldSerializeReflection() => Reflection is not null;
  public bool ShouldSerializeTextOutlineEffect() => TextOutlineEffect is not null;
  public bool ShouldSerializeFillTextEffect() => FillTextEffect is not null;
  public bool ShouldSerializeScene3D() => Scene3D is not null;
  public bool ShouldSerializeProperties3D() => Properties3D is not null;
  public bool ShouldSerializeLigatures() => Ligatures is not null;
  public bool ShouldSerializeNumberingFormat() => NumberingFormat is not null;
  public bool ShouldSerializeNumberSpacing() => NumberSpacing is not null;
  public bool ShouldSerializeStylisticSets() => StylisticSets is not null;
}
