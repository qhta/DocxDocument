namespace DocumentModel.Presentation;

/// <summary>
/// Presentation-wide Properties.
/// </summary>
public interface IPresentationProperties // : DocumentModel.ITypedOpenXmlPartRootElement
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
  public IColorMostRecentlyUsed? ColorMostRecentlyUsed { get ; set; }
  
  /// <summary>
  /// PresentationPropertiesExtensionList.
  /// </summary>
  public IPresentationPropertiesExtensionList? PresentationPropertiesExtensionList { get ; set; }
  
  /// <summary>
  /// Gets the PresentationPropertiesPart associated with this element.
  /// </summary>
  public PresentationPropertiesPart? PresentationPropertiesPart { get ; set; }
  
}
