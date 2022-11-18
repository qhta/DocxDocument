namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Orientation
/// </summary>
public enum Orientation
{
  /// <summary>
  /// Maximum to Minimum.
  /// </summary>
  [XmlEnum("maxMin")]
  MaxMin,
  
  /// <summary>
  /// Minimum to Maximum.
  /// </summary>
  [XmlEnum("minMax")]
  MinMax,
  
}
