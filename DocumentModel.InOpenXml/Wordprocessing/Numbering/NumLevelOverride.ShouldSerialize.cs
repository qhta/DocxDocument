namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class NumLevelOverride
{
  public bool ShouldSerializeLevelIndex() => LevelIndex is not null;
  public bool ShouldSerializeStartOverrideNumberingValue() => StartOverrideNumberingValue is not null;
  public bool ShouldSerializeLevel() => Level is not null;
}
