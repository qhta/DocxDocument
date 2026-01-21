namespace DocumentModel.Drawings;

public partial class PresetColor
{
  public bool ShouldSerializeVal() => Val is not null;
}
