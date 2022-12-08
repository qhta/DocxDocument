namespace DocumentModel.Wordprocessing;

/// <summary>
/// Information About Single HTML div Element.
/// </summary>
public class DivImpl: ModelElementImpl, Div
{
  public DocumentFormat.OpenXml.Wordprocessing.Div? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Div?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// div Data ID
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data for HTML blockquote Element.
  /// </summary>
  public Boolean? BlockQuote
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data for HTML body Element.
  /// </summary>
  public Boolean? BodyDiv
  {
    get;
    set;
  }
  
  /// <summary>
  /// Left Margin for HTML div.
  /// </summary>
  public String? LeftMarginDiv
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right Margin for HTML div.
  /// </summary>
  public String? RightMarginDiv
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top Margin for HTML div.
  /// </summary>
  public String? TopMarginDiv
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom Margin for HTML div.
  /// </summary>
  public String? BottomMarginDiv
  {
    get;
    set;
  }
  
  /// <summary>
  /// Set of Borders for HTML div.
  /// </summary>
  public DivBorder? DivBorder
  {
    get;
    set;
  }
  
  public Collection<DivsChild>? DivsChilds
  {
    get;
    set;
  }
  
}
