namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class AlphaBiLevel
{
  public bool ShouldSerializeThreshold() => Threshold is not null;
}
