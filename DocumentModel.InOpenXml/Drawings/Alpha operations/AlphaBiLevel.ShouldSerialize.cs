namespace DocumentModel.Drawings;

public partial class AlphaBiLevel
{
  public bool ShouldSerializeThreshold() => Threshold is not null;
}
