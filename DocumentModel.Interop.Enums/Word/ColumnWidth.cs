namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent column width in reading layout, passed to and returned by the ColumnWidth property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcolumnwidth?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdColumnWidth")]
public enum ColumnWidth
{
  /// <summary>
  /// Narrow column width.
  /// </summary>
  [WordInteropEnumValue("wdColumnWidthNarrow")]
  Narrow = 1,
  /// <summary>
  /// Default column width.
  /// </summary>
  [WordInteropEnumValue("wdColumnWidthDefault")]
  Default = 2,
  /// <summary>
  /// Wide column width.
  /// </summary>
  [WordInteropEnumValue("wdColumnWidthWide")]
  Wide = 3
}
