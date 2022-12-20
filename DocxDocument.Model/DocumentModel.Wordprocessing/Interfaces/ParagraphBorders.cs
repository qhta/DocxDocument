namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ParagraphBorders Class.
/// </summary>
public partial interface ParagraphBorders
{
  /// <summary>
  /// Paragraph Border Above Identical Paragraphs.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? TopBorder { get; set; }
  
  /// <summary>
  /// Left Paragraph Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? LeftBorder { get; set; }
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? BottomBorder { get; set; }
  
  /// <summary>
  /// Right Paragraph Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? RightBorder { get; set; }
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? BetweenBorder { get; set; }
  
  /// <summary>
  /// Paragraph Border Between Facing Pages.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? BarBorder { get; set; }
  
}
