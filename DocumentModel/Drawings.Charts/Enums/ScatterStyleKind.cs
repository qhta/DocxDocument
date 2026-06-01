namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Scatter IStyle
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ScatterStyleKind
{
  /// <summary>
  ///   ILine.
  /// </summary>
  ILine,

  /// <summary>
  ///   ILine with Markers.
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
