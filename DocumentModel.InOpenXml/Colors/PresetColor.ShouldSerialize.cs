namespace DocumentModel;

public partial class PresetColor
{
  public bool ShouldSerializeVal() => Val is not null;
}
