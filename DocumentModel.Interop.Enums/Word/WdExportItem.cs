namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether to export the document with markup.
/// </summary>
public enum WdExportItem
{
  /// <summary>
  /// Exports the document without markup.
  /// </summary>
  Content = unchecked((int)0),
  /// <summary>
  /// Exports the document with markup.
  /// </summary>
  WithMarkup = unchecked((int)7)
}
