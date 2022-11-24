namespace DocumentModel.Presentation;

/// <summary>
/// Text Element.
/// </summary>
public interface ITextElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Character Range.
  /// </summary>
  public ICharRange? CharRange { get ; set; }
  
  /// <summary>
  /// Paragraph Text Range.
  /// </summary>
  public IParagraphIndexRange? ParagraphIndexRange { get ; set; }
  
}
