namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class DivBorders
{
  public bool ShouldSerializeTopBorder() => TopBorder is not null;
  public bool ShouldSerializeLeftBorder() => LeftBorder is not null;
  public bool ShouldSerializeBottomBorder() => BottomBorder is not null;
  public bool ShouldSerializeRightBorder() => RightBorder is not null;
}
