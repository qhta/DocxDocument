namespace DocumentModel.Presentation;

/// <summary>
/// Presentation-wide Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IColorMostRecentlyUsed))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IHtmlPublishProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IPresentationPropertiesExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IPrintingProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IShowProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IWebProperties))]
public interface IPresentationProperties // : DocumentFormat.OpenXml.TypedOpenXmlPartRootElement
{
  /// <summary>
  /// HTML Publishing Properties.
  /// </summary>
  public IHtmlPublishProperties? HtmlPublishProperties { get ; set; }
  
  /// <summary>
  /// Web Properties.
  /// </summary>
  public IWebProperties? WebProperties { get ; set; }
  
  /// <summary>
  /// PrintingProperties.
  /// </summary>
  public IPrintingProperties? PrintingProperties { get ; set; }
  
  /// <summary>
  /// ShowProperties.
  /// </summary>
  public IShowProperties? ShowProperties { get ; set; }
  
  /// <summary>
  /// ColorMostRecentlyUsed.
  /// </summary>
  public DocumentModel.Presentation.IColorMostRecentlyUsed? ColorMostRecentlyUsed { get ; set; }
  
  /// <summary>
  /// PresentationPropertiesExtensionList.
  /// </summary>
  public IPresentationPropertiesExtensionList? PresentationPropertiesExtensionList { get ; set; }
  
}
