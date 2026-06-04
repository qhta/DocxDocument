namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character to use to separate text into cells when converting text to a table, or to delimit
/// converted columns when converting a table to text (paragraph marks delimit converted rows).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtablefieldseparator?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdTableFieldSeparator))]
public enum TableFieldSeparator
{
  /// <summary>
  /// Paragraph markers.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFieldSeparator.wdSeparateByParagraphs))]
  Paragraphs = 0,
  /// <summary>
  /// A tab.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFieldSeparator.wdSeparateByTabs))]
  Tabs = 1,
  /// <summary>
  /// A comma.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFieldSeparator.wdSeparateByCommas))]
  Commas = 2,
  /// <summary>
  /// The default list separator.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFieldSeparator.wdSeparateByDefaultListSeparator))]
  DefaultListSeparator = 3
}
