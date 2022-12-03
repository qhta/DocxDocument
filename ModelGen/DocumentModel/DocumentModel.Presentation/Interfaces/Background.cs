namespace DocumentModel.Presentation;

/// <summary>
/// Slide Background.
/// </summary>
public interface Background // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public DocumentModel.Drawings.BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Background Properties.
  /// </summary>
  public BackgroundProperties? BackgroundProperties { get ; set; }
  
  /// <summary>
  /// Background Style Reference.
  /// </summary>
  public BackgroundStyleReference? BackgroundStyleReference { get ; set; }
  
}
