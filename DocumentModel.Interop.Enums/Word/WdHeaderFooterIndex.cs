namespace DocumentModel.Interop.Word;

/// <summary>
/// Returns the specified header or footer in a document or section.
/// </summary>
public enum WdHeaderFooterIndex
{
  /// <summary>
  /// Returns the specified header or footer in a document or section.
  /// </summary>
  Primary = 1,
  /// <summary>
  /// Returns the first header or footer in a document or section.
  /// </summary>
  FirstPage = 2,
  /// <summary>
  /// Returns all headers or footers on even-numbered pages.
  /// </summary>
  EvenPages = 3
}
