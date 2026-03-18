namespace DocumentModel.Drawings.ChartsStyle;

#pragma warning disable CS1591

public partial class TextCharacterPropertiesType
{
  public bool ShouldSerializeSmtClean() => SmtClean is not null;
  public bool ShouldSerializeSmtId() => SmtId is not null;
  public bool ShouldSerializeKumimoji() => Kumimoji is not null;
  public bool ShouldSerializeLanguage() => !String.IsNullOrEmpty(Language);
  public bool ShouldSerializeAlternativeLanguage() => !String.IsNullOrEmpty(AlternativeLanguage);
  public bool ShouldSerializeFontSize() => FontSize is not null;
  public bool ShouldSerializeBold() => Bold is not null;
  public bool ShouldSerializeItalic() => Italic is not null;
  public bool ShouldSerializeUnderline() => Underline is not null;
  public bool ShouldSerializeStrike() => Strike is not null;
  public bool ShouldSerializeKerning() => Kerning is not null;
  public bool ShouldSerializeCapital() => Capital is not null;
  public bool ShouldSerializeSpacing() => Spacing is not null;
  public bool ShouldSerializeNormalizeHeight() => NormalizeHeight is not null;
  public bool ShouldSerializeBaseline() => Baseline is not null;
  public bool ShouldSerializeNoProof() => NoProof is not null;
  public bool ShouldSerializeDirty() => Dirty is not null;
  public bool ShouldSerializeSpellingError() => SpellingError is not null;
  public bool ShouldSerializeSmartTagClean() => SmartTagClean is not null;
  public bool ShouldSerializeSmartTagId() => SmartTagId is not null;
  public bool ShouldSerializeBookmark() => !String.IsNullOrEmpty(Bookmark);
  public bool ShouldSerializeOutline() => Outline is not null;
  public bool ShouldSerializeFill() => Fill is not null;
  public bool ShouldSerializeEffectList() => EffectList is not null && EffectList.Count > 0;
  public bool ShouldSerializeEffectDag() => EffectDag is not null;
  public bool ShouldSerializeHighlight() => Highlight is not null;
  public bool ShouldSerializeUnderlineFollowsText() => UnderlineFollowsText is not null;
  public bool ShouldSerializeUnderlineFillText() => UnderlineFillText is not null;
  public bool ShouldSerializeUnderlineFill() => UnderlineFill is not null;
  public bool ShouldSerializeLatinFont() => LatinFont is not null;
  public bool ShouldSerializeEastAsianFont() => EastAsianFont is not null;
  public bool ShouldSerializeComplexScriptFont() => ComplexScriptFont is not null;
  public bool ShouldSerializeSymbolFont() => SymbolFont is not null;
  public bool ShouldSerializeHyperlinkOnClick() => HyperlinkOnClick is not null;
  public bool ShouldSerializeHyperlinkOnMouseOver() => HyperlinkOnMouseOver is not null;
  public bool ShouldSerializeRightToLeft() => RightToLeft is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
