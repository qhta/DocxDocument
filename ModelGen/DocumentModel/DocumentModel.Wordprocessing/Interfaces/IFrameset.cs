namespace DocumentModel.Wordprocessing;

/// <summary>
/// Nested Frameset Definition.
/// </summary>
public interface IFrameset // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Nested Frameset Size.
  /// </summary>
  public System.String? FrameSize { get ; set; }
  
  /// <summary>
  /// Frameset Splitter Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IFramesetSplitbar? FramesetSplitbar { get ; set; }
  
  /// <summary>
  /// Frameset Layout.
  /// </summary>
  public DocumentModel.Wordprocessing.FrameLayoutKind? FrameLayout { get ; set; }
  
}
