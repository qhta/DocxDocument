namespace DocumentModel.Presentation;

/// <summary>
/// Text Element.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICharRange))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IParagraphIndexRange))]
public class TextElement: ITextElement
{
  /// <summary>
  /// Character Range.
  /// </summary>
  public ICharRange? CharRange
  {
    get;
    set;
  }
  
  /// <summary>
  /// Paragraph Text Range.
  /// </summary>
  public IParagraphIndexRange? ParagraphIndexRange
  {
    get;
    set;
  }
  
}
