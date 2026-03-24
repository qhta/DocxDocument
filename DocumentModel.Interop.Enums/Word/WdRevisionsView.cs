namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether Word displays the original version of a document or a version with revisions and formatting
/// changes applied.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisionsview?view=office-pia` for Office interop details.
/// </remarks>
public enum WdRevisionsView
{
  /// <summary>
  /// Specifies whether Word displays the original version of a document or a version with revisions and formatting
  /// changes applied.
  /// </summary>
  Final = 0,
  /// <summary>
  /// Specifies whether Word displays the original version of a document or a version with revisions and formatting
  /// changes applied.
  /// </summary>
  Original = 1
}
