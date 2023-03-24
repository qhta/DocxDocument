namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GeoProjectionType enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum GeoProjectionType
{
  /// <summary>
  ///   mercator.
  /// </summary>
  Mercator,

  /// <summary>
  ///   miller.
  /// </summary>
  Miller,

  /// <summary>
  ///   robinson.
  /// </summary>
  Robinson,

  /// <summary>
  ///   albers.
  /// </summary>
  Albers
}