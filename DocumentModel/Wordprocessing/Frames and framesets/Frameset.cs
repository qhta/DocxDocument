namespace DocumentModel.Wordprocessing;

/// <summary>
///   IFrameset Definition.
/// </summary>
public class IFrameset: ElementCollection<IFramesetItem>, IFramesetItem
{
  ///// <summary>
  /////   Advisory information about the frameset.
  ///// </summary>
  //public String? Title { get; set; }

  /// <summary>
  ///   Nested IFrameset Size.
  /// </summary>
  public UInt32? FrameSize { get; set; }

  /// <summary>
  ///   IFrameset Splitter Properties.
  /// </summary>
  public FramesetSplitbar? FramesetSplitbar { get; set; }

  /// <summary>
  ///   IFrameset Layout.
  /// </summary>
  public FrameLayoutKind? FrameLayout { get; set; }

}
