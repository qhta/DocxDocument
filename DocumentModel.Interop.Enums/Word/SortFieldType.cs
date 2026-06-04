namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the sort type to apply when sorting a column.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsortfieldtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdSortFieldType))]
public enum SortFieldType
{
  /// <summary>
  /// Alphanumeric order.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSortFieldType.wdSortFieldAlphanumeric))]
  Alphanumeric = 0,
  /// <summary>
  /// Numeric order.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSortFieldType.wdSortFieldNumeric))]
  Numeric = 1,
  /// <summary>
  /// Date order.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSortFieldType.wdSortFieldDate))]
  Date = 2,
  /// <summary>
  /// Syllable order.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSortFieldType.wdSortFieldSyllable))]
  Syllable = 3,
  /// <summary>
  /// Japanese JIS order.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSortFieldType.wdSortFieldJapanJIS))]
  JapanJIS = 4,
  /// <summary>
  /// Stroke order.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSortFieldType.wdSortFieldStroke))]
  Stroke = 5,
  /// <summary>
  /// Korean KS order.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSortFieldType.wdSortFieldKoreaKS))]
  KoreaKS = 6
}
