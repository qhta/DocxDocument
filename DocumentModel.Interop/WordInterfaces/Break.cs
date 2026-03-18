namespace DocumentModel.Interop;

/// <summary>
/// Represents individual page, column, and section breaks in a page.
/// </summary>
public interface Break
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }
  /// <summary>
  /// The page index.
  /// </summary>
  public int PageIndex { get; }

}
