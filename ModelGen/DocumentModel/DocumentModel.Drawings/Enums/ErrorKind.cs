namespace DocumentModel.Drawings;

/// <summary>
/// Error Value Type
/// </summary>
public enum ErrorKind
{
  /// <summary>
  /// Custom Error Bars.
  /// </summary>
  [XmlEnum("cust")]
  Custom,
  
  /// <summary>
  /// Fixed Value.
  /// </summary>
  [XmlEnum("fixedVal")]
  FixedValue,
  
  /// <summary>
  /// Percentage.
  /// </summary>
  [XmlEnum("percentage")]
  Percentage,
  
  /// <summary>
  /// Standard Deviation.
  /// </summary>
  [XmlEnum("stdDev")]
  StandardDeviation,
  
  /// <summary>
  /// Standard Error.
  /// </summary>
  [XmlEnum("stdErr")]
  StandardError,
  
}
