namespace DocumentModel.Drawings;

public partial class BiLevel
{
  public bool ShouldSerializeThreshold() => Threshold is not null;
}
