namespace DocumentModel.Presentation;

/// <summary>
/// Presentation-wide Properties.
/// </summary>
public interface IPresentationProperties // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// HTML Publishing Properties.
  /// </summary>
  public DocumentModel.Presentation.IHtmlPublishProperties? HtmlPublishProperties { get ; set; }
  
  /// <summary>
  /// Web Properties.
  /// </summary>
  public DocumentModel.Presentation.IWebProperties? WebProperties { get ; set; }
  
  /// <summary>
  /// PrintingProperties.
  /// </summary>
  public DocumentModel.Presentation.IPrintingProperties? PrintingProperties { get ; set; }
  
  /// <summary>
  /// ShowProperties.
  /// </summary>
  public DocumentModel.Presentation.IShowProperties? ShowProperties { get ; set; }
  
  /// <summary>
  /// ColorMostRecentlyUsed.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ColorMostRecentlyUsed { get ; set; }
  
  /// <summary>
  /// PresentationPropertiesExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? PresentationPropertiesExtensionList { get ; set; }
  
}
