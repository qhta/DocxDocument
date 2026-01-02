namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Radar Style
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum RadarStyleKind
{
  /// <summary>
  ///   Standard.
  /// </summary>
  Standard,
  /// <summary>
  ///   Marker.
  /// </summary>
  Marker,
  /// <summary>
  ///   Filled.
  /// </summary>
  Filled
}