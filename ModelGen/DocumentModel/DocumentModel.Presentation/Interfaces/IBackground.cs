namespace DocumentModel.Presentation;

/// <summary>
/// Slide Background.
/// </summary>
public interface IBackground // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public DocumentModel.Drawing.BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Background Properties.
  /// </summary>
  public IBackgroundProperties? BackgroundProperties { get ; set; }
  
  /// <summary>
  /// Background Style Reference.
  /// </summary>
  public IBackgroundStyleReference? BackgroundStyleReference { get ; set; }
  
}
