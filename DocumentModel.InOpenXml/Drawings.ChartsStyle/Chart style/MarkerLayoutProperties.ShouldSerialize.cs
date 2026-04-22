namespace DocumentModel.Drawings.ChartsStyle;

#pragma warning disable CS1591

public partial class MarkerLayoutProperties
{
  public bool ShouldSerializeSymbol() => Symbol is not null;
  public bool ShouldSerializeSize() => Size is not null;
}
