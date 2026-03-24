namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the item to print.
/// </summary>
public enum WdPrintOutItem
{
  /// <summary>
  /// Current document content.
  /// </summary>
  DocumentContent = unchecked((int)0),
  /// <summary>
  /// Properties in the current document.
  /// </summary>
  Properties = unchecked((int)1),
  /// <summary>
  /// Comments in the current document.
  /// </summary>
  Comments = unchecked((int)2),
  /// <summary>
  /// Markup in the current document.
  /// </summary>
  Markup = unchecked((int)2),
  /// <summary>
  /// Styles in the current document.
  /// </summary>
  Styles = unchecked((int)3),
  /// <summary>
  /// Autotext entries in the current document.
  /// </summary>
  AutoTextEntries = unchecked((int)4),
  /// <summary>
  /// Key assignments in the current document.
  /// </summary>
  KeyAssignments = unchecked((int)5),
  /// <summary>
  /// An envelope. wdPrintDocumentWithMarkup7 Current document content including markup.
  /// </summary>
  Envelope = unchecked((int)6),
  /// <summary>
  /// Specifies the item to print.
  /// </summary>
  DocumentWithMarkup = unchecked((int)7)
}
