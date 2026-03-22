namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how much of the document to export.
/// </summary>
public enum WdExportRange
{
  /// <summary>
  /// Specifies how much of the document to export.
  /// </summary>
  wdExportAllDocument = unchecked((int)0),
  /// <summary>
  /// Exports the contents of the current selection.
  /// </summary>
  wdExportSelection = unchecked((int)1),
  /// <summary>
  /// Exports the current page.
  /// </summary>
  wdExportCurrentPage = unchecked((int)2),
  /// <summary>
  /// Exports the contents of a range using the starting and ending positions.
  /// </summary>
  wdExportFromTo = unchecked((int)3)
}
