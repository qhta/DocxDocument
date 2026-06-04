namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the sort type to apply when sorting a column.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsortfieldtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSortFieldType")]
public enum SortFieldType
{
  /// <summary>
  /// Alphanumeric order.
  /// </summary>
  [WordInteropEnumValue("wdSortFieldAlphanumeric")]
  Alphanumeric = 0,
  /// <summary>
  /// Numeric order.
  /// </summary>
  [WordInteropEnumValue("wdSortFieldNumeric")]
  Numeric = 1,
  /// <summary>
  /// Date order.
  /// </summary>
  [WordInteropEnumValue("wdSortFieldDate")]
  Date = 2,
  /// <summary>
  /// Syllable order.
  /// </summary>
  [WordInteropEnumValue("wdSortFieldSyllable")]
  Syllable = 3,
  /// <summary>
  /// Japanese JIS order.
  /// </summary>
  [WordInteropEnumValue("wdSortFieldJapanJIS")]
  JapanJIS = 4,
  /// <summary>
  /// Stroke order.
  /// </summary>
  [WordInteropEnumValue("wdSortFieldStroke")]
  Stroke = 5,
  /// <summary>
  /// Korean KS order.
  /// </summary>
  [WordInteropEnumValue("wdSortFieldKoreaKS")]
  KoreaKS = 6
}
