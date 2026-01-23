namespace DocumentModel.Wordprocessing;

public partial class Frame
{
  public bool ShouldSerializeFrameSize() => FrameSize is not null;
  public bool ShouldSerializeFrameName() => FrameName is not null;
  public bool ShouldSerializeSourceFileReference() => SourceFileReference is not null;
  public bool ShouldSerializeMarginWidth() => MarginWidth is not null;
  public bool ShouldSerializeMarginHeight() => MarginHeight is not null;
  public bool ShouldSerializeScrollbarVisibility() => ScrollbarVisibility is not null;
  public bool ShouldSerializeNoResizeAllowed() => NoResizeAllowed is not null;
  public bool ShouldSerializeLinkedToFile() => LinkedToFile is not null;
}
