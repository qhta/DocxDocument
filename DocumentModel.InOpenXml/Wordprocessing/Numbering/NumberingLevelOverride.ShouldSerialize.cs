namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class NumberingLevelOverride
{
  public bool ShouldSerializeLevelIndex() => LevelIndex is not null && ShouldSerialize(LevelIndex);
  public bool ShouldSerializeStartOverrideNumberingValue() => StartOverrideNumberingValue is not null && ShouldSerialize(StartOverrideNumberingValue);
  public bool ShouldSerializeLevel() => Level is not null && ShouldSerialize(Level);
}
