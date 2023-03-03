namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Scatter Style
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ScatterStyleKind
{
  /// <summary>
  ///   Line.
  /// </summary>
  Line,

  /// <summary>
  ///   Line with Markers.
  /// </summary>
  LineMarker,

  /// <summary>
  ///   Marker.
  /// </summary>
  Marker,

  /// <summary>
  ///   Smooth.
  /// </summary>
  Smooth,

  /// <summary>
  ///   Smooth with Markers.
  /// </summary>
  SmoothMarker
}