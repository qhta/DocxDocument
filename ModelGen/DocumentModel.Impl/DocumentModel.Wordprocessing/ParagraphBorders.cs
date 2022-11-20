namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ParagraphBorders Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITopBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILeftBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBottomBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRightBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBetweenBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBarBorder))]
public class ParagraphBorders: IParagraphBorders
{
  /// <summary>
  /// Paragraph Border Above Identical Paragraphs.
  /// </summary>
  public DocumentModel.Wordprocessing.ITopBorder? TopBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Left Paragraph Border.
  /// </summary>
  public DocumentModel.Wordprocessing.ILeftBorder? LeftBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public DocumentModel.Wordprocessing.IBottomBorder? BottomBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right Paragraph Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IRightBorder? RightBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public IBetweenBorder? BetweenBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Paragraph Border Between Facing Pages.
  /// </summary>
  public IBarBorder? BarBorder
  {
    get;
    set;
  }
  
}
