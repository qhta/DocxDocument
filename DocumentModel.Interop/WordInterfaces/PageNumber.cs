namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a page number in a header or footer.
/// </summary>
public partial interface PageNumber : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The alignment.
  /// </summary>
  public WdPageNumberAlignment Alignment { get; set; }
}
