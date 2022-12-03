namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SparklineAxisMinMaxValues enumeration.
/// </summary>
public enum SparklineAxisMinMaxKind
{
  /// <summary>
  /// individual.
  /// </summary>
  [XmlEnum("individual")]
  Individual,
  
  /// <summary>
  /// group.
  /// </summary>
  [XmlEnum("group")]
  Group,
  
  /// <summary>
  /// custom.
  /// </summary>
  [XmlEnum("custom")]
  Custom,
  
}
