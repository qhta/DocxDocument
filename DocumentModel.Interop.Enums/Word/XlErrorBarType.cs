namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the range marked by error bars.
/// </summary>
public enum XlErrorBarType
{
  /// <summary>
  /// Fixed-length error bars.
  /// </summary>
  xlErrorBarTypeFixedValue = unchecked((int)1),
  /// <summary>
  /// Percentage of range to be covered by the error bars.
  /// </summary>
  xlErrorBarTypePercent = unchecked((int)2),
  /// <summary>
  /// Shows standard error range.
  /// </summary>
  xlErrorBarTypeStError = unchecked((int)4),
  /// <summary>
  /// Specifies the range marked by error bars.
  /// </summary>
  xlErrorBarTypeStDev = unchecked((int)-4155),
  /// <summary>
  /// Specifies the range marked by error bars.
  /// </summary>
  xlErrorBarTypeCustom = unchecked((int)-4114)
}
