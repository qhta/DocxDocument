namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character to use to separate text into cells when converting text to a table, or to delimit
/// converted columns when converting a table to text (paragraph marks delimit converted rows).
/// </summary>
public enum WdTableFieldSeparator
{
  /// <summary>
  /// Paragraph markers.
  /// </summary>
  Paragraphs = 0,
  /// <summary>
  /// A tab.
  /// </summary>
  Tabs = 1,
  /// <summary>
  /// A comma.
  /// </summary>
  Commas = 2,
  /// <summary>
  /// The default list separator.
  /// </summary>
  DefaultListSeparator = 3
}
