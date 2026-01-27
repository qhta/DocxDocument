namespace DocumentModel.Wordprocessing.Drawings;

#pragma warning disable CS1591

public partial class BevelType
{
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeHeight() => Height is not null;
  public bool ShouldSerializePresetProfileType() => PresetProfileType is not null;
}
