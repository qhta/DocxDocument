namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether Word displays the original version of a document or a version with revisions and formatting
/// changes applied.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisionsview?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdRevisionsView")]
public enum RevisionsView
{
  /// <summary>
  /// Displays the document with formatting and content changes applied.
  /// </summary>
  [InteropEnumValue("wdRevisionsViewFinal")]
  Final = 0,
  /// <summary>
  /// Displays the document before changes were made.
  /// </summary>
  [InteropEnumValue("wdRevisionsViewOriginal")]
  Original = 1
}
