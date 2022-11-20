namespace DocumentModel.Wordprocessing;

/// <summary>
/// Information About Single HTML div Element.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDivBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDivsChild))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBlockQuote))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBodyDiv))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILeftMarginDiv))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRightMarginDiv))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITopMarginDiv))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBottomMarginDiv))]
public class Div: IDiv
{
  /// <summary>
  /// div Data ID
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data for HTML blockquote Element.
  /// </summary>
  public IBlockQuote? BlockQuote
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data for HTML body Element.
  /// </summary>
  public IBodyDiv? BodyDiv
  {
    get;
    set;
  }
  
  /// <summary>
  /// Left Margin for HTML div.
  /// </summary>
  public ILeftMarginDiv? LeftMarginDiv
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right Margin for HTML div.
  /// </summary>
  public IRightMarginDiv? RightMarginDiv
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top Margin for HTML div.
  /// </summary>
  public ITopMarginDiv? TopMarginDiv
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom Margin for HTML div.
  /// </summary>
  public IBottomMarginDiv? BottomMarginDiv
  {
    get;
    set;
  }
  
  /// <summary>
  /// Set of Borders for HTML div.
  /// </summary>
  public IDivBorder? DivBorder
  {
    get;
    set;
  }
  
}
