namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of field separator.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsortseparator?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSortSeparator")]
public enum SortSeparator
{
  /// <summary>
  /// Tab.
  /// </summary>
  [WordInteropEnumValue("wdSortSeparateByTabs")]
  Tabs = 0,
  /// <summary>
  /// Comma.
  /// </summary>
  [WordInteropEnumValue("wdSortSeparateByCommas")]
  Commas = 1,
  /// <summary>
  /// Default table separator.
  /// </summary>
  [WordInteropEnumValue("wdSortSeparateByDefaultTableSeparator")]
  DefaultTableSeparator = 2
}
