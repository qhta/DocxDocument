namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Scatter Style
/// </summary>
public enum ScatterStyle
{
  /// <summary>
  /// Line.
  /// </summary>
  [XmlEnum("line")]
  Line,
  
  /// <summary>
  /// Line with Markers.
  /// </summary>
  [XmlEnum("lineMarker")]
  LineMarker,
  
  /// <summary>
  /// Marker.
  /// </summary>
  [XmlEnum("marker")]
  Marker,
  
  /// <summary>
  /// Smooth.
  /// </summary>
  [XmlEnum("smooth")]
  Smooth,
  
  /// <summary>
  /// Smooth with Markers.
  /// </summary>
  [XmlEnum("smoothMarker")]
  SmoothMarker,
  
}
