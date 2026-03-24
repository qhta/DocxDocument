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
  None = unchecked((int)0),
  /// <summary>
  /// Constants that represent the extent of markup visible in the document, returned by and passed to the
  /// RevisionsFilter.MarkupProperty(Word) property.
  /// </summary>
  Simple = unchecked((int)1),
  /// <summary>
  /// Displays the final document with all markup visible.
  /// </summary>
  All = unchecked((int)2)
}
