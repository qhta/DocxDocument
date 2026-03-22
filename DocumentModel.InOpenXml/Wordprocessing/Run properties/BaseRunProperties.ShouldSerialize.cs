namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class BaseRunProperties<T> 
{
  public bool ShouldSerializeRunFonts() => RunFonts is not null;
  public bool ShouldSerializeBold() => Bold is not null;
  public bool ShouldSerializeBoldCS() => BoldCS is not null;
  public bool ShouldSerializeItalic() => Italic is not null;
  public bool ShouldSerializeItalicCS() => ItalicCS is not null;
  public bool ShouldSerializeFontSize() => FontSize is not null;
  public bool ShouldSerializeFontSizeCS() => FontSizeCS is not null;
  public bool ShouldSerializeCaps() => Caps is not null;
  public bool ShouldSerializeSmallCaps() => SmallCaps is not null;
  public bool ShouldSerializeUnderline() => Underline is not null;
  public bool ShouldSerializeStrike() => Strike is not null;
  public bool ShouldSerializeDoubleStrike() => DoubleStrike is not null;
  public bool ShouldSerializeColor() => Color is not null;
  public bool ShouldSerializeSpacing() => Spacing is not null;
  public bool ShouldSerializeCharacterScale() => CharacterScale is not null;
  public bool ShouldSerializeKern() => Kern is not null;
  public bool ShouldSerializeSnapToGrid() => SnapToGrid is not null;
  public bool ShouldSerializeVerticalTextAlignment() => VerticalTextAlignment is not null;
  public bool ShouldSerializePosition() => Position is not null;
  public bool ShouldSerializeOutline() => Outline is not null;
  public bool ShouldSerializeEmboss() => Emboss is not null;
  public bool ShouldSerializeImprint() => Imprint is not null;
  public bool ShouldSerializeShadow() => Shadow is not null;
  public bool ShouldSerializeLanguage() => Language is not null;
  public bool ShouldSerializeNoProof() => NoProof is not null;
  public bool ShouldSerializeShading() => Shading is not null;
  public bool ShouldSerializeBorder() => Border is not null;
  public bool ShouldSerializeTextEffect() => TextEffect is not null;
  public bool ShouldSerializeFitText() => FitText is not null;
  public bool ShouldSerializeEmphasis() => Emphasis is not null;
  public bool ShouldSerializeEastAsianLayout() => EastAsianLayout is not null;
  public bool ShouldSerializeVanish() => Hidden is not null;
  public bool ShouldSerializeSpecVanish() => HiddenAlways is not null;
  public bool ShouldSerializeWebHidden() => HiddenInWeb is not null;
}
