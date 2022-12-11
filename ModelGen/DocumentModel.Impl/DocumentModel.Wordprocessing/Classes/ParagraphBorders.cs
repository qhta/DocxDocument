namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ParagraphBorders Class.
/// </summary>
public class ParagraphBordersImpl: ModelElementImpl, ParagraphBorders
{
  public DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ParagraphBordersImpl(): base() {}
  
  public ParagraphBordersImpl(DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Paragraph Border Above Identical Paragraphs.
  /// </summary>
  public BorderType? TopBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Left Paragraph Border.
  /// </summary>
  public BorderType? LeftBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public BorderType? BottomBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Right Paragraph Border.
  /// </summary>
  public BorderType? RightBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public BorderType? BetweenBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Paragraph Border Between Facing Pages.
  /// </summary>
  public BorderType? BarBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
