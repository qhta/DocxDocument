namespace DocumentModel.Drawings;

public partial class Saturation
{
  public bool ShouldSerializeSaturationAmount() => SaturationAmount is not null;
}
