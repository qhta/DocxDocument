namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Radar Style
/// </summary>
public enum RadarStyle
{
  /// <summary>
  /// Standard.
  /// </summary>
  [XmlEnum("standard")]
  Standard,
  
  /// <summary>
  /// Marker.
  /// </summary>
  [XmlEnum("marker")]
  Marker,
  
  /// <summary>
  /// Filled.
  /// </summary>
  [XmlEnum("filled")]
  Filled,
  
}
