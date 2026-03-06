namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class NumberingLevel
{
  public bool ShouldSerializeLevelIndex() => LevelIndex is not null;
  public bool ShouldSerializeTentative() => Tentative is not null;
  public bool ShouldSerializeStartNumberingValue() => StartNumberingValue is not null;
  public bool ShouldSerializeLevelRestart() => LevelRestart is not null;
  public bool ShouldSerializeNumberingFormat() => NumberingFormat is not null;
  public bool ShouldSerializeParagraphStyleIdInLevel() => ParagraphStyleIdInLevel is not null;
  public bool ShouldSerializeIsLegalNumberingStyle() => IsLegalNumberingStyle is not null;
  public bool ShouldSerializeLevelSuffix() => LevelSuffix is not null;
  public bool ShouldSerializeLevelText() => LevelText is not null;
  public bool ShouldSerializeLevelPictureBulletId() => LevelPictureBulletId is not null;
  public bool ShouldSerializeTemplateCode() => TemplateCode is not null;
  public bool ShouldSerializeLegacyNumbering() => LegacyNumbering is not null;
  public bool ShouldSerializeJustification() => Justification is not null;
  public bool ShouldSerializeNumberingSymbolRunProperties() => NumberingSymbolRunProperties is not null;
}
