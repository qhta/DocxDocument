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
  wdSeparateByParagraphs = unchecked((int)0),
  /// <summary>
  /// A tab.
  /// </summary>
  wdSeparateByTabs = unchecked((int)1),
  /// <summary>
  /// A comma.
  /// </summary>
  wdSeparateByCommas = unchecked((int)2),
  /// <summary>
  /// The default list separator.
  /// </summary>
  wdSeparateByDefaultListSeparator = unchecked((int)3)
}
