namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class BevelType
{
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeHeight() => Height is not null;
  public bool ShouldSerializePreset() => Preset is not null;
}
