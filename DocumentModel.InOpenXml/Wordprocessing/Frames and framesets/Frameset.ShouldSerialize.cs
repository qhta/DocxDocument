namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Frameset
{
  public bool ShouldSerializeTitle() => Title is not null;
  public bool ShouldSerializeFrameSize() => FrameSize is not null;
  public bool ShouldSerializeFramesetSplitbar() => FramesetSplitbar is not null;
  public bool ShouldSerializeFrameLayout() => FrameLayout is not null;
}
