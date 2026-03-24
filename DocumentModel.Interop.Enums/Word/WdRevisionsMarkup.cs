namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent the extent of markup visible in the document, returned by and passed to the
/// RevisionsFilter.MarkupProperty(Word) property.
/// </summary>
public enum WdRevisionsMarkup
{
  /// <summary>
  /// Constants that represent the extent of markup visible in the document, returned by and passed to the
  /// RevisionsFilter.MarkupProperty(Word) property.
  /// </summary>
  None = 0,
  /// <summary>
  /// Constants that represent the extent of markup visible in the document, returned by and passed to the
  /// RevisionsFilter.MarkupProperty(Word) property.
  /// </summary>
  Simple = 1,
  /// <summary>
  /// Displays the final document with all markup visible.
  /// </summary>
  All = 2
}
