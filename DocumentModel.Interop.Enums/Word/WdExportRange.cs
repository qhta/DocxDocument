namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how much of the document to export.
/// </summary>
public enum WdExportRange
{
  /// <summary>
  /// Specifies how much of the document to export.
  /// </summary>
  AllDocument = unchecked((int)0),
  /// <summary>
  /// Exports the contents of the current selection.
  /// </summary>
  Selection = unchecked((int)1),
  /// <summary>
  /// Exports the current page.
  /// </summary>
  CurrentPage = unchecked((int)2),
  /// <summary>
  /// Exports the contents of a range using the starting and ending positions.
  /// </summary>
  FromTo = unchecked((int)3)
}
