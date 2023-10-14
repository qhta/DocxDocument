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
  public DocumentModel.Wordprocessing.BlockQuote? BlockQuote { get; set; }
  
  
  /// <summary>
  ///   Data for HTML body Element.
  /// </summary>
  public DocumentModel.Wordprocessing.BodyDiv? BodyDiv { get; set; }
  
  
  /// <summary>
  ///   Left Margin for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.LeftMarginDiv? LeftMarginDiv { get; set; }
  
  
  /// <summary>
  ///   Right Margin for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.RightMarginDiv? RightMarginDiv { get; set; }
  
  
  /// <summary>
  ///   Top Margin for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.TopMarginDiv? TopMarginDiv { get; set; }
  
  
  /// <summary>
  ///   Bottom Margin for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.BottomMarginDiv? BottomMarginDiv { get; set; }
  
  
  /// <summary>
  ///   Set of Borders for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.DivBorder? DivBorder { get; set; }
  
  public DM.ElementCollection<DivsChild>? Items { get; set; }
  
}
