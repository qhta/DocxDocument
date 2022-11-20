namespace DocumentModel.Presentation;

/// <summary>
/// Slide Background.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IBackgroundStyleReference))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IBackgroundProperties))]
public interface IBackground // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public BlackWhiteModeValues? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Background Properties.
  /// </summary>
  public DocumentModel.Presentation.IBackgroundProperties? BackgroundProperties { get ; set; }
  
  /// <summary>
  /// Background Style Reference.
  /// </summary>
  public IBackgroundStyleReference? BackgroundStyleReference { get ; set; }
  
}
