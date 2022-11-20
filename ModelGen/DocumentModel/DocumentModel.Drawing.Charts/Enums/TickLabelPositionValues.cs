namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Tick Label Position
/// </summary>
public enum TickLabelPositionValues
{
  /// <summary>
  /// High.
  /// </summary>
  [XmlEnum("high")]
  High,
  
  /// <summary>
  /// Low.
  /// </summary>
  [XmlEnum("low")]
  Low,
  
  /// <summary>
  /// Next To.
  /// </summary>
  [XmlEnum("nextTo")]
  NextTo,
  
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}
