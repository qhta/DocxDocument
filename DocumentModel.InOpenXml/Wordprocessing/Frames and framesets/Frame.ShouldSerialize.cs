namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Frame
{
  public bool ShouldSerializeFrameSize() => FrameSize is not null && ShouldSerialize(FrameSize);
  public bool ShouldSerializeFrameName() => !String.IsNullOrEmpty(FrameName);
  public bool ShouldSerializeSourceFileReference() => SourceFileReference is not null && ShouldSerialize(SourceFileReference);
  public bool ShouldSerializeMarginWidth() => MarginWidth is not null && ShouldSerialize(MarginWidth);
  public bool ShouldSerializeMarginHeight() => MarginHeight is not null && ShouldSerialize(MarginHeight);
  public bool ShouldSerializeScrollbarVisibility() => ScrollbarVisibility is not null && ShouldSerialize(ScrollbarVisibility);
  public bool ShouldSerializeNoResizeAllowed() => NoResizeAllowed is not null;
  public bool ShouldSerializeLinkedToFile() => LinkedToFile is not null;
}
