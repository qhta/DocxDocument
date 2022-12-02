namespace DocumentModel.Wordprocessing;

/// <summary>
/// Nested Frameset Definition.
/// </summary>
public interface IFrameset // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Nested Frameset Size.
  /// </summary>
  public String? FrameSize { get ; set; }
  
  /// <summary>
  /// Frameset Splitter Properties.
  /// </summary>
  public IFramesetSplitbar? FramesetSplitbar { get ; set; }
  
  /// <summary>
  /// Frameset Layout.
  /// </summary>
  public FrameLayoutKind? FrameLayout { get ; set; }
  
  public Collection<IFrameset>? Framesets { get ; set; }
  
  public Collection<IFrame>? Frames { get ; set; }
  
}
