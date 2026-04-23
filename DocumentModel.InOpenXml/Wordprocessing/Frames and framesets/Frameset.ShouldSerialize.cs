namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Frameset
{
  public bool ShouldSerializeTitle() => !String.IsNullOrEmpty(Title);
  public bool ShouldSerializeFrameSize() => FrameSize is not null && ShouldSerialize(FrameSize);
  public bool ShouldSerializeFramesetSplitbar() => FramesetSplitbar is not null && ShouldSerialize(FramesetSplitbar);
  public bool ShouldSerializeFrameLayout() => FrameLayout is not null && ShouldSerialize(FrameLayout);
}
