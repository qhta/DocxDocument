namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class BaseRunProperties<T>
{
  public bool ShouldSerializeBold() => Bold.HasValue;
  public bool ShouldSerializeItalic() => Italic.HasValue;
  public bool ShouldSerializeCaps() => Caps.HasValue;
  public bool ShouldSerializeSmallCaps() => SmallCaps.HasValue;
  public bool ShouldSerializeStrike() => Strike.HasValue;
  public bool ShouldSerializeDoubleStrike() => DoubleStrike.HasValue;
  public bool ShouldSerializeColor() => Color != null;
  public bool ShouldSerializeSpacing() => Spacing != null;
  public bool ShouldSerializeCharacterScale() => CharacterScale.HasValue;
  public bool ShouldSerializeKern() => Kern != null;
  public bool ShouldSerializeSnapToGrid() => SnapToGrid.HasValue;
  public bool ShouldSerializeVerticalTextAlignment() => VerticalTextAlignment.HasValue;
  public bool ShouldSerializePosition() => Position != null;
  public bool ShouldSerializeOutline() => Outline.HasValue;
  public bool ShouldSerializeEmboss() => Emboss.HasValue;
  public bool ShouldSerializeImprint() => Imprint.HasValue;
  public bool ShouldSerializeShadow() => Shadow.HasValue;
  public bool ShouldSerializeNoProof() => NoProof.HasValue;
  public bool ShouldSerializeTextEffect() => TextEffect.HasValue;
  public bool ShouldSerializeEmphasis() => Emphasis.HasValue;
  public bool ShouldSerializeVanish() => Vanish.HasValue;
  public bool ShouldSerializeSpecVanish() => SpecVanish.HasValue;
  public bool ShouldSerializeWebHidden() => WebHidden.HasValue;
}
