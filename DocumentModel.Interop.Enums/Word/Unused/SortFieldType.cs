namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the sort type to apply when sorting a column.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsortfieldtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSortFieldType")]
public enum SortFieldType
{
  /// <summary>
  /// Alphanumeric order.
  /// </summary>
  [InteropEnumValue("wdSortFieldAlphanumeric")]
  Alphanumeric = 0,
  /// <summary>
  /// Numeric order.
  /// </summary>
  [InteropEnumValue("wdSortFieldNumeric")]
  Numeric = 1,
  /// <summary>
  /// Date order.
  /// </summary>
  [InteropEnumValue("wdSortFieldDate")]
  Date = 2,
  /// <summary>
  /// Syllable order.
  /// </summary>
  [InteropEnumValue("wdSortFieldSyllable")]
  Syllable = 3,
  /// <summary>
  /// Japanese JIS order.
  /// </summary>
  [InteropEnumValue("wdSortFieldJapanJIS")]
  JapanJIS = 4,
  /// <summary>
  /// Stroke order.
  /// </summary>
  [InteropEnumValue("wdSortFieldStroke")]
  Stroke = 5,
  /// <summary>
  /// Korean KS order.
  /// </summary>
  [InteropEnumValue("wdSortFieldKoreaKS")]
  KoreaKS = 6
}
