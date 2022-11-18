namespace DocumentModel.Presentation;

/// <summary>
/// HTML Publishing Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICustomShowReference))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISlideAll))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISlideRange))]
public interface IHtmlPublishProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Show Speaker Notes
  /// </summary>
  public bool? ShowSpeakerNotes { get ; set; }
  
  /// <summary>
  /// Browser Support Target
  /// </summary>
  public HtmlPublishWebBrowserSupport? TargetBrowser { get ; set; }
  
  /// <summary>
  /// Publish Path
  /// </summary>
  public string? Id { get ; set; }
  
}
