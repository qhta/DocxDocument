namespace DocumentModel;

public partial class RgbOrAutoColor
{
  public bool ShouldSerializeIsAuto() => IsAuto == true;
}
