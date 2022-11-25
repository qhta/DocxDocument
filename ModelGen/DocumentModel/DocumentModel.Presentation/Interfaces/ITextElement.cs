namespace DocumentModel.Presentation;

/// <summary>
/// Text Element.
/// </summary>
public interface ITextElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Character Range.
  /// </summary>
  public DocumentModel.Presentation.IIndexRangeType? CharRange { get ; set; }
  
  /// <summary>
  /// Paragraph Text Range.
  /// </summary>
  public DocumentModel.Presentation.IIndexRangeType? ParagraphIndexRange { get ; set; }
  
}
