namespace DocumentModel;
#pragma warning disable CS1591
public partial class RgbColor
{
  public bool ShouldSerializeVal() => Val is not null;
}
