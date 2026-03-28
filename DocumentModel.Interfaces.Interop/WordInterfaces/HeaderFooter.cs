namespace DocumentModel.Interop;

/// <summary>
/// Represents a single header or footer.
/// </summary>
public interface HeaderFooter : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }
  /// <summary>
  /// The index.
  /// </summary>
  public WdHeaderFooterIndex Index { get; }
  /// <summary>
  /// The is header.
  /// </summary>
  public bool IsHeader { get; }
  /// <summary>
  /// The exists.
  /// </summary>
  public bool Exists { get; set; }
  /// <summary>
  /// The page numbers.
  /// </summary>
  public PageNumbers PageNumbers { get; }
  /// <summary>
  /// The link to previous.
  /// </summary>
  public bool LinkToPrevious { get; set; }
  /// <summary>
  /// The shapes.
  /// </summary>
  public Shapes Shapes { get; }

}
