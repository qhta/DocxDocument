namespace DocumentModel.Presentation;

/// <summary>
/// Text Element.
/// </summary>
public interface TextElement // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Character Range.
  /// </summary>
  public IndexRangeType? CharRange { get ; set; }
  
  /// <summary>
  /// Paragraph Text Range.
  /// </summary>
  public IndexRangeType? ParagraphIndexRange { get ; set; }
  
}
