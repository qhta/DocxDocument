namespace DocumentModel.Interop.Word;

/// <summary>
/// Returns the specified header or footer in a document or section.
/// </summary>
public enum WdHeaderFooterIndex
{
  /// <summary>
  /// Returns the specified header or footer in a document or section.
  /// </summary>
  wdHeaderFooterPrimary = unchecked((int)1),
  /// <summary>
  /// Returns the first header or footer in a document or section.
  /// </summary>
  wdHeaderFooterFirstPage = unchecked((int)2),
  /// <summary>
  /// Returns all headers or footers on even-numbered pages.
  /// </summary>
  wdHeaderFooterEvenPages = unchecked((int)3)
}
