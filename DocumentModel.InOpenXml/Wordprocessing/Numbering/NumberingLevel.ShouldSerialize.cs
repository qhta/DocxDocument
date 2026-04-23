namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class NumberingLevel
{
  public bool ShouldSerializeLevelIndex() => LevelIndex is not null && ShouldSerialize(LevelIndex);
  public bool ShouldSerializeTentative() => Tentative is not null;
  public bool ShouldSerializeStartNumberingValue() => StartNumberingValue is not null && ShouldSerialize(StartNumberingValue);
  public bool ShouldSerializeLevelRestart() => LevelRestart is not null && ShouldSerialize(LevelRestart);
  public bool ShouldSerializeNumberingFormat() => NumberingFormat is not null && ShouldSerialize(NumberingFormat);
  public bool ShouldSerializeParagraphStyleIdInLevel() => !String.IsNullOrEmpty(ParagraphStyleIdInLevel);
  public bool ShouldSerializeIsLegalNumberingStyle() => IsLegalNumberingStyle is not null;
  public bool ShouldSerializeLevelSuffix() => LevelSuffix is not null && ShouldSerialize(LevelSuffix);
  public bool ShouldSerializeLevelText() => LevelText is not null && ShouldSerialize(LevelText);
  public bool ShouldSerializeLevelPictureBulletId() => LevelPictureBulletId is not null && ShouldSerialize(LevelPictureBulletId);
  public bool ShouldSerializeTemplateCode() => TemplateCode is not null && ShouldSerialize(TemplateCode);
  public bool ShouldSerializeLegacyNumbering() => LegacyNumbering is not null && ShouldSerialize(LegacyNumbering);
  public bool ShouldSerializeJustification() => Justification is not null && ShouldSerialize(Justification);
  public bool ShouldSerializeNumberingSymbolRunProperties() => NumberingSymbolRunProperties is not null && ShouldSerialize(NumberingSymbolRunProperties);
  public bool ShouldSerializeParagraphProperties() => ParagraphProperties is not null && ShouldSerialize(ParagraphProperties);
}
