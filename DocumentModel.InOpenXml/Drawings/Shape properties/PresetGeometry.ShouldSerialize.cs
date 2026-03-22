namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class PresetGeometry
{
  public bool ShouldSerializePreset() => Preset is not null;
  public bool ShouldSerializeAdjustValueList() => AdjustValueList is not null;
}
