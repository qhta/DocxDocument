namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the range marked by error bars.
/// </summary>
public enum XlErrorBarType
{
  /// <summary>
  /// Fixed-length error bars.
  /// </summary>
  FixedValue = 1,
  /// <summary>
  /// Percentage of range to be covered by the error bars.
  /// </summary>
  Percent = 2,
  /// <summary>
  /// Shows standard error range.
  /// </summary>
  StError = 4,
  /// <summary>
  /// Specifies the range marked by error bars.
  /// </summary>
  StDev = -4155,
  /// <summary>
  /// Specifies the range marked by error bars.
  /// </summary>
  Custom = -4114
}
