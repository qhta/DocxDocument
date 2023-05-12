namespace DocumentModel.Wordprocessing;

/// <summary>
///   Frameset Definition.
/// </summary>
public class Frameset: ElementCollection<IFramesetItem>, IFramesetItem
{
  ///// <summary>
  /////   Advisory information about the frameset.
  ///// </summary>
  //public String? Title { get; set; }

  /// <summary>
  ///   Nested Frameset Size.
  /// </summary>
  public UInt32? FrameSize { get; set; }

  /// <summary>
  ///   Frameset Splitter Properties.
  /// </summary>
  public FramesetSplitbar? FramesetSplitbar { get; set; }

  /// <summary>
  ///   Frameset Layout.
  /// </summary>
  public FrameLayoutKind? FrameLayout { get; set; }

}