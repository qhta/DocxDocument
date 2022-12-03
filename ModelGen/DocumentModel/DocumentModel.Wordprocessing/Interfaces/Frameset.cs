namespace DocumentModel.Wordprocessing;

/// <summary>
/// Nested Frameset Definition.
/// </summary>
public interface Frameset // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Nested Frameset Size.
  /// </summary>
  public String? FrameSize { get ; set; }
  
  /// <summary>
  /// Frameset Splitter Properties.
  /// </summary>
  public FramesetSplitbar? FramesetSplitbar { get ; set; }
  
  /// <summary>
  /// Frameset Layout.
  /// </summary>
  public FrameLayoutKind? FrameLayout { get ; set; }
  
  public Collection<Frameset>? Framesets { get ; set; }
  
  public Collection<Frame>? Frames { get ; set; }
  
}
