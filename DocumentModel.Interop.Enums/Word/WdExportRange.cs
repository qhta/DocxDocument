namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how much of the document to export.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdexportrange?view=office-pia` for Office interop details.
/// </remarks>
public enum ExportRange
{
  /// <summary>
  /// Exports the entire document.
  /// </summary>
  AllDocument = 0,
  /// <summary>
  /// Exports the contents of the current selection.
  /// </summary>
  Selection = 1,
  /// <summary>
  /// Exports the current page.
  /// </summary>
  CurrentPage = 2,
  /// <summary>
  /// Exports the contents of a range using the starting and ending positions.
  /// </summary>
  FromTo = 3
}
