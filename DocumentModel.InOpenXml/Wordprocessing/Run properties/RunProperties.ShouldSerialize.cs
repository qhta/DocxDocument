namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class RunProperties
{
  public bool ShouldSerializeRunStyle() => !String.IsNullOrEmpty(RunStyle);
  public bool ShouldSerializeBoldComplexScript() => BoldComplexScript is not null;
  public bool ShouldSerializeItalicComplexScript() => ItalicComplexScript is not null;
  public bool ShouldSerializeFontSizeComplexScript() => !String.IsNullOrEmpty(FontSizeComplexScript);
  public bool ShouldSerializeHighlight() => Highlight is not null;
  public bool ShouldSerializeRightToLeftText() => RightToLeftText is not null;
  public bool ShouldSerializeComplexScript() => ComplexScript is not null;
  public bool ShouldSerializeGlow() => Glow is not null;
  public bool ShouldSerializeShadow() => Shadow is not null;
  public bool ShouldSerializeReflection() => Reflection is not null;
  public bool ShouldSerializeTextOutlineEffect() => TextOutlineEffect is not null;
  public bool ShouldSerializeFillTextEffect() => FillTextEffect is not null;
  public bool ShouldSerializeScene3D() => Scene3D is not null;
  public bool ShouldSerializeProperties3D() => Properties3D is not null;
  public bool ShouldSerializeLigatures() => Ligatures is not null;
  public bool ShouldSerializeNumberingFormat() => NumberingFormat is not null;
  public bool ShouldSerializeNumberSpacing() => NumberSpacing is not null;
  public bool ShouldSerializeStylisticSets() => StylisticSets is not null;
  public bool ShouldSerializeContextualAlternatives() => ContextualAlternatives is not null;
  public bool ShouldSerializeRunPropertiesChange() => RunPropertiesChange is not null;
}
