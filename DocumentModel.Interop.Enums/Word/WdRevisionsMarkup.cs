namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent the extent of markup visible in the document, returned by and passed to the
/// RevisionsFilter.MarkupProperty(Word) property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisionsmarkup?view=office-pia` for Office interop details.
/// </remarks>
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
  /// Constants that represent the extent of markup visible in the document, returned by and passed to the
  /// RevisionsFilter.MarkupProperty(Word) property.
  /// </summary>
  All = 2
}
