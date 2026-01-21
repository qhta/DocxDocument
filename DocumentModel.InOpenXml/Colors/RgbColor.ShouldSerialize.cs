namespace DocumentModel;

public partial class RgbColor
{
  public bool ShouldSerializeVal() => Val is not null;
}
