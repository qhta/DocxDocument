namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of field separator.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsortseparator?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSortSeparator")]
public enum SortSeparator
{
  /// <summary>
  /// Tab.
  /// </summary>
  [InteropEnumValue("wdSortSeparateByTabs")]
  Tabs = 0,
  /// <summary>
  /// Comma.
  /// </summary>
  [InteropEnumValue("wdSortSeparateByCommas")]
  Commas = 1,
  /// <summary>
  /// Default table separator.
  /// </summary>
  [InteropEnumValue("wdSortSeparateByDefaultTableSeparator")]
  DefaultTableSeparator = 2
}
