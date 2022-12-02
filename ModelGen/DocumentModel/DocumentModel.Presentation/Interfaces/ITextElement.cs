namespace DocumentModel.Presentation;

/// <summary>
/// Text Element.
/// </summary>
public interface ITextElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Character Range.
  /// </summary>
  public IIndexRangeType? CharRange { get ; set; }
  
  /// <summary>
  /// Paragraph Text Range.
  /// </summary>
  public IIndexRangeType? ParagraphIndexRange { get ; set; }
  
}
