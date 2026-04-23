namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class ParagraphBorders
{
  public bool ShouldSerializeTopBorder() => TopBorder is not null && ShouldSerialize(TopBorder);
  public bool ShouldSerializeLeftBorder() => LeftBorder is not null && ShouldSerialize(LeftBorder);
  public bool ShouldSerializeBottomBorder() => BottomBorder is not null && ShouldSerialize(BottomBorder);
  public bool ShouldSerializeRightBorder() => RightBorder is not null && ShouldSerialize(RightBorder);
  public bool ShouldSerializeBetweenBorder() => BetweenBorder is not null && ShouldSerialize(BetweenBorder);
  public bool ShouldSerializeBarBorder() => BarBorder is not null && ShouldSerialize(BarBorder);
}
