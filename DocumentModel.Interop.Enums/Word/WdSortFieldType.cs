namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the sort type to apply when sorting a column.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsortfieldtype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdSortFieldType
{
  /// <summary>
  /// Alphanumeric order.
  /// </summary>
  Alphanumeric = 0,
  /// <summary>
  /// Numeric order.
  /// </summary>
  Numeric = 1,
  /// <summary>
  /// Date order.
  /// </summary>
  Date = 2,
  /// <summary>
  /// Syllable order.
  /// </summary>
  Syllable = 3,
  /// <summary>
  /// Japanese JIS order.
  /// </summary>
  JapanJIS = 4,
  /// <summary>
  /// Stroke order.
  /// </summary>
  Stroke = 5,
  /// <summary>
  /// Korean KS order.
  /// </summary>
  KoreaKS = 6
}
