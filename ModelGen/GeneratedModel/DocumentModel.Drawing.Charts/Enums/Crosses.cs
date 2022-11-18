namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Crosses
/// </summary>
public enum Crosses
{
  /// <summary>
  /// Axis Crosses at Zero.
  /// </summary>
  [XmlEnum("autoZero")]
  AutoZero,
  
  /// <summary>
  /// Maximum.
  /// </summary>
  [XmlEnum("max")]
  Maximum,
  
  /// <summary>
  /// Minimum.
  /// </summary>
  [XmlEnum("min")]
  Minimum,
  
}
