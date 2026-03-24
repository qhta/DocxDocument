namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how much of the document to export.
/// </summary>
public enum WdExportRange
{
  /// <summary>
  /// Specifies how much of the document to export.
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
