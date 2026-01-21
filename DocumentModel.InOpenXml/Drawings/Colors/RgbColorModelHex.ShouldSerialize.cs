namespace DocumentModel.Drawings;

public partial class RgbColorModelHex
{
  public bool ShouldSerializeVal() => Val is not null;
}
