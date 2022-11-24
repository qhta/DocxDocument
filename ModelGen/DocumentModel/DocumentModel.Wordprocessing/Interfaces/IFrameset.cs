namespace DocumentModel.Wordprocessing;

/// <summary>
/// Nested Frameset Definition.
/// </summary>
public interface IFrameset // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Nested Frameset Size.
  /// </summary>
  public IFrameSize? FrameSize { get ; set; }
  
  /// <summary>
  /// Frameset Splitter Properties.
  /// </summary>
  public IFramesetSplitbar? FramesetSplitbar { get ; set; }
  
  /// <summary>
  /// Frameset Layout.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues>? FrameLayout { get ; set; }
  
}
