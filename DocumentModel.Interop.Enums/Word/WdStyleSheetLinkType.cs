namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how to associate a style sheet with the document.
/// </summary>
public enum WdStyleSheetLinkType
{
  /// <summary>
  /// Linked external style sheet.
  /// </summary>
  Linked = unchecked((int)0),
  /// <summary>
  /// Imported internal style sheet.
  /// </summary>
  Imported = unchecked((int)1)
}
