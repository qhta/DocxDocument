namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ParagraphBorders Class.
/// </summary>
public interface IParagraphBorders // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Paragraph Border Above Identical Paragraphs.
  /// </summary>
  public ITopBorder? TopBorder { get ; set; }
  
  /// <summary>
  /// Left Paragraph Border.
  /// </summary>
  public ILeftBorder? LeftBorder { get ; set; }
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public IBottomBorder? BottomBorder { get ; set; }
  
  /// <summary>
  /// Right Paragraph Border.
  /// </summary>
  public IRightBorder? RightBorder { get ; set; }
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public IBetweenBorder? BetweenBorder { get ; set; }
  
  /// <summary>
  /// Paragraph Border Between Facing Pages.
  /// </summary>
  public IBarBorder? BarBorder { get ; set; }
  
}
