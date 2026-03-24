namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the range marked by error bars.
/// </summary>
public enum XlErrorBarType
{
  /// <summary>
  /// Fixed-length error bars.
  /// </summary>
  FixedValue = unchecked((int)1),
  /// <summary>
  /// Percentage of range to be covered by the error bars.
  /// </summary>
  Percent = unchecked((int)2),
  /// <summary>
  /// Shows standard error range.
  /// </summary>
  StError = unchecked((int)4),
  /// <summary>
  /// Specifies the range marked by error bars.
  /// </summary>
  StDev = unchecked((int)-4155),
  /// <summary>
  /// Specifies the range marked by error bars.
  /// </summary>
  Custom = unchecked((int)-4114)
}
