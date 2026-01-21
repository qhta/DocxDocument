namespace DocumentModel.Wordprocessing;

public partial class FramesetSplitbar
{
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeColor() => Color is not null;
  public bool ShouldSerializeNoBorder() => NoBorder is not null;
  public bool ShouldSerializeFlatBorders() => FlatBorders is not null;
}
