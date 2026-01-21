namespace DocumentModel.Drawings;

public partial class TintEffect
{
  public bool ShouldSerializeHue() => Hue is not null;
  public bool ShouldSerializeAmount() => Amount is not null;
}
