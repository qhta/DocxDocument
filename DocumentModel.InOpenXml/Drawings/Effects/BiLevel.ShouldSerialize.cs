namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class BiLevel
{
  public bool ShouldSerializeThreshold() => Threshold is not null;
}
