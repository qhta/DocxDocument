namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SparklineTypeValues enumeration.
/// </summary>
public enum SparklineTypeValues
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
