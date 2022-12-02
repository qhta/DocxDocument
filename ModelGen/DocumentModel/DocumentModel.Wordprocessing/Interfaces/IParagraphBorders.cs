namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ParagraphBorders Class.
/// </summary>
public interface IParagraphBorders // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Paragraph Border Above Identical Paragraphs.
  /// </summary>
  public IBorderType? TopBorder { get ; set; }
  
  /// <summary>
  /// Left Paragraph Border.
  /// </summary>
  public IBorderType? LeftBorder { get ; set; }
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public IBorderType? BottomBorder { get ; set; }
  
  /// <summary>
  /// Right Paragraph Border.
  /// </summary>
  public IBorderType? RightBorder { get ; set; }
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public IBorderType? BetweenBorder { get ; set; }
  
  /// <summary>
  /// Paragraph Border Between Facing Pages.
  /// </summary>
  public IBorderType? BarBorder { get ; set; }
  
}
