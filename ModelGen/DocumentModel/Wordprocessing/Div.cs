namespace DocumentModel.Wordprocessing;


/// <summary>
///   Information About Single HTML div Element.
/// </summary>
public partial class Div
{
  
  /// <summary>
  ///   div Data ID
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Data for HTML blockquote Element.
  /// </summary>
  public DMW.BlockQuote? BlockQuote { get; set; }
  
  
  /// <summary>
  ///   Data for HTML body Element.
  /// </summary>
  public DMW.BodyDiv? BodyDiv { get; set; }
  
  
  /// <summary>
  ///   Left Margin for HTML div.
  /// </summary>
  public DMW.LeftMarginDiv? LeftMarginDiv { get; set; }
  
  
  /// <summary>
  ///   Right Margin for HTML div.
  /// </summary>
  public DMW.RightMarginDiv? RightMarginDiv { get; set; }
  
  
  /// <summary>
  ///   Top Margin for HTML div.
  /// </summary>
  public DMW.TopMarginDiv? TopMarginDiv { get; set; }
  
  
  /// <summary>
  ///   Bottom Margin for HTML div.
  /// </summary>
  public DMW.BottomMarginDiv? BottomMarginDiv { get; set; }
  
  
  /// <summary>
  ///   Set of Borders for HTML div.
  /// </summary>
  public DMW.DivBorder? DivBorder { get; set; }
  
}
