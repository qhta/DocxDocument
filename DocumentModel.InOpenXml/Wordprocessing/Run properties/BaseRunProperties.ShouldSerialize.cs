namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class BaseRunProperties<T> 
{
  public bool ShouldSerializeRunFonts() => RunFonts is not null && ShouldSerialize(RunFonts);
  public bool ShouldSerializeBold() => Bold is not null && ShouldSerialize(Bold);
  public bool ShouldSerializeBoldCS() => BoldCS is not null && ShouldSerialize(BoldCS);
  public bool ShouldSerializeItalic() => Italic is not null && ShouldSerialize(Italic);
  public bool ShouldSerializeItalicCS() => ItalicCS is not null && ShouldSerialize(ItalicCS);
  public bool ShouldSerializeFontSize() => FontSize is not null && ShouldSerialize(FontSize);
  public bool ShouldSerializeFontSizeCS() => FontSizeCS is not null && ShouldSerialize(FontSizeCS);
  public bool ShouldSerializeAllCaps() => AllCaps is not null;
  public bool ShouldSerializeSmallCaps() => SmallCaps is not null;
  public bool ShouldSerializeUnderline() => Underline is not null && ShouldSerialize(Underline);
  public bool ShouldSerializeStrike() => Strike is not null;
  public bool ShouldSerializeDoubleStrike() => DoubleStrike is not null;
  public bool ShouldSerializeColor() => Color is not null && ShouldSerialize(Color);
  public bool ShouldSerializeSpacing() => Spacing is not null && ShouldSerialize(Spacing);
  public bool ShouldSerializeCharacterScale() => CharacterScale is not null && ShouldSerialize(CharacterScale);
  public bool ShouldSerializeKern() => Kern is not null && ShouldSerialize(Kern);
  public bool ShouldSerializeSnapToGrid() => SnapToGrid is not null;
  public bool ShouldSerializeVerticalTextAlignment() => VerticalTextAlignment is not null && ShouldSerialize(VerticalTextAlignment);
  public bool ShouldSerializePosition() => Position is not null && ShouldSerialize(Position);
  public bool ShouldSerializeOutline() => Outline is not null;
  public bool ShouldSerializeEmboss() => Emboss is not null;
  public bool ShouldSerializeImprint() => Imprint is not null;
  public bool ShouldSerializeHasShadow() => HasShadow is not null;
  public bool ShouldSerializeLanguage() => Language is not null && ShouldSerialize(Language);
  public bool ShouldSerializeNoProof() => NoProof is not null;
  public bool ShouldSerializeShading() => Shading is not null && ShouldSerialize(Shading);
  public bool ShouldSerializeBorder() => Border is not null && ShouldSerialize(Border);
  public bool ShouldSerializeTextEffect() => TextEffect is not null && ShouldSerialize(TextEffect);
  public bool ShouldSerializeFitText() => FitText is not null && ShouldSerialize(FitText);
  public bool ShouldSerializeEmphasis() => Emphasis is not null && ShouldSerialize(Emphasis);
  public bool ShouldSerializeEastAsianLayout() => EastAsianLayout is not null && ShouldSerialize(EastAsianLayout);
  public bool ShouldSerializeHidden() => Hidden is not null;
  public bool ShouldSerializeHiddenAlways() => HiddenAlways is not null;
  public bool ShouldSerializeHiddenInWeb() => HiddenInWeb is not null;
}
