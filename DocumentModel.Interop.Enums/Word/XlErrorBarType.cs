namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the range marked by error bars.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlerrorbartype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlErrorBarType))]
public enum ErrorBarType
{
  /// <summary>
  /// Fixed-length error bars.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlErrorBarType.xlErrorBarTypeFixedValue))]
  FixedValue = 1,
  /// <summary>
  /// Percentage of range to be covered by the error bars.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlErrorBarType.xlErrorBarTypePercent))]
  Percent = 2,
  /// <summary>
  /// Shows standard error range.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlErrorBarType.xlErrorBarTypeStError))]
  StError = 4,
  /// <summary>
  /// Shows range for specified number of standard deviations.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlErrorBarType.xlErrorBarTypeStDev))]
  StDev = -4155,
  /// <summary>
  /// Range is set by fixed values or cell values.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlErrorBarType.xlErrorBarTypeCustom))]
  Custom = -4114
}
