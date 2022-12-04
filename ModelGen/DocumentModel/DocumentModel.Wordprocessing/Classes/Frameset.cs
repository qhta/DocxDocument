namespace DocumentModel.Wordprocessing;

/// <summary>
/// Nested Frameset Definition.
/// </summary>
public class Frameset
{
  /// <summary>
  /// Frameset Splitter Properties.
  /// </summary>
  public FramesetSplitbar? FramesetSplitbar
  {
    get;
    set;
  }
  
  /// <summary>
  /// Frameset Layout.
  /// </summary>
  public FrameLayoutKind? FrameLayout
  {
    get;
    set;
  }
  
}
