namespace DocumentModel.Drawings;

public partial class RgbColorModelPercentage
{
  public bool ShouldSerializeRedPortion() => RedPortion is not null;
  public bool ShouldSerializeGreenPortion() => GreenPortion is not null;
  public bool ShouldSerializeBluePortion() => BluePortion is not null;
}
