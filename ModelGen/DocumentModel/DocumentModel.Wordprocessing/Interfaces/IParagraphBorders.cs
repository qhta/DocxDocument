namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ParagraphBorders Class.
/// </summary>
public interface IParagraphBorders // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Paragraph Border Above Identical Paragraphs.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? TopBorder { get ; set; }
  
  /// <summary>
  /// Left Paragraph Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? LeftBorder { get ; set; }
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? BottomBorder { get ; set; }
  
  /// <summary>
  /// Right Paragraph Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? RightBorder { get ; set; }
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? BetweenBorder { get ; set; }
  
  /// <summary>
  /// Paragraph Border Between Facing Pages.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? BarBorder { get ; set; }
  
}
