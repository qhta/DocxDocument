namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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