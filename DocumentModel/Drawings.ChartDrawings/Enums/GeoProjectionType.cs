namespace DocumentModel.Drawings.ChartDrawings;

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