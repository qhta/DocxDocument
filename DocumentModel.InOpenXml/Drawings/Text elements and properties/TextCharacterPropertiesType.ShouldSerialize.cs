namespace DocumentModel.Drawings;

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
}
