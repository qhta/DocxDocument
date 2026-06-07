namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent column width in reading layout, passed to and returned by the ColumnWidth property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcolumnwidth?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdColumnWidth")]
public enum ColumnWidth
{
  /// <summary>
  /// Narrow column width.
  /// </summary>
  [InteropEnumValue("wdColumnWidthNarrow")]
  Narrow = 1,
  /// <summary>
  /// Default column width.
  /// </summary>
  [InteropEnumValue("wdColumnWidthDefault")]
  Default = 2,
  /// <summary>
  /// Wide column width.
  /// </summary>
  [InteropEnumValue("wdColumnWidthWide")]
  Wide = 3
}
