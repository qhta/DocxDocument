namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the borders for the parent paragraph. Each child element shall specify a specific kind of border (left, right, bottom, top, and between).
/// </summary>
public partial class ParagraphBorders
{
  
  /// <summary>
  ///   Paragraph Border Above Identical Paragraphs.
  /// </summary>
  public DocumentModel.Wordprocessing.TopBorder? TopBorder { get; set; }
  
  
  /// <summary>
  ///   Left Paragraph Border.
  /// </summary>
  public DocumentModel.Wordprocessing.LeftBorder? LeftBorder { get; set; }
  
  
  /// <summary>
  ///   Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public DocumentModel.Wordprocessing.BottomBorder? BottomBorder { get; set; }
  
  
  /// <summary>
  ///   Right Paragraph Border.
  /// </summary>
  public DocumentModel.Wordprocessing.RightBorder? RightBorder { get; set; }
  
  
  /// <summary>
  ///   Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public DocumentModel.Wordprocessing.BetweenBorder? BetweenBorder { get; set; }
  
  
  /// <summary>
  ///   Paragraph Border Between Facing Pages.
  /// </summary>
  public DocumentModel.Wordprocessing.BarBorder? BarBorder { get; set; }
  
}
