namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Format Value Object Type
/// </summary>
public enum ConditionalFormatValueObject
{
  /// <summary>
  /// Number.
  /// </summary>
  [XmlEnum("num")]
  Number,
  
  /// <summary>
  /// Percent.
  /// </summary>
  [XmlEnum("percent")]
  Percent,
  
  /// <summary>
  /// Maximum.
  /// </summary>
  [XmlEnum("max")]
  Max,
  
  /// <summary>
  /// Minimum.
  /// </summary>
  [XmlEnum("min")]
  Min,
  
  /// <summary>
  /// Formula.
  /// </summary>
  [XmlEnum("formula")]
  Formula,
  
  /// <summary>
  /// Percentile.
  /// </summary>
  [XmlEnum("percentile")]
  Percentile,
  
}
