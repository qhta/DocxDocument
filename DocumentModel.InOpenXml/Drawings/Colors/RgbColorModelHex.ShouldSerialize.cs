namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class RgbColorModelHex
{
  public bool ShouldSerializeVal() => Val is not null;
}
