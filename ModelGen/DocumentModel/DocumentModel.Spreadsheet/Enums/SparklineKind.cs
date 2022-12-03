namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SparklineTypeValues enumeration.
/// </summary>
public enum SparklineKind
{
  /// <summary>
  /// line.
  /// </summary>
  [XmlEnum("line")]
  Line,
  
  /// <summary>
  /// column.
  /// </summary>
  [XmlEnum("column")]
  Column,
  
  /// <summary>
  /// stacked.
  /// </summary>
  [XmlEnum("stacked")]
  Stacked,
  
}
