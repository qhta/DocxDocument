namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the PageOrientation enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PageOrientation
{
  /// <summary>
  ///   default.
  /// </summary>
  Default,
  /// <summary>
  ///   portrait.
  /// </summary>
  Portrait,
  /// <summary>
  ///   landscape.
  /// </summary>
  Landscape
}