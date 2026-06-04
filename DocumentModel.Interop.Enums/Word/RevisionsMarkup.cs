namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent the extent of markup visible in the document, returned by and passed to the
/// RevisionsFilter.MarkupProperty(Word) property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisionsmarkup?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdRevisionsMarkup")]
public enum RevisionsMarkup
{
  /// <summary>
  /// Displays the final document with no markup visible.
  /// </summary>
  [WordInteropEnumValue("wdRevisionsMarkupNone")]
  None = 0,
  /// <summary>
  /// Displays the final document in simple markup: with revisions incorporated, but with no markup visible.
  /// </summary>
  [WordInteropEnumValue("wdRevisionsMarkupSimple")]
  Simple = 1,
  /// <summary>
  /// Displays the final document with all markup visible.
  /// </summary>
  [WordInteropEnumValue("wdRevisionsMarkupAll")]
  All = 2
}
