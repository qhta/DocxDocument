namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the presence of a structured document tag around one or more block-level structures (paragraphs, tables, etc.).
/// </summary>
public class SdtBlock: ElementCollection<ISdtBlockContent>, IBodyContent, ITableCellContent, ISdtBlockContent, ICommentContent
{
  /// <summary>
  ///  Specifies the set of properties which shall be applied to this structured document tag.
  /// </summary>
  public SdtProperties? SdtProperties { get; set; }

  /// <summary>
  /// Specifies the properties which shall be applied to the physical character which delimits the end of a structured document tag.
  /// </summary>
  public SdtEndCharProperties? SdtEndCharProperties { get; set; }
}