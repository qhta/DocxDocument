namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FramesetSplitbar
{
  public bool ShouldSerializeWidth() => Width is not null && ShouldSerialize(Width);
  public bool ShouldSerializeColor() => Color is not null && ShouldSerialize(Color);
  public bool ShouldSerializeNoBorder() => NoBorder is not null;
  public bool ShouldSerializeFlatBorders() => FlatBorders is not null;
}
