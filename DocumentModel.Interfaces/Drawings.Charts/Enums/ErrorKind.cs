namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Error Value Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ErrorKind
{
  /// <summary>
  ///   Custom Error Bars.
  /// </summary>
  Custom,
  /// <summary>
  ///   Fixed Value.
  /// </summary>
  FixedValue,
  /// <summary>
  ///   Percentage.
  /// </summary>
  Percentage,
  /// <summary>
  ///   Standard Deviation.
  /// </summary>
  StandardDeviation,
  /// <summary>
  ///   Standard Error.
  /// </summary>
  StandardError
}