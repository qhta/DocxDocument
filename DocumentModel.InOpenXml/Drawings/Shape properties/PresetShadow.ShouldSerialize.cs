namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class PresetShadow
{
  public bool ShouldSerializePreset() => Preset is not null;
  public bool ShouldSerializeDistance() => Distance is not null;
  public bool ShouldSerializeDirection() => Direction is not null;
  public bool ShouldSerializeColor() => Color is not null;

}
