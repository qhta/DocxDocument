namespace DocumentModel.Wordprocessing;

/// <summary>
/// Nested Frameset Definition.
/// </summary>
public partial interface Frameset
{
  /// <summary>
  /// Nested Frameset Size.
  /// </summary>
  public String? FrameSize { get; set; }
  
  /// <summary>
  /// Frameset Splitter Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.FramesetSplitbar? FramesetSplitbar { get; set; }
  
  /// <summary>
  /// Frameset Layout.
  /// </summary>
  public DocumentModel.Wordprocessing.FrameLayoutKind? FrameLayout { get; set; }
  
  public DocumentModel.Wordprocessing.Frameset? ChildFrameset { get; set; }
  
  public DocumentModel.Wordprocessing.Frame? Frame { get; set; }
  
}
