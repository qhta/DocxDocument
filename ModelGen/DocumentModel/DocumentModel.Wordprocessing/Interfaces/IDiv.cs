namespace DocumentModel.Wordprocessing;

/// <summary>
/// Information About Single HTML div Element.
/// </summary>
public interface IDiv // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// div Data ID
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Data for HTML blockquote Element.
  /// </summary>
  public System.Boolean? BlockQuote { get ; set; }
  
  /// <summary>
  /// Data for HTML body Element.
  /// </summary>
  public System.Boolean? BodyDiv { get ; set; }
  
  /// <summary>
  /// Left Margin for HTML div.
  /// </summary>
  public System.String? LeftMarginDiv { get ; set; }
  
  /// <summary>
  /// Right Margin for HTML div.
  /// </summary>
  public System.String? RightMarginDiv { get ; set; }
  
  /// <summary>
  /// Top Margin for HTML div.
  /// </summary>
  public System.String? TopMarginDiv { get ; set; }
  
  /// <summary>
  /// Bottom Margin for HTML div.
  /// </summary>
  public System.String? BottomMarginDiv { get ; set; }
  
  /// <summary>
  /// Set of Borders for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.IDivBorder? DivBorder { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IDivsChild>? DivsChilds { get ; set; }
  
}
