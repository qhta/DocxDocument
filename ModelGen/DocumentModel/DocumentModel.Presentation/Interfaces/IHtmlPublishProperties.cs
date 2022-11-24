namespace DocumentModel.Presentation;

/// <summary>
/// HTML Publishing Properties.
/// </summary>
public interface IHtmlPublishProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Show Speaker Notes
  /// </summary>
  public Boolean? ShowSpeakerNotes { get ; set; }
  
  /// <summary>
  /// Browser Support Target
  /// </summary>
  public HtmlPublishWebBrowserSupportValues? TargetBrowser { get ; set; }
  
  /// <summary>
  /// Publish Path
  /// </summary>
  public String? Id { get ; set; }
  
}
