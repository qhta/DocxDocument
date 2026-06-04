namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of field separator.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsortseparator?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdSortSeparator))]
public enum SortSeparator
{
  /// <summary>
  /// Tab.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSortSeparator.wdSortSeparateByTabs))]
  Tabs = 0,
  /// <summary>
  /// Comma.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSortSeparator.wdSortSeparateByCommas))]
  Commas = 1,
  /// <summary>
  /// Default table separator.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSortSeparator.wdSortSeparateByDefaultTableSeparator))]
  DefaultTableSeparator = 2
}
