namespace DocumentModel.Presentation;

/// <summary>
/// HTML Publishing Properties.
/// </summary>
public interface IHtmlPublishProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Show Speaker Notes
  /// </summary>
  public System.Boolean? ShowSpeakerNotes { get ; set; }
  
  /// <summary>
  /// Browser Support Target
  /// </summary>
  public DocumentModel.Presentation.HtmlPublishWebBrowserSupportKind? TargetBrowser { get ; set; }
  
  /// <summary>
  /// Publish Path
  /// </summary>
  public System.String? Id { get ; set; }
  
}
