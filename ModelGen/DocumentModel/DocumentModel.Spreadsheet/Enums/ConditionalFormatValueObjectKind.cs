namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Format Value Object Type
/// </summary>
public enum ConditionalFormatValueObjectKind
{
  /// <summary>
  /// Number.
  /// </summary>
  Number,
  
  /// <summary>
  /// Percent.
  /// </summary>
  Percent,
  
  /// <summary>
  /// Maximum.
  /// </summary>
  Max,
  
  /// <summary>
  /// Minimum.
  /// </summary>
  Min,
  
  /// <summary>
  /// Formula.
  /// </summary>
  Formula,
  
  /// <summary>
  /// Percentile.
  /// </summary>
  Percentile,
  
}
