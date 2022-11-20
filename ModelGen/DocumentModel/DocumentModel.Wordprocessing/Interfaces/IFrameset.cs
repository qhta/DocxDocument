namespace DocumentModel.Wordprocessing;

/// <summary>
/// Nested Frameset Definition.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFrame))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFrameLayout))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFrameset))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFramesetSplitbar))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFrameSize))]
public interface IFrameset // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public IFrameLayout? FrameLayout { get ; set; }
  
}
