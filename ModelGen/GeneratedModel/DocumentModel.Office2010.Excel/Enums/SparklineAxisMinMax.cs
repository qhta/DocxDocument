namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SparklineAxisMinMaxValues enumeration.
/// </summary>
public enum SparklineAxisMinMax
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
