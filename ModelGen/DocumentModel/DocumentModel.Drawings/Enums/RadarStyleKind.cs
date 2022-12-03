namespace DocumentModel.Drawings;

/// <summary>
/// Radar Style
/// </summary>
public enum RadarStyleKind
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
