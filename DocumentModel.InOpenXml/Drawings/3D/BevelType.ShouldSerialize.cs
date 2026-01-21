namespace DocumentModel.Drawings;

public partial class BevelType
{
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeHeight() => Height is not null;
  public bool ShouldSerializePreset() => Preset is not null;
}
