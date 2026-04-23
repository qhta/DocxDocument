namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Zoom
{
  public bool ShouldSerializePreset() => Preset is not null && ShouldSerialize(Preset);
  public bool ShouldSerializePercent() => Percent is not null && ShouldSerialize(Percent);
}
