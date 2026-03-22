namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the item to print.
/// </summary>
public enum WdPrintOutItem
{
  /// <summary>
  /// Current document content.
  /// </summary>
  wdPrintDocumentContent = unchecked((int)0),
  /// <summary>
  /// Properties in the current document.
  /// </summary>
  wdPrintProperties = unchecked((int)1),
  /// <summary>
  /// Comments in the current document.
  /// </summary>
  wdPrintComments = unchecked((int)2),
  /// <summary>
  /// Markup in the current document.
  /// </summary>
  wdPrintMarkup = unchecked((int)2),
  /// <summary>
  /// Styles in the current document.
  /// </summary>
  wdPrintStyles = unchecked((int)3),
  /// <summary>
  /// Autotext entries in the current document.
  /// </summary>
  wdPrintAutoTextEntries = unchecked((int)4),
  /// <summary>
  /// Key assignments in the current document.
  /// </summary>
  wdPrintKeyAssignments = unchecked((int)5),
  /// <summary>
  /// An envelope. wdPrintDocumentWithMarkup7 Current document content including markup.
  /// </summary>
  wdPrintEnvelope = unchecked((int)6),
  /// <summary>
  /// Specifies the item to print.
  /// </summary>
  wdPrintDocumentWithMarkup = unchecked((int)7)
}
